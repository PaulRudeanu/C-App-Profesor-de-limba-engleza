using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MyThesis_Login_And_Registration
{
    public partial class Leaderboard : Form
    {
        public Leaderboard()
        {
            InitializeComponent();
        }

        private void Leaderboard_Load(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
            MySqlDataAdapter adapterData = new MySqlDataAdapter("SELECT username, score FROM users_database.users order by score desc", connection);
            connection.Open();

            DataSet destination = new DataSet();
            adapterData.Fill(destination, "users");
            dataGridView1.DataSource = destination.Tables["users"];

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

        private void labelCLose_MouseEnter(object sender, EventArgs e)
        {
            labelCLose.ForeColor = Color.White;
        }

        private void labelCLose_MouseLeave(object sender, EventArgs e)
        {
            labelCLose.ForeColor = Color.Black;
        }

        private void labelMinimize_MouseEnter(object sender, EventArgs e)
        {
            labelMinimize.ForeColor = Color.White;
        }

        private void labelMinimize_MouseLeave(object sender, EventArgs e)
        {
            labelMinimize.ForeColor = Color.Black;
        }

        private void buttonGoBack4_Click(object sender, EventArgs e)
        {
            MainForm openForm = new MainForm();
            openForm.Show();
            Visible = false;
        }
    }
}
