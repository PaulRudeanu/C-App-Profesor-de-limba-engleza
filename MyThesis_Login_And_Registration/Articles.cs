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
    public partial class Articles : Form
    {
        public Articles()
        {
            InitializeComponent();
        }

        double score = 0;
        public static string passingText;

        private void buttonVerify_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text.Equals("St. Paul's Cathedral"))
            {
                comboBox1.BackColor = Color.Green;
                if (comboBox1.BackColor == Color.Green)
                {
                    score = score + 0.5;
                }
            }
            else
            {
                comboBox1.BackColor = Color.Red;
                label11.Text = "Last year we visited St. Paul's Cathedral and the Tower.";
                label11.ForeColor = Color.Green;
            }


            if (comboBox2.Text.Equals("the Tower"))
            {
                comboBox2.BackColor = Color.Green;
                if (comboBox2.BackColor == Color.Green)
                {
                    score = score + 0.5;
                }
            }
            else
            {
                comboBox2.BackColor = Color.Red;
                label11.Text = "Last year we visited St. Paul's Cathedral and the Tower.";
                label11.ForeColor = Color.Green;
            }


            if (comboBox3.Text.Equals("Mount Everest"))
            {
                comboBox3.BackColor = Color.Green;
                if (comboBox3.BackColor == Color.Green)
                {
                    score = score + 0.5;
                }
            }
            else
            {
                comboBox3.BackColor = Color.Red;
                label12.Text = "Mount Everest is the highest mountain on Earth.";
                label12.ForeColor = Color.Green;
            }


            if (comboBox4.Text.Equals("the highest mountain"))
            {
                comboBox4.BackColor = Color.Green;
                if (comboBox4.BackColor == Color.Green)
                {
                    score = score + 0.5;
                }
            }
            else
            {
                comboBox4.BackColor = Color.Red;
                label12.Text = "Mount Everest is the highest mountain on Earth.";
                label12.ForeColor = Color.Green;
            }


            if (comboBox5.Text.Equals("Loch Ness"))
            {
                comboBox5.BackColor = Color.Green;
                if (comboBox5.BackColor == Color.Green)
                {
                    score = score + 0.5;
                }
            }
            else
            {
                comboBox5.BackColor = Color.Red;
                label13.Text = "Loch Ness is the most famous lake in Scotland.";
                label13.ForeColor = Color.Green;
            }


            if (comboBox6.Text.Equals("the most famous lake"))
            {
                comboBox6.BackColor = Color.Green;
                if (comboBox6.BackColor == Color.Green)
                {
                    score = score + 0.5;
                }
            }
            else
            {
                comboBox6.BackColor = Color.Red;
                label13.Text = "Loch Ness is the most famous lake in Scotland.";
                label13.ForeColor = Color.Green;
            }


            if (comboBox7.Text.Equals("Most children"))
            {
                comboBox7.BackColor = Color.Green;
                if (comboBox7.BackColor == Color.Green)
                {
                    score = score + 0.5;
                }
            }
            else
            {
                comboBox7.BackColor = Color.Red;
                label14.Text = "Most children like sweets.";
                label14.ForeColor = Color.Green;
            }


            if (comboBox8.Text.Equals("sweets"))
            {
                comboBox8.BackColor = Color.Green;
                if (comboBox8.BackColor == Color.Green)
                {
                    score = score + 0.5;
                }
            }
            else
            {
                comboBox8.BackColor = Color.Red;
                label14.Text = "Most children like sweets.";
                label14.ForeColor = Color.Green;
            }


            if (comboBox9.Text.Equals("The summer of 2003"))
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
                label15.Text = "The summer of 2003 was hot and dry.";
                label15.ForeColor = Color.Green;
            }


            if (comboBox10.Text.Equals("The Plaza Hotel"))
            {
                comboBox10.BackColor = Color.Green;
                if (comboBox10.BackColor == Color.Green)
                {
                    score = score + 0.3;
                }
            }
            else
            {
                comboBox10.BackColor = Color.Red;
                label16.Text = "The Plaza Hotel is on the corner of 59th Street and 5th Avenue.";
                label16.ForeColor = Color.Green;
            }


            if (comboBox11.Text.Equals("59th Street"))
            {
                comboBox11.BackColor = Color.Green;
                if (comboBox11.BackColor == Color.Green)
                {
                    score = score + 0.3;
                }
            }
            else
            {
                comboBox11.BackColor = Color.Red;
                label16.Text = "The Plaza Hotel is on the corner of 59th Street and 5th Avenue.";
                label16.ForeColor = Color.Green;
            }


            if (comboBox12.Text.Equals("5th Avenue"))
            {
                comboBox12.BackColor = Color.Green;
                if (comboBox12.BackColor == Color.Green)
                {
                    score = score + 0.3;
                }
            }
            else
            {
                comboBox12.BackColor = Color.Red;
                label16.Text = "The Plaza Hotel is on the corner of 59th Street and 5th Avenue.";
                label16.ForeColor = Color.Green;
            }


            if (comboBox13.Text.Equals("Uncle Tim's"))
            {
                comboBox13.BackColor = Color.Green;
                if (comboBox13.BackColor == Color.Green)
                {
                    score = score + 1;
                }
            }
            else
            {
                comboBox13.BackColor = Color.Red;
                label17.Text = "My sister often stays at Uncle Tim's in Detroit.";
                label17.ForeColor = Color.Green;
            }


            if (comboBox14.Text.Equals("the Millers"))
            {
                comboBox14.BackColor = Color.Green;
                if (comboBox14.BackColor == Color.Green)
                {
                    score = score + 1;
                }

            }
            else
            {
                comboBox14.BackColor = Color.Red;
                label18.Text = "Our friends the Millers moved to Florida last August.";
                label18.ForeColor = Color.Green;
            }


            if (comboBox15.Text.Equals("Smog"))
            {
                comboBox15.BackColor = Color.Green;
                if (comboBox15.BackColor == Color.Green)
                {
                    score = score + 0.5;
                }
            }
            else
            {
                comboBox15.BackColor = Color.Red;
                label19.Text = "Smog is a problem in big cities.";
                label19.ForeColor = Color.Green;
            }


            if (comboBox16.Text.Equals("big cities"))
            {
                comboBox16.BackColor = Color.Green;
                if (comboBox16.BackColor == Color.Green)
                {
                    score = score + 0.5;
                }
            }
            else
            {
                comboBox16.BackColor = Color.Red;
                label19.Text = "Smog is a problem in big cities.";
                label19.ForeColor = Color.Green;
            }


            if (comboBox17.Text.Equals("school"))
            {
                comboBox17.BackColor = Color.Green;
                if (comboBox17.BackColor == Color.Green)
                {
                    score = score + 0.5;
                }
            }
            else
            {
                comboBox17.BackColor = Color.Red;
                label20.Text = "Our children go to school by bus.";
                label20.ForeColor = Color.Green;
            }


            if (comboBox18.Text.Equals("bus"))
            {
                comboBox18.BackColor = Color.Green;
                if (comboBox18.BackColor == Color.Green)
                {
                    score = score + 0.5;
                }
            }
            else
            {
                comboBox18.BackColor = Color.Red;
                label20.Text = "Our children go to school by bus.";
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
            comboBox1.Text = "St. Paul's Cathedral";
            comboBox2.Text = "the Tower";
            comboBox3.Text = "Mount Everest";
            comboBox4.Text = "the highest mountain";
            comboBox5.Text = "Loch Ness";
            comboBox6.Text = "the most famous lake";
            comboBox7.Text = "Most children";
            comboBox8.Text = "sweets";
            comboBox9.Text = "The summer of 2003";
            comboBox10.Text = "The Plaza Hotel";
            comboBox11.Text = "59th Street";
            comboBox12.Text = "5th Avenue";
            comboBox13.Text = "Uncle Tim's";
            comboBox14.Text = "the Millers";
            comboBox15.Text = "Smog";
            comboBox16.Text = "big cities";
            comboBox17.Text = "school";
            comboBox18.Text = "bus";
            buttonVerify.Enabled = false;
            buttonVerify2.Hide();
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            this.Close();
            GrammarExercises openForm = new GrammarExercises();
            openForm.Show();
        }

        private void buttonRepetaExercitiul_Click(object sender, EventArgs e)
        {
            Articles openForm = new Articles();
            openForm.Show();
            Visible = false;
        }

        private void buttonVocabular_Click(object sender, EventArgs e)
        {
            VocabularyHelp openForm = new VocabularyHelp();
            openForm.Show();
        }

        private void buttonExercitiulAnterior_Click(object sender, EventArgs e)
        {
            this.Close();
            Adjectives adjectiveAdverbe = new Adjectives();
            adjectiveAdverbe.Show();
        }

        private void buttonExercitiulUrmator_Click(object sender, EventArgs e)
        {
            this.Close();
            ConditionalSentences conditionalSentencesIf = new ConditionalSentences();
            conditionalSentencesIf.Show();
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


        private void labelCerinta_MouseHover(object sender, EventArgs e)
        {
            if (labelCerinta.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(labelCerinta.Text);
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

        private void label3_MouseHover(object sender, EventArgs e)
        {
            if (label3.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(label3.Text);
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

        private void label7_MouseHover_1(object sender, EventArgs e)
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

        private void label9_MouseHover_1(object sender, EventArgs e)
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

        private void label22_MouseHover(object sender, EventArgs e)
        {
            if (label22.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(label22.Text);
            }
        }

        private void label24_MouseHover(object sender, EventArgs e)
        {
            if (label24.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(label22.Text);
            }
        }

        private void label26_MouseHover_1(object sender, EventArgs e)
        {
            if (label26.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(label26.Text);
            }
        }

        private void label27_MouseHover_1(object sender, EventArgs e)
        {
            if (label27.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(label27.Text);
            }
        }

        private void label28_MouseHover(object sender, EventArgs e)
        {
            if (label28.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(label28.Text);
            }
        }

        private void label29_MouseHover(object sender, EventArgs e)
        {
            if (label29.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(label29.Text);
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

        private void label23_MouseHover_1(object sender, EventArgs e)
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

        private void Articles_Load(object sender, EventArgs e)
        {
            labelUsername.Text = LoginForm.passingText;
        }

        private void buttonNewExercise_Click(object sender, EventArgs e)
        {
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
            comboBox11.Items.Clear();
            comboBox11.Text = "";
            comboBox11.BackColor = Color.White;
            comboBox12.Items.Clear();
            comboBox12.Text = "";
            comboBox12.BackColor = Color.White;
            comboBox13.Items.Clear();
            comboBox13.Text = "";
            comboBox13.BackColor = Color.White;
            comboBox14.Items.Clear();
            comboBox14.Text = "";
            comboBox14.BackColor = Color.White;
            comboBox15.Items.Clear();
            comboBox15.Text = "";
            comboBox15.BackColor = Color.White;
            comboBox16.Items.Clear();
            comboBox16.Text = "";
            comboBox16.BackColor = Color.White;
            comboBox17.Items.Clear();
            comboBox17.Text = "";
            comboBox17.BackColor = Color.White;
            comboBox18.Items.Clear();
            comboBox18.Text = "";
            comboBox18.BackColor = Color.White;
            comboBox1.Items.Add("flowers");
            comboBox1.Items.Add("the flowers");
            comboBox2.Items.Add("chocolate");
            comboBox2.Items.Add("the chocolate");
            comboBox3.Items.Add("the Mercury");
            comboBox3.Items.Add("Mercury");
            comboBox4.Items.Add("closest planet to");
            comboBox4.Items.Add("the closest planet to");
            comboBox5.Items.Add("Russia");
            comboBox5.Items.Add("The Russia");
            comboBox6.Items.Add("biggest country");
            comboBox6.Items.Add("the biggest country");
            comboBox7.Items.Add("Game of Thrones");
            comboBox7.Items.Add("The Game of Thrones");
            comboBox8.Items.Add("most popular show on TV");
            comboBox8.Items.Add("the most popular show on TV");
            comboBox9.Items.Add("Weather");
            comboBox9.Items.Add("The weather");
            comboBox10.Items.Add("Statue of Liberty");
            comboBox10.Items.Add("The Statue of Liberty");
            comboBox11.Items.Add("USA");
            comboBox11.Items.Add("the USA");
            comboBox12.Items.Add("France");
            comboBox12.Items.Add("the France");
            comboBox13.Items.Add("the radio");
            comboBox13.Items.Add("radio");
            comboBox14.Items.Add("bus");
            comboBox14.Items.Add("the bus");
            comboBox15.Items.Add("Berlin");
            comboBox15.Items.Add("The Berlin");
            comboBox16.Items.Add("Germany");
            comboBox16.Items.Add("the Germany");
            comboBox17.Items.Add("cinema");
            comboBox17.Items.Add("cinema");
            comboBox18.Items.Add("theater");
            comboBox18.Items.Add("the theater");

            buttonVerify.Hide();
            buttonVerify2.Show();
            buttonShowAnswer.Hide();
            buttonShowAnswer2.Show();
            buttonNewExercise.Hide();
            buttonVerify2.Enabled = true;
            buttonShowAnswer2.Enabled = true;

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

            string fileName = "XMLArticole.xml";
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
                        label22.Text = ("" + s22);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "twentythree")
                    {
                        string s23 = xtr.ReadElementString();
                        label23.Text = ("" + s23);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "twentyfour")
                    {
                        string s24 = xtr.ReadElementString();
                        label24.Text = ("" + s24);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "twentyfive")
                    {
                        string s25 = xtr.ReadElementString();
                        label25.Text = ("" + s25);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "twentysix")
                    {
                        string s26 = xtr.ReadElementString();
                        label26.Text = ("" + s26);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "twentyseven")
                    {
                        string s27 = xtr.ReadElementString();
                        label27.Text = ("" + s27);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "twentyeight")
                    {
                        string s28 = xtr.ReadElementString();
                        label28.Text = ("" + s28);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "twentynine")
                    {
                        string s29 = xtr.ReadElementString();
                        label29.Text = ("" + s29);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "thirty")
                    {
                        string s30 = xtr.ReadElementString();
                        label30.Text = ("" + s30);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "thirtyone")
                    {
                        string s31 = xtr.ReadElementString();
                        label31.Text = ("" + s31);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "thirtytwo")
                    {
                        string s32 = xtr.ReadElementString();
                        label32.Text = ("" + s32);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "thirtythree")
                    {
                        string s33 = xtr.ReadElementString();
                        label33.Text = ("" + s33);
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
            double newscore = 0;

            if (comboBox1.Text.Equals("flowers"))
            {
                comboBox1.BackColor = Color.Green;
                if (comboBox1.BackColor == Color.Green)
                {
                    newscore = newscore + 0.5;
                }
            }
            else
            {
                comboBox1.BackColor = Color.Red;
                label11.Text = "My grandmother likes flowers and chocolate.";
                label11.ForeColor = Color.Green;
            }


            if (comboBox2.Text.Equals("chocolate"))
            {
                comboBox2.BackColor = Color.Green;
                if (comboBox2.BackColor == Color.Green)
                {
                    newscore = newscore + 0.5;
                }
            }
            else
            {
                comboBox2.BackColor = Color.Red;
                label11.Text = "My grandmother likes flowers and chocolate.";
                label11.ForeColor = Color.Green;
            }


            if (comboBox3.Text.Equals("Mercury"))
            {
                comboBox3.BackColor = Color.Green;
                if (comboBox3.BackColor == Color.Green)
                {
                    newscore = newscore + 0.5;
                }
            }
            else
            {
                comboBox3.BackColor = Color.Red;
                label12.Text = "Mercury is the closest planet to the Sun.";
                label12.ForeColor = Color.Green;
            }


            if (comboBox4.Text.Equals("the closest planet to"))
            {
                comboBox4.BackColor = Color.Green;
                if (comboBox4.BackColor == Color.Green)
                {
                    newscore = newscore + 0.5;
                }
            }
            else
            {
                comboBox4.BackColor = Color.Red;
                label12.Text = "Mercury is the closest planet to the Sun.";
                label12.ForeColor = Color.Green;
            }


            if (comboBox5.Text.Equals("Russia"))
            {
                comboBox5.BackColor = Color.Green;
                if (comboBox5.BackColor == Color.Green)
                {
                    newscore = newscore + 0.5;
                }
            }
            else
            {
                comboBox5.BackColor = Color.Red;
                label13.Text = "Russia is the biggest country on the planet.";
                label13.ForeColor = Color.Green;
            }


            if (comboBox6.Text.Equals("the biggest country"))
            {
                comboBox6.BackColor = Color.Green;
                if (comboBox6.BackColor == Color.Green)
                {
                    newscore = newscore + 0.5;
                }
            }
            else
            {
                comboBox6.BackColor = Color.Red;
                label13.Text = "Russia is the biggest country on the planet.";
                label13.ForeColor = Color.Green;
            }


            if (comboBox7.Text.Equals("Game of Thrones"))
            {
                comboBox7.BackColor = Color.Green;
                if (comboBox7.BackColor == Color.Green)
                {
                    newscore = newscore + 0.5;
                }
            }
            else
            {
                comboBox7.BackColor = Color.Red;
                label14.Text = "Game of Thrones is the most popular show on TV.";
                label14.ForeColor = Color.Green;
            }


            if (comboBox8.Text.Equals("the most popular show on TV"))
            {
                comboBox8.BackColor = Color.Green;
                if (comboBox8.BackColor == Color.Green)
                {
                    newscore = newscore + 0.5;
                }
            }
            else
            {
                comboBox8.BackColor = Color.Red;
                label14.Text = "Game of Thrones is the most popular show on TV.";
                label14.ForeColor = Color.Green;
            }


            if (comboBox9.Text.Equals("The weather"))
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
                label15.Text = "The weather is cold today";
                label15.ForeColor = Color.Green;
            }


            if (comboBox10.Text.Equals("The Statue of Liberty"))
            {
                comboBox10.BackColor = Color.Green;
                if (comboBox10.BackColor == Color.Green)
                {
                    newscore = newscore + 0.3;
                }
            }
            else
            {
                comboBox10.BackColor = Color.Red;
                label16.Text = "The Statue of Liberty symbolises friendship between the USA and France.";
                label16.ForeColor = Color.Green;
            }


            if (comboBox11.Text.Equals("the USA"))
            {
                comboBox11.BackColor = Color.Green;
                if (comboBox11.BackColor == Color.Green)
                {
                    newscore = newscore + 0.3;
                }
            }
            else
            {
                comboBox11.BackColor = Color.Red;
                label16.Text = "The Statue of Liberty symbolises friendship between the USA and France.";
                label16.ForeColor = Color.Green;
            }


            if (comboBox12.Text.Equals("France"))
            {
                comboBox12.BackColor = Color.Green;
                if (comboBox12.BackColor == Color.Green)
                {
                    newscore = newscore + 0.3;
                }
            }
            else
            {
                comboBox12.BackColor = Color.Red;
                label16.Text = "The Statue of Liberty symbolises friendship between the USA and France.";
                label16.ForeColor = Color.Green;
            }


            if (comboBox13.Text.Equals("the radio"))
            {
                comboBox13.BackColor = Color.Green;
                if (comboBox13.BackColor == Color.Green)
                {
                    newscore = newscore + 1;
                }
            }
            else
            {
                comboBox13.BackColor = Color.Red;
                label17.Text = "I always listen to the radio in the morning.";
                label17.ForeColor = Color.Green;
            }


            if (comboBox14.Text.Equals("bus"))
            {
                comboBox14.BackColor = Color.Green;
                if (comboBox14.BackColor == Color.Green)
                {
                    newscore = newscore + 1;
                }

            }
            else
            {
                comboBox14.BackColor = Color.Red;
                label18.Text = "Alex goes to work by bus every day.";
                label18.ForeColor = Color.Green;
            }


            if (comboBox15.Text.Equals("Berlin"))
            {
                comboBox15.BackColor = Color.Green;
                if (comboBox15.BackColor == Color.Green)
                {
                    newscore = newscore + 0.5;
                }
            }
            else
            {
                comboBox15.BackColor = Color.Red;
                label19.Text = "Berlin is a city in Germany.";
                label19.ForeColor = Color.Green;
            }


            if (comboBox16.Text.Equals("Germany"))
            {
                comboBox16.BackColor = Color.Green;
                if (comboBox16.BackColor == Color.Green)
                {
                    newscore = newscore + 0.5;
                }
            }
            else
            {
                comboBox16.BackColor = Color.Red;
                label19.Text = "Berlin is a city in Germany.";
                label19.ForeColor = Color.Green;
            }


            if (comboBox17.Text.Equals("the cinema"))
            {
                comboBox17.BackColor = Color.Green;
                if (comboBox17.BackColor == Color.Green)
                {
                    newscore = newscore + 0.5;
                }
            }
            else
            {
                comboBox17.BackColor = Color.Red;
                label20.Text = "She has never been to the cinema or the theater.";
                label20.ForeColor = Color.Green;
            }


            if (comboBox18.Text.Equals("the theater"))
            {
                comboBox18.BackColor = Color.Green;
                if (comboBox18.BackColor == Color.Green)
                {
                    newscore = newscore + 0.5;
                }
            }
            else
            {
                comboBox18.BackColor = Color.Red;
                label20.Text = "She has never been to the cinema or the theater.";
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
            comboBox1.Text = "flowers";
            comboBox2.Text = "chocolate";
            comboBox3.Text = "Mercury";
            comboBox4.Text = "the closest planet to";
            comboBox5.Text = "Russia";
            comboBox6.Text = "the biggest country";
            comboBox7.Text = "Game of Thrones";
            comboBox8.Text = "The most popular show on TV";
            comboBox9.Text = "The weather";
            comboBox10.Text = "The Statue of Liberty";
            comboBox11.Text = "the USA";
            comboBox12.Text = "France";
            comboBox13.Text = "the radio";
            comboBox14.Text = "bus";
            comboBox15.Text = "Berlin";
            comboBox16.Text = "Germany";
            comboBox17.Text = "the cinema";
            comboBox18.Text = "the theater";
            buttonVerify2.Enabled = false;
        }
    }
}
