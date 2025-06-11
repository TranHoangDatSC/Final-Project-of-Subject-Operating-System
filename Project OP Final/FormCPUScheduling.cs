using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

            comboAlgorithm.Items.Add("(FCFS)First Come First Serve"); //Có Priority
            comboAlgorithm.Items.Add("(SJF) Shortest Job First");
            comboAlgorithm.Items.Add("(SRTF) Shortest Remaining Time First");
            comboAlgorithm.Items.Add("(RR) Round Robin"); //Có Priority và Quantum Time
            comboAlgorithm.Items.Add("Priority Scheduling");

            comboAlgorithm.SelectedItem = "(FCFS)First Come First Serve";

            lblQuantumTime.Visible = false;
            txtQuantumTime.Visible = false;

        }

        private void comboAlgorithm_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedAlgorithm = comboAlgorithm.SelectedItem.ToString();

            //Only show the quantum time conponents for Round Robin algorithm
            bool isRoundRobin = selectedAlgorithm.Equals("(RR) Round Robin");

            lblQuantumTime.Visible = isRoundRobin;
            txtQuantumTime.Visible = isRoundRobin;

            // Only show the priority components for FCFS and Round Robin algorithm
            bool isFCFS = selectedAlgorithm.Equals("(FCFS)First Come First Serve");
            bool isRR = selectedAlgorithm.Equals("(RR) Round Robin");

            lblPriority.Visible = isFCFS || isRR;
            radWithoutPriority.Visible = isFCFS || isRR;
            radWithPriority.Visible = isFCFS || isRR;


        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // Giao diện mẫu
            comboAlgorithm.SelectedItem = "(FCFS)First Come First Serve";
            lblQuantumTime.Visible = false;
            txtQuantumTime.Visible = false;
            lblPriority.Visible = true;
            radWithoutPriority.Visible = true;
            radWithPriority.Visible = true;
            radWithoutPriority.Checked = true; // Reset to default option

            // Xóa data grid view của bảng dữ liệu và kết quả
            gridResult.DataSource = null; // Clear the DataGridView data source
            gridResult.Columns.Clear(); // Clear the columns in the DataGridView
            gridResult.Rows.Clear(); // Clear the rows in the DataGridView

            gridData. DataSource = null; // Clear the DataGridView data source
            gridData.Columns.Clear(); // Clear the columns in the DataGridView
            gridData.Rows.Clear(); // Clear the rows in the DataGridView

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
