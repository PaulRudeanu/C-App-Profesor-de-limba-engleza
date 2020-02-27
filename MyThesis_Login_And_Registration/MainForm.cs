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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buttonVocabulary_Click(object sender, EventArgs e)
        {
            MainForm closeForm = new MainForm();
            closeForm.Close();
            Vocabulary cuvintedebaza = new Vocabulary();
            cuvintedebaza.Show();
            Visible = false;
        }

        private void buttonGrammarExercises_Click(object sender, EventArgs e)
        {
            MainForm closeForm = new MainForm();
            closeForm.Close();
            GrammarExercises  gramatica = new GrammarExercises();
            gramatica.Show();
            Visible = false;
        }

        private void labelCLose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void labelCLose_MouseEnter(object sender, EventArgs e)
        {
            labelCLose.ForeColor = Color.White;
        }

        private void labelCLose_MouseLeave(object sender, EventArgs e)
        {
            labelCLose.ForeColor = Color.Black;
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

        private void buttonLeaderboard_Click(object sender, EventArgs e)
        {
            String totalscore = labelTotalScore.Text;
            String username = labelUsername.Text;
            DataBase db = new DataBase();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users`(`username`, `score`) VALUES (@usn, @scr)", db.getConnection());

            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username;
            command.Parameters.Add("@scr", MySqlDbType.VarChar).Value = totalscore;

            db.openConnection();

            //executa query-ul
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Punctajul acumulat de dumneavoastră este: " + labelTotalScore.Text , "Score Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("ERROR");
            }

            db.closeConnection();

            MainForm closeForm = new MainForm();
            closeForm.Close();
            Leaderboard leaderboard = new Leaderboard();
            leaderboard.Show();
            Visible = false;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            int rezultat = 0;
            labelUsername.Text = LoginForm.passingText;

            
                try
                {
                    rezultat = Convert.ToInt32(Adjectives.passingText) +
                        Convert.ToInt32(Articles.passingText) +
                        Convert.ToInt32(ConditionalSentences.passingText) +
                        Convert.ToInt32(GerundAndInfinitive.passingText) +
                        Convert.ToInt32(NounsApostrophe.passingText) +
                        Convert.ToInt32(NounsCapitalization.passingText) +
                        Convert.ToInt32(PhrasalVerbs.passingText) +
                        Convert.ToInt32(Pronouns.passingText) +
                        Convert.ToInt32(TensesPresentPerfect.passingText) +
                        Convert.ToInt32(VerbsIrregularForm.passingText) +
                        Convert.ToInt32(WordOrderInAffirmative.passingText) +
                        Convert.ToInt32(WordOrderInPassive.passingText);
                }
                catch
                {
                    MessageBox.Show("Încercați să rezolvați exerciții de gramatică");
                }
            

            labelTotalScore.Text = Convert.ToString(rezultat);
        }

        private void buttonOpenPDF_Click(object sender, EventArgs e)
        {
            MainForm closeForm = new MainForm();
            closeForm.Close();
            UserManual openForm = new UserManual();
            openForm.Show();
            Visible = false;
        }
    }
}
