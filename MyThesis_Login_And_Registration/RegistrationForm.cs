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
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            //indepartarea focus-ului de pe textboxuri
            this.ActiveControl = label1;
        }

        private void textBoxFirstname_Enter(object sender, EventArgs e)
        {
            String fname = textBoxFirstname.Text;
            if(fname.Trim().Equals("Nume"))
            {
                textBoxFirstname.Text = "";
                textBoxFirstname.ForeColor = Color.Black;
            }
        }

        private void textBoxFirstname_Leave(object sender, EventArgs e)
        {
            String fname = textBoxFirstname.Text;
            if(fname.Trim().Equals("Nume") || fname.Trim().Equals(""))
            {
                textBoxFirstname.Text = "Nume";
                textBoxFirstname.ForeColor = Color.Gray;
            }
        }

        private void textBoxLastname_Enter(object sender, EventArgs e)
        {
            String lname = textBoxLastname.Text;
            if (lname.Trim().Equals("Prenume"))
            {
                textBoxLastname.Text = "";
                textBoxLastname.ForeColor = Color.Black;
            }
        }

        private void textBoxLastname_Leave(object sender, EventArgs e)
        {
            String lname = textBoxLastname.Text;
            if (lname.Trim().Equals("Prenume") || lname.Trim().Equals(""))
            {
                textBoxLastname.Text = "Prenume";
                textBoxLastname.ForeColor = Color.Gray;
            }
        }

        private void textBoxEmail_Enter(object sender, EventArgs e)
        {
            String email = textBoxEmail.Text;
            if (email.Trim().Equals("Adresă de email"))
            {
                textBoxEmail.Text = "";
                textBoxEmail.ForeColor = Color.Black;
            }
        }

        private void textBoxEmail_Leave(object sender, EventArgs e)
        {
            String email = textBoxEmail.Text;
            if (email.Trim().Equals("Adresă de email") || email.Trim().Equals(""))
            {
                textBoxEmail.Text = "Adresă de email";
                textBoxEmail.ForeColor = Color.Gray;
            }
        }

        private void textBoxUsername_Enter(object sender, EventArgs e)
        {
            String username = textBoxUsername.Text;
            if (username.Trim().Equals("Nume de utilizator"))
            {
                textBoxUsername.Text = "";
                textBoxUsername.ForeColor = Color.Black;
            }
        }

        private void textBoxUsername_Leave(object sender, EventArgs e)
        {
            String username = textBoxUsername.Text;
            if (username.Trim().Equals("Nume de utilizator") || username.Trim().Equals(""))
            {
                textBoxUsername.Text = "Nume de utilizator";
                textBoxUsername.ForeColor = Color.Gray;
            }
        }

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            String parola = textBoxPassword.Text;
            if (parola.Trim().Equals("Parolă"))
            {
                textBoxPassword.Text = "";
                textBoxPassword.UseSystemPasswordChar = true;
                textBoxPassword.ForeColor = Color.Black;
            }
        }

        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            String parola = textBoxPassword.Text;
            if (parola.Trim().Equals("Parolă") || parola.Trim().Equals(""))
            {
                textBoxPassword.Text = "Parolă";
                textBoxPassword.UseSystemPasswordChar = false;
                textBoxPassword.ForeColor = Color.Gray;
            }
        }

        private void textBoxConfirmPassword_Enter(object sender, EventArgs e)
        {
            String cparola = textBoxConfirmPassword.Text;
            if (cparola.Trim().Equals("Confirmă parola"))
            {
                textBoxConfirmPassword.Text = "";
                textBoxConfirmPassword.UseSystemPasswordChar = true;
                textBoxConfirmPassword.ForeColor = Color.Black;
            }
        }

        private void textBoxConfirmPassword_Leave(object sender, EventArgs e)
        {
            String cparola = textBoxConfirmPassword.Text;
            if (cparola.Trim().Equals("Confirmă parola") ||
                cparola.Trim().Equals("Parolă") ||
                cparola.Trim().Equals(""))
            {
                textBoxConfirmPassword.Text = "Confirmă parola";
                textBoxConfirmPassword.UseSystemPasswordChar = false;
                textBoxConfirmPassword.ForeColor = Color.Gray;
            }
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }
        
        private void labelClose_MouseEnter(object sender, EventArgs e)
        {
            labelClose.ForeColor = Color.White;
        }

        private void labelClose_MouseLeave(object sender, EventArgs e)
        {
            labelClose.ForeColor = Color.Black;
        }

        private void buttonCreateAccount_Click(object sender, EventArgs e)
        {
            //adauga un user nou

            DataBase db = new DataBase();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users`(`nume`, `prenume`, `adresa de email`, `username`, `password`) VALUES (@fn, @ln, @email, @usn, @pass)", db.getConnection());

            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = textBoxFirstname.Text;
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = textBoxLastname.Text;
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = textBoxEmail.Text;
            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = textBoxUsername.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = textBoxPassword.Text;

            //dechide conexiunea
            db.openConnection();

            //verifica daca textboxurile contin valorile default
            if(!checkTextBoxesValues())
            {
                //verifica daca parola e egala cu confirma parola
                if(textBoxPassword.Text.Equals(textBoxConfirmPassword.Text))
                {
                    //verifica daca acest username exista deja
                    if (checkUsername())
                    {
                        MessageBox.Show("Acest username există deja, selectați unul diferit","Duplicate Username",MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                    else
                    {
                        //executa query-ul
                        if (command.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Contul dumneavoastră a fost creat","Account Created",MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("ERROR");
                        }
                        LoginForm openForm = new LoginForm();
                        this.Close();
                        openForm.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Confirmați parola corectă","Password Error",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
                }
            }
                
            else
            {
                MessageBox.Show("Introduceți informațiile dumneavoastră mai întâi","Empty Data",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
            }
            

            //inchide conexiunea
            db.closeConnection();

        }

        //verifica daca usernameul exista deja
        public Boolean checkUsername()
        {
            DataBase db = new DataBase();
            String username = textBoxUsername.Text;

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `username` = @usn", db.getConnection());

            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username;

            adapter.SelectCommand = command;

            adapter.Fill(table);


            //verificare daca usernameul exista deja in baza de date
            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //verifica daca textboxurile contin valorile default
        public Boolean checkTextBoxesValues()
        {
            String fname = textBoxFirstname.Text;
            String lname = textBoxLastname.Text;
            String email = textBoxEmail.Text;
            String uname = textBoxUsername.Text;
            String pass = textBoxPassword.Text;

            if (fname.Equals("Nume") || lname.Equals("Prenume") ||
                email.Equals("Adresă de email") || uname.Equals("Nume de utilizator") || pass.Equals("Parolă"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void labelGoToLogin_MouseEnter(object sender, EventArgs e)
        {
            labelGoToLogin.ForeColor = Color.Yellow;
        }

        private void labelGoToLogin_MouseLeave(object sender, EventArgs e)
        {
            labelGoToLogin.ForeColor = Color.White;
        }

        private void labelGoToLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginform = new LoginForm();
            loginform.Show();
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

        private void textBoxConfirmPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonCreateAccount.PerformClick();
            }
        }
    }
}
