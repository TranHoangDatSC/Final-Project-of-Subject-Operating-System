namespace Project_OP_Final
{
    partial class FormDiskScheduling
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDiskScheduling));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbSelectAlgorithm = new System.Windows.Forms.ComboBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSaveRequest = new System.Windows.Forms.Button();
            this.btnLoadFromFile = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvAlgorithm = new System.Windows.Forms.DataGridView();
            this.From = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.To = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Distance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHeadPosition = new System.Windows.Forms.TextBox();
            this.txtDiskSize = new System.Windows.Forms.TextBox();
            this.txtRequestQueue = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotalHeadMovement = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelSteps = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelAlgorithms = new System.Windows.Forms.Label();
            this.radRight = new System.Windows.Forms.RadioButton();
            this.radLeft = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlgorithm)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(196, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "ALGORITHMS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project_OP_Final.Properties.Resources.DiskSchedulingIcon;
            this.pictureBox1.Location = new System.Drawing.Point(26, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // cbSelectAlgorithm
            // 
            this.cbSelectAlgorithm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSelectAlgorithm.FormattingEnabled = true;
            this.cbSelectAlgorithm.Location = new System.Drawing.Point(380, 68);
            this.cbSelectAlgorithm.Name = "cbSelectAlgorithm";
            this.cbSelectAlgorithm.Size = new System.Drawing.Size(231, 37);
            this.cbSelectAlgorithm.TabIndex = 8;
            // 
            // btnRun
            // 
            this.btnRun.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRun.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRun.Location = new System.Drawing.Point(651, 30);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(198, 117);
            this.btnRun.TabIndex = 9;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = false;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReset.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(1345, 30);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(198, 117);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSaveRequest
            // 
            this.btnSaveRequest.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSaveRequest.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveRequest.Location = new System.Drawing.Point(1111, 30);
            this.btnSaveRequest.Name = "btnSaveRequest";
            this.btnSaveRequest.Size = new System.Drawing.Size(198, 117);
            this.btnSaveRequest.TabIndex = 11;
            this.btnSaveRequest.Text = "Save Request";
            this.btnSaveRequest.UseVisualStyleBackColor = false;
            this.btnSaveRequest.Click += new System.EventHandler(this.btnSaveRequest_Click);
            // 
            // btnLoadFromFile
            // 
            this.btnLoadFromFile.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLoadFromFile.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadFromFile.Location = new System.Drawing.Point(875, 30);
            this.btnLoadFromFile.Name = "btnLoadFromFile";
            this.btnLoadFromFile.Size = new System.Drawing.Size(198, 117);
            this.btnLoadFromFile.TabIndex = 12;
            this.btnLoadFromFile.Text = "Load From File";
            this.btnLoadFromFile.UseVisualStyleBackColor = false;
            this.btnLoadFromFile.Click += new System.EventHandler(this.btnLoadFromFile_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvAlgorithm);
            this.panel1.Location = new System.Drawing.Point(26, 210);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(915, 700);
            this.panel1.TabIndex = 13;
            // 
            // dgvAlgorithm
            // 
            this.dgvAlgorithm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlgorithm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.From,
            this.To,
            this.Distance});
            this.dgvAlgorithm.Location = new System.Drawing.Point(0, 98);
            this.dgvAlgorithm.Name = "dgvAlgorithm";
            this.dgvAlgorithm.RowHeadersWidth = 62;
            this.dgvAlgorithm.RowTemplate.Height = 28;
            this.dgvAlgorithm.Size = new System.Drawing.Size(915, 602);
            this.dgvAlgorithm.TabIndex = 0;
            // 
            // From
            // 
            this.From.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.From.DataPropertyName = "From";
            this.From.HeaderText = "From";
            this.From.MinimumWidth = 8;
            this.From.Name = "From";
            // 
            // To
            // 
            this.To.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.To.DataPropertyName = "To";
            this.To.HeaderText = "To";
            this.To.MinimumWidth = 8;
            this.To.Name = "To";
            // 
            // Distance
            // 
            this.Distance.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Distance.DataPropertyName = "Distance";
            this.Distance.HeaderText = "Distance";
            this.Distance.MinimumWidth = 8;
            this.Distance.Name = "Distance";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(958, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 26);
            this.label2.TabIndex = 14;
            this.label2.Text = "Head Position";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(958, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 26);
            this.label3.TabIndex = 15;
            this.label3.Text = "Request Queue";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(958, 408);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 26);
            this.label4.TabIndex = 16;
            this.label4.Text = "Disk Size";
            // 
            // txtHeadPosition
            // 
            this.txtHeadPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtHeadPosition.Location = new System.Drawing.Point(1138, 235);
            this.txtHeadPosition.Name = "txtHeadPosition";
            this.txtHeadPosition.Size = new System.Drawing.Size(247, 35);
            this.txtHeadPosition.TabIndex = 17;
            // 
            // txtDiskSize
            // 
            this.txtDiskSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDiskSize.Location = new System.Drawing.Point(1138, 403);
            this.txtDiskSize.Name = "txtDiskSize";
            this.txtDiskSize.Size = new System.Drawing.Size(247, 35);
            this.txtDiskSize.TabIndex = 18;
            // 
            // txtRequestQueue
            // 
            this.txtRequestQueue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtRequestQueue.Location = new System.Drawing.Point(1138, 318);
            this.txtRequestQueue.Name = "txtRequestQueue";
            this.txtRequestQueue.Size = new System.Drawing.Size(247, 35);
            this.txtRequestQueue.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(958, 504);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(239, 26);
            this.label5.TabIndex = 21;
            this.label5.Text = "Total Head Movement";
            // 
            // txtTotalHeadMovement
            // 
            this.txtTotalHeadMovement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTotalHeadMovement.Location = new System.Drawing.Point(1203, 499);
            this.txtTotalHeadMovement.Name = "txtTotalHeadMovement";
            this.txtTotalHeadMovement.Size = new System.Drawing.Size(322, 35);
            this.txtTotalHeadMovement.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.labelSteps);
            this.panel2.Location = new System.Drawing.Point(963, 559);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(591, 351);
            this.panel2.TabIndex = 23;
            // 
            // labelSteps
            // 
            this.labelSteps.AutoSize = true;
            this.labelSteps.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSteps.Location = new System.Drawing.Point(19, 21);
            this.labelSteps.Name = "labelSteps";
            this.labelSteps.Size = new System.Drawing.Size(66, 26);
            this.labelSteps.TabIndex = 0;
            this.labelSteps.Text = "Steps";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.Controls.Add(this.labelAlgorithms);
            this.panel3.Location = new System.Drawing.Point(26, 210);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(915, 100);
            this.panel3.TabIndex = 0;
            // 
            // labelAlgorithms
            // 
            this.labelAlgorithms.AutoSize = true;
            this.labelAlgorithms.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlgorithms.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelAlgorithms.Location = new System.Drawing.Point(313, 43);
            this.labelAlgorithms.Name = "labelAlgorithms";
            this.labelAlgorithms.Size = new System.Drawing.Size(351, 26);
            this.labelAlgorithms.TabIndex = 24;
            this.labelAlgorithms.Text = "First-Come, First-Served (FCFS)";
            // 
            // radRight
            // 
            this.radRight.AutoSize = true;
            this.radRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radRight.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radRight.Location = new System.Drawing.Point(1425, 353);
            this.radRight.Name = "radRight";
            this.radRight.Size = new System.Drawing.Size(86, 29);
            this.radRight.TabIndex = 25;
            this.radRight.TabStop = true;
            this.radRight.Text = "Right";
            this.radRight.UseVisualStyleBackColor = true;
            this.radRight.CheckedChanged += new System.EventHandler(this.radRight_CheckedChanged);
            // 
            // radLeft
            // 
            this.radLeft.AutoSize = true;
            this.radLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLeft.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radLeft.Location = new System.Drawing.Point(1425, 407);
            this.radLeft.Name = "radLeft";
            this.radLeft.Size = new System.Drawing.Size(73, 29);
            this.radLeft.TabIndex = 27;
            this.radLeft.TabStop = true;
            this.radLeft.Text = "Left";
            this.radLeft.UseVisualStyleBackColor = true;
            this.radLeft.CheckedChanged += new System.EventHandler(this.radLeft_CheckedChanged);
            // 
            // FormDiskScheduling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(1581, 936);
            this.Controls.Add(this.radLeft);
            this.Controls.Add(this.radRight);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtTotalHeadMovement);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRequestQueue);
            this.Controls.Add(this.txtDiskSize);
            this.Controls.Add(this.txtHeadPosition);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnLoadFromFile);
            this.Controls.Add(this.btnSaveRequest);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.cbSelectAlgorithm);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDiskScheduling";
            this.Text = "FormDiskScheduling";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlgorithm)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbSelectAlgorithm;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSaveRequest;
        private System.Windows.Forms.Button btnLoadFromFile;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHeadPosition;
        private System.Windows.Forms.TextBox txtDiskSize;
        private System.Windows.Forms.TextBox txtRequestQueue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotalHeadMovement;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvAlgorithm;
        private System.Windows.Forms.DataGridViewTextBoxColumn From;
        private System.Windows.Forms.DataGridViewTextBoxColumn To;
        private System.Windows.Forms.DataGridViewTextBoxColumn Distance;
        private System.Windows.Forms.Label labelSteps;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelAlgorithms;
        private System.Windows.Forms.RadioButton radRight;
        private System.Windows.Forms.RadioButton radLeft;
    }
}