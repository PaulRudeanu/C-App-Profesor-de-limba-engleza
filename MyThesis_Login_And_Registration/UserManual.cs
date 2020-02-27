using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyThesis_Login_And_Registration
{
    public partial class UserManual : Form
    {
        public UserManual()
        {
            InitializeComponent();
        }

        private void labelCLose_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm openForm = new MainForm();
            openForm.Show();
        }

        private void labelMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void UserManual_Load(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { ValidateNames = true, Multiselect = false, Filter = "Manual de utilizare|*.pdf" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    axAcroPDF1.src = ofd.FileName;
                }
            }
        }

        private void labelCLose_MouseEnter(object sender, EventArgs e)
        {
            labelCLose.ForeColor = Color.Orange;
        }

        private void labelCLose_MouseLeave(object sender, EventArgs e)
        {
            labelCLose.ForeColor = Color.Black;
        }

        private void labelMinimize_MouseEnter(object sender, EventArgs e)
        {
            labelMinimize.ForeColor = Color.Orange;
        }

        private void labelMinimize_MouseLeave(object sender, EventArgs e)
        {
            labelMinimize.ForeColor = Color.Black;
        }
    }
}
