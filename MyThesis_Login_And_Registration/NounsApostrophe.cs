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
    public partial class NounsApostrophe : Form
    {
        public NounsApostrophe()
        {
            InitializeComponent();
        }

        int score = 0;
        public static string passingText;

        private void buttonVerify_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text.Equals("Julian's"))
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
                label11.Text = "This is Julian's book.";
                label11.ForeColor = Color.Green;
            }


            if (comboBox2.Text.Equals("Laura's"))
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
                label12.Text = "He is Laura's brother.";
                label12.ForeColor = Color.Green;
            }


            if (comboBox3.Text.Equals("children's"))
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
                label13.Text = "The children's room is nice.";
                label13.ForeColor = Color.Green;
            }


            if (comboBox4.Text.Equals("Nick's"))
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
                label14.Text = "Where is Nick's football?";
                label14.ForeColor = Color.Green;
            }


            if (comboBox5.Text.Equals("parents'"))
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
                label15.Text = "Our parents' van is big.";
                label15.ForeColor = Color.Green;
            }


            if (comboBox6.Text.Equals("aunt's"))
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
                label16.Text = "My aunt's family lives in Scotland.";
                label16.ForeColor = Color.Green;
            }


            if (comboBox7.Text.Equals("Bakers'"))
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
                label17.Text = "The Bakers' house is green.";
                label17.ForeColor = Color.Green;
            }


            if (comboBox8.Text.Equals("grandma's"))
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
                label18.Text = "My grandma's watch is always slow.";
                label18.ForeColor = Color.Green;
            }


            if (comboBox9.Text.Equals("mum's"))
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
                label19.Text = "These are my mum's keys.";
                label19.ForeColor = Color.Green;
            }


            if (comboBox10.Text.Equals("secretaries'"))
            {
                comboBox10.BackColor = Color.Green;
                if (comboBox10.BackColor == Color.Green)
                {
                    score = score + 1;
                }
            }
            else
            {
                comboBox10.BackColor = Color.Red;
                label20.Text = "The secretaries' laptops are brand new.";
                label20.ForeColor = Color.Green;
            }

            buttonShowAnswer.Enabled = false;
            buttonShowAnswer2.Enabled = false;
            buttonVerify2.Hide();
            buttonVerify.Enabled = false;
            labelScore.Text += Convert.ToInt32(score);
            passingText = labelScore.Text;

        }

        private void buttonGoBack3_Click(object sender, EventArgs e)
        {
            GrammarExercises openForm = new GrammarExercises();
            openForm.Show();
            Visible = false;
        }

        private void buttonShowAnswer_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "Julian's";
            comboBox2.Text = "Laura's";
            comboBox3.Text = "children's";
            comboBox4.Text = "Nick's";
            comboBox5.Text = "parents'";
            comboBox6.Text = "aunt's";
            comboBox7.Text = "Bakers'";
            comboBox8.Text = "grandma's";
            comboBox9.Text = "mum's";
            comboBox10.Text = "secretaries'";
            buttonVerify.Enabled = false;
            buttonVerify2.Hide();
        }

        private void buttonRepetaExercitiul_Click(object sender, EventArgs e)
        {
            NounsApostrophe openForm = new NounsApostrophe();
            openForm.Show();
            Visible = false;
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            this.Close();
            GrammarExercises openForm = new GrammarExercises();
            openForm.Show();
        }

        private void buttonVocabular_Click(object sender, EventArgs e)
        {
            VocabularyHelp openForm = new VocabularyHelp();
            openForm.Show();
        }

        private void buttonExercitiulAnterior_Click(object sender, EventArgs e)
        {
            this.Close();
            GerundAndInfinitive gerundAndInfinitive = new GerundAndInfinitive();
            gerundAndInfinitive.Show();

        }

        private void buttonExercitiulUrmator_Click(object sender, EventArgs e)
        {
            this.Close();
            NounsCapitalization nounsCapitalization = new NounsCapitalization();
            nounsCapitalization.Show();
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

            comboBox1.Items.Add("1 teacher and 1 tablet");
            comboBox1.Items.Add("1 teacher and more tablets");
            comboBox1.Items.Add("more teachers and 1 tablet");
            comboBox1.Items.Add("more teachers and more tablets");
            comboBox2.Items.Add("1 dog and 1 hut");
            comboBox2.Items.Add("1 dog and more huts");
            comboBox2.Items.Add("more dogs and 1 hut");
            comboBox2.Items.Add("more dogs and more huts");
            comboBox3.Items.Add("1 man and 1 sandwich");
            comboBox3.Items.Add("1 man and more sandwiches");
            comboBox3.Items.Add("more men and 1 sandwich");
            comboBox3.Items.Add("more men and more sandwiches");
            comboBox4.Items.Add("1 woman and 1 budgie");
            comboBox4.Items.Add("1 woman and more budgies");
            comboBox4.Items.Add("more women and 1 budgie");
            comboBox4.Items.Add("more women and more budgies");
            comboBox5.Items.Add("1 baby and 1 toy");
            comboBox5.Items.Add("1 baby and more toys");
            comboBox5.Items.Add("more babies and 1 toy");
            comboBox5.Items.Add("more babies and more toys");
            comboBox6.Items.Add("1 mouse and 1 cage");
            comboBox6.Items.Add("1 mouse and more cages");
            comboBox6.Items.Add("more mice and 1 cage");
            comboBox6.Items.Add("more mice and more cages");
            comboBox7.Items.Add("1 friend and 1 car");
            comboBox7.Items.Add("1 friend and more cars");
            comboBox7.Items.Add("more friend and 1 car");
            comboBox7.Items.Add("more friends and more cars");
            comboBox8.Items.Add("1 friend and 1 car");
            comboBox8.Items.Add("1 friend and more cars");
            comboBox8.Items.Add("more friends and 1 car");
            comboBox8.Items.Add("more friends and more cars");
            comboBox9.Items.Add("1 friend and 1 car");
            comboBox9.Items.Add("1 friend and more cars");
            comboBox9.Items.Add("more friends and 1 car");
            comboBox9.Items.Add("more friends and more cars");
            comboBox10.Items.Add("1 friend and 1 car");
            comboBox10.Items.Add("1 friend and more cars");
            comboBox10.Items.Add("more friends and 1 car");
            comboBox10.Items.Add("more friends and more cars");

            label21.Hide();
            label22.Hide();
            label23.Hide();
            label24.Hide();
            label25.Hide();
            label27.Hide();
            label30.Hide();
            label31.Hide();
            label32.Hide();
            label33.Hide();

            comboBox1.Size = new Size(254, 27);
            comboBox2.Size = new Size(254, 27);
            comboBox3.Size = new Size(254, 27);
            comboBox4.Size = new Size(254, 27);
            comboBox5.Size = new Size(254, 27);
            comboBox6.Size = new Size(254, 27);
            comboBox7.Size = new Size(254, 27);
            comboBox8.Size = new Size(254, 27);
            comboBox9.Size = new Size(254, 27);
            comboBox10.Size = new Size(254, 27);

            comboBox1.Location = new Point(972, 165);
            comboBox2.Location = new Point(972, 228);
            comboBox3.Location = new Point(972, 290);
            comboBox4.Location = new Point(972, 353);
            comboBox5.Location = new Point(972, 417);
            comboBox6.Location = new Point(972, 481);
            comboBox7.Location = new Point(972, 545);
            comboBox8.Location = new Point(972, 615);
            comboBox9.Location = new Point(972, 686);
            comboBox10.Location = new Point(972, 751);

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

            string fileName = "XMLSubstantiveApostrof.xml";
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

            if (comboBox1.Text.Equals("1 teacher and 1 tablet"))
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
                label11.Text = "1 teacher and 1 tablet";
                label11.ForeColor = Color.Green;
            }


            if (comboBox2.Text.Equals("more dogs and 1 hut"))
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
                label12.Text = "more dogs and 1 hut";
                label12.ForeColor = Color.Green;
            }


            if (comboBox3.Text.Equals("more men and more sandwiches"))
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
                label13.Text = "more men and more sandwiches";
                label13.ForeColor = Color.Green;
            }


            if (comboBox4.Text.Equals("1 woman and more budgies"))
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
                label14.Text = "1 woman and more budgies";
                label14.ForeColor = Color.Green;
            }


            if (comboBox5.Text.Equals("1 baby and more toys"))
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
                label15.Text = "1 baby and more toys";
                label15.ForeColor = Color.Green;
            }


            if (comboBox6.Text.Equals("more mice and 1 cage"))
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
                label16.Text = "more mice and 1 cage";
                label16.ForeColor = Color.Green;
            }


            if (comboBox7.Text.Equals("1 friend and 1 car"))
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
                label17.Text = "1 friend and 1 car";
                label17.ForeColor = Color.Green;
            }


            if (comboBox8.Text.Equals("1 friend and more cars"))
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
                label18.Text = "1 friend and more cars";
                label18.ForeColor = Color.Green;
            }


            if (comboBox9.Text.Equals("more friends and 1 car"))
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
                label19.Text = "more friends and 1 car";
                label19.ForeColor = Color.Green;
            }


            if (comboBox10.Text.Equals("more friends and more cars"))
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
                label20.Text = "more friends and more cars";
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
            comboBox1.Text = "1 teacher and 1 tablet";
            comboBox2.Text = "more dogs and 1 hut";
            comboBox3.Text = "more men and more sandwiches";
            comboBox4.Text = "1 woman and more budgies";
            comboBox5.Text = "1 baby and more toys";
            comboBox6.Text = "more mice and 1 cage";
            comboBox7.Text = "1 friend and 1 car";
            comboBox8.Text = "1 friend and more cars";
            comboBox9.Text = "more friends and 1 car";
            comboBox10.Text = "more friends and more cars";
            buttonVerify2.Enabled = false;
        }
    }
}
