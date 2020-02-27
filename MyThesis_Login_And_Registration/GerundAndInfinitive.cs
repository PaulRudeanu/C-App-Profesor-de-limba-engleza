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
    public partial class GerundAndInfinitive : Form
    {
        public GerundAndInfinitive()
        {
            InitializeComponent();
        }

        int score = 0;
        public static string passingText;

        private void buttonVerify_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("going"))
            {
                textBox1.BackColor = Color.Green;
                if (textBox1.BackColor == Color.Green)
                {
                    score++;
                }
            }
            else
            {
                textBox1.BackColor = Color.Red;
                label11.Text = "Correct answer: going";
                label11.ForeColor = Color.Green;
            }


            if (textBox2.Text.Equals("to buy"))
            {
                textBox2.BackColor = Color.Green;
                if (textBox2.BackColor == Color.Green)
                {
                    score++;
                }
            }
            else
            {
                textBox2.BackColor = Color.Red;
                label12.Text = "Correct answer: to buy";
                label12.ForeColor = Color.Green;
            }


            if (textBox3.Text.Equals("to answer"))
            {
                textBox3.BackColor = Color.Green;
                if (textBox3.BackColor == Color.Green)
                {
                    score++;
                }
            }
            else
            {
                textBox3.BackColor = Color.Red;
                label13.Text = "Correct answer: to answer";
                label13.ForeColor = Color.Green;
            }


            if (textBox4.Text.Equals("to get"))
            {
                textBox4.BackColor = Color.Green;
                if (textBox4.BackColor == Color.Green)
                {
                    score++;
                }
            }
            else
            {
                textBox4.BackColor = Color.Red;
                label14.Text = "Correct answer: to get";
                label14.ForeColor = Color.Green;
            }


            if (textBox5.Text.Equals("seeing"))
            {
                textBox5.BackColor = Color.Green;
                if (textBox5.BackColor == Color.Green)
                {
                    score++;
                }
            }
            else
            {
                textBox5.BackColor = Color.Red;
                label15.Text = "Correct answer: seeing";
                label15.ForeColor = Color.Green;
            }


            if (textBox6.Text.Equals("visiting"))
            {
                textBox6.BackColor = Color.Green;
                if (textBox6.BackColor == Color.Green)
                {
                    score++;
                }
            }
            else
            {
                textBox6.BackColor = Color.Red;
                label16.Text = "Correct answer: visiting";
                label16.ForeColor = Color.Green;
            }


            if (textBox7.Text.Equals("to run"))
            {
                textBox7.BackColor = Color.Green;
                if (textBox7.BackColor == Color.Green)
                {
                    score++;
                }
            }
            else
            {
                textBox7.BackColor = Color.Red;
                label17.Text = "Correct answer: to run";
                label17.ForeColor = Color.Green;
            }


            if (textBox8.Text.Equals("to study"))
            {
                textBox8.BackColor = Color.Green;
                if (textBox8.BackColor == Color.Green)
                {
                    score++;
                }
            }
            else
            {
                textBox8.BackColor = Color.Red;
                label18.Text = "Correct answer: to study";
                label18.ForeColor = Color.Green;
            }


            if (textBox9.Text.Equals("working"))
            {
                textBox9.BackColor = Color.Green;
                if (textBox9.BackColor == Color.Green)
                {
                    score++;
                }
            }
            else
            {
                textBox9.BackColor = Color.Red;
                label19.Text = "Correct answer: working";
                label19.ForeColor = Color.Green;
            }


            if (textBox10.Text.Equals("to ride"))
            {
                textBox10.BackColor = Color.Green;
                if (textBox10.BackColor == Color.Green)
                {
                    score++;
                }
            }
            else
            {
                textBox10.BackColor = Color.Red;
                label20.Text = "Correct answer: to ride";
                label20.ForeColor = Color.Green;
            }

            buttonShowAnswer.Enabled = false;
            buttonShowAnswer2.Enabled = false;
            buttonVerify2.Hide();
            buttonVerify.Enabled = false;
            labelScore.Text += score;
            passingText = labelScore.Text;

        }

        private void buttonGoBack2_Click(object sender, EventArgs e)
        {
            GrammarExercises openForm = new GrammarExercises();
            openForm.Show();
            Visible = false;
        }

        private void buttonShowAnswer_Click(object sender, EventArgs e)
        {
            textBox1.Text = "going";
            textBox2.Text = "to buy";
            textBox3.Text = "to answer";
            textBox4.Text = "to get";
            textBox5.Text = "seeing";
            textBox6.Text = "visiting";
            textBox7.Text = "to run";
            textBox8.Text = "to study";
            textBox9.Text = "working";
            textBox10.Text = "to ride";
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
            GerundAndInfinitive openForm = new GerundAndInfinitive();
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
            ConditionalSentences conditionalSentencesIf = new ConditionalSentences();
            conditionalSentencesIf.Show();
        }

        private void buttonExercitiulUrmator_Click(object sender, EventArgs e)
        {
            this.Close();
            NounsApostrophe nounsApostrophe = new NounsApostrophe();
            nounsApostrophe.Show();
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

        private void label22_MouseHover(object sender, EventArgs e)
        {
            if (label22.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(label22.Text);
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

        private void label24_MouseHover(object sender, EventArgs e)
        {
            if (label24.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(label24.Text);
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

        private void label26_MouseHover(object sender, EventArgs e)
        {
            if (label26.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(label26.Text);
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

            textBox1.Clear();
            textBox1.BackColor = Color.White;
            textBox1.Location = new Point(832, 166);
            textBox2.Clear();
            textBox2.BackColor = Color.White;
            textBox2.Location = new Point(914, 226);
            textBox3.Clear();
            textBox3.BackColor = Color.White;
            textBox3.Location = new Point(848, 290);
            textBox4.Clear();
            textBox4.BackColor = Color.White;
            textBox4.Location = new Point(827, 354);
            textBox5.Clear();
            textBox5.BackColor = Color.White;
            textBox5.Location = new Point(800, 417);
            textBox6.Clear();
            textBox6.BackColor = Color.White;
            textBox7.Clear();
            textBox7.BackColor = Color.White;
            textBox7.Location = new Point(792, 547);
            textBox8.Clear();
            textBox8.BackColor = Color.White;
            textBox8.Location = new Point(906, 617);
            textBox9.Clear();
            textBox9.BackColor = Color.White;
            textBox9.Location = new Point(846, 681);
            textBox10.Clear();
            textBox10.BackColor = Color.White;
            textBox10.Location = new Point(831, 748);

            label21.Location = new Point(932, 166);
            label22.Location = new Point(1012, 226);
            label23.Location = new Point(948, 290);
            label24.Location = new Point(935, 354);
            label25.Location = new Point(906, 417);
            label27.Location = new Point(894, 547);
            label28.Location = new Point(1006, 617);
            label29.Location = new Point(946, 681);
            label30.Location = new Point(931, 748);

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

            string fileName = "XMLGerunziuSiInfinitiv.xml";
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

            if (textBox1.Text.Equals("to buy"))
            {
                textBox1.BackColor = Color.Green;
                if (textBox1.BackColor == Color.Green)
                {
                    newscore++;
                }
            }
            else
            {
                textBox1.BackColor = Color.Red;
                label11.Text = "Correct answer: to buy";
                label11.ForeColor = Color.Green;
            }
            if (textBox2.Text.Equals("to do"))
            {
                textBox2.BackColor = Color.Green;
                if (textBox2.BackColor == Color.Green)
                {
                    newscore++;
                }
            }
            else
            {
                textBox2.BackColor = Color.Red;
                label12.Text = "Correct answer: to do";
                label12.ForeColor = Color.Green;
            }
            if (textBox3.Text.Equals("smoking"))
            {
                textBox3.BackColor = Color.Green;
                if (textBox3.BackColor == Color.Green)
                {
                    newscore++;
                }
            }
            else
            {
                textBox3.BackColor = Color.Red;
                label13.Text = "Correct answer: smoking";
                label13.ForeColor = Color.Green;
            }
            if (textBox4.Text.Equals("to fly"))
            {
                textBox4.BackColor = Color.Green;
                if (textBox4.BackColor == Color.Green)
                {
                    newscore++;
                }
            }
            else
            {
                textBox4.BackColor = Color.Red;
                label14.Text = "Correct answer: to fly";
                label14.ForeColor = Color.Green;
            }
            if (textBox5.Text.Equals("writing"))
            {
                textBox5.BackColor = Color.Green;
                if (textBox5.BackColor == Color.Green)
                {
                    newscore++;
                }
            }
            else
            {
                textBox5.BackColor = Color.Red;
                label15.Text = "Correct answer: writing";
                label15.ForeColor = Color.Green;
            }
            if (textBox6.Text.Equals("to do"))
            {
                textBox6.BackColor = Color.Green;
                if (textBox6.BackColor == Color.Green)
                {
                    newscore++;
                }
            }
            else
            {
                textBox6.BackColor = Color.Red;
                label16.Text = "Correct answer: to do";
                label16.ForeColor = Color.Green;
            }
            if (textBox7.Text.Equals("making"))
            {
                textBox7.BackColor = Color.Green;
                if (textBox7.BackColor == Color.Green)
                {
                    newscore++;
                }
            }
            else
            {
                textBox7.BackColor = Color.Red;
                label17.Text = "Correct answer: making";
                label17.ForeColor = Color.Green;
            }
            if (textBox8.Text.Equals("to be"))
            {
                textBox8.BackColor = Color.Green;
                if (textBox8.BackColor == Color.Green)
                {
                    newscore++;
                }
            }
            else
            {
                textBox8.BackColor = Color.Red;
                label18.Text = "Correct answer: to be";
                label18.ForeColor = Color.Green;
            }
            if (textBox9.Text.Equals("building"))
            {
                textBox9.BackColor = Color.Green;
                if (textBox9.BackColor == Color.Green)
                {
                    newscore++;
                }
            }
            else
            {
                textBox9.BackColor = Color.Red;
                label19.Text = "Correct answer: building";
                label19.ForeColor = Color.Green;
            }
            if (textBox10.Text.Equals("to see"))
            {
                textBox10.BackColor = Color.Green;
                if (textBox10.BackColor == Color.Green)
                {
                    newscore++;
                }
            }
            else
            {
                textBox10.BackColor = Color.Red;
                label20.Text = "Correct answer: to see";
                label20.ForeColor = Color.Green;
            }

            buttonVerify2.Enabled = false;
            buttonShowAnswer2.Enabled = false;
            labelScore.Text = "";
            labelScore.Text += score + newscore;
            passingText = labelScore.Text;
        }

        private void buttonShowAnswer2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "to buy";
            textBox2.Text = "to do";
            textBox3.Text = "smoking";
            textBox4.Text = "to fly";
            textBox5.Text = "writing";
            textBox6.Text = "to do";
            textBox7.Text = "making";
            textBox8.Text = "to be";
            textBox9.Text = "building";
            textBox10.Text = "to see";
            buttonVerify2.Enabled = false;
        }
    }
}
