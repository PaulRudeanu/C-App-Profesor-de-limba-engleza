using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace MyThesis_Login_And_Registration
{
    public partial class LoginForm : Form
    {

        

        public LoginForm()
        {
            InitializeComponent();

            this.textBoxPassword.AutoSize = false;
            this.textBoxPassword.Size = new Size(this.textBoxPassword.Size.Width, 50);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public static string passingText;

        private void buttonLogin_Click(object sender, EventArgs e)
        {

            DataBase db = new DataBase();
            
            String username = textBoxUsername.Text;
            String password = textBoxPassword.Text;

            passingText = username;

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `username` = @usn and `password` = @pass; ", db.getConnection());

            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;

            adapter.SelectCommand = command;

            adapter.Fill(table);

            //verificare daca contul userului exista sau nu
            if (table.Rows.Count > 0)
            {
                this.Hide();
                MainForm mainform = new MainForm();
                mainform.Show();
            }
            else
            {
                if(username.Trim().Equals(""))
                    {
                    MessageBox.Show("Introduceti Numele Dumneavoastra De Utilizator Pentru A Va Loga","Empty Username",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                if (username.Trim().Equals(""))
                {
                    MessageBox.Show("Introduceti Parola Dumneavoastra Pentru A Va Loga", "Empty Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Nume De Utilizator Sau Parola Gresite", "Wrong Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        private void labelCLose_MouseEnter(object sender, EventArgs e)
        {
            labelCLose.ForeColor = Color.White;
        }

        private void labelCLose_MouseLeave(object sender, EventArgs e)
        {
            labelCLose.ForeColor = Color.Black;
        }

        private void labelGoToSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationForm registerform = new RegistrationForm();
            registerform.Show();
        }

        private void labelGoToSignUp_MouseEnter(object sender, EventArgs e)
        {
            labelGoToSignUp.ForeColor = Color.Yellow;
        }

        private void labelGoToSignUp_MouseLeave(object sender, EventArgs e)
        {
            labelGoToSignUp.ForeColor = Color.White;
        }

        private void labelMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void labelMinimize_MouseEnter(object sender, EventArgs e)
        {
            labelMinimize.ForeColor = Color.White;
        }

        private void labelMinimize_MouseLeave(object sender, EventArgs e)
        {
            labelMinimize.ForeColor = Color.Black;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            Process ExternalProcess = new Process();
            ExternalProcess.StartInfo.FileName = @"C:\\XAMPP\\xampp-control.exe";
            ExternalProcess.Start();
        }

        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonLogin.PerformClick();
            }
        }
    }
}
