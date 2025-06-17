using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
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
            comboAlgorithm.Items.Add("Priority Scheduling");
            comboAlgorithm.Items.Add("(FCFS)First Come First Serve"); 
            comboAlgorithm.Items.Add("(SJF) Shortest Job First");
            comboAlgorithm.Items.Add("(SRTF) Shortest Remaining Time First");
            comboAlgorithm.Items.Add("(RR) Round Robin"); //+ Quantum Time

            defaultUI();
            radWithoutPriority.Enabled = true;
            radWithPriority.Enabled = true;

            setUpGridCollumns(); //Vẫn còn cột Priority trong gridData nhưng sẽ được ẩn đi sau khi Run thuật toán không có Priority

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

            //Hide labels for Priority when the selected algorithm is "Priority Scheduling"
            bool isPriorityScheduling = selectedAlgorithm.Equals("Priority Scheduling");
            
            lblPriority.Visible = !isPriorityScheduling;
            radWithoutPriority.Visible = !isPriorityScheduling;
            radWithPriority.Visible = !isPriorityScheduling;
            radWithoutPriority.Checked = !isPriorityScheduling; 
            radWithPriority.Checked = isPriorityScheduling; 
        }

        //btnReset: Reset giao diện về mặc định
        private void btnReset_Click(object sender, EventArgs e)
        {
            // Giao diện mẫu: Default algorithm là FCFS
            defaultUI();

            // Xóa data grid view của bảng dữ liệu và kết quả
            gridViewsReset();
            gridData.Columns["Priority"].Visible = true; // Hiển thị lại cột Priority nếu nó đã bị ẩn trước đó

        }

        //Auto-generate ProcessID when a new row is added to gridData
        private void gridData_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < gridData.Rows.Count; i++)
            {
                var row = gridData.Rows[i];
                if (!row.IsNewRow)
                {
                    row.Cells["ProcessID"].Value = "P" + (i + 1);
                }
            }
        }

        //Start execution of the selected algorithm
        private void btnRun_Click(object sender, EventArgs e)
        {
            /*
            Workflow:
            1. DONE: Get data from gridData
            2. DONE: Validate the data
                If valid, run the selected algorithm
                If not valid, show error message
            3. TODO: Perform calculation based on 
                the selected algorithm
                + with/ without priority radBtn checked
            4. Show the result in gridResult and gridAverage
            5. (Test after the calculation reached correction) 
            Perform string manipulation to print the gantt chart out into panelGanttChart
            
            */

            //Throw error: If no data in gridData
            if (gridData.Rows.Count == 0 || gridData.Rows[0].IsNewRow)
            {
                MessageBox.Show("⚠️ No data in the grid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                informError("⚠️Build Failed - Please ensure all data is entered correctly.");
                return;
            }
            
            if (radWithoutPriority.Checked)
            {
                //Hide the Priority column 
                gridData.Columns["Priority"].Visible = false;
            }

            List<Process> processes = new List<Process>();

            foreach (DataGridViewRow row in gridData.Rows)
            {
                if (row.IsNewRow) continue; // Skip the new row placeholder

                string id = row.Cells["ProcessID"].Value.ToString();

                if (!int.TryParse(row.Cells["ArrivalTime"].Value?.ToString(), out int arrivalTime))
                {
                    MessageBox.Show($"Invalid Arrival Time Input for id {id}.\r\nTry Again.");
                    return; // Exit if invalid input -> Avoid crashing 
                }

                if (!int.TryParse(row.Cells["BurstTime"].Value ? .ToString() ,out int burstTime))
                {
                    MessageBox.Show($"Invalid Burst Time Input for id {id}.\r\nTry Again.");
                    return;
                }

                int priority = 0;
                // If Priority column exists, get the priority value
                if (radWithPriority.Checked || comboAlgorithm.SelectedItem.ToString() == "Priority Scheduling")
                {
                    if (!int.TryParse(row.Cells["Priority"].Value?.ToString(), out priority))
                    {
                        MessageBox.Show($"Invalid Priority Input for id {id}.\r\nTry Again.");
                        return;
                    }
                }

                    processes.Add(new Process
                    {
                        ID = id,
                        ArrivalTime = arrivalTime,
                        BurstTime = burstTime,
                        Priority = priority,
                        StartTime = -1,
                        CompletionTime = 0,
                        //Initialize TurnaroundTime and WaitingTime to 0
                        TurnaroundTime = 0,
                        WaitingTime = 0
                    }
                    );
            }

            //Step 3: Perform the calculation based on the selected algorithm
            
            //NOT with priority algorithms
            if (radWithoutPriority.Checked)
            {
                switch (comboAlgorithm.SelectedItem.ToString())
                {
                    case "(FCFS)First Come First Serve":
                        Process.FCFSRun(processes);
                        ganttChartShow(processes);
                        break;
                    case "(SJF) Shortest Job First":    
                        Process.SJFRun(processes);
                        ganttChartShow(processes);
                        break;
                    default:
                        informError("⚠️Build Failed - Please ensure all data is entered correctly.");
                        break;
                }
            }
            //WITH priority algorithms
            if (radWithPriority.Checked)
            {
                switch (comboAlgorithm.SelectedItem.ToString())
                {
                    case "Priority Scheduling":
                        Process.PriorityRun(processes);
                        ganttChartShow(processes);
                        break;
                    case "(FCFS)First Come First Serve":
                        Process.PriorityRun(processes); //Về mặt logic, FCFS là PriorityRun với Priority = 0
                        ganttChartShow(processes);
                        break;
                    case "(SJF) Shortest Job First":
                        Process.P_SJFRun(processes);
                        ganttChartShow(processes);
                        break;
                    default:
                        informError("⚠️Build Failed - Please ensure all data is entered correctly.");
                        break;
                }
            }


            gridResult.Rows.Clear(); // Clear previous results
            foreach (var p in processes){
                gridResult.Rows.Add(p.TurnaroundTime, p.WaitingTime);
            }

            double avgTAT = processes.Average(p => p.TurnaroundTime);
            double avgWT = processes.Average(p => p.WaitingTime);

            gridAverage.Rows.Clear(); // Clear previous averages
            gridAverage.Rows.Add(avgTAT, avgWT);
            txtProcessNumber.Text = processes.Count.ToString(); // Update the process count

        }

        private void btnLoadFromFile_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = Path.Combine(Application.StartupPath, "Data", "Priority_CPU.txt");

                // Read all lines
                string[] lines = File.ReadAllLines(filePath);

                // Clear existing rows
                gridData.Rows.Clear();

                int processCount = 0;

                foreach (string line in lines)
                {
                    if (string.IsNullOrWhiteSpace(line)) continue;

                    string[] parts = line.Split(' ');

                    if (parts.Length >= 2) // At least Arrival and Burst time
                    {
                        int arrival = int.Parse(parts[0]);
                        int burst = int.Parse(parts[1]);
                        int prio = (parts.Length >= 3) ? int.Parse(parts[2]) : 0;

                        gridData.Rows.Add($"P{++processCount}", arrival, burst, prio);
                    }
                }

                inform("Load file successfully"); // Inform the user that the file has been loaded successfully
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading file: {ex.Message}");
                informError("⚠️Failed to load file");
            }
        }

        private void btnSaveData_Click(object sender, EventArgs e)
        {

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
            gridData.Columns["ProcessID"].ReadOnly = true; // Process ID is auto-generated, so it should not be editable
            gridData.Columns["ProcessID"].Visible = true;
            gridData.Columns["Priority"].Visible = true;

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

            setUpPanel(); // Reset the panel for gantt chart/ information display

        }

        private void setUpPanel()
        {
            lblChartSequence.Visible = true;
            lblChartSequence.Text = "Step 1: Select Algorithm of choice\r\nStep 2: Load data\r\nStep 3: Press Run";
            lblChartSequence.ForeColor = Color.Green;

            lblChartSequence.AutoSize = true;
            lblChartSequence.MaximumSize = new Size(panelGanttChart.Width, panelGanttChart.Height); // Set maximum width to the panel's width


        }

        private void gridViewsReset()
        {
            // Xóa dữ liệu trong các bảng
            gridData.Rows.Clear();
            gridResult.Rows.Clear();
            gridAverage.Rows.Clear();
        }

        private void informError(string text)
        {
            lblChartSequence.ForeColor = Color.Red;
            lblChartSequence.Text = text;
            lblChartSequence.AutoSize = true;
        }

        private void inform(string text)
        {
            lblChartSequence.Text = text;
            lblChartSequence.AutoSize = true;
            lblChartSequence.ForeColor = Color.Green;
        }

        private void ganttChartShow(List<Process> process)
        {
            // Clear previous gantt chart
            panelGanttChart.Invalidate(); // Refresh the panel
            lblChartSequence.Text = ""; // Clear the previous gantt chart sequence

            // Display the gantt chart sequence from the processes
            foreach (var p in process)
            {
                lblChartSequence.Text += $"{p.ID}({p.StartTime} - {p.CompletionTime}) -> ";
            }
            lblChartSequence.Text += "Finish";

        }



        /*        
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
