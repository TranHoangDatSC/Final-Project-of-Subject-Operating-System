using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Project_OP_Final
{
    public partial class FormCPUScheduling : Form
    {
        public FormCPUScheduling()
        {
            InitializeComponent();

        }

        private void FormCPUScheduling_Load(object sender, EventArgs e)
        {
            //About combobox comboAlgorithm
            comboAlgorithm.Items.Add("(FCFS)First Come First Serve"); //Có Priority
            comboAlgorithm.Items.Add("(SJF) Shortest Job First");
            comboAlgorithm.Items.Add("(SRTF) Shortest Remaining Time First");
            comboAlgorithm.Items.Add("(RR) Round Robin"); //Có Priority và Quantum Time
            comboAlgorithm.Items.Add("Priority Scheduling");
                //Default algorithm
            comboAlgorithm.SelectedItem = "(FCFS)First Come First Serve";

            //About UI components
            lblQuantumTime.Visible = false;
            txtQuantumTime.Visible = false;

            //Set up grid view values
            setUpGridCollumns();

        }

        private void setUpGridCollumns()
        {
            //gridData
            gridData.Columns.Add("ProcessID", "Process ID");
            gridData.Columns.Add("Priority", "Priority");
            gridData.Columns.Add("ArrivalTime", "Arrival Time");
            gridData.Columns.Add("BurstTime", "Burst Time");
            gridData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridData.AllowUserToAddRows = true;
            gridData.Enabled = true;

            //gridResult
            gridResult.Columns.Add("TurnAroundTime","Turn-around Time");
            gridResult.Columns.Add("WaitingTime", "Waiting Time");
            gridResult.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridResult.ReadOnly = true;

            //gridAverage
            gridAverage.Columns.Add("AvgTA", "Avg TA");
            gridAverage.Columns.Add("AvgWT", "Avg WT");
            gridAverage.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridResult.ReadOnly = true;

        }

        //UI modification when the user selects an algorithm
        private void comboAlgorithm_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedAlgorithm = comboAlgorithm.SelectedItem.ToString();

            //Only show the quantum time conponents for Round Robin algorithm
            bool isRoundRobin = selectedAlgorithm.Equals("(RR) Round Robin");

            lblQuantumTime.Visible = isRoundRobin;
            txtQuantumTime.Visible = isRoundRobin;
            lblSecond.Visible = isRoundRobin;

            // Only show the priority components for FCFS and Round Robin algorithm
            bool isFCFS = selectedAlgorithm.Equals("(FCFS)First Come First Serve");
            bool isRR = selectedAlgorithm.Equals("(RR) Round Robin");

            lblPriority.Visible = isFCFS || isRR;
            radWithoutPriority.Visible = isFCFS || isRR;
            radWithPriority.Visible = isFCFS || isRR;

        }

        //btnReset: Reset giao diện về mặc định
        private void btnReset_Click(object sender, EventArgs e)
        {
            // Giao diện mẫu: Default algorithm là FCFS
            comboAlgorithm.SelectedItem = "(FCFS)First Come First Serve";
            lblQuantumTime.Visible = false;
            txtQuantumTime.Visible = false;
            lblSecond.Visible = false;
            lblPriority.Visible = true;

            radWithoutPriority.Visible = true;
            radWithPriority.Visible = true;
            radWithoutPriority.Checked = true; // Reset to default option

            txtProcessNumber.Text = "0";

            // Xóa data grid view của bảng dữ liệu và kết quả
            gridViewsReset();
            // Initialize grid views again
            setUpGridCollumns();

        }

        private void gridViewsReset()
        {
            // Xóa dữ liệu trong các bảng
            gridData.Rows.Clear();
            gridResult.Rows.Clear();
            gridAverage.Rows.Clear();
        }

        /*
        private void btnLoadFromFile_Click(object sender, EventArgs e)
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
        */
    }
}
