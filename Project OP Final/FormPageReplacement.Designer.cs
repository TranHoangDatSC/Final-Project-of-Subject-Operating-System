namespace Project_OP_Final
{
    partial class FormPageReplacement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPageReplacement));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgv_Result = new System.Windows.Forms.DataGridView();
            this.cb_Algorithm = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nud_Frame = new System.Windows.Forms.NumericUpDown();
            this.txt_Page_reference_string = new System.Windows.Forms.TextBox();
            this.btn_Simulation = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_SaveFile = new System.Windows.Forms.Button();
            this.btn_LoadFromFile = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_Pagefaults = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelAlgorithm = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Result)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Frame)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project_OP_Final.Properties.Resources.PRIocn;
            this.pictureBox1.Location = new System.Drawing.Point(25, 8);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dgv_Result
            // 
            this.dgv_Result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Result.Location = new System.Drawing.Point(14, 182);
            this.dgv_Result.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_Result.Name = "dgv_Result";
            this.dgv_Result.RowHeadersWidth = 62;
            this.dgv_Result.RowTemplate.Height = 28;
            this.dgv_Result.Size = new System.Drawing.Size(807, 276);
            this.dgv_Result.TabIndex = 1;
            // 
            // cb_Algorithm
            // 
            this.cb_Algorithm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cb_Algorithm.FormattingEnabled = true;
            this.cb_Algorithm.Location = new System.Drawing.Point(797, 57);
            this.cb_Algorithm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_Algorithm.Name = "cb_Algorithm";
            this.cb_Algorithm.Size = new System.Drawing.Size(179, 28);
            this.cb_Algorithm.TabIndex = 2;
            this.cb_Algorithm.SelectedIndexChanged += new System.EventHandler(this.cb_Algorithm_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(510, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select Frame";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(825, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Choose Algorithm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(170, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Enter Page Reference String";
            // 
            // nud_Frame
            // 
            this.nud_Frame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nud_Frame.Location = new System.Drawing.Point(484, 57);
            this.nud_Frame.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nud_Frame.Name = "nud_Frame";
            this.nud_Frame.Size = new System.Drawing.Size(154, 26);
            this.nud_Frame.TabIndex = 6;
            // 
            // txt_Page_reference_string
            // 
            this.txt_Page_reference_string.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_Page_reference_string.Location = new System.Drawing.Point(155, 58);
            this.txt_Page_reference_string.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Page_reference_string.Name = "txt_Page_reference_string";
            this.txt_Page_reference_string.Size = new System.Drawing.Size(231, 26);
            this.txt_Page_reference_string.TabIndex = 7;
            // 
            // btn_Simulation
            // 
            this.btn_Simulation.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Simulation.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Simulation.Location = new System.Drawing.Point(864, 138);
            this.btn_Simulation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Simulation.Name = "btn_Simulation";
            this.btn_Simulation.Size = new System.Drawing.Size(148, 90);
            this.btn_Simulation.TabIndex = 8;
            this.btn_Simulation.Text = "Run";
            this.btn_Simulation.UseVisualStyleBackColor = false;
            this.btn_Simulation.Click += new System.EventHandler(this.btn_Simulation_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Reset.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.Location = new System.Drawing.Point(864, 460);
            this.btn_Reset.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(148, 90);
            this.btn_Reset.TabIndex = 9;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = false;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_SaveFile
            // 
            this.btn_SaveFile.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_SaveFile.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SaveFile.Location = new System.Drawing.Point(864, 348);
            this.btn_SaveFile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_SaveFile.Name = "btn_SaveFile";
            this.btn_SaveFile.Size = new System.Drawing.Size(148, 90);
            this.btn_SaveFile.TabIndex = 10;
            this.btn_SaveFile.Text = "Save File";
            this.btn_SaveFile.UseVisualStyleBackColor = false;
            this.btn_SaveFile.Click += new System.EventHandler(this.btn_SaveFile_Click);
            // 
            // btn_LoadFromFile
            // 
            this.btn_LoadFromFile.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_LoadFromFile.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LoadFromFile.Location = new System.Drawing.Point(864, 241);
            this.btn_LoadFromFile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_LoadFromFile.Name = "btn_LoadFromFile";
            this.btn_LoadFromFile.Size = new System.Drawing.Size(148, 90);
            this.btn_LoadFromFile.TabIndex = 11;
            this.btn_LoadFromFile.Text = "Load From File";
            this.btn_LoadFromFile.UseVisualStyleBackColor = false;
            this.btn_LoadFromFile.Click += new System.EventHandler(this.btn_LoadFromFile_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.lb_Pagefaults);
            this.panel1.Location = new System.Drawing.Point(14, 471);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(809, 116);
            this.panel1.TabIndex = 12;
            // 
            // lb_Pagefaults
            // 
            this.lb_Pagefaults.AutoSize = true;
            this.lb_Pagefaults.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Pagefaults.Location = new System.Drawing.Point(23, 24);
            this.lb_Pagefaults.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Pagefaults.Name = "lb_Pagefaults";
            this.lb_Pagefaults.Size = new System.Drawing.Size(87, 19);
            this.lb_Pagefaults.TabIndex = 0;
            this.lb_Pagefaults.Text = "Page Faults";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.labelAlgorithm);
            this.panel2.Location = new System.Drawing.Point(14, 118);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(807, 70);
            this.panel2.TabIndex = 13;
            // 
            // labelAlgorithm
            // 
            this.labelAlgorithm.AutoSize = true;
            this.labelAlgorithm.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlgorithm.Location = new System.Drawing.Point(338, 27);
            this.labelAlgorithm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAlgorithm.Name = "labelAlgorithm";
            this.labelAlgorithm.Size = new System.Drawing.Size(75, 19);
            this.labelAlgorithm.TabIndex = 0;
            this.labelAlgorithm.Text = "Algorithm";
            // 
            // FormPageReplacement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_LoadFromFile);
            this.Controls.Add(this.btn_SaveFile);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_Simulation);
            this.Controls.Add(this.txt_Page_reference_string);
            this.Controls.Add(this.nud_Frame);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_Algorithm);
            this.Controls.Add(this.dgv_Result);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormPageReplacement";
            this.Text = "FormPageReplacement";
            this.Load += new System.EventHandler(this.FormPageReplacement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Result)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Frame)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgv_Result;
        private System.Windows.Forms.ComboBox cb_Algorithm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nud_Frame;
        private System.Windows.Forms.TextBox txt_Page_reference_string;
        private System.Windows.Forms.Button btn_Simulation;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_SaveFile;
        private System.Windows.Forms.Button btn_LoadFromFile;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_Pagefaults;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelAlgorithm;
    }
}