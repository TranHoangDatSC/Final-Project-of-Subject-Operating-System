using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_OP_Final
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            this.Text = "Visualization Operating System Algorithm";
        }

        private Form FormChild;
        private void OpenFormChild(Form childForm)
        {
            if(FormChild != null)
            {
                FormChild.Close();
            }
            FormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(childForm);
            MainPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (FormChild != null)
                FormChild.Close();
        }

        private void btnBankerAlgorithm_Click(object sender, EventArgs e)
        {
            OpenFormChild(new FormBankerAlgorithm());
        }

        private void btnCPUScheduling_Click(object sender, EventArgs e)
        {
            OpenFormChild(new FormCPUScheduling());
        }

        private void btnPageReplacement_Click(object sender, EventArgs e)
        {
            OpenFormChild(new FormPageReplacement());
        }

        private void btnDiskScheduling_Click(object sender, EventArgs e)
        {
            OpenFormChild(new FormDiskScheduling());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
