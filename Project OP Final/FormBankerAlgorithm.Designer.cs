namespace Project_OP_Final
{
    partial class FormBankerAlgorithm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBankerAlgorithm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCheckSafe = new System.Windows.Forms.Button();
            this.btnRequestResource = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbProcessRequest = new System.Windows.Forms.ComboBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.flowPanelRequest = new System.Windows.Forms.FlowLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.nudProcesses = new System.Windows.Forms.NumericUpDown();
            this.nudResources = new System.Windows.Forms.NumericUpDown();
            this.labelSequence = new System.Windows.Forms.Label();
            this.dgvMaxDemand = new System.Windows.Forms.DataGridView();
            this.MaxDemand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNeed = new System.Windows.Forms.DataGridView();
            this.Need = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAvailable = new System.Windows.Forms.DataGridView();
            this.Available = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAllocation = new System.Windows.Forms.DataGridView();
            this.Allocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLoadFromTxt = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSaveFile = new System.Windows.Forms.Button();
            this.flowPanelRequest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudProcesses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudResources)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaxDemand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(269, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "PROCESSES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(526, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "RESOURCES";
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLoad.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(714, 24);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(218, 98);
            this.btnLoad.TabIndex = 7;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReset.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(1379, 24);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(181, 98);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCheckSafe
            // 
            this.btnCheckSafe.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCheckSafe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckSafe.Location = new System.Drawing.Point(793, 676);
            this.btnCheckSafe.Name = "btnCheckSafe";
            this.btnCheckSafe.Size = new System.Drawing.Size(215, 117);
            this.btnCheckSafe.TabIndex = 10;
            this.btnCheckSafe.Text = "Check Safe";
            this.btnCheckSafe.UseVisualStyleBackColor = false;
            this.btnCheckSafe.Click += new System.EventHandler(this.btnCheckSafe_Click);
            // 
            // btnRequestResource
            // 
            this.btnRequestResource.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRequestResource.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRequestResource.ForeColor = System.Drawing.Color.Black;
            this.btnRequestResource.Location = new System.Drawing.Point(793, 539);
            this.btnRequestResource.Name = "btnRequestResource";
            this.btnRequestResource.Size = new System.Drawing.Size(215, 117);
            this.btnRequestResource.TabIndex = 11;
            this.btnRequestResource.Text = "Request Resource";
            this.btnRequestResource.UseVisualStyleBackColor = false;
            this.btnRequestResource.Click += new System.EventHandler(this.btnRequestResource_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(531, 488);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(256, 26);
            this.label4.TabIndex = 12;
            this.label4.Text = "Enter resource request:";
            // 
            // cbProcessRequest
            // 
            this.cbProcessRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbProcessRequest.FormattingEnabled = true;
            this.cbProcessRequest.Location = new System.Drawing.Point(793, 486);
            this.cbProcessRequest.Name = "cbProcessRequest";
            this.cbProcessRequest.Size = new System.Drawing.Size(215, 33);
            this.cbProcessRequest.TabIndex = 13;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 936);
            this.splitter1.TabIndex = 15;
            this.splitter1.TabStop = false;
            // 
            // flowPanelRequest
            // 
            this.flowPanelRequest.Controls.Add(this.textBox1);
            this.flowPanelRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.flowPanelRequest.Location = new System.Drawing.Point(536, 522);
            this.flowPanelRequest.Name = "flowPanelRequest";
            this.flowPanelRequest.Size = new System.Drawing.Size(235, 376);
            this.flowPanelRequest.TabIndex = 20;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(232, 35);
            this.textBox1.TabIndex = 0;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.Location = new System.Drawing.Point(3, 27);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(75, 26);
            this.labelStatus.TabIndex = 21;
            this.labelStatus.Text = "Status";
            // 
            // nudProcesses
            // 
            this.nudProcesses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nudProcesses.Location = new System.Drawing.Point(259, 75);
            this.nudProcesses.Name = "nudProcesses";
            this.nudProcesses.Size = new System.Drawing.Size(178, 30);
            this.nudProcesses.TabIndex = 22;
            // 
            // nudResources
            // 
            this.nudResources.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nudResources.Location = new System.Drawing.Point(520, 75);
            this.nudResources.Name = "nudResources";
            this.nudResources.Size = new System.Drawing.Size(178, 30);
            this.nudResources.TabIndex = 23;
            // 
            // labelSequence
            // 
            this.labelSequence.AutoSize = true;
            this.labelSequence.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSequence.Location = new System.Drawing.Point(3, 81);
            this.labelSequence.Name = "labelSequence";
            this.labelSequence.Size = new System.Drawing.Size(157, 26);
            this.labelSequence.TabIndex = 24;
            this.labelSequence.Text = "Safe Sequence";
            // 
            // dgvMaxDemand
            // 
            this.dgvMaxDemand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaxDemand.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaxDemand});
            this.dgvMaxDemand.Location = new System.Drawing.Point(9, 151);
            this.dgvMaxDemand.Name = "dgvMaxDemand";
            this.dgvMaxDemand.RowHeadersWidth = 62;
            this.dgvMaxDemand.RowTemplate.Height = 28;
            this.dgvMaxDemand.Size = new System.Drawing.Size(516, 315);
            this.dgvMaxDemand.TabIndex = 26;
            // 
            // MaxDemand
            // 
            this.MaxDemand.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaxDemand.HeaderText = "Max Demand";
            this.MaxDemand.MinimumWidth = 8;
            this.MaxDemand.Name = "MaxDemand";
            // 
            // dgvNeed
            // 
            this.dgvNeed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNeed.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Need});
            this.dgvNeed.Location = new System.Drawing.Point(9, 488);
            this.dgvNeed.Name = "dgvNeed";
            this.dgvNeed.RowHeadersWidth = 62;
            this.dgvNeed.RowTemplate.Height = 28;
            this.dgvNeed.Size = new System.Drawing.Size(516, 410);
            this.dgvNeed.TabIndex = 27;
            // 
            // Need
            // 
            this.Need.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Need.DataPropertyName = "Need";
            this.Need.HeaderText = "Need";
            this.Need.MinimumWidth = 8;
            this.Need.Name = "Need";
            // 
            // dgvAvailable
            // 
            this.dgvAvailable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAvailable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Available});
            this.dgvAvailable.Location = new System.Drawing.Point(1070, 151);
            this.dgvAvailable.Name = "dgvAvailable";
            this.dgvAvailable.RowHeadersWidth = 62;
            this.dgvAvailable.RowTemplate.Height = 28;
            this.dgvAvailable.Size = new System.Drawing.Size(510, 315);
            this.dgvAvailable.TabIndex = 28;
            // 
            // Available
            // 
            this.Available.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Available.DataPropertyName = "Available";
            this.Available.HeaderText = "Available";
            this.Available.MinimumWidth = 8;
            this.Available.Name = "Available";
            // 
            // dgvAllocation
            // 
            this.dgvAllocation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllocation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Allocation});
            this.dgvAllocation.Location = new System.Drawing.Point(531, 151);
            this.dgvAllocation.Name = "dgvAllocation";
            this.dgvAllocation.RowHeadersWidth = 62;
            this.dgvAllocation.RowTemplate.Height = 28;
            this.dgvAllocation.Size = new System.Drawing.Size(533, 315);
            this.dgvAllocation.TabIndex = 29;
            // 
            // Allocation
            // 
            this.Allocation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Allocation.DataPropertyName = "Allocation";
            this.Allocation.HeaderText = "Allocation";
            this.Allocation.MinimumWidth = 8;
            this.Allocation.Name = "Allocation";
            // 
            // btnLoadFromTxt
            // 
            this.btnLoadFromTxt.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLoadFromTxt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadFromTxt.Location = new System.Drawing.Point(947, 24);
            this.btnLoadFromTxt.Name = "btnLoadFromTxt";
            this.btnLoadFromTxt.Size = new System.Drawing.Size(221, 98);
            this.btnLoadFromTxt.TabIndex = 30;
            this.btnLoadFromTxt.Text = "Load From File";
            this.btnLoadFromTxt.UseVisualStyleBackColor = false;
            this.btnLoadFromTxt.Click += new System.EventHandler(this.btnLoadFromTxt_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project_OP_Final.Properties.Resources.BankerIcon;
            this.pictureBox1.Location = new System.Drawing.Point(28, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.labelStatus);
            this.panel1.Controls.Add(this.labelSequence);
            this.panel1.Location = new System.Drawing.Point(1037, 525);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(540, 359);
            this.panel1.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(1239, 486);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 26);
            this.label3.TabIndex = 33;
            this.label3.Text = "RESULT:";
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSaveFile.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveFile.Location = new System.Drawing.Point(1183, 24);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(181, 98);
            this.btnSaveFile.TabIndex = 34;
            this.btnSaveFile.Text = "Save File";
            this.btnSaveFile.UseVisualStyleBackColor = false;
            this.btnSaveFile.Click += new System.EventHandler(this.btnSaveFile_Click);
            // 
            // FormBankerAlgorithm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1581, 936);
            this.Controls.Add(this.btnSaveFile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLoadFromTxt);
            this.Controls.Add(this.dgvAllocation);
            this.Controls.Add(this.dgvAvailable);
            this.Controls.Add(this.dgvNeed);
            this.Controls.Add(this.dgvMaxDemand);
            this.Controls.Add(this.nudResources);
            this.Controls.Add(this.nudProcesses);
            this.Controls.Add(this.flowPanelRequest);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.cbProcessRequest);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnRequestResource);
            this.Controls.Add(this.btnCheckSafe);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormBankerAlgorithm";
            this.Text = "FormBankerAlgorithm";
            this.flowPanelRequest.ResumeLayout(false);
            this.flowPanelRequest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudProcesses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudResources)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaxDemand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnCheckSafe;
        private System.Windows.Forms.Button btnRequestResource;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbProcessRequest;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.FlowLayoutPanel flowPanelRequest;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.NumericUpDown nudProcesses;
        private System.Windows.Forms.NumericUpDown nudResources;
        private System.Windows.Forms.Label labelSequence;
        private System.Windows.Forms.DataGridView dgvMaxDemand;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxDemand;
        private System.Windows.Forms.DataGridView dgvNeed;
        private System.Windows.Forms.DataGridView dgvAvailable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Available;
        private System.Windows.Forms.DataGridView dgvAllocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Allocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Need;
        private System.Windows.Forms.Button btnLoadFromTxt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSaveFile;
    }
}