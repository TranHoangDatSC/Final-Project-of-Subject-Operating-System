using Project_OP_Final.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_OP_Final
{
    public partial class FormBankerAlgorithm : Form
    {
        private BankerAlgorithm banker;
        private List<NumericUpDown> nudRequests = new List<NumericUpDown>();

        public FormBankerAlgorithm()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            int processCount = (int)nudProcesses.Value;
            int resourceCount = (int)nudResources.Value;

            if (processCount <= 0 || resourceCount <= 0)
            {
                MessageBox.Show("Please enter a valid number of processes and resources (> 0).",
                                "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            banker = new BankerAlgorithm(processCount, resourceCount);

            InitDataGrids(processCount, resourceCount);
            InitRequestControls(resourceCount);
            //InitAvailableGrid(resourceCount);

            cbProcessRequest.Items.Clear();

            for(int i = 0; i < processCount; i++)
            {
                cbProcessRequest.Items.Add($"Process{i}");
            }

            if(cbProcessRequest.Items.Count > 0)
            {
                cbProcessRequest.SelectedIndex = 0;
            }
            ClearResult();
        }

        private void InitDataGrids(int processCount, int resourceCount)
        {
            InitGrid(dgvMaxDemand, processCount, resourceCount);
            InitGrid(dgvAllocation, processCount, resourceCount);
            InitGrid(dgvAvailable, processCount, resourceCount);
            InitGrid(dgvNeed, processCount, resourceCount);
        }
        private void InitGrid(DataGridView grid, int rows, int cols)
        {
            grid.Columns.Clear();
            grid.Rows.Clear();

            for(int i = 0; i < cols; i++)
            {
                grid.Columns.Add($"Resource {i}", $"Resource {i}");
            }

            grid.Rows.Add(rows);
            for(int i = 0; i < rows; i++)
            {
                grid.Rows[i].HeaderCell.Value = $"Process{i}";
            }
        }

        private void InitRequestControls(int resourcesCount)
        {
            flowPanelRequest.Controls.Clear();
            nudRequests.Clear();

            for(int i = 0; i < resourcesCount; i++)
            {
                var panel = new FlowLayoutPanel
                {
                    AutoSize = true,
                    FlowDirection = FlowDirection.LeftToRight,
                    Margin = new Padding(0),
                    Padding = new Padding(0)
                };
                var lbl = new Label
                {
                    AutoSize = true,
                    TextAlign = ContentAlignment.MiddleLeft,
                    Margin = new Padding(0, 0, 0, 0)
                };

                var nud = new NumericUpDown
                {
                    Minimum = 0,
                    Maximum = 232,
                    Width = 232,
                    Height = 35
                };

                nudRequests.Add(nud);
                panel.Controls.Add(lbl);
                panel.Controls.Add(nud);
                flowPanelRequest.Controls.Add(panel);
            }
        }
        private void LoadData()
        {
            for (int i = 0; i < banker.ProcessCount; i++)
            {
                for (int j = 0; j < banker.ResourceCount; j++)
                {
                    banker.MaxDemand[i, j] = Convert.ToInt32(dgvMaxDemand.Rows[i].Cells[j].Value ?? 0);
                    banker.Allocation[i, j] = Convert.ToInt32(dgvAllocation.Rows[i].Cells[j].Value ?? 0);
                }
            }

            for (int j = 0; j < banker.ResourceCount; j++)
                banker.Available[j] = Convert.ToInt32(dgvAvailable.Rows[0].Cells[j].Value ?? 0);
        }
        private void ShowNeed()
        {
            int[,] need = banker.Need;
            for (int i = 0; i < banker.ProcessCount; i++)
                for (int j = 0; j < banker.ResourceCount; j++)
                    dgvNeed.Rows[i].Cells[j].Value = need[i, j];
        }
        private void ClearResult()
        {
            labelStatus.Text = "";
            labelSequence.Text = "";
            labelSuggest.Text = "";
        }

        private void btnRequestResource_Click(object sender, EventArgs e)
        {
            labelSuggest.Text = "";
            if (banker == null)
            {
                MessageBox.Show("⚠️ Please load data before making a resource request.",
                                "Data Not Loaded", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!IsInputDataValid()) return;

            int processIndex = cbProcessRequest.SelectedIndex;
            int[] request = nudRequests.Select(n => (int)n.Value).ToArray();

            try
            {
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("⚠️ Failed to load input data:\n" + ex.Message,
                                "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            labelSequence.Text = "";
            if (banker.RequestResource(processIndex, request))
            {
                labelStatus.Text = "✔ Request granted. System is still in a safe state";
                labelStatus.ForeColor = Color.Green;
                labelSuggest.Text = "";
            }
            else
            {
                labelStatus.Text = "❌ Request denied. System would be unsafe.";
                labelStatus.ForeColor = Color.Red;
                labelStatus.Text += Environment.NewLine +
                $"Needed: {string.Join(", ", request)}. Available: {string.Join(", ", banker.Available)}.";

                labelSuggest.Text += Environment.NewLine + "Possible solutions:" + Environment.NewLine;
                labelSuggest.Text += $"- Release resources from other process(es) (for example, consider freeing P{processIndex})." + Environment.NewLine;
                labelSuggest.Text += $"- Wait until resources become available." + Environment.NewLine;
                labelSuggest.Text += $"- Roll back or terminate P{processIndex} to avoid deadlock.";
            }

            ShowNeed();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (banker == null) return;

            if (banker != null)
                banker.ResetTableBanker();

            dgvMaxDemand.Rows.Clear();
            dgvMaxDemand.Columns.Clear();
            dgvAllocation.Rows.Clear();
            dgvAllocation.Columns.Clear();
            dgvNeed.Rows.Clear();
            dgvNeed.Columns.Clear();
            dgvAvailable.Rows.Clear();
            dgvAvailable.Columns.Clear();

            flowPanelRequest.Controls.Clear();
            nudRequests.Clear();

            cbProcessRequest.Items.Clear();
            labelStatus.Text = "";
            labelSequence.Text = "";
            labelSuggest.Text = "";
        }

        private void btnCheckSafe_Click(object sender, EventArgs e)
        {
            if (banker == null)
            {
                MessageBox.Show("⚠️ Please load data before checking system safety.",
                                "Data Not Loaded", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!IsInputDataValid()) return;

            try
            {
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("⚠️ Failed to load input data:\n" + ex.Message,
                                "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            LoadData();

            if (banker.IsSafe(out List<int> safeSequence, out bool isDeadlock))
            {
                labelStatus.Text = "✔ The system is in a safe state.";
                labelStatus.ForeColor = Color.Green;
                labelSequence.Text = "Safe sequence: " + string.Join(" → ", safeSequence.Select(p => $"P{p}"));
            }
            else
            {
                if (isDeadlock)
                {
                    labelStatus.Text = "⛔ DEADLOCK detected! All processes are blocked.";
                    labelStatus.ForeColor = Color.DarkRed;
                    labelSuggest.Text = banker.SuggestDeadlockSolution();
                }
                else
                {
                    labelStatus.Text = "❌ The system is in an unsafe state (but no deadlock has occurred).";
                    labelStatus.ForeColor = Color.OrangeRed;
                    labelSuggest.Text = "";
                }

                labelSequence.Text = safeSequence.Count > 0
                    ? "Some processes can still proceed: " + string.Join(" → ", safeSequence.Select(p => $"P{p}"))
                    : "No process can proceed.";
            }

            ShowNeed();
        }

        private void btnLoadFromTxt_Click(object sender, EventArgs e)
        {
            try
            {
                string dataDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data");

                string maxFile = Path.Combine(dataDir, "MaxDemand.txt");
                string allocFile = Path.Combine(dataDir, "Allocation.txt");
                string availFile = Path.Combine(dataDir, "Available.txt");

                if (!File.Exists(maxFile) || !File.Exists(allocFile) || !File.Exists(availFile))
                    throw new FileNotFoundException("One or more data files do not exist.");

                var maxLines = File.ReadAllLines(maxFile);
                var allocLines = File.ReadAllLines(allocFile);
                var availLine = File.ReadAllText(availFile).Trim();

                int processCount = maxLines.Length;
                int resourceCount = maxLines[0].Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).Length;

                if (allocLines.Length != processCount)
                    throw new Exception("Allocation line count does not match MaxDemand.");

                var availableTokens = availLine.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                if (availableTokens.Length != resourceCount)
                    throw new Exception("Available resource count does not match.");

                nudProcesses.Value = processCount;
                nudResources.Value = resourceCount;

                banker = new BankerAlgorithm(processCount, resourceCount);
                InitDataGrids(processCount, resourceCount);
                InitRequestControls(resourceCount);

                // Load MaxDemand
                for (int i = 0; i < processCount; i++)
                {
                    var tokens = maxLines[i].Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                    for (int j = 0; j < resourceCount; j++)
                        dgvMaxDemand.Rows[i].Cells[j].Value = int.Parse(tokens[j]);
                }

                // Load Allocation
                for (int i = 0; i < processCount; i++)
                {
                    var tokens = allocLines[i].Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                    for (int j = 0; j < resourceCount; j++)
                        dgvAllocation.Rows[i].Cells[j].Value = int.Parse(tokens[j]);
                }

                // Load Available
                for (int j = 0; j < resourceCount; j++)
                    dgvAvailable.Rows[0].Cells[j].Value = int.Parse(availableTokens[j]);

                cbProcessRequest.Items.Clear();
                for (int i = 0; i < processCount; i++)
                    cbProcessRequest.Items.Add($"Process{i}");
                cbProcessRequest.SelectedIndex = 0;

                ClearResult();
                LoadData();
                ShowNeed();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading file:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool IsInputDataValid()
        {
            if (banker == null)
            {
                return true;
            }

            for (int i = 0; i < banker.ProcessCount; i++)
            {
                for (int j = 0; j < banker.ResourceCount; j++)
                {
                    if (dgvMaxDemand.Rows[i].Cells[j].Value == null ||
                        string.IsNullOrWhiteSpace(dgvMaxDemand.Rows[i].Cells[j].Value.ToString()))
                    {
                        MessageBox.Show($"⚠️ Missing data at MaxDemand [P{i}, R{j}]", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }

                    if (dgvAllocation.Rows[i].Cells[j].Value == null ||
                        string.IsNullOrWhiteSpace(dgvAllocation.Rows[i].Cells[j].Value.ToString()))
                    {
                        MessageBox.Show($"⚠️ Missing data at Allocation [P{i}, R{j}]", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
            }

            for (int j = 0; j < banker.ResourceCount; j++)
            {
                if (dgvAvailable.Rows[0].Cells[j].Value == null ||
                    string.IsNullOrWhiteSpace(dgvAvailable.Rows[0].Cells[j].Value.ToString()))
                {
                    MessageBox.Show($"⚠️ Missing data at Available Resource{j}", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            if (!IsInputDataValid()) return;

            try
            {
                string dataDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data");

                // Tạo thư mục nếu chưa tồn tại
                if (!Directory.Exists(dataDir))
                    Directory.CreateDirectory(dataDir);

                string maxFile = Path.Combine(dataDir, "MaxDemand.txt");
                string allocFile = Path.Combine(dataDir, "Allocation.txt");
                string availFile = Path.Combine(dataDir, "Available.txt");

                int processCount = (int)nudProcesses.Value;
                int resourceCount = (int)nudResources.Value;

                // Save MaxDemand
                using (StreamWriter writer = new StreamWriter(maxFile, false))
                {
                    for (int i = 0; i < processCount; i++)
                    {
                        List<string> values = new List<string>();
                        for (int j = 0; j < resourceCount; j++)
                        {
                            values.Add(dgvMaxDemand.Rows[i].Cells[j].Value?.ToString() ?? "0");
                        }
                        writer.WriteLine(string.Join(" ", values));
                    }
                }

                // Save Allocation
                using (StreamWriter writer = new StreamWriter(allocFile, false))
                {
                    for (int i = 0; i < processCount; i++)
                    {
                        List<string> values = new List<string>();
                        for (int j = 0; j < resourceCount; j++)
                        {
                            values.Add(dgvAllocation.Rows[i].Cells[j].Value?.ToString() ?? "0");
                        }
                        writer.WriteLine(string.Join(" ", values));
                    }
                }

                // Save Available
                using (StreamWriter writer = new StreamWriter(availFile, false))
                {
                    List<string> values = new List<string>();
                    for (int j = 0; j < resourceCount; j++)
                    {
                        values.Add(dgvAvailable.Rows[0].Cells[j].Value?.ToString() ?? "0");
                    }
                    writer.WriteLine(string.Join(" ", values));
                }

                MessageBox.Show("✔ Data successfully saved to files.", "Save Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error saving files:\n" + ex.Message, "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
