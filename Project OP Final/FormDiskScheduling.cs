using Project_OP_Final.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Project_OP_Final
{
    public partial class FormDiskScheduling : Form
    {
        private DiskScheduling diskScheduling;
        private string selectedAlgorithm = "";
        private Dictionary<string, string> algorithmDescriptions = new Dictionary<string, string>()
        {
            { "FCFS", "First-Come, First-Served (FCFS)" },
            { "SSTF", "Shortest Seek Time First (SSTF)" },
            { "SCAN", "Elevator Algorithm (SCAN)" },
            { "C-SCAN", "Circular SCAN (C-SCAN)" },
            { "LOOK", "Optimized SCAN (LOOK)" },
            { "C-LOOK", "Circular LOOK (C-LOOK)" }
        };

        public FormDiskScheduling()
        {
            InitializeComponent();
            InitializeAlgorithmComboBox();
            SetupDataGridView();
            UpdateDiskSizeTextBoxState();
            //labelAlgorithms.Visible = false;
            //labelSteps.Visible = false;
            //labelSteps.ForeColor = Color.MediumBlue;
            //labelSteps.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
        }
        private void InitializeAlgorithmComboBox()
        {
            cbSelectAlgorithm.Items.Clear();
            cbSelectAlgorithm.Items.AddRange(algorithmDescriptions.Keys.ToArray());
            cbSelectAlgorithm.SelectedIndex = 0;
            cbSelectAlgorithm.SelectedIndexChanged += cbSelectAlgorithm_SelectedIndexChanged;
            selectedAlgorithm = cbSelectAlgorithm.SelectedItem.ToString();
        }
        private void cbSelectAlgorithm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSelectAlgorithm.SelectedItem != null)
            {
                selectedAlgorithm = cbSelectAlgorithm.SelectedItem.ToString();
                UpdateDiskSizeTextBoxState();

                if (algorithmDescriptions.ContainsKey(selectedAlgorithm))
                {
                    labelAlgorithms.Text = algorithmDescriptions[selectedAlgorithm];
                    labelAlgorithms.Visible = true;
                }
            }
        }
        private void SetupDataGridView()
        {
            dgvAlgorithm.Rows.Clear();
            dgvAlgorithm.Columns.Clear();
            dgvAlgorithm.Columns.Add("From", "From");
            dgvAlgorithm.Columns.Add("To", "To");
            dgvAlgorithm.Columns.Add("Distance", "Distance");
            dgvAlgorithm.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void UpdateDiskSizeTextBoxState()
        {
            if (selectedAlgorithm == "SCAN" || selectedAlgorithm == "C-SCAN")
            {
                txtDiskSize.Enabled = true;
            }
            else
            {
                txtDiskSize.Enabled = false;
                txtDiskSize.Text = "";
            }
        }

        private void AddStepToGrid(int from, int to, int distance)
        {
            dgvAlgorithm.Rows.Add(from, to, distance);
        }
        private void btnRun_Click(object sender, EventArgs e)
        {
            dgvAlgorithm.Rows.Clear();
            labelSteps.Visible = false;
            labelSteps.Text = "";

            try
            {
                if (string.IsNullOrWhiteSpace(txtRequestQueue.Text))
                {
                    MessageBox.Show("Please enter at least one request in the queue!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Parse requests from textbox
                int[] requests = txtRequestQueue.Text.Split(',')
                                        .Select(s => int.Parse(s.Trim()))
                                        .ToArray();

                if (requests.Length == 0)
                {
                    MessageBox.Show("Request queue cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(txtHeadPosition.Text.Trim(), out int head))
                {
                    MessageBox.Show("Please enter a valid initial head position!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int diskSize = 0;
                if (txtDiskSize.Enabled)
                {
                    if (!int.TryParse(txtDiskSize.Text.Trim(), out diskSize))
                    {
                        MessageBox.Show("Please enter a valid disk size!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                List<(int from, int to, int move)> steps;
                int total = 0;

                switch (selectedAlgorithm)
                {
                    case "FCFS":
                        total = DiskScheduling.FCFS(requests, head, out steps);
                        break;
                    case "SSTF":
                        total = DiskScheduling.SSTF(requests, head, out steps);
                        break;
                    case "SCAN":
                        total = DiskScheduling.SCAN(requests, head, diskSize, Direction.Left, out steps);
                        break;
                    case "C-SCAN":
                        total = DiskScheduling.CSCAN(requests, head, diskSize, out steps);
                        break;
                    case "LOOK":
                        total = DiskScheduling.LOOK(requests, head, Direction.Left, out steps);
                        break;
                    case "C-LOOK":
                        total = DiskScheduling.CLOOK(requests, head, out steps);
                        break;
                    default:
                        steps = new List<(int from, int to, int move)>();
                        break;
                }

                // Add steps to grid
                foreach (var step in steps)
                {
                    AddStepToGrid(step.from, step.to, step.move);
                }

                txtTotalHeadMovement.Text = total.ToString();

                // Show steps as multiline text in labelSteps
                if (steps.Count > 0)
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (var step in steps)
                    {
                        sb.AppendLine($"From {step.from} to {step.to}, Distance: {step.move}");
                    }
                    labelSteps.Text = sb.ToString();
                    labelSteps.Visible = true;
                }
                else
                {
                    labelSteps.Visible = false;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numeric values separated by commas in request queue.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoadFromFile_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedAlgorithm))
            {
                MessageBox.Show("Please select an algorithm first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data");
            string fileName = Path.Combine(folderPath, $"DiskScheduling.txt");

            if (!File.Exists(fileName))
            {
                MessageBox.Show($"File '{fileName}' not found.\nExpected at: {fileName}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string content = File.ReadAllText(fileName);
                txtRequestQueue.Text = content;
                MessageBox.Show($"Loaded from {fileName}", "Loaded", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to read file:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSaveRequest_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRequestQueue.Text))
            {
                MessageBox.Show("Request queue is empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(selectedAlgorithm))
            {
                MessageBox.Show("Please select an algorithm first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data");

            // Tạo thư mục nếu chưa tồn tại
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            string fileName = Path.Combine(folderPath, $"{selectedAlgorithm}_DiskScheduling.txt");

            try
            {
                File.WriteAllText(fileName, txtRequestQueue.Text);
                MessageBox.Show($"Saved to {fileName}", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to save file:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtRequestQueue.Clear();
            txtHeadPosition.Clear();
            txtDiskSize.Clear();
            txtTotalHeadMovement.Clear();
            dgvAlgorithm.Rows.Clear();
            labelSteps.Visible = false;
        }
    }
}
