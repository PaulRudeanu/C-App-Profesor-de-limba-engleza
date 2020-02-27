using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Xml;
using System.IO;

namespace MyThesis_Login_And_Registration
{
    public partial class PhrasalVerbs : Form
    {
        public PhrasalVerbs()
        {
            InitializeComponent();
        }

        int score = 0;
        public static string passingText;

        private void buttonExercitiulAnterior_Click(object sender, EventArgs e)
        {
            this.Close();
            TensesPresentPerfect tensesPresentPerfect = new TensesPresentPerfect();
            tensesPresentPerfect.Show();
        }

        private void buttonExercitiulUrmator_Click(object sender, EventArgs e)
        {
            this.Close();
            Pronouns prepositions = new Pronouns();
            prepositions.Show();
        }

        private void buttonGoBack3_Click(object sender, EventArgs e)
        {
            GrammarExercises openForm = new GrammarExercises();
            openForm.Show();
            Visible = false;
        }

        private void buttonVerify_Click(object sender, EventArgs e)
        {
            //1)
            if (comboBox1.Text.Equals("through"))
            {
                comboBox1.BackColor = Color.Green;
                if (comboBox1.BackColor == Color.Green)
                {
                    score = score + 1;
                }
            }
            else
            {
                comboBox1.BackColor = Color.Red;
                label11.Text = "Henry looked through the magazine quickly.";
                label11.ForeColor = Color.Green;
            }

            //2)
            if (comboBox2.Text.Equals("out"))
            {
                comboBox2.BackColor = Color.Green;
                if (comboBox2.BackColor == Color.Green)
                {
                    score = score + 1;
                }
            }
            else
            {
                comboBox2.BackColor = Color.Red;
                label12.Text = "Look out! There's a bus coming! It is going to hit you!";
                label12.ForeColor = Color.Green;
            }

            //3)
            if (comboBox3.Text.Equals("at"))
            {
                comboBox3.BackColor = Color.Green;
                if (comboBox3.BackColor == Color.Green)
                {
                    score = score + 1;
                }
            }
            else
            {
                comboBox3.BackColor = Color.Red;
                label13.Text = "Did the doctor look at your leg?";
                label13.ForeColor = Color.Green;
            }


            //4)
            if (comboBox4.Text.Equals("from"))
            {
                comboBox4.BackColor = Color.Green;
                if (comboBox4.BackColor == Color.Green)
                {
                    score = score + 1;
                }
            }
            else
            {
                comboBox4.BackColor = Color.Red;
                label14.Text = "He comes from Italy.";
                label14.ForeColor = Color.Green;
            }


            //5)
            if (comboBox5.Text.Equals("in"))
            {
                comboBox5.BackColor = Color.Green;
                if (comboBox5.BackColor == Color.Green)
                {
                    score = score + 1;
                }
            }
            else
            {
                comboBox5.BackColor = Color.Red;
                label15.Text = "The blue car came in last.";
                label15.ForeColor = Color.Green;
            }


            //6)
            if (comboBox6.Text.Equals("on"))
            {
                comboBox6.BackColor = Color.Green;
                if (comboBox6.BackColor == Color.Green)
                {
                    score = score + 1;
                }
            }
            else
            {
                comboBox6.BackColor = Color.Red;
                label16.Text = "Come on try once more.";
                label16.ForeColor = Color.Green;
            }


            //7)
            if (comboBox7.Text.Equals("back"))
            {
                comboBox7.BackColor = Color.Green;
                if (comboBox7.BackColor == Color.Green)
                {
                    score = score + 1;
                }
            }
            else
            {
                comboBox7.BackColor = Color.Red;
                label17.Text = "When we got back to the room, she had already left.";
                label17.ForeColor = Color.Green;
            }


            //8)
            if (comboBox8.Text.Equals("away"))
            {
                comboBox8.BackColor = Color.Green;
                if (comboBox8.BackColor == Color.Green)
                {
                    score = score + 1;
                }
            }
            else
            {
                comboBox8.BackColor = Color.Red;
                label18.Text = "The police let him get away with only a $10 ticket.";
                label18.ForeColor = Color.Green;
            }


            //9)
            if (comboBox9.Text.Equals("in"))
            {
                comboBox9.BackColor = Color.Green;
                if (comboBox9.BackColor == Color.Green)
                {
                    score = score + 1;
                }
            }
            else
            {
                comboBox9.BackColor = Color.Red;
                label19.Text = "Look! Our plane is getting in now.";
                label19.ForeColor = Color.Green;
            }


            //10)
            if (comboBox10.Text.Equals("up"))
            {
                comboBox10.BackColor = Color.Green;
                if (comboBox10.BackColor == Color.Green)
                {
                    score = score + 1;
                }
            }
            else
            {
                comboBox10.ForeColor = Color.Red;
                label20.Text = "Students have to get up when the teacher comes in.";
                label20.ForeColor = Color.Green;
            }

            buttonShowAnswer.Enabled = false;
            buttonShowAnswer2.Enabled = false;
            buttonVerify2.Hide();
            buttonVerify.Enabled = false;
            labelScore.Text += Convert.ToInt32(score);
            passingText = labelScore.Text;
        }

        private void buttonRepetaExercitiul_Click(object sender, EventArgs e)
        {
            PhrasalVerbs openForm = new PhrasalVerbs();
            openForm.Show();
            Visible = false;
        }

        private void buttonShowAnswer_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "through";
            comboBox2.Text = "out";
            comboBox3.Text = "at";
            comboBox4.Text = "from";
            comboBox5.Text = "in";
            comboBox6.Text = "on";
            comboBox7.Text = "back";
            comboBox8.Text = "away";
            comboBox9.Text = "in";
            comboBox10.Text = "up";
            buttonVerify.Enabled = false;
            buttonVerify2.Hide();
        }

        private void buttonVocabular_Click(object sender, EventArgs e)
        {
            VocabularyHelp openForm = new VocabularyHelp();
            openForm.Show();
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            this.Close();
            GrammarExercises openForm = new GrammarExercises();
            openForm.Show();
        }

        private void labelClose_MouseEnter(object sender, EventArgs e)
        {
            labelClose.ForeColor = Color.White;
        }

        private void labelClose_MouseLeave(object sender, EventArgs e)
        {
            labelClose.ForeColor = Color.Black;
        }


        //Speech synthesis

        SpeechSynthesizer reader = new SpeechSynthesizer();

        private void label1_MouseHover(object sender, EventArgs e)
        {
            if (label1.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(label1.Text);
            }
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            if (label2.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(label2.Text);
            }
        }

        private void label3_MouseHover(object sender, EventArgs e)
        {
            if (label3.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(label3.Text);
            }
        }

        private void label4_MouseHover(object sender, EventArgs e)
        {
            if (label4.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(label4.Text);
            }
        }

        private void label5_MouseHover(object sender, EventArgs e)
        {
            if (label5.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(label5.Text);
            }
        }

        private void label6_MouseHover(object sender, EventArgs e)
        {
            if (label6.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(label6.Text);
            }
        }

        private void label7_MouseHover(object sender, EventArgs e)
        {
            if (label7.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(label7.Text);
            }
        }

        private void label8_MouseHover(object sender, EventArgs e)
        {
            if (label8.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(label8.Text);
            }
        }

        private void label9_MouseHover(object sender, EventArgs e)
        {
            if (label9.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(label9.Text);
            }
        }

        private void label10_MouseHover(object sender, EventArgs e)
        {
            if (label10.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(label10.Text);
            }
        }

        private void label21_MouseHover(object sender, EventArgs e)
        {
            if (label21.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(label21.Text);
            }
        }

        private void label23_MouseHover(object sender, EventArgs e)
        {
            if (label23.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(label23.Text);
            }
        }

        private void label25_MouseHover(object sender, EventArgs e)
        {
            if (label25.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(label25.Text);
            }
        }

        private void label22_MouseHover(object sender, EventArgs e)
        {
            if (label22.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(label22.Text);
            }
        }

        private void label27_MouseHover(object sender, EventArgs e)
        {
            if (label27.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(label27.Text);
            }
        }

        private void label24_MouseHover(object sender, EventArgs e)
        {
            if (label24.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(label24.Text);
            }
        }

        private void label30_MouseHover(object sender, EventArgs e)
        {
            if (label30.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(label30.Text);
            }
        }

        private void label31_MouseHover(object sender, EventArgs e)
        {
            if (label31.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(label31.Text);
            }
        }

        private void label32_MouseHover(object sender, EventArgs e)
        {
            if (label32.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(label32.Text);
            }
        }

        private void label33_MouseHover(object sender, EventArgs e)
        {
            if (label33.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(label33.Text);
            }
        }

        private void labelCerinta_MouseHover(object sender, EventArgs e)
        {
            if (labelCerinta.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(labelCerinta.Text);
            }
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

        private void label11_MouseHover(object sender, EventArgs e)
        {
            if (label11.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(label11.Text);
            }
        }

        private void label12_MouseHover(object sender, EventArgs e)
        {
            if (label12.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(label12.Text);
            }
        }

        private void label13_MouseHover(object sender, EventArgs e)
        {
            if (label13.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(label13.Text);
            }
        }

        private void label14_MouseHover(object sender, EventArgs e)
        {
            if (label14.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(label14.Text);
            }
        }

        private void label15_MouseHover(object sender, EventArgs e)
        {
            if (label15.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(label15.Text);
            }
        }

        private void label16_MouseHover(object sender, EventArgs e)
        {
            if (label16.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(label16.Text);
            }
        }

        private void label17_MouseHover(object sender, EventArgs e)
        {
            if (label17.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(label17.Text);
            }
        }

        private void label18_MouseHover(object sender, EventArgs e)
        {
            if (label18.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(label18.Text);
            }
        }

        private void label19_MouseHover(object sender, EventArgs e)
        {
            if (label19.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(label19.Text);
            }
        }

        private void label20_MouseHover(object sender, EventArgs e)
        {
            if (label20.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(label20.Text);
            }
        }

        private void buttonNewExercise_Click(object sender, EventArgs e)
        {
            buttonVerify.Hide();
            buttonVerify2.Show();
            buttonShowAnswer.Hide();
            buttonShowAnswer2.Show();
            buttonNewExercise.Hide();
            buttonVerify2.Enabled = true;
            buttonShowAnswer2.Enabled = true;

            comboBox1.Items.Clear();
            comboBox1.Text = "";
            comboBox1.BackColor = Color.White;
            comboBox2.Items.Clear();
            comboBox2.Text = "";
            comboBox2.BackColor = Color.White;
            comboBox3.Items.Clear();
            comboBox3.Text = "";
            comboBox3.BackColor = Color.White;
            comboBox4.Items.Clear();
            comboBox4.Text = "";
            comboBox4.BackColor = Color.White;
            comboBox5.Items.Clear();
            comboBox5.Text = "";
            comboBox5.BackColor = Color.White;
            comboBox6.Items.Clear();
            comboBox6.Text = "";
            comboBox6.BackColor = Color.White;
            comboBox7.Items.Clear();
            comboBox7.Text = "";
            comboBox7.BackColor = Color.White;
            comboBox8.Items.Clear();
            comboBox8.Text = "";
            comboBox8.BackColor = Color.White;
            comboBox9.Items.Clear();
            comboBox9.Text = "";
            comboBox9.BackColor = Color.White;
            comboBox10.Items.Clear();
            comboBox10.Text = "";
            comboBox10.BackColor = Color.White;

            comboBox1.Items.Add("across");
            comboBox1.Items.Add("back");
            comboBox1.Items.Add("down");
            comboBox1.Items.Add("from");
            comboBox1.Items.Add("in");
            comboBox1.Items.Add("off");
            comboBox1.Items.Add("on");
            comboBox1.Items.Add("out");
            comboBox1.Items.Add("over");
            comboBox1.Items.Add("up");
            comboBox2.Items.Add("across");
            comboBox2.Items.Add("back");
            comboBox2.Items.Add("down");
            comboBox2.Items.Add("from");
            comboBox2.Items.Add("in");
            comboBox2.Items.Add("off");
            comboBox2.Items.Add("on");
            comboBox2.Items.Add("out");
            comboBox2.Items.Add("over");
            comboBox2.Items.Add("up");
            comboBox3.Items.Add("across");
            comboBox3.Items.Add("back");
            comboBox3.Items.Add("down");
            comboBox3.Items.Add("from");
            comboBox3.Items.Add("in");
            comboBox3.Items.Add("off");
            comboBox3.Items.Add("on");
            comboBox3.Items.Add("out");
            comboBox3.Items.Add("over");
            comboBox3.Items.Add("up");
            comboBox4.Items.Add("across");
            comboBox4.Items.Add("back");
            comboBox4.Items.Add("down");
            comboBox4.Items.Add("from");
            comboBox4.Items.Add("in");
            comboBox4.Items.Add("off");
            comboBox4.Items.Add("on");
            comboBox4.Items.Add("out");
            comboBox4.Items.Add("over");
            comboBox4.Items.Add("up");
            comboBox5.Items.Add("across");
            comboBox5.Items.Add("back");
            comboBox5.Items.Add("down");
            comboBox5.Items.Add("from");
            comboBox5.Items.Add("in");
            comboBox5.Items.Add("off");
            comboBox5.Items.Add("on");
            comboBox5.Items.Add("out");
            comboBox5.Items.Add("over");
            comboBox5.Items.Add("up");
            comboBox6.Items.Add("across");
            comboBox6.Items.Add("back");
            comboBox6.Items.Add("down");
            comboBox6.Items.Add("from");
            comboBox6.Items.Add("in");
            comboBox6.Items.Add("off");
            comboBox6.Items.Add("on");
            comboBox6.Items.Add("out");
            comboBox6.Items.Add("over");
            comboBox6.Items.Add("up");
            comboBox7.Items.Add("across");
            comboBox7.Items.Add("back");
            comboBox7.Items.Add("down");
            comboBox7.Items.Add("from");
            comboBox7.Items.Add("in");
            comboBox7.Items.Add("off");
            comboBox7.Items.Add("on");
            comboBox7.Items.Add("out");
            comboBox7.Items.Add("over");
            comboBox7.Items.Add("up");
            comboBox8.Items.Add("across");
            comboBox8.Items.Add("back");
            comboBox8.Items.Add("down");
            comboBox8.Items.Add("from");
            comboBox8.Items.Add("in");
            comboBox8.Items.Add("off");
            comboBox8.Items.Add("on");
            comboBox8.Items.Add("out");
            comboBox8.Items.Add("over");
            comboBox8.Items.Add("up");
            comboBox9.Items.Add("across");
            comboBox9.Items.Add("back");
            comboBox9.Items.Add("down");
            comboBox9.Items.Add("from");
            comboBox9.Items.Add("in");
            comboBox9.Items.Add("off");
            comboBox9.Items.Add("on");
            comboBox9.Items.Add("out");
            comboBox9.Items.Add("over");
            comboBox9.Items.Add("up");
            comboBox10.Items.Add("across");
            comboBox10.Items.Add("back");
            comboBox10.Items.Add("down");
            comboBox10.Items.Add("from");
            comboBox10.Items.Add("in");
            comboBox10.Items.Add("off");
            comboBox10.Items.Add("on");
            comboBox10.Items.Add("out");
            comboBox10.Items.Add("over");
            comboBox10.Items.Add("up");

            comboBox1.Location = new Point(795, 154);
            comboBox2.Location = new Point(848, 216);
            comboBox3.Location = new Point(759, 278);
            comboBox5.Location = new Point(795, 401);
            comboBox6.Location = new Point(946, 462);
            comboBox7.Location = new Point(870, 522);
            comboBox8.Location = new Point(820, 577);
            comboBox9.Location = new Point(795, 633);
            comboBox10.Location = new Point(870, 693);

            label21.Location = new Point(922, 154);
            label23.Location = new Point(980, 216);
            label25.Location = new Point(882, 278);
            label22.Location = new Point(925, 345);
            label27.Location = new Point(921, 401);
            label24.Location = new Point(1078, 462);
            label30.Location = new Point(998, 522);
            label31.Location = new Point(940, 577);
            label32.Location = new Point(925, 633);
            label33.Location = new Point(1000, 693);

            label11.Text = "";
            label12.Text = "";
            label13.Text = "";
            label14.Text = "";
            label15.Text = "";
            label16.Text = "";
            label17.Text = "";
            label18.Text = "";
            label19.Text = "";
            label20.Text = "";

            string fileName = "XMLExpresiiVerbale.xml";
            string path = Path.Combine(Environment.CurrentDirectory, @"", fileName);

            XmlTextReader xtr = new XmlTextReader(path);
            try
            {
                while (xtr.Read())
                {
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "one")
                    {
                        string s1 = xtr.ReadElementString();
                        label1.Text = ("" + s1);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "two")
                    {
                        string s2 = xtr.ReadElementString();
                        label2.Text = ("" + s2);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "three")
                    {
                        string s3 = xtr.ReadElementString();
                        label3.Text = ("" + s3);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "four")
                    {
                        string s4 = xtr.ReadElementString();
                        label4.Text = ("" + s4);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "five")
                    {
                        string s5 = xtr.ReadElementString();
                        label5.Text = ("" + s5);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "six")
                    {
                        string s6 = xtr.ReadElementString();
                        label6.Text = ("" + s6);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "seven")
                    {
                        string s7 = xtr.ReadElementString();
                        label7.Text = ("" + s7);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "eight")
                    {
                        string s8 = xtr.ReadElementString();
                        label8.Text = ("" + s8);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "nine")
                    {
                        string s9 = xtr.ReadElementString();
                        label9.Text = ("" + s9);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "ten")
                    {
                        string s10 = xtr.ReadElementString();
                        label10.Text = ("" + s10);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "twentyone")
                    {
                        string s21 = xtr.ReadElementString();
                        label21.Text = ("" + s21);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "twentytwo")
                    {
                        string s22 = xtr.ReadElementString();
                        label23.Text = ("" + s22);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "twentythree")
                    {
                        string s23 = xtr.ReadElementString();
                        label25.Text = ("" + s23);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "twentyfour")
                    {
                        string s24 = xtr.ReadElementString();
                        label22.Text = ("" + s24);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "twentyfive")
                    {
                        string s25 = xtr.ReadElementString();
                        label27.Text = ("" + s25);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "twentysix")
                    {
                        string s26 = xtr.ReadElementString();
                        label30.Text = ("" + s26);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "twentyseven")
                    {
                        string s27 = xtr.ReadElementString();
                        label31.Text = ("" + s27);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "twentyeight")
                    {
                        string s28 = xtr.ReadElementString();
                        label32.Text = ("" + s28);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "twentynine")
                    {
                        string s29 = xtr.ReadElementString();
                        label33.Text = ("" + s29);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonVerify2_Click(object sender, EventArgs e)
        {
            int newscore = 0;

            if (comboBox1.Text.Equals("from"))
            {
                comboBox1.BackColor = Color.Green;
                if (comboBox1.BackColor == Color.Green)
                {
                    newscore = newscore + 1;
                }
            }
            else
            {
                comboBox1.BackColor = Color.Red;
                label11.Text = "from";
                label11.ForeColor = Color.Green;
            }


            if (comboBox2.Text.Equals("in"))
            {
                comboBox2.BackColor = Color.Green;
                if (comboBox2.BackColor == Color.Green)
                {
                    newscore = newscore + 1;
                }
            }
            else
            {
                comboBox2.BackColor = Color.Red;
                label12.Text = "in";
                label12.ForeColor = Color.Green;
            }


            if (comboBox3.Text.Equals("on"))
            {
                comboBox3.BackColor = Color.Green;
                if (comboBox3.BackColor == Color.Green)
                {
                    newscore = newscore + 1;
                }
            }
            else
            {
                comboBox3.BackColor = Color.Red;
                label13.Text = "on";
                label13.ForeColor = Color.Green;
            }


            if (comboBox4.Text.Equals("back"))
            {
                comboBox4.BackColor = Color.Green;
                if (comboBox4.BackColor == Color.Green)
                {
                    newscore = newscore + 1;
                }
            }
            else
            {
                comboBox4.BackColor = Color.Red;
                label14.Text = "back";
                label14.ForeColor = Color.Green;
            }


            if (comboBox5.Text.Equals("across"))
            {
                comboBox5.BackColor = Color.Green;
                if (comboBox5.BackColor == Color.Green)
                {
                    newscore = newscore + 1;
                }
            }
            else
            {
                comboBox5.BackColor = Color.Red;
                label15.Text = "across";
                label15.ForeColor = Color.Green;
            }


            if (comboBox6.Text.Equals("down"))
            {
                comboBox6.BackColor = Color.Green;
                if (comboBox6.BackColor == Color.Green)
                {
                    newscore = newscore + 1;
                }
            }
            else
            {
                comboBox6.BackColor = Color.Red;
                label16.Text = "down";
                label16.ForeColor = Color.Green;
            }


            if (comboBox7.Text.Equals("off"))
            {
                comboBox7.BackColor = Color.Green;
                if (comboBox7.BackColor == Color.Green)
                {
                    newscore = newscore + 1;
                }
            }
            else
            {
                comboBox7.BackColor = Color.Red;
                label17.Text = "off";
                label17.ForeColor = Color.Green;
            }


            if (comboBox8.Text.Equals("out"))
            {
                comboBox8.BackColor = Color.Green;
                if (comboBox8.BackColor == Color.Green)
                {
                    newscore = newscore + 1;
                }
            }
            else
            {
                comboBox8.BackColor = Color.Red;
                label18.Text = "out";
                label18.ForeColor = Color.Green;
            }


            if (comboBox9.Text.Equals("over"))
            {
                comboBox9.BackColor = Color.Green;
                if (comboBox9.BackColor == Color.Green)
                {
                    newscore = newscore + 1;
                }
            }
            else
            {
                comboBox9.BackColor = Color.Red;
                label19.Text = "over";
                label19.ForeColor = Color.Green;
            }


            if (comboBox10.Text.Equals("up"))
            {
                comboBox10.BackColor = Color.Green;
                if (comboBox10.BackColor == Color.Green)
                {
                    newscore = newscore + 1;
                }
            }
            else
            {
                comboBox10.BackColor = Color.Red;
                label20.Text = "up";
                label20.ForeColor = Color.Green;
            }

            buttonVerify2.Enabled = false;
            buttonShowAnswer2.Enabled = false;
            labelScore.Text = "";
            labelScore.Text += Convert.ToInt32(score) + Convert.ToInt32(newscore);
            passingText = labelScore.Text;
        }

        private void buttonShowAnswer2_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "from";
            comboBox2.Text = "in";
            comboBox3.Text = "on";
            comboBox4.Text = "back";
            comboBox5.Text = "across";
            comboBox6.Text = "down";
            comboBox7.Text = "off";
            comboBox8.Text = "out";
            comboBox9.Text = "over";
            comboBox10.Text = "up";
            buttonVerify2.Enabled = false;
        }
    }
}
