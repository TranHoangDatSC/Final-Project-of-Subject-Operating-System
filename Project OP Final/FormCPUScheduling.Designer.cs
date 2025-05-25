namespace Project_OP_Final
{
    partial class FormCPUScheduling
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCPUScheduling));
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.labelAlgorithm = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.Process = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Priority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BurstTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArrivingTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvResult = new System.Windows.Forms.DataGridView();
            this.ProcessID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TurnaroundTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WaitingTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelNumOfProcess = new System.Windows.Forms.Label();
            this.processNumberBox = new System.Windows.Forms.TextBox();
            this.runBtn = new System.Windows.Forms.Button();
            this.loadFileBtn = new System.Windows.Forms.Button();
            this.saveDataBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.labelGanttChart = new System.Windows.Forms.Label();
            this.panelGanttChart = new System.Windows.Forms.Panel();
            this.labelChartSequence = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelProcessBoard = new System.Windows.Forms.Label();
            this.labelResultBoard = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AverageTAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AverageWT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            this.panelGanttChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(12, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(82, 72);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // labelAlgorithm
            // 
            this.labelAlgorithm.AutoSize = true;
            this.labelAlgorithm.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlgorithm.ForeColor = System.Drawing.SystemColors.Info;
            this.labelAlgorithm.Location = new System.Drawing.Point(117, 42);
            this.labelAlgorithm.Name = "labelAlgorithm";
            this.labelAlgorithm.Size = new System.Drawing.Size(132, 26);
            this.labelAlgorithm.TabIndex = 1;
            this.labelAlgorithm.Text = "Algorithm :";
            this.labelAlgorithm.Click += new System.EventHandler(this.labelAlgorithm_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "(FCFS) First Come First Serve",
            "(SJF) Shortest Job First",
            "(SRTF) Shortest Remaining Time First",
            "(Round Robin)"});
            this.comboBox1.Location = new System.Drawing.Point(271, 37);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(122, 31);
            this.comboBox1.TabIndex = 2;
            // 
            // dgvData
            // 
            this.dgvData.BackgroundColor = System.Drawing.Color.Linen;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Process,
            this.Priority,
            this.BurstTime,
            this.ArrivingTime});
            this.dgvData.Location = new System.Drawing.Point(68, 162);
            this.dgvData.Name = "dgvData";
            this.dgvData.Size = new System.Drawing.Size(486, 297);
            this.dgvData.TabIndex = 3;
            this.dgvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellContentClick);
            // 
            // Process
            // 
            this.Process.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Process.DataPropertyName = "Process";
            this.Process.HeaderText = "Process";
            this.Process.Name = "Process";
            // 
            // Priority
            // 
            this.Priority.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Priority.DataPropertyName = "Priority";
            this.Priority.HeaderText = "Priority";
            this.Priority.Name = "Priority";
            // 
            // BurstTime
            // 
            this.BurstTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BurstTime.DataPropertyName = "BurstTime";
            this.BurstTime.HeaderText = "Burst Time";
            this.BurstTime.Name = "BurstTime";
            // 
            // ArrivingTime
            // 
            this.ArrivingTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ArrivingTime.DataPropertyName = "ArrivingTime";
            this.ArrivingTime.HeaderText = "Arriving Time";
            this.ArrivingTime.Name = "ArrivingTime";
            // 
            // dgvResult
            // 
            this.dgvResult.BackgroundColor = System.Drawing.Color.Linen;
            this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProcessID,
            this.TurnaroundTime,
            this.WaitingTime});
            this.dgvResult.Location = new System.Drawing.Point(610, 162);
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.Size = new System.Drawing.Size(470, 297);
            this.dgvResult.TabIndex = 4;
            this.dgvResult.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResult_CellContentClick);
            // 
            // ProcessID
            // 
            this.ProcessID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProcessID.DataPropertyName = "ProcessID";
            this.ProcessID.HeaderText = "ProcessID";
            this.ProcessID.Name = "ProcessID";
            // 
            // TurnaroundTime
            // 
            this.TurnaroundTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TurnaroundTime.DataPropertyName = "TurnaroundTime";
            this.TurnaroundTime.HeaderText = "Turn-around Time";
            this.TurnaroundTime.Name = "TurnaroundTime";
            // 
            // WaitingTime
            // 
            this.WaitingTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.WaitingTime.DataPropertyName = "WaitingTime";
            this.WaitingTime.HeaderText = "Waiting Time";
            this.WaitingTime.Name = "WaitingTime";
            // 
            // labelNumOfProcess
            // 
            this.labelNumOfProcess.AutoSize = true;
            this.labelNumOfProcess.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumOfProcess.ForeColor = System.Drawing.SystemColors.Info;
            this.labelNumOfProcess.Location = new System.Drawing.Point(75, 93);
            this.labelNumOfProcess.Name = "labelNumOfProcess";
            this.labelNumOfProcess.Size = new System.Drawing.Size(191, 24);
            this.labelNumOfProcess.TabIndex = 5;
            this.labelNumOfProcess.Text = "Number of Process :";
            // 
            // processNumberBox
            // 
            this.processNumberBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processNumberBox.Location = new System.Drawing.Point(271, 86);
            this.processNumberBox.Name = "processNumberBox";
            this.processNumberBox.Size = new System.Drawing.Size(123, 31);
            this.processNumberBox.TabIndex = 6;
            // 
            // runBtn
            // 
            this.runBtn.BackColor = System.Drawing.SystemColors.Info;
            this.runBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.runBtn.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.runBtn.Location = new System.Drawing.Point(420, 42);
            this.runBtn.Name = "runBtn";
            this.runBtn.Size = new System.Drawing.Size(101, 60);
            this.runBtn.TabIndex = 7;
            this.runBtn.Text = "Run";
            this.runBtn.UseVisualStyleBackColor = false;
            // 
            // loadFileBtn
            // 
            this.loadFileBtn.BackColor = System.Drawing.SystemColors.Info;
            this.loadFileBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadFileBtn.Location = new System.Drawing.Point(590, 40);
            this.loadFileBtn.Name = "loadFileBtn";
            this.loadFileBtn.Size = new System.Drawing.Size(101, 62);
            this.loadFileBtn.TabIndex = 8;
            this.loadFileBtn.Text = "Load File";
            this.loadFileBtn.UseVisualStyleBackColor = false;
            // 
            // saveDataBtn
            // 
            this.saveDataBtn.BackColor = System.Drawing.SystemColors.Info;
            this.saveDataBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveDataBtn.Location = new System.Drawing.Point(753, 39);
            this.saveDataBtn.Name = "saveDataBtn";
            this.saveDataBtn.Size = new System.Drawing.Size(101, 63);
            this.saveDataBtn.TabIndex = 9;
            this.saveDataBtn.Text = "Save Data";
            this.saveDataBtn.UseVisualStyleBackColor = false;
            // 
            // resetBtn
            // 
            this.resetBtn.BackColor = System.Drawing.SystemColors.Info;
            this.resetBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetBtn.Location = new System.Drawing.Point(908, 40);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(101, 62);
            this.resetBtn.TabIndex = 10;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = false;
            // 
            // labelGanttChart
            // 
            this.labelGanttChart.AutoSize = true;
            this.labelGanttChart.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGanttChart.ForeColor = System.Drawing.SystemColors.Info;
            this.labelGanttChart.Location = new System.Drawing.Point(6, 473);
            this.labelGanttChart.Name = "labelGanttChart";
            this.labelGanttChart.Size = new System.Drawing.Size(159, 31);
            this.labelGanttChart.TabIndex = 11;
            this.labelGanttChart.Text = "Gantt Chart";
            // 
            // panelGanttChart
            // 
            this.panelGanttChart.BackColor = System.Drawing.Color.SandyBrown;
            this.panelGanttChart.Controls.Add(this.labelChartSequence);
            this.panelGanttChart.Controls.Add(this.labelStatus);
            this.panelGanttChart.Location = new System.Drawing.Point(18, 507);
            this.panelGanttChart.Name = "panelGanttChart";
            this.panelGanttChart.Size = new System.Drawing.Size(777, 128);
            this.panelGanttChart.TabIndex = 12;
            // 
            // labelChartSequence
            // 
            this.labelChartSequence.AutoSize = true;
            this.labelChartSequence.BackColor = System.Drawing.Color.Linen;
            this.labelChartSequence.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChartSequence.Location = new System.Drawing.Point(20, 72);
            this.labelChartSequence.Name = "labelChartSequence";
            this.labelChartSequence.Size = new System.Drawing.Size(175, 26);
            this.labelChartSequence.TabIndex = 14;
            this.labelChartSequence.Text = "Chart Sequence";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.BackColor = System.Drawing.Color.Linen;
            this.labelStatus.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.Location = new System.Drawing.Point(20, 21);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(75, 26);
            this.labelStatus.TabIndex = 13;
            this.labelStatus.Text = "Status";
            // 
            // labelProcessBoard
            // 
            this.labelProcessBoard.AutoSize = true;
            this.labelProcessBoard.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProcessBoard.ForeColor = System.Drawing.SystemColors.Info;
            this.labelProcessBoard.Location = new System.Drawing.Point(226, 136);
            this.labelProcessBoard.Name = "labelProcessBoard";
            this.labelProcessBoard.Size = new System.Drawing.Size(130, 23);
            this.labelProcessBoard.TabIndex = 13;
            this.labelProcessBoard.Text = "Process Board";
            // 
            // labelResultBoard
            // 
            this.labelResultBoard.AutoSize = true;
            this.labelResultBoard.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultBoard.ForeColor = System.Drawing.SystemColors.Info;
            this.labelResultBoard.Location = new System.Drawing.Point(724, 136);
            this.labelResultBoard.Name = "labelResultBoard";
            this.labelResultBoard.Size = new System.Drawing.Size(120, 23);
            this.labelResultBoard.TabIndex = 14;
            this.labelResultBoard.Text = "Result Board";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Linen;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AverageTAT,
            this.AverageWT});
            this.dataGridView1.Location = new System.Drawing.Point(753, 507);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(334, 128);
            this.dataGridView1.TabIndex = 15;
            // 
            // AverageTAT
            // 
            this.AverageTAT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AverageTAT.DataPropertyName = "AverageTAT";
            this.AverageTAT.HeaderText = "Average TAT";
            this.AverageTAT.Name = "AverageTAT";
            // 
            // AverageWT
            // 
            this.AverageWT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AverageWT.DataPropertyName = "AverageWT";
            this.AverageWT.HeaderText = "Average WT";
            this.AverageWT.Name = "AverageWT";
            // 
            // FormCPUScheduling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.panelGanttChart);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelResultBoard);
            this.Controls.Add(this.labelProcessBoard);
            this.Controls.Add(this.labelGanttChart);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.saveDataBtn);
            this.Controls.Add(this.loadFileBtn);
            this.Controls.Add(this.runBtn);
            this.Controls.Add(this.processNumberBox);
            this.Controls.Add(this.labelNumOfProcess);
            this.Controls.Add(this.dgvResult);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelAlgorithm);
            this.Controls.Add(this.pictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormCPUScheduling";
            this.Text = "FormCPUScheduling";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            this.panelGanttChart.ResumeLayout(false);
            this.panelGanttChart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label labelAlgorithm;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.DataGridViewTextBoxColumn Process;
        private System.Windows.Forms.DataGridViewTextBoxColumn Priority;
        private System.Windows.Forms.DataGridViewTextBoxColumn BurstTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArrivingTime;
        private System.Windows.Forms.DataGridView dgvResult;
        private System.Windows.Forms.Label labelNumOfProcess;
        private System.Windows.Forms.TextBox processNumberBox;
        private System.Windows.Forms.Button runBtn;
        private System.Windows.Forms.Button loadFileBtn;
        private System.Windows.Forms.Button saveDataBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Label labelGanttChart;
        private System.Windows.Forms.Panel panelGanttChart;
        private System.Windows.Forms.Label labelChartSequence;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelProcessBoard;
        private System.Windows.Forms.Label labelResultBoard;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProcessID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TurnaroundTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn WaitingTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn AverageTAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn AverageWT;
    }
}