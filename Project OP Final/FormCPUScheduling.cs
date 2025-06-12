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

/*
 TODO: 
    Sẽ như thế nào nếu sau khi form load(gridData có cột Priority), 
        user chọn Run thuật toán với radWithoutPriority.Checked? 
        -> Cần phải xóa cột Priority trong gridData sau khi nút Run được nhấn.
 */

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

            defaultUI();
            radWithoutPriority.Enabled = true;
            radWithPriority.Enabled = true;

            setUpGridCollumns();

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
            defaultUI();

            // Xóa data grid view của bảng dữ liệu và kết quả
            gridViewsReset();

        }

        //Start execution of the selected algorithm
        private void btnRun_Click(object sender, EventArgs e)
        {
            /*
            Workflow:
            1. Get data from gridData
            2. Validate the data
                If valid, run the selected algorithm
                If not valid, show error message
            3. Perform calculation based on 
                the selected algorithm
                + with/ without priority radBtn checked
            4. Show the result in gridResult and gridAverage
            5. (Test after the calculation reached correction) 
            Perform string manipulation to print the gantt chart out into panelGanttChart
            
            */

            //Step 1: Get data from gridData
            List<Process> processes = new List<Process>();
                //1.1: Get the data from gridData and store it in a list of Process objects
            foreach (DataGridViewRow row in gridData.Rows)
            {
                if (row.IsNewRow) continue; // Skip the new row placeholder

                processes.Add(new Process
                {
                    ID = row.Cells[row.IndexOf(row.Cells["ProcessID"])].Value?.ToString() ?? "Unknown",
                });
            }

            //1.2: Populate gridResult
            /*
             
            gridResult.Rows.Clear(); // Clear previous results
            foreach (var p in processes){
                gridResult.Rows.Add(p.TurnaroundTime, p.WaitingTime);
            }

            //1.3: Populate gridAverage
            double avgTAT = processes.Average(p => p.TurnaroundTime);
            double avgWT = processes.Average(p => p.WaitingTime);

            gridAverage.Rows.Clear(); // Clear previous averages
            gridAverage.Rows.Add(avgTAT, avgWT);
            */

        }


        //---------------Additional Methods---------------

        private void setUpGridCollumns()
        {
            //gridData
            gridData.Columns.Add("ProcessID", "Process ID");
            gridData.Columns.Add("ArrivalTime", "Arrival Time");
            gridData.Columns.Add("BurstTime", "Burst Time");
            if (radWithPriority.Checked || comboAlgorithm.SelectedItem.ToString() == "Priority Scheduling")
            {
                gridData.Columns.Add("Priority", "Priority");
            }
            gridData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridData.AllowUserToAddRows = true;

            //gridResult
            gridResult.Columns.Add("TurnAroundTime","Turn-around Time");
            gridResult.Columns.Add("WaitingTime", "Waiting Time");
            gridResult.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridResult.ReadOnly = true;

            //gridAverage
            gridAverage.Columns.Add("AvgTAT", "Avg TAT");
            gridAverage.Columns.Add("AvgWT", "Avg WT");
            gridAverage.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridResult.ReadOnly = true;

        }

        private void defaultUI()
        {
            comboAlgorithm.SelectedItem = "(FCFS)First Come First Serve";
            lblQuantumTime.Visible = false;
            txtQuantumTime.Visible = false;
            lblSecond.Visible = false;
            lblPriority.Visible = true;

            radWithoutPriority.Visible = true;
            radWithPriority.Visible = true;
            radWithPriority.Checked = true; // Reset to default option

            txtProcessNumber.Text = "0";
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
