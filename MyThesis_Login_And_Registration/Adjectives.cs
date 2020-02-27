using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace MyThesis_Login_And_Registration
{

    public partial class Adjectives : Form
    {
        public Adjectives()
        {
            InitializeComponent();
        }


        int score = 0;
        public static string passingText;

        private void buttonVerify_Click(object sender, EventArgs e)
        {         
            if(textBox1.Text.Equals("better"))
            {
                textBox1.BackColor = Color.Green;
                if(textBox1.BackColor == Color.Green)
                {
                    score++;
                }
            }
            else
            {
                textBox1.BackColor = Color.Red;
                label11.Text = "Correct answer: better";
                label11.ForeColor = Color.Green;
            }
            if (textBox2.Text.Equals("happier"))
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
                label12.Text = "Correct answer: happier";
                label12.ForeColor = Color.Green;
            }
            if (textBox3.Text.Equals("worse"))
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
                label13.Text = "Correct answer: worse";
                label13.ForeColor = Color.Green;
            }
            if (textBox4.Text.Equals("more"))
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
                label14.Text = "Correct answer: more";
                label14.ForeColor = Color.Green;
            }
            if (textBox5.Text.Equals("sunny"))
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
                label15.Text = "Correct answer: sunny";
                label15.ForeColor = Color.Green;
            }
            if (textBox6.Text.Equals("worst"))
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
                label16.Text = "Correct answer: worst";
                label16.ForeColor = Color.Green;
            }
            if (textBox7.Text.Equals("newest"))
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
                label17.Text = "Correct answer: newest";
                label17.ForeColor = Color.Green;
            }
            if (textBox8.Text.Equals("clean"))
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
                label18.Text = "Correct answer: clean";
                label18.ForeColor = Color.Green;
            }
            if (textBox9.Text.Equals("oldest"))
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
                label19.Text = "Correct answer: oldest";
                label19.ForeColor = Color.Green;
            }
            if (textBox10.Text.Equals("difficult"))
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
                label20.Text = "Correct answer: difficult";
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
            textBox1.Text = "better";
            textBox2.Text = "happier";
            textBox3.Text = "worse";
            textBox4.Text = "more";
            textBox5.Text = "sunny";
            textBox6.Text = "worst";
            textBox7.Text = "newest";
            textBox8.Text = "clean";
            textBox9.Text = "oldest";
            textBox10.Text = "difficult";
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
            Adjectives openForm = new Adjectives();
            openForm.Show();
            Visible = false;
        }

        private void buttonVocabular_Click(object sender, EventArgs e)
        {
            VocabularyHelp openForm = new VocabularyHelp();
            openForm.Show();
        }

        private void buttonExercitiulUrmator_Click(object sender, EventArgs e)
        {
            this.Close();
            Articles articole = new Articles();
            articole.Show();
        }

        private void buttonExercitiulAnterior_Click(object sender, EventArgs e)
        {
            this.Close();
            Pronouns prepositions = new Pronouns();
            prepositions.Show();
        }

        private void labelClose_MouseEnter(object sender, EventArgs e)
        {
            labelClose.ForeColor = Color.White;
        }

        private void labelClose_MouseLeave(object sender, EventArgs e)
        {
            labelClose.ForeColor = Color.Black;
        }

        //Speech Synthesis

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

        private void label10_MouseHover(object sender, EventArgs e)
        {
            if (label10.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(label10.Text);
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

        private void buttonNewExercise_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.BackColor = Color.White;
            textBox2.Clear();
            textBox2.BackColor = Color.White;
            textBox3.Clear();
            textBox3.BackColor = Color.White;
            textBox4.Clear();
            textBox4.BackColor = Color.White;
            textBox5.Clear();
            textBox5.BackColor = Color.White;
            textBox6.Clear();
            textBox6.BackColor = Color.White;
            textBox7.Clear();
            textBox7.BackColor = Color.White;
            textBox8.Clear();
            textBox8.BackColor = Color.White;
            textBox9.Clear();
            textBox9.BackColor = Color.White;
            textBox10.Clear();
            textBox10.BackColor = Color.White;

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

            string fileName = "XMLAdjective.xml";
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

            if (textBox1.Text.Equals("flatter"))
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
                label11.Text = "Correct answer: flatter";
                label11.ForeColor = Color.Green;
            }
            if (textBox2.Text.Equals("less"))
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
                label12.Text = "Correct answer: less";
                label12.ForeColor = Color.Green;
            }
            if (textBox3.Text.Equals("further"))
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
                label13.Text = "Correct answer: further";
                label13.ForeColor = Color.Green;
            }
            if (textBox4.Text.Equals("more popular"))
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
                label14.Text = "Correct answer: more popular";
                label14.ForeColor = Color.Green;
            }
            if (textBox5.Text.Equals("antique"))
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
                label15.Text = "Correct answer: antique";
                label15.ForeColor = Color.Green;
            }
            if (textBox6.Text.Equals("most boring"))
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
                label16.Text = "Correct answer: most boring";
                label16.ForeColor = Color.Green;
            }
            if (textBox7.Text.Equals("holier"))
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
                label17.Text = "Correct answer: holier";
                label17.ForeColor = Color.Green;
            }
            if (textBox8.Text.Equals("hot"))
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
                label18.Text = "Correct answer: hot";
                label18.ForeColor = Color.Green;
            }
            if (textBox9.Text.Equals("bigger"))
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
                label19.Text = "Correct answer: bigger";
                label19.ForeColor = Color.Green;
            }
            if (textBox10.Text.Equals("sad"))
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
                label20.Text = "Correct answer: sad";
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
            textBox1.Text = "flatter";
            textBox2.Text = "less";
            textBox3.Text = "further";
            textBox4.Text = "more popular";
            textBox5.Text = "antique";
            textBox6.Text = "most boring";
            textBox7.Text = "holier";
            textBox8.Text = "hot";
            textBox9.Text = "bigger";
            textBox10.Text = "sad";
            buttonVerify2.Enabled = false;
        }
    }
}
