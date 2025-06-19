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
            this.gridResult = new System.Windows.Forms.DataGridView();
            this.lblNumOfProcess = new System.Windows.Forms.Label();
            this.txtProcessNumber = new System.Windows.Forms.TextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnLoadFromFile = new System.Windows.Forms.Button();
            this.btnSaveData = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblGanttChart = new System.Windows.Forms.Label();
            this.panelGanttChart = new System.Windows.Forms.Panel();
            this.lblChartSequence = new System.Windows.Forms.Label();
            this.gridAverage = new System.Windows.Forms.DataGridView();
            this.lblPriority = new System.Windows.Forms.Label();
            this.radWithoutPriority = new System.Windows.Forms.RadioButton();
            this.radWithPriority = new System.Windows.Forms.RadioButton();
            this.txtQuantumTime = new System.Windows.Forms.TextBox();
            this.lblQuantumTime = new System.Windows.Forms.Label();
            this.lblSecond = new System.Windows.Forms.Label();
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
            this.pictureBox.Location = new System.Drawing.Point(20, 19);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(169, 161);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // lblAlgorithm
            // 
            this.lblAlgorithm.AutoSize = true;
            this.lblAlgorithm.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlgorithm.ForeColor = System.Drawing.SystemColors.Info;
            this.lblAlgorithm.Location = new System.Drawing.Point(212, 19);
            this.lblAlgorithm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAlgorithm.Name = "lblAlgorithm";
            this.lblAlgorithm.Size = new System.Drawing.Size(173, 41);
            this.lblAlgorithm.TabIndex = 1;
            this.lblAlgorithm.Text = "Algorithm";
            // 
            // comboAlgorithm
            // 
            this.comboAlgorithm.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboAlgorithm.FormattingEnabled = true;
            this.comboAlgorithm.Location = new System.Drawing.Point(393, 20);
            this.comboAlgorithm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboAlgorithm.Name = "comboAlgorithm";
            this.comboAlgorithm.Size = new System.Drawing.Size(478, 41);
            this.comboAlgorithm.TabIndex = 2;
            this.comboAlgorithm.SelectedIndexChanged += new System.EventHandler(this.comboAlgorithm_SelectedIndexChanged);
            // 
            // gridData
            // 
            this.gridData.BackgroundColor = System.Drawing.Color.Linen;
            this.gridData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridData.Location = new System.Drawing.Point(13, 209);
            this.gridData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gridData.Name = "gridData";
            this.gridData.RowHeadersWidth = 62;
            this.gridData.Size = new System.Drawing.Size(885, 456);
            this.gridData.TabIndex = 3;
            this.gridData.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridData_CellValueChanged);
            // 
            // gridResult
            // 
            this.gridResult.BackgroundColor = System.Drawing.Color.Linen;
            this.gridResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridResult.Location = new System.Drawing.Point(906, 209);
            this.gridResult.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gridResult.Name = "gridResult";
            this.gridResult.ReadOnly = true;
            this.gridResult.RowHeadersWidth = 62;
            this.gridResult.Size = new System.Drawing.Size(440, 456);
            this.gridResult.TabIndex = 4;
            // 
            // lblNumOfProcess
            // 
            this.lblNumOfProcess.AutoSize = true;
            this.lblNumOfProcess.Font = new System.Drawing.Font("Times New Roman", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumOfProcess.ForeColor = System.Drawing.SystemColors.Info;
            this.lblNumOfProcess.Location = new System.Drawing.Point(903, 17);
            this.lblNumOfProcess.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumOfProcess.Name = "lblNumOfProcess";
            this.lblNumOfProcess.Size = new System.Drawing.Size(300, 40);
            this.lblNumOfProcess.TabIndex = 5;
            this.lblNumOfProcess.Text = "Number of Process";
            // 
            // txtProcessNumber
            // 
            this.txtProcessNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProcessNumber.Location = new System.Drawing.Point(1211, 17);
            this.txtProcessNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtProcessNumber.MaxLength = 10;
            this.txtProcessNumber.Name = "txtProcessNumber";
            this.txtProcessNumber.Size = new System.Drawing.Size(142, 40);
            this.txtProcessNumber.TabIndex = 6;
            this.txtProcessNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnRun
            // 
            this.btnRun.BackColor = System.Drawing.SystemColors.Info;
            this.btnRun.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRun.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRun.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnRun.Location = new System.Drawing.Point(1354, 209);
            this.btnRun.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(214, 125);
            this.btnRun.TabIndex = 7;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = false;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnLoadFromFile
            // 
            this.btnLoadFromFile.BackColor = System.Drawing.SystemColors.Info;
            this.btnLoadFromFile.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadFromFile.Location = new System.Drawing.Point(1354, 363);
            this.btnLoadFromFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLoadFromFile.Name = "btnLoadFromFile";
            this.btnLoadFromFile.Size = new System.Drawing.Size(214, 128);
            this.btnLoadFromFile.TabIndex = 8;
            this.btnLoadFromFile.Text = "Load From File";
            this.btnLoadFromFile.UseVisualStyleBackColor = false;
            this.btnLoadFromFile.Click += new System.EventHandler(this.btnLoadFromFile_Click);
            // 
            // btnSaveData
            // 
            this.btnSaveData.BackColor = System.Drawing.SystemColors.Info;
            this.btnSaveData.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveData.Location = new System.Drawing.Point(1354, 527);
            this.btnSaveData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSaveData.Name = "btnSaveData";
            this.btnSaveData.Size = new System.Drawing.Size(214, 125);
            this.btnSaveData.TabIndex = 9;
            this.btnSaveData.Text = "Save Data";
            this.btnSaveData.UseVisualStyleBackColor = false;
            this.btnSaveData.Click += new System.EventHandler(this.btnSaveData_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.Info;
            this.btnReset.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(1354, 687);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(214, 128);
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
            this.lblGanttChart.Location = new System.Drawing.Point(13, 670);
            this.lblGanttChart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGanttChart.Name = "lblGanttChart";
            this.lblGanttChart.Size = new System.Drawing.Size(208, 41);
            this.lblGanttChart.TabIndex = 11;
            this.lblGanttChart.Text = "Gantt Chart";
            // 
            // panelGanttChart
            // 
            this.panelGanttChart.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelGanttChart.Controls.Add(this.lblChartSequence);
            this.panelGanttChart.Location = new System.Drawing.Point(13, 716);
            this.panelGanttChart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelGanttChart.Name = "panelGanttChart";
            this.panelGanttChart.Size = new System.Drawing.Size(885, 197);
            this.panelGanttChart.TabIndex = 12;
            // 
            // lblChartSequence
            // 
            this.lblChartSequence.AutoSize = true;
            this.lblChartSequence.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblChartSequence.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChartSequence.ForeColor = System.Drawing.Color.Green;
            this.lblChartSequence.Location = new System.Drawing.Point(30, 29);
            this.lblChartSequence.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChartSequence.Name = "lblChartSequence";
            this.lblChartSequence.Size = new System.Drawing.Size(284, 41);
            this.lblChartSequence.TabIndex = 14;
            this.lblChartSequence.Text = "Ready to Execute";
            // 
            // gridAverage
            // 
            this.gridAverage.BackgroundColor = System.Drawing.Color.Linen;
            this.gridAverage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAverage.Location = new System.Drawing.Point(906, 716);
            this.gridAverage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gridAverage.Name = "gridAverage";
            this.gridAverage.ReadOnly = true;
            this.gridAverage.RowHeadersWidth = 62;
            this.gridAverage.Size = new System.Drawing.Size(436, 197);
            this.gridAverage.TabIndex = 15;
            // 
            // lblPriority
            // 
            this.lblPriority.AutoSize = true;
            this.lblPriority.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriority.ForeColor = System.Drawing.SystemColors.Info;
            this.lblPriority.Location = new System.Drawing.Point(912, 83);
            this.lblPriority.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(138, 41);
            this.lblPriority.TabIndex = 16;
            this.lblPriority.Text = "Priority";
            // 
            // radWithoutPriority
            // 
            this.radWithoutPriority.AutoSize = true;
            this.radWithoutPriority.Checked = true;
            this.radWithoutPriority.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radWithoutPriority.ForeColor = System.Drawing.SystemColors.Info;
            this.radWithoutPriority.Location = new System.Drawing.Point(1118, 83);
            this.radWithoutPriority.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radWithoutPriority.Name = "radWithoutPriority";
            this.radWithoutPriority.Size = new System.Drawing.Size(235, 37);
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
            this.radWithPriority.Location = new System.Drawing.Point(1118, 143);
            this.radWithPriority.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radWithPriority.Name = "radWithPriority";
            this.radWithPriority.Size = new System.Drawing.Size(196, 37);
            this.radWithPriority.TabIndex = 19;
            this.radWithPriority.Text = "With Priority";
            this.radWithPriority.UseVisualStyleBackColor = true;
            // 
            // txtQuantumTime
            // 
            this.txtQuantumTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantumTime.Location = new System.Drawing.Point(477, 104);
            this.txtQuantumTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtQuantumTime.MaxLength = 10;
            this.txtQuantumTime.Name = "txtQuantumTime";
            this.txtQuantumTime.Size = new System.Drawing.Size(100, 40);
            this.txtQuantumTime.TabIndex = 21;
            this.txtQuantumTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblQuantumTime
            // 
            this.lblQuantumTime.AutoSize = true;
            this.lblQuantumTime.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantumTime.ForeColor = System.Drawing.SystemColors.Info;
            this.lblQuantumTime.Location = new System.Drawing.Point(228, 108);
            this.lblQuantumTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantumTime.Name = "lblQuantumTime";
            this.lblQuantumTime.Size = new System.Drawing.Size(241, 36);
            this.lblQuantumTime.TabIndex = 20;
            this.lblQuantumTime.Text = "*Quantum Time";
            // 
            // lblSecond
            // 
            this.lblSecond.AutoSize = true;
            this.lblSecond.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecond.ForeColor = System.Drawing.SystemColors.Info;
            this.lblSecond.Location = new System.Drawing.Point(585, 108);
            this.lblSecond.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSecond.Name = "lblSecond";
            this.lblSecond.Size = new System.Drawing.Size(105, 36);
            this.lblSecond.TabIndex = 22;
            this.lblSecond.Text = "unit(s)";
            // 
            // FormCPUScheduling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(1581, 936);
            this.Controls.Add(this.gridData);
            this.Controls.Add(this.lblSecond);
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
            this.Controls.Add(this.comboAlgorithm);
            this.Controls.Add(this.lblAlgorithm);
            this.Controls.Add(this.pictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.DataGridView gridAverage;
        private System.Windows.Forms.Label lblPriority;
        private System.Windows.Forms.RadioButton radWithoutPriority;
        private System.Windows.Forms.RadioButton radWithPriority;
        private System.Windows.Forms.TextBox txtQuantumTime;
        private System.Windows.Forms.Label lblQuantumTime;
        private System.Windows.Forms.Label lblSecond;
    }
}