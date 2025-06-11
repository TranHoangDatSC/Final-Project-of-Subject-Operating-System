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
            this.lblAlgorithm = new System.Windows.Forms.Label();
            this.comboAlgorithm = new System.Windows.Forms.ComboBox();
            this.gridData = new System.Windows.Forms.DataGridView();
            this.Process = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Priority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BurstTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArrivingTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridResult = new System.Windows.Forms.DataGridView();
            this.ProcessID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TurnaroundTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WaitingTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblNumOfProcess = new System.Windows.Forms.Label();
            this.txtProcessNumber = new System.Windows.Forms.TextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnLoadFromFile = new System.Windows.Forms.Button();
            this.btnSaveData = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblGanttChart = new System.Windows.Forms.Label();
            this.panelGanttChart = new System.Windows.Forms.Panel();
            this.lblChartSequence = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.gridAverage = new System.Windows.Forms.DataGridView();
            this.AverageTAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AverageWT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPriority = new System.Windows.Forms.Label();
            this.radWithoutPriority = new System.Windows.Forms.RadioButton();
            this.radWithPriority = new System.Windows.Forms.RadioButton();
            this.txtQuantumTime = new System.Windows.Forms.TextBox();
            this.lblQuantumTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridResult)).BeginInit();
            this.panelGanttChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAverage)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(18, 25);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(101, 95);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // lblAlgorithm
            // 
            this.lblAlgorithm.AutoSize = true;
            this.lblAlgorithm.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlgorithm.ForeColor = System.Drawing.SystemColors.Info;
            this.lblAlgorithm.Location = new System.Drawing.Point(155, 31);
            this.lblAlgorithm.Name = "lblAlgorithm";
            this.lblAlgorithm.Size = new System.Drawing.Size(118, 26);
            this.lblAlgorithm.TabIndex = 1;
            this.lblAlgorithm.Text = "Algorithm";
            // 
            // comboAlgorithm
            // 
            this.comboAlgorithm.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboAlgorithm.FormattingEnabled = true;
            this.comboAlgorithm.Location = new System.Drawing.Point(320, 28);
            this.comboAlgorithm.Name = "comboAlgorithm";
            this.comboAlgorithm.Size = new System.Drawing.Size(310, 29);
            this.comboAlgorithm.TabIndex = 2;
            this.comboAlgorithm.SelectedIndexChanged += new System.EventHandler(this.comboAlgorithm_SelectedIndexChanged);
            // 
            // gridData
            // 
            this.gridData.BackgroundColor = System.Drawing.Color.Linen;
            this.gridData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Process,
            this.Priority,
            this.BurstTime,
            this.ArrivingTime});
            this.gridData.Location = new System.Drawing.Point(43, 187);
            this.gridData.Name = "gridData";
            this.gridData.Size = new System.Drawing.Size(451, 283);
            this.gridData.TabIndex = 3;
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
            // gridResult
            // 
            this.gridResult.BackgroundColor = System.Drawing.Color.Linen;
            this.gridResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProcessID,
            this.TurnaroundTime,
            this.WaitingTime});
            this.gridResult.Location = new System.Drawing.Point(500, 187);
            this.gridResult.Name = "gridResult";
            this.gridResult.Size = new System.Drawing.Size(435, 283);
            this.gridResult.TabIndex = 4;
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
            // lblNumOfProcess
            // 
            this.lblNumOfProcess.AutoSize = true;
            this.lblNumOfProcess.Font = new System.Drawing.Font("Times New Roman", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumOfProcess.ForeColor = System.Drawing.SystemColors.Info;
            this.lblNumOfProcess.Location = new System.Drawing.Point(704, 26);
            this.lblNumOfProcess.Name = "lblNumOfProcess";
            this.lblNumOfProcess.Size = new System.Drawing.Size(204, 25);
            this.lblNumOfProcess.TabIndex = 5;
            this.lblNumOfProcess.Text = "Number of Process";
            // 
            // txtProcessNumber
            // 
            this.txtProcessNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProcessNumber.Location = new System.Drawing.Point(915, 25);
            this.txtProcessNumber.MaxLength = 10;
            this.txtProcessNumber.Name = "txtProcessNumber";
            this.txtProcessNumber.Size = new System.Drawing.Size(68, 29);
            this.txtProcessNumber.TabIndex = 6;
            this.txtProcessNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnRun
            // 
            this.btnRun.BackColor = System.Drawing.SystemColors.Info;
            this.btnRun.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRun.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRun.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnRun.Location = new System.Drawing.Point(971, 99);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(143, 81);
            this.btnRun.TabIndex = 7;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = false;
            // 
            // btnLoadFromFile
            // 
            this.btnLoadFromFile.BackColor = System.Drawing.SystemColors.Info;
            this.btnLoadFromFile.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadFromFile.Location = new System.Drawing.Point(971, 200);
            this.btnLoadFromFile.Name = "btnLoadFromFile";
            this.btnLoadFromFile.Size = new System.Drawing.Size(143, 83);
            this.btnLoadFromFile.TabIndex = 8;
            this.btnLoadFromFile.Text = "Load From File";
            this.btnLoadFromFile.UseVisualStyleBackColor = false;
            // 
            // btnSaveData
            // 
            this.btnSaveData.BackColor = System.Drawing.SystemColors.Info;
            this.btnSaveData.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveData.Location = new System.Drawing.Point(971, 306);
            this.btnSaveData.Name = "btnSaveData";
            this.btnSaveData.Size = new System.Drawing.Size(143, 81);
            this.btnSaveData.TabIndex = 9;
            this.btnSaveData.Text = "Save Data";
            this.btnSaveData.UseVisualStyleBackColor = false;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.Info;
            this.btnReset.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(971, 406);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(143, 83);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblGanttChart
            // 
            this.lblGanttChart.AutoSize = true;
            this.lblGanttChart.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGanttChart.ForeColor = System.Drawing.SystemColors.Info;
            this.lblGanttChart.Location = new System.Drawing.Point(6, 473);
            this.lblGanttChart.Name = "lblGanttChart";
            this.lblGanttChart.Size = new System.Drawing.Size(138, 26);
            this.lblGanttChart.TabIndex = 11;
            this.lblGanttChart.Text = "Gantt Chart";
            // 
            // panelGanttChart
            // 
            this.panelGanttChart.BackColor = System.Drawing.Color.SandyBrown;
            this.panelGanttChart.Controls.Add(this.lblChartSequence);
            this.panelGanttChart.Controls.Add(this.lblStatus);
            this.panelGanttChart.Location = new System.Drawing.Point(18, 507);
            this.panelGanttChart.Name = "panelGanttChart";
            this.panelGanttChart.Size = new System.Drawing.Size(777, 128);
            this.panelGanttChart.TabIndex = 12;
            // 
            // lblChartSequence
            // 
            this.lblChartSequence.AutoSize = true;
            this.lblChartSequence.BackColor = System.Drawing.Color.Linen;
            this.lblChartSequence.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChartSequence.Location = new System.Drawing.Point(20, 72);
            this.lblChartSequence.Name = "lblChartSequence";
            this.lblChartSequence.Size = new System.Drawing.Size(175, 26);
            this.lblChartSequence.TabIndex = 14;
            this.lblChartSequence.Text = "Chart Sequence";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Linen;
            this.lblStatus.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(20, 21);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(75, 26);
            this.lblStatus.TabIndex = 13;
            this.lblStatus.Text = "Status";
            // 
            // gridAverage
            // 
            this.gridAverage.BackgroundColor = System.Drawing.Color.Linen;
            this.gridAverage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAverage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AverageTAT,
            this.AverageWT});
            this.gridAverage.Location = new System.Drawing.Point(753, 507);
            this.gridAverage.Name = "gridAverage";
            this.gridAverage.Size = new System.Drawing.Size(345, 128);
            this.gridAverage.TabIndex = 15;
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
            // lblPriority
            // 
            this.lblPriority.AutoSize = true;
            this.lblPriority.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriority.ForeColor = System.Drawing.SystemColors.Info;
            this.lblPriority.Location = new System.Drawing.Point(652, 100);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(95, 26);
            this.lblPriority.TabIndex = 16;
            this.lblPriority.Text = "Priority";
            // 
            // radWithoutPriority
            // 
            this.radWithoutPriority.AutoSize = true;
            this.radWithoutPriority.Checked = true;
            this.radWithoutPriority.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radWithoutPriority.ForeColor = System.Drawing.SystemColors.Info;
            this.radWithoutPriority.Location = new System.Drawing.Point(753, 85);
            this.radWithoutPriority.Name = "radWithoutPriority";
            this.radWithoutPriority.Size = new System.Drawing.Size(155, 26);
            this.radWithoutPriority.TabIndex = 18;
            this.radWithoutPriority.TabStop = true;
            this.radWithoutPriority.Text = "Without Priority";
            this.radWithoutPriority.UseVisualStyleBackColor = true;
            // 
            // radWithPriority
            // 
            this.radWithPriority.AutoSize = true;
            this.radWithPriority.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radWithPriority.ForeColor = System.Drawing.SystemColors.Info;
            this.radWithPriority.Location = new System.Drawing.Point(753, 131);
            this.radWithPriority.Name = "radWithPriority";
            this.radWithPriority.Size = new System.Drawing.Size(130, 26);
            this.radWithPriority.TabIndex = 19;
            this.radWithPriority.Text = "With Priority";
            this.radWithPriority.UseVisualStyleBackColor = true;
            // 
            // txtQuantumTime
            // 
            this.txtQuantumTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantumTime.Location = new System.Drawing.Point(365, 100);
            this.txtQuantumTime.MaxLength = 10;
            this.txtQuantumTime.Name = "txtQuantumTime";
            this.txtQuantumTime.Size = new System.Drawing.Size(68, 29);
            this.txtQuantumTime.TabIndex = 21;
            this.txtQuantumTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblQuantumTime
            // 
            this.lblQuantumTime.AutoSize = true;
            this.lblQuantumTime.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantumTime.ForeColor = System.Drawing.SystemColors.Info;
            this.lblQuantumTime.Location = new System.Drawing.Point(154, 101);
            this.lblQuantumTime.Name = "lblQuantumTime";
            this.lblQuantumTime.Size = new System.Drawing.Size(155, 24);
            this.lblQuantumTime.TabIndex = 20;
            this.lblQuantumTime.Text = "*Quantum Time";
            // 
            // FormCPUScheduling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.txtQuantumTime);
            this.Controls.Add(this.lblQuantumTime);
            this.Controls.Add(this.radWithPriority);
            this.Controls.Add(this.radWithoutPriority);
            this.Controls.Add(this.lblPriority);
            this.Controls.Add(this.panelGanttChart);
            this.Controls.Add(this.gridAverage);
            this.Controls.Add(this.lblGanttChart);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSaveData);
            this.Controls.Add(this.btnLoadFromFile);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.txtProcessNumber);
            this.Controls.Add(this.lblNumOfProcess);
            this.Controls.Add(this.gridResult);
            this.Controls.Add(this.gridData);
            this.Controls.Add(this.comboAlgorithm);
            this.Controls.Add(this.lblAlgorithm);
            this.Controls.Add(this.pictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormCPUScheduling";
            this.Text = "FormCPUScheduling";
            this.Load += new System.EventHandler(this.FormCPUScheduling_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridResult)).EndInit();
            this.panelGanttChart.ResumeLayout(false);
            this.panelGanttChart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAverage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label lblAlgorithm;
        private System.Windows.Forms.ComboBox comboAlgorithm;
        private System.Windows.Forms.DataGridView gridData;
        private System.Windows.Forms.DataGridViewTextBoxColumn Process;
        private System.Windows.Forms.DataGridViewTextBoxColumn Priority;
        private System.Windows.Forms.DataGridViewTextBoxColumn BurstTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArrivingTime;
        private System.Windows.Forms.DataGridView gridResult;
        private System.Windows.Forms.Label lblNumOfProcess;
        private System.Windows.Forms.TextBox txtProcessNumber;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnLoadFromFile;
        private System.Windows.Forms.Button btnSaveData;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblGanttChart;
        private System.Windows.Forms.Panel panelGanttChart;
        private System.Windows.Forms.Label lblChartSequence;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.DataGridView gridAverage;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProcessID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TurnaroundTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn WaitingTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn AverageTAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn AverageWT;
        private System.Windows.Forms.Label lblPriority;
        private System.Windows.Forms.RadioButton radWithoutPriority;
        private System.Windows.Forms.RadioButton radWithPriority;
        private System.Windows.Forms.TextBox txtQuantumTime;
        private System.Windows.Forms.Label lblQuantumTime;
    }
}