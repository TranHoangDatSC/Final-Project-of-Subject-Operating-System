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
            this.mainlabel = new System.Windows.Forms.Label();
            this.txt_Page_reference_string = new System.Windows.Forms.TextBox();
            this.cb_Algorithm = new System.Windows.Forms.ComboBox();
            this.nud_Frame = new System.Windows.Forms.NumericUpDown();
            this.btn_Simulation = new System.Windows.Forms.Button();
            this.lb_Page_reference_string = new System.Windows.Forms.Label();
            this.lb_Frame = new System.Windows.Forms.Label();
            this.lb_Algorithm = new System.Windows.Forms.Label();
            this.dgv_Result = new System.Windows.Forms.DataGridView();
            this.lb_Pagefaults = new System.Windows.Forms.Label();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_LoadFromFile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Frame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Result)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainlabel
            // 
            this.mainlabel.AutoSize = true;
            this.mainlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.mainlabel.Location = new System.Drawing.Point(145, 57);
            this.mainlabel.Name = "mainlabel";
            this.mainlabel.Size = new System.Drawing.Size(1196, 84);
            this.mainlabel.TabIndex = 0;
            this.mainlabel.Text = "PROGRAM ILLUSTRATING PAGE REPLACEMENT ALGORITHMS\r\n\r\n";
            // 
            // txt_Page_reference_string
            // 
            this.txt_Page_reference_string.Location = new System.Drawing.Point(354, 158);
            this.txt_Page_reference_string.Name = "txt_Page_reference_string";
            this.txt_Page_reference_string.Size = new System.Drawing.Size(278, 22);
            this.txt_Page_reference_string.TabIndex = 1;
            // 
            // cb_Algorithm
            // 
            this.cb_Algorithm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Algorithm.FormattingEnabled = true;
            this.cb_Algorithm.Location = new System.Drawing.Point(1257, 159);
            this.cb_Algorithm.Name = "cb_Algorithm";
            this.cb_Algorithm.Size = new System.Drawing.Size(121, 24);
            this.cb_Algorithm.TabIndex = 2;
            // 
            // nud_Frame
            // 
            this.nud_Frame.Location = new System.Drawing.Point(821, 161);
            this.nud_Frame.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_Frame.Name = "nud_Frame";
            this.nud_Frame.Size = new System.Drawing.Size(120, 22);
            this.nud_Frame.TabIndex = 3;
            this.nud_Frame.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // btn_Simulation
            // 
            this.btn_Simulation.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Simulation.Location = new System.Drawing.Point(1066, 722);
            this.btn_Simulation.Name = "btn_Simulation";
            this.btn_Simulation.Size = new System.Drawing.Size(224, 110);
            this.btn_Simulation.TabIndex = 4;
            this.btn_Simulation.Text = "Simulation";
            this.btn_Simulation.UseVisualStyleBackColor = true;
            this.btn_Simulation.Click += new System.EventHandler(this.btn_Simulation_Click);
            // 
            // lb_Page_reference_string
            // 
            this.lb_Page_reference_string.AutoSize = true;
            this.lb_Page_reference_string.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_Page_reference_string.Location = new System.Drawing.Point(96, 158);
            this.lb_Page_reference_string.Name = "lb_Page_reference_string";
            this.lb_Page_reference_string.Size = new System.Drawing.Size(252, 25);
            this.lb_Page_reference_string.TabIndex = 5;
            this.lb_Page_reference_string.Text = "Enter page reference string:\r\n";
            // 
            // lb_Frame
            // 
            this.lb_Frame.AutoSize = true;
            this.lb_Frame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_Frame.Location = new System.Drawing.Point(688, 159);
            this.lb_Frame.Name = "lb_Frame";
            this.lb_Frame.Size = new System.Drawing.Size(127, 25);
            this.lb_Frame.TabIndex = 6;
            this.lb_Frame.Text = "Select frame:";
            // 
            // lb_Algorithm
            // 
            this.lb_Algorithm.AutoSize = true;
            this.lb_Algorithm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_Algorithm.Location = new System.Drawing.Point(1080, 159);
            this.lb_Algorithm.Name = "lb_Algorithm";
            this.lb_Algorithm.Size = new System.Drawing.Size(171, 25);
            this.lb_Algorithm.TabIndex = 7;
            this.lb_Algorithm.Text = "Choose algorithm:";
            // 
            // dgv_Result
            // 
            this.dgv_Result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Result.Location = new System.Drawing.Point(12, 230);
            this.dgv_Result.Name = "dgv_Result";
            this.dgv_Result.RowHeadersWidth = 51;
            this.dgv_Result.RowTemplate.Height = 24;
            this.dgv_Result.Size = new System.Drawing.Size(1569, 351);
            this.dgv_Result.TabIndex = 8;
            // 
            // lb_Pagefaults
            // 
            this.lb_Pagefaults.AutoSize = true;
            this.lb_Pagefaults.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_Pagefaults.Location = new System.Drawing.Point(668, 626);
            this.lb_Pagefaults.Name = "lb_Pagefaults";
            this.lb_Pagefaults.Size = new System.Drawing.Size(120, 25);
            this.lb_Pagefaults.TabIndex = 9;
            this.lb_Pagefaults.Text = "Page faults: ";
            // 
            // btn_Reset
            // 
            this.btn_Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Reset.Location = new System.Drawing.Point(613, 722);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(224, 110);
            this.btn_Reset.TabIndex = 10;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project_OP_Final.Properties.Resources.documents;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 143);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // btn_LoadFromFile
            // 
            this.btn_LoadFromFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_LoadFromFile.Location = new System.Drawing.Point(166, 722);
            this.btn_LoadFromFile.Name = "btn_LoadFromFile";
            this.btn_LoadFromFile.Size = new System.Drawing.Size(224, 110);
            this.btn_LoadFromFile.TabIndex = 12;
            this.btn_LoadFromFile.Text = "Load From File";
            this.btn_LoadFromFile.UseVisualStyleBackColor = true;
            this.btn_LoadFromFile.Click += new System.EventHandler(this.btn_LoadFromFile_Click);
            // 
            // FormPageReplacement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1585, 945);
            this.Controls.Add(this.btn_LoadFromFile);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.lb_Pagefaults);
            this.Controls.Add(this.dgv_Result);
            this.Controls.Add(this.lb_Algorithm);
            this.Controls.Add(this.lb_Frame);
            this.Controls.Add(this.lb_Page_reference_string);
            this.Controls.Add(this.btn_Simulation);
            this.Controls.Add(this.nud_Frame);
            this.Controls.Add(this.cb_Algorithm);
            this.Controls.Add(this.txt_Page_reference_string);
            this.Controls.Add(this.mainlabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormPageReplacement";
            this.Text = "FormPageReplacement";
            this.Load += new System.EventHandler(this.FormPageReplacement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_Frame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Result)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainlabel;
        private System.Windows.Forms.TextBox txt_Page_reference_string;
        private System.Windows.Forms.ComboBox cb_Algorithm;
        private System.Windows.Forms.NumericUpDown nud_Frame;
        private System.Windows.Forms.Button btn_Simulation;
        private System.Windows.Forms.Label lb_Page_reference_string;
        private System.Windows.Forms.Label lb_Frame;
        private System.Windows.Forms.Label lb_Algorithm;
        private System.Windows.Forms.DataGridView dgv_Result;
        private System.Windows.Forms.Label lb_Pagefaults;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_LoadFromFile;
    }
}