using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Speech.Synthesis;
using System.IO;

namespace MyThesis_Login_And_Registration
{
    public partial class TensesPresentPerfect : Form
    {
        public TensesPresentPerfect()
        {
            InitializeComponent();
        }

        double score = 0;
        public static string passingText;

        private void buttonVerify_Click(object sender, EventArgs e)
        {
            //1)
            if (textBox1.Text.Equals("has not tidied up") && textBox2.Text.Equals("yet"))
            {
                textBox1.BackColor = Color.Green;
                textBox2.BackColor = Color.Green;
                if(textBox1.BackColor == Color.Green && textBox2.BackColor == Color.Green)
                {
                    score = score + 1.3;
                }
            }
            else
            {
                textBox1.BackColor = Color.Red;
                textBox2.BackColor = Color.Red;
                label11.Text = "She has not tidied up her room yet.";
                label11.ForeColor = Color.Green;
            }
            if(textBox1.Text.Equals("has not tidied up"))
            {
                textBox1.BackColor = Color.Green;
                score = score + 0.625;
            }
            if (textBox2.Text.Equals("yet"))
            {
                textBox2.BackColor = Color.Green;
                score = score + 0.625;
            }

            //2)
            if (textBox3.Text.Equals("have not used") && textBox4.Text.Equals("so far"))
            {
                textBox3.BackColor = Color.Green;
                textBox4.BackColor = Color.Green;
                if (textBox3.BackColor == Color.Green && textBox4.BackColor == Color.Green)
                {
                    score = score + 1.3;
                }
            }
            else
            {
                textBox3.BackColor = Color.Red;
                textBox4.BackColor = Color.Red;
                label12.Text = "They have not used a Tablet PC so far.";
                label12.ForeColor = Color.Green;
            }
            if (textBox3.Text.Equals("have not used"))
            {
                textBox3.BackColor = Color.Green;
                score = score + 0.625;
            }
            if (textBox4.Text.Equals("so far"))
            {
                textBox4.BackColor = Color.Green;
                score = score + 0.625;
            }


            //3)
            if (textBox5.Text.Equals("has not polished"))
            {
                textBox5.BackColor = Color.Green;
                score = score + 0.625;
            }
            else
            {
                textBox5.BackColor = Color.Red;
                label13.Text = "My father has not polished the car. It is still dirty.";
                label13.ForeColor = Color.Green;
            }

            //4)
            if (textBox6.Text.Equals("have not read") && textBox7.Text.Equals("yet"))
            {
                textBox6.BackColor = Color.Green;
                textBox7.BackColor = Color.Green;
                if (textBox6.BackColor == Color.Green && textBox7.BackColor == Color.Green)
                {
                    score = score + 1.3;
                }
            }
            else
            {
                textBox6.BackColor = Color.Red;
                textBox7.BackColor = Color.Red;
                label14.Text = "The children have not read the comics yet.";
                label14.ForeColor = Color.Green;
            }
            if (textBox6.Text.Equals("have not read"))
            {
                textBox6.BackColor = Color.Green;
                score = score + 0.625;
            }
            if (textBox7.Text.Equals("yet"))
            {
                textBox7.BackColor = Color.Green;
                score = score + 0.625;
            }

            //5)
            if (textBox8.Text.Equals("have not learned"))
            {
                textBox8.BackColor = Color.Green;
                score = score + 0.625;
            }
            else
            {
                textBox8.BackColor = Color.Red;
                label15.Text = "Jason and Tony have not learned the words, so they will probably fail the test.";
                label15.ForeColor = Color.Green;
            }

            //6)
            if (textBox9.Text.Equals("has not made") && textBox10.Text.Equals("so far"))
            {
                textBox9.BackColor = Color.Green;
                textBox10.BackColor = Color.Green;
                if (textBox9.BackColor == Color.Green && textBox10.BackColor == Color.Green)
                {
                    score = score + 1.3;
                }
            }
            else
            {
                textBox9.BackColor = Color.Red;
                textBox10.BackColor = Color.Red;
                label16.Text = "His mother has not made breakfast so far.";
                label16.ForeColor = Color.Green;
            }
            if (textBox9.Text.Equals("has not made"))
            {
                textBox9.BackColor = Color.Green;
                score = score + 0.625;
            }
            if (textBox10.Text.Equals("so far"))
            {
                textBox10.BackColor = Color.Green;
                score = score + 0.625;
            }

            //7)
            if (textBox11.Text.Equals("have not skated") && textBox12.Text.Equals("yet"))
            {
                textBox11.BackColor = Color.Green;
                textBox12.BackColor = Color.Green;
                if (textBox11.BackColor == Color.Green && textBox12.BackColor == Color.Green)
                {
                    score = score + 1.3;
                }
            }
            else
            {
                textBox11.BackColor = Color.Red;
                textBox12.BackColor = Color.Red;
                label17.Text = "I have not skated on a lake in winter yet.";
                label17.ForeColor = Color.Green;
            }
            if (textBox11.Text.Equals("have not skated"))
            {
                textBox11.BackColor = Color.Green;
                score = score + 0.625;
            }
            if (textBox12.Text.Equals("yet"))
            {
                textBox12.BackColor = Color.Green;
                score = score + 0.625;
            }

            //8)
            if (textBox13.Text.Equals("has never phoned"))
            {
                textBox13.BackColor = Color.Green;
                score = score + 0.625;
            }
            else
            {
                textBox13.BackColor = Color.Red;
                label18.Text = "My boss has never phoned the helpline.";
                label18.ForeColor = Color.Green;
            }

            //9)
            if (textBox14.Text.Equals("has not washed"))
            {
                textBox14.BackColor = Color.Green;
                score = score + 0.625;
            }
            else
            {
                textBox14.BackColor = Color.Red;
                label19.Text = "He has not washed his favourite T-shirt himself.";
                label19.ForeColor = Color.Green;
            }

            //10)
            if (textBox15.Text.Equals("has not taken out") && textBox16.Text.Equals("yet"))
            {
                textBox15.BackColor = Color.Green;
                textBox16.BackColor = Color.Green;
                if (textBox15.BackColor == Color.Green && textBox16.BackColor == Color.Green)
                {
                    score = score + 1.3;
                }
            }
            else
            {
                textBox15.BackColor = Color.Red;
                textBox16.BackColor = Color.Red;
                label20.Text = "Sarah has not taken out her dog yet.";
                label20.ForeColor = Color.Green;
            }
            if (textBox15.Text.Equals("has not taken out "))
            {
                textBox15.BackColor = Color.Green;
                score = score + 0.625;
            }
            if (textBox16.Text.Equals("yet"))
            {
                textBox16.BackColor = Color.Green;
                score = score + 0.625;
            }

            buttonShowAnswer.Enabled = false;
            buttonShowAnswer2.Enabled = false;
            buttonVerify2.Hide();
            buttonVerify.Enabled = false;
            labelScore.Text += Convert.ToInt32(score);
            passingText = labelScore.Text;

        }

        private void buttonShowAnswer_Click(object sender, EventArgs e)
        {
            textBox1.Text = "has not tidied up";
            textBox2.Text = "yet";
            textBox3.Text = "have not used";
            textBox4.Text = "so far";
            textBox5.Text = "has not polished";
            textBox6.Text = "have not read";
            textBox7.Text = "yet";
            textBox8.Text = "have not learned";
            textBox9.Text = "has not made";
            textBox10.Text = "so far";
            textBox11.Text = "have not skated";
            textBox12.Text = "yet";
            textBox13.Text = "has never phoned";
            textBox14.Text = "has not washed";
            textBox15.Text = "has not taken out";
            textBox16.Text = "yet";
            buttonVerify.Enabled = false;
            buttonVerify2.Hide();
        }

        private void buttonRepetaExercitiul_Click(object sender, EventArgs e)
        {
            TensesPresentPerfect openForm = new TensesPresentPerfect();
            openForm.Show();
            Visible = false;
        }

        private void buttonVocabular_Click(object sender, EventArgs e)
        {
            VocabularyHelp openForm = new VocabularyHelp();
            openForm.Show();
        }

        private void buttonGoBack2_Click(object sender, EventArgs e)
        {
            GrammarExercises openForm = new GrammarExercises();
            openForm.Show();
            Visible = false;
        }

        private void buttonExercitiulAnterior_Click(object sender, EventArgs e)
        {
            this.Close();
            VerbsIrregularForm verbsIrregularForm = new VerbsIrregularForm();
            verbsIrregularForm.Show();
        }

        private void buttonExercitiulUrmator_Click(object sender, EventArgs e)
        {
            this.Close();
            PhrasalVerbs phrasalVerbs = new PhrasalVerbs();
            phrasalVerbs.Show();
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

        private void label34_MouseHover(object sender, EventArgs e)
        {
            if (label34.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(label34.Text);
            }
        }

        private void label35_MouseHover(object sender, EventArgs e)
        {
            if (label35.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(label35.Text);
            }
        }

        private void label36_MouseHover(object sender, EventArgs e)
        {
            if (label36.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(label36.Text);
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

        private void buttonNewExercise_Click(object sender, EventArgs e)
        {
            buttonVerify.Hide();
            buttonVerify2.Show();
            buttonShowAnswer.Hide();
            buttonShowAnswer2.Show();
            buttonNewExercise.Hide();
            buttonVerify2.Enabled = true;
            buttonShowAnswer2.Enabled = true;

            textBox2.Hide();
            textBox4.Hide();
            textBox7.Hide();
            textBox10.Hide();
            textBox12.Hide();
            textBox16.Hide();

            label22.Hide();
            label24.Hide();
            label27.Hide();
            label30.Hide();
            label32.Hide();
            label36.Hide();

            textBox1.Clear();
            textBox1.BackColor = Color.White;
            textBox3.Clear();
            textBox3.BackColor = Color.White;
            textBox5.Clear();
            textBox5.BackColor = Color.White;
            textBox6.Clear();
            textBox6.BackColor = Color.White;
            textBox8.Clear();
            textBox8.BackColor = Color.White;
            textBox9.Clear();
            textBox9.BackColor = Color.White;
            textBox11.Clear();
            textBox11.BackColor = Color.White;
            textBox13.Clear();
            textBox13.BackColor = Color.White;
            textBox14.Clear();
            textBox14.BackColor = Color.White;
            textBox15.Clear();
            textBox15.BackColor = Color.White;

            textBox1.Location = new Point(824, 170);
            textBox1.Size = new Size(136, 26);
            textBox3.Location = new Point(849, 233);
            textBox3.Size = new Size(136, 26);
            textBox5.Location = new Point(787, 291);
            textBox5.Size = new Size(136, 26);
            textBox6.Location = new Point(824, 347);
            textBox6.Size = new Size(136, 26);
            textBox8.Location = new Point(787, 407);
            textBox8.Size = new Size(136, 26);
            textBox9.Location = new Point(787, 470);
            textBox9.Size = new Size(136, 26);
            textBox11.Location = new Point(812, 527);
            textBox11.Size = new Size(136, 26);
            textBox13.Location = new Point(805, 587);
            textBox13.Size = new Size(136, 26);
            textBox14.Location = new Point(839, 647);
            textBox14.Size = new Size(136, 26);
            textBox15.Location = new Point(863, 709);
            textBox15.Size = new Size(136, 26);

            label21.Location = new Point(960, 170);
            label23.Location = new Point(992, 233);
            label26.Location = new Point(975, 347);
            label28.Location = new Point(944, 407);
            label29.Location = new Point(950, 473);
            label31.Location = new Point(961, 527);
            label33.Location = new Point(944, 587);
            label34.Location = new Point(982, 647);
            label35.Location = new Point(1010, 709);

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

            string fileName = "XMLTimpuriPrezentPerfect.xml";
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
                        label26.Text = ("" + s24);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "twentyfive")
                    {
                        string s25 = xtr.ReadElementString();
                        label28.Text = ("" + s25);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "twentysix")
                    {
                        string s26 = xtr.ReadElementString();
                        label29.Text = ("" + s26);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "twentyseven")
                    {
                        string s27 = xtr.ReadElementString();
                        label31.Text = ("" + s27);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "twentyeight")
                    {
                        string s28 = xtr.ReadElementString();
                        label33.Text = ("" + s28);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "twentynine")
                    {
                        string s29 = xtr.ReadElementString();
                        label34.Text = ("" + s29);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "thirty")
                    {
                        string s30 = xtr.ReadElementString();
                        label35.Text = ("" + s30);
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

            if (textBox1.Text.Equals("has not written"))
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
                label11.Text = "has not written";
                label11.ForeColor = Color.Green;
            }
            if (textBox3.Text.Equals("have not carried"))
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
                label12.Text = "have not carried";
                label12.ForeColor = Color.Green;
            }
            if (textBox5.Text.Equals("has not started"))
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
                label13.Text = "has not started";
                label13.ForeColor = Color.Green;
            }
            if (textBox6.Text.Equals("has not jumped"))
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
                label14.Text = "has not jumped";
                label14.ForeColor = Color.Green;
            }
            if (textBox8.Text.Equals("have not visited"))
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
                label15.Text = "have not visited";
                label15.ForeColor = Color.Green;
            }
            if (textBox9.Text.Equals("have not gone"))
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
                label16.Text = "have not gone";
                label16.ForeColor = Color.Green;
            }
            if (textBox11.Text.Equals("has not given"))
            {
                textBox11.BackColor = Color.Green;
                if (textBox11.BackColor == Color.Green)
                {
                    newscore++;
                }
            }
            else
            {
                textBox11.BackColor = Color.Red;
                label17.Text = "has not given";
                label17.ForeColor = Color.Green;
            }
            if (textBox13.Text.Equals("have not told"))
            {
                textBox13.BackColor = Color.Green;
                if (textBox13.BackColor == Color.Green)
                {
                    newscore++;
                }
            }
            else
            {
                textBox13.BackColor = Color.Red;
                label18.Text = "have not told";
                label18.ForeColor = Color.Green;
            }
            if (textBox14.Text.Equals("has not walked"))
            {
                textBox14.BackColor = Color.Green;
                if (textBox14.BackColor == Color.Green)
                {
                    newscore++;
                }
            }
            else
            {
                textBox14.BackColor = Color.Red;
                label19.Text = "has not walked";
                label19.ForeColor = Color.Green;
            }
            if (textBox15.Text.Equals("has not come"))
            {
                textBox15.BackColor = Color.Green;
                if (textBox15.BackColor == Color.Green)
                {
                    newscore++;
                }
            }
            else
            {
                textBox15.BackColor = Color.Red;
                label20.Text = "has not come";
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
            textBox1.Text = "has not written";
            textBox3.Text = "have not carried";
            textBox5.Text = "has not started";
            textBox6.Text = "has not jumped";
            textBox8.Text = "have not visited";
            textBox9.Text = "have not gone";
            textBox11.Text = "has not given";
            textBox13.Text = "have not told";
            textBox14.Text = "has not walked";
            textBox15.Text = "has not come";
            buttonVerify2.Enabled = false;
        }
    }
}
