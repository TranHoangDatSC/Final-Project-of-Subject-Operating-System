using Project_OP_Final.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;
using System.IO;

namespace Project_OP_Final
{
    public partial class FormPageReplacement : Form
    {
        public FormPageReplacement()
        {
            InitializeComponent();
        }

        private void FormPageReplacement_Load(object sender, EventArgs e)
        {
            cb_Algorithm.Items.Add("OPT");
            cb_Algorithm.Items.Add("LRU");
            cb_Algorithm.Items.Add("FIFO");
            cb_Algorithm.Items.Add("Clock");
            cb_Algorithm.SelectedItem = "OPT";
            labelAlgorithm.Text = "Algorithm: Optimal (OPT)";
        }

        private void btn_Simulation_Click(object sender, EventArgs e)
        {
            string algorithmName = cb_Algorithm.SelectedItem?.ToString();
            int frameCount = (int)nud_Frame.Value;

            // Kiểm tra nếu chuỗi rỗng hoặc chỉ chứa khoảng trắng
            if (string.IsNullOrWhiteSpace(txt_Page_reference_string.Text))
            {
                MessageBox.Show("Please enter page reference string.");
                return;
            }

            string[] tokens = txt_Page_reference_string.Text.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            List<int> reference = new List<int>();
            foreach (var token in tokens)
            {
                if (int.TryParse(token, out int num))
                {
                    reference.Add(num);
                }
                else
                {
                    MessageBox.Show("The page reference string must be an integer, separated by spaces or commas.");
                    return;
                }
            }

            PageReplacement pr = new PageReplacement();
            pr.referenceString = reference;
            pr.frameCount = frameCount;

            switch (algorithmName)
            {
                case "OPT":
                    pr.OPTAlgorithmRun();
                    lb_Pagefaults.Text = $"Page faults: {pr.faults}";
                    ShowFrameStates(pr.frameStates, pr.pageFaults);
                    labelAlgorithm.Text = "Algorithm: Optimal (OPT)";
                    break;
                case "LRU":
                    pr.LRUAlgorithmRun();
                    lb_Pagefaults.Text = $"Page faults: {pr.faults}";
                    ShowFrameStates(pr.frameStates, pr.pageFaults);
                    labelAlgorithm.Text = "Algorithm: Least Recently Used (LRU)";
                    break;
                case "FIFO":
                    pr.FIFOAlgorithmRun();
                    lb_Pagefaults.Text = $"Page faults: {pr.faults}";
                    ShowFrameStates(pr.frameStates, pr.pageFaults);
                    labelAlgorithm.Text = "Algorithm: First-In First-Out (FIFO)";
                    break;
                case "Clock":
                    pr.ClockAlgorithmRun();
                    lb_Pagefaults.Text = $"Page faults: {pr.faults}";
                    ShowFrameStates(pr.frameStates, pr.pageFaults, pr.bitsStates);
                    labelAlgorithm.Text = "Algorithm: Clock Replacement";
                    break;
                default:
                    MessageBox.Show("Invalid algorithm");
                    return;
            }
            lb_Pagefaults.Text = $"Page faults: {pr.faults}";
        }
        private void ShowFrameStates(List<List<int>> frameStates, List<bool> pageFaults)
        {
            dgv_Result.Columns.Clear();
            dgv_Result.Rows.Clear();

            // Số cột = số List<int> (list con)
            int soCot = frameStates.Count;

            // Số dòng = số phần tử trong mỗi list con (giả sử đều)
            int soDong = frameStates.Max(r => r.Count);

            // Thêm cột
            for (int i = 0; i < soCot; i++)
            {
                dgv_Result.Columns.Add($"Frame{i}", $"Column {i + 1}");
            }

            // Thêm từng dòng (theo chỉ số phần tử)
            for (int row = 0; row < soDong; row++)
            {
                object[] rowData = new object[soCot];

                for (int col = 0; col < soCot; col++)
                {
                    // Kiểm tra nếu list con đủ phần tử
                    rowData[col] = (row < frameStates[col].Count) ? frameStates[col][row].ToString() : "";
                }

                dgv_Result.Rows.Add(rowData);
            }

            // Thêm dòng đánh dấu page fault (dòng cuối)
            object[] faultRow = new object[soCot];
            for (int col = 0; col < soCot; col++)
            {
                faultRow[col] = pageFaults[col] ? "F" : ""; // Hiển thị "F" nếu có page fault
            }
            dgv_Result.Rows.Add(faultRow);
        }
        private void ShowFrameStates(List<List<int>> frameStates, List<bool> pageFaults, List<List<bool>> bitsStates)
        {
            dgv_Result.Columns.Clear();
            dgv_Result.Rows.Clear();

            // Số cột = số List<int> (list con)
            int soCot = frameStates.Count;

            // Số dòng = số phần tử trong mỗi list con (giả sử đều)
            int soDong = frameStates.Max(r => r.Count);

            // Thêm cột
            for (int i = 0; i < soCot; i++)
            {
                dgv_Result.Columns.Add($"Frame{i}", $"Column {i + 1}");
            }

            // Thêm từng dòng (theo chỉ số phần tử)
            for (int row = 0; row < soDong; row++)
            {
                object[] rowData = new object[soCot];

                for (int col = 0; col < soCot; col++)
                {
                    if (row < frameStates[col].Count)
                    {
                        int value = frameStates[col][row];
                        bool bit = bitsStates[col].Count > row ? bitsStates[col][row] : false;
                        rowData[col] = bit ? $"{value}*" : $"{value}";
                    }
                    else
                    {
                        rowData[col] = "";
                    }
                }

                dgv_Result.Rows.Add(rowData);
            }

            // Thêm dòng đánh dấu page fault (dòng cuối)
            object[] faultRow = new object[soCot];
            for (int col = 0; col < soCot; col++)
            {
                faultRow[col] = pageFaults[col] ? "F" : ""; // Hiển thị "F" nếu có page fault
            }
            dgv_Result.Rows.Add(faultRow);
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            txt_Page_reference_string.Text = "";
            cb_Algorithm.SelectedItem = "OPT";
            nud_Frame.Value = 3;
            dgv_Result.Rows.Clear();
            lb_Pagefaults.Text = $"Page faults: ";
            labelAlgorithm.Text = "Algorithm: Optimal (OPT)";
        }

        private void btn_LoadFromFile_Click(object sender, EventArgs e)
        {
            string filePath = Path.Combine(Application.StartupPath, "Data", "PageReferenceString.txt");
            string content = File.ReadAllText(filePath);
            txt_Page_reference_string.Text = content;
        }

        private void btn_SaveFile_Click(object sender, EventArgs e)
        {
            try
            {
                string content = txt_Page_reference_string.Text;

                if (string.IsNullOrWhiteSpace(content))
                {
                    MessageBox.Show("⚠️ No content to save. Please enter or load a page reference string first.",
                                    "Empty Content", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string dataDir = Path.Combine(Application.StartupPath, "Data");
                if (!Directory.Exists(dataDir))
                {
                    Directory.CreateDirectory(dataDir);
                }

                string filePath = Path.Combine(dataDir, "PageReferenceString.txt");
                File.WriteAllText(filePath, content);

                MessageBox.Show("✅ Page reference string saved successfully.",
                                "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Failed to save the file:\n" + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cb_Algorithm_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = cb_Algorithm.SelectedItem?.ToString();

            switch (selected)
            {
                case "OPT":
                    labelAlgorithm.Text = "Algorithm: Optimal (OPT)";
                    break;
                case "LRU":
                    labelAlgorithm.Text = "Algorithm: Least Recently Used (LRU)";
                    break;
                case "FIFO":
                    labelAlgorithm.Text = "Algorithm: First-In First-Out (FIFO)";
                    break;
                case "Clock":
                    labelAlgorithm.Text = "Algorithm: Clock Replacement";
                    break;
                default:
                    labelAlgorithm.Text = "Algorithm: ";
                    break;
            }
        }
    }
}
