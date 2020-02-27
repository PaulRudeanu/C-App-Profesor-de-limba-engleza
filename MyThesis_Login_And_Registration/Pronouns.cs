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
    public partial class Pronouns : Form
    {
        public Pronouns()
        {
            InitializeComponent();
        }


        int score = 0;
        public static string passingText;


        //1)
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.ForeColor = Color.Red;
            label11.Text = "them";
            label11.ForeColor = Color.Green;
            radioButton2.Enabled = false;
            radioButton3.Enabled = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radioButton2.ForeColor = Color.Green;
            label11.Text = "✓";
            label11.ForeColor = Color.Green;
            radioButton1.Enabled = false;
            radioButton3.Enabled = false;
            if (radioButton2.Checked)
            {
                score++;
                labelScore.Text = Convert.ToString(score);
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            radioButton3.ForeColor = Color.Red;
            label11.Text = "them";
            label11.ForeColor = Color.Green;
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
        }

        //2)
        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            radioButton6.ForeColor = Color.Green;
            label12.Text = "✓";
            label12.ForeColor = Color.Green;
            radioButton4.Enabled = false;
            radioButton5.Enabled = false;
            if (radioButton6.Checked)
            {
                score++;
                labelScore.Text = Convert.ToString(score);
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            radioButton5.ForeColor = Color.Red;
            label12.Text = "her";
            label12.ForeColor = Color.Green;
            radioButton4.Enabled = false;
            radioButton6.Enabled = false;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            radioButton4.ForeColor = Color.Red;
            label12.Text = "her";
            label12.ForeColor = Color.Green;
            radioButton5.Enabled = false;
            radioButton6.Enabled = false;
        }

        //3)
        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            radioButton9.ForeColor = Color.Red;
            label13.Text = "them";
            label13.ForeColor = Color.Green;
            radioButton7.Enabled = false;
            radioButton8.Enabled = false;
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            radioButton8.ForeColor = Color.Green;
            label13.Text = "✓";
            label13.ForeColor = Color.Green;
            radioButton7.Enabled = false;
            radioButton9.Enabled = false;
            if (radioButton8.Checked)
            {
                score++;
                labelScore.Text = Convert.ToString(score);
            }
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            radioButton7.ForeColor = Color.Red;
            label13.Text = "them";
            label13.ForeColor = Color.Green;
            radioButton9.Enabled = false;
            radioButton8.Enabled = false;
        }

        //4)
        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            radioButton12.ForeColor = Color.Red;
            label14.Text = "him";
            label14.ForeColor = Color.Green;
            radioButton10.Enabled = false;
            radioButton11.Enabled = false;
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            radioButton11.ForeColor = Color.Red;
            label14.Text = "him";
            label14.ForeColor = Color.Green;
            radioButton10.Enabled = false;
            radioButton12.Enabled = false;
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            radioButton10.ForeColor = Color.Green;
            label14.Text = "✓";
            label14.ForeColor = Color.Green;
            radioButton11.Enabled = false;
            radioButton12.Enabled = false;
            if (radioButton10.Checked)
            {
                score++;
                labelScore.Text = Convert.ToString(score);
            }
        }

        //5)
        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {
            radioButton15.ForeColor = Color.Red;
            label15.Text = "it";
            label15.ForeColor = Color.Green;
            radioButton13.Enabled = false;
            radioButton14.Enabled = false;
        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            radioButton14.ForeColor = Color.Red;
            label15.Text = "it";
            label15.ForeColor = Color.Green;
            radioButton13.Enabled = false;
            radioButton15.Enabled = false;
        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            radioButton13.ForeColor = Color.Green;
            label15.Text = "✓";
            label15.ForeColor = Color.Green;
            radioButton11.Enabled = false;
            radioButton12.Enabled = false;
            if (radioButton13.Checked)
            {
                score++;
                labelScore.Text = Convert.ToString(score);
            }
        }

        //6)
        private void radioButton18_CheckedChanged(object sender, EventArgs e)
        {
            radioButton18.ForeColor = Color.Green;
            label16.Text = "✓";
            label16.ForeColor = Color.Green;
            radioButton16.Enabled = false;
            radioButton17.Enabled = false;
            if (radioButton18.Checked)
            {
                score++;
                labelScore.Text = Convert.ToString(score);
            }
        }

        private void radioButton17_CheckedChanged(object sender, EventArgs e)
        {
            radioButton17.ForeColor = Color.Red;
            label16.Text = "her";
            label16.ForeColor = Color.Green;
            radioButton16.Enabled = false;
            radioButton18.Enabled = false;
        }

        private void radioButton16_CheckedChanged(object sender, EventArgs e)
        {
            radioButton16.ForeColor = Color.Red;
            label16.Text = "her";
            label16.ForeColor = Color.Green;
            radioButton17.Enabled = false;
            radioButton18.Enabled = false;
        }

        //7)
        private void radioButton21_CheckedChanged(object sender, EventArgs e)
        {
            radioButton21.ForeColor = Color.Green;
            label17.Text = "✓";
            label17.ForeColor = Color.Green;
            radioButton19.Enabled = false;
            radioButton20.Enabled = false;
            if (radioButton21.Checked)
            {
                score++;
                labelScore.Text = Convert.ToString(score);
            }
        }

        private void radioButton20_CheckedChanged(object sender, EventArgs e)
        {
            radioButton20.ForeColor = Color.Red;
            label17.Text = "it";
            label17.ForeColor = Color.Green;
            radioButton19.Enabled = false;
            radioButton21.Enabled = false;
        }

        private void radioButton19_CheckedChanged(object sender, EventArgs e)
        {
            radioButton19.ForeColor = Color.Red;
            label17.Text = "it";
            label17.ForeColor = Color.Green;
            radioButton20.Enabled = false;
            radioButton21.Enabled = false;
        }

        //8)
        private void radioButton24_CheckedChanged(object sender, EventArgs e)
        {
            radioButton24.ForeColor = Color.Red;
            label18.Text = "them";
            label18.ForeColor = Color.Green;
            radioButton22.Enabled = false;
            radioButton23.Enabled = false;
        }

        private void radioButton23_CheckedChanged(object sender, EventArgs e)
        {
            radioButton23.ForeColor = Color.Green;
            label18.Text = "✓";
            label18.ForeColor = Color.Green;
            radioButton22.Enabled = false;
            radioButton24.Enabled = false;
            if (radioButton23.Checked)
            {
                score++;
                labelScore.Text = Convert.ToString(score);
            }
        }

        private void radioButton22_CheckedChanged(object sender, EventArgs e)
        {
            radioButton22.ForeColor = Color.Red;
            label18.Text = "them";
            label18.ForeColor = Color.Green;
            radioButton24.Enabled = false;
            radioButton23.Enabled = false;
        }

        //9)
        private void radioButton27_CheckedChanged(object sender, EventArgs e)
        {
            radioButton27.ForeColor = Color.Green;
            label19.Text = "✓";
            label19.ForeColor = Color.Green;
            radioButton25.Enabled = false;
            radioButton26.Enabled = false;
            if (radioButton27.Checked)
            {
                score++;
                labelScore.Text = Convert.ToString(score);
            }
        }

        private void radioButton26_CheckedChanged(object sender, EventArgs e)
        {
            radioButton26.ForeColor = Color.Red;
            label19.Text = "him";
            label19.ForeColor = Color.Green;
            radioButton25.Enabled = false;
            radioButton27.Enabled = false;
        }

        private void radioButton25_CheckedChanged(object sender, EventArgs e)
        {
            radioButton25.ForeColor = Color.Red;
            label19.Text = "him";
            label19.ForeColor = Color.Green;
            radioButton26.Enabled = false;
            radioButton27.Enabled = false;
        }

        //10)
        private void radioButton30_CheckedChanged(object sender, EventArgs e)
        {
            radioButton30.ForeColor = Color.Red;
            label20.Text = "us";
            label20.ForeColor = Color.Green;
            radioButton28.Enabled = false;
            radioButton29.Enabled = false;
        }

        private void radioButton29_CheckedChanged(object sender, EventArgs e)
        {
            radioButton29.ForeColor = Color.Red;
            label20.Text = "us";
            label20.ForeColor = Color.Green;
            radioButton30.Enabled = false;
            radioButton28.Enabled = false;
        }

        private void radioButton28_CheckedChanged(object sender, EventArgs e)
        {
            radioButton28.ForeColor = Color.Green;
            label20.Text = "✓";
            label20.ForeColor = Color.Green;
            radioButton29.Enabled = false;
            radioButton30.Enabled = false;
            if (radioButton28.Checked)
            {
                score++;
                labelScore.Text = Convert.ToString(score);
            }
        }

        private void buttonShowAnswer_Click(object sender, EventArgs e)
        {
            radioButton2.ForeColor = Color.Green;
            radioButton6.ForeColor = Color.Green;
            radioButton8.ForeColor = Color.Green;
            radioButton10.ForeColor = Color.Green;
            radioButton13.ForeColor = Color.Green;
            radioButton18.ForeColor = Color.Green;
            radioButton21.ForeColor = Color.Green;
            radioButton23.ForeColor = Color.Green;
            radioButton27.ForeColor = Color.Green;
            radioButton28.ForeColor = Color.Green;
        }


        private void buttonVocabular_Click(object sender, EventArgs e)
        {
            VocabularyHelp openForm = new VocabularyHelp();
            openForm.Show();
        }

        private void buttonRepetaExercitiul_Click(object sender, EventArgs e)
        {
            Pronouns openForm = new Pronouns();
            openForm.Show();
            Visible = false;
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
            PhrasalVerbs phrasalVerbs = new PhrasalVerbs();
            phrasalVerbs.Show();
        }

        private void buttonExercitiulUrmator_Click(object sender, EventArgs e)
        {
            this.Close();
            Adjectives adjectiveAdverbe = new Adjectives();
            adjectiveAdverbe.Show();
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


        private void textBox1_MouseHover(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(textBox1.Text);
            }
        }

        private void textBox2_MouseHover(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(textBox2.Text);
            }
        }

        private void textBox3_MouseHover(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(textBox3.Text);
            }
        }

        private void textBox4_MouseHover(object sender, EventArgs e)
        {
            if (textBox4.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(textBox4.Text);
            }
        }

        private void textBox5_MouseHover(object sender, EventArgs e)
        {
            if (textBox5.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(textBox5.Text);
            }
        }

        private void textBox6_MouseHover(object sender, EventArgs e)
        {
            if (textBox6.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(textBox6.Text);
            }
        }

        private void textBox7_MouseHover(object sender, EventArgs e)
        {
            if (textBox7.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(textBox7.Text);
            }
        }

        private void textBox8_MouseHover(object sender, EventArgs e)
        {
            if (textBox8.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(textBox8.Text);
            }
        }

        private void textBox9_MouseHover(object sender, EventArgs e)
        {
            if (textBox9.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(textBox9.Text);
            }
        }

        private void textBox10_MouseHover(object sender, EventArgs e)
        {
            if (textBox10.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(textBox10.Text);
            }
        }

        private void radioButton1_MouseHover(object sender, EventArgs e)
        {
            if (radioButton1.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(radioButton1.Text);
            }
        }

        private void radioButton2_MouseHover(object sender, EventArgs e)
        {
            if (radioButton2.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(radioButton2.Text);
            }
        }

        private void radioButton3_MouseHover(object sender, EventArgs e)
        {
            if (radioButton3.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(radioButton3.Text);
            }
        }

        private void radioButton6_MouseHover(object sender, EventArgs e)
        {
            if (radioButton6.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(radioButton6.Text);
            }
        }

        private void radioButton5_MouseHover(object sender, EventArgs e)
        {
            if (radioButton5.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(radioButton5.Text);
            }
        }

        private void radioButton4_MouseHover(object sender, EventArgs e)
        {
            if (radioButton4.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(radioButton4.Text);
            }
        }

        private void radioButton9_MouseHover(object sender, EventArgs e)
        {
            if (radioButton9.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(radioButton9.Text);
            }
        }

        private void radioButton8_MouseHover(object sender, EventArgs e)
        {
            if (radioButton8.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(radioButton8.Text);
            }
        }

        private void radioButton7_MouseHover(object sender, EventArgs e)
        {
            if (radioButton7.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(radioButton7.Text);
            }
        }

        private void radioButton12_MouseHover(object sender, EventArgs e)
        {
            if (radioButton12.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(radioButton12.Text);
            }
        }

        private void radioButton11_MouseHover(object sender, EventArgs e)
        {
            if (radioButton11.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(radioButton11.Text);
            }
        }

        private void radioButton10_MouseHover(object sender, EventArgs e)
        {
            if (radioButton10.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(radioButton10.Text);
            }
        }

        private void radioButton15_MouseHover(object sender, EventArgs e)
        {
            if (radioButton15.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(radioButton15.Text);
            }
        }

        private void radioButton14_MouseHover(object sender, EventArgs e)
        {
            if (radioButton14.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(radioButton14.Text);
            }
        }

        private void radioButton13_MouseHover(object sender, EventArgs e)
        {
            if (radioButton13.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(radioButton13.Text);
            }
        }

        private void radioButton18_MouseHover(object sender, EventArgs e)
        {
            if (radioButton18.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(radioButton18.Text);
            }
        }

        private void radioButton17_MouseHover(object sender, EventArgs e)
        {
            if (radioButton17.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(radioButton17.Text);
            }
        }

        private void radioButton16_MouseHover(object sender, EventArgs e)
        {
            if (radioButton16.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(radioButton16.Text);
            }
        }

        private void radioButton21_MouseHover(object sender, EventArgs e)
        {
            if (radioButton21.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(radioButton21.Text);
            }
        }

        private void radioButton20_MouseHover(object sender, EventArgs e)
        {
            if (radioButton20.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(radioButton20.Text);
            }
        }

        private void radioButton19_MouseHover(object sender, EventArgs e)
        {
            if (radioButton19.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(radioButton19.Text);
            }
        }

        private void radioButton24_MouseHover(object sender, EventArgs e)
        {
            if (radioButton24.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(radioButton24.Text);
            }
        }

        private void radioButton23_MouseHover(object sender, EventArgs e)
        {
            if (radioButton23.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(radioButton23.Text);
            }
        }

        private void radioButton22_MouseHover(object sender, EventArgs e)
        {
            if (radioButton22.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(radioButton22.Text);
            }
        }

        private void radioButton27_MouseHover(object sender, EventArgs e)
        {
            if (radioButton27.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(radioButton27.Text);
            }
        }

        private void radioButton26_MouseHover(object sender, EventArgs e)
        {
            if (radioButton26.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(radioButton26.Text);
            }
        }

        private void radioButton25_MouseHover(object sender, EventArgs e)
        {
            if (radioButton25.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(radioButton25.Text);
            }
        }

        private void radioButton30_MouseHover(object sender, EventArgs e)
        {
            if (radioButton30.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(radioButton30.Text);
            }
        }

        private void radioButton29_MouseHover(object sender, EventArgs e)
        {
            if (radioButton29.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(radioButton29.Text);
            }
        }

        private void radioButton28_MouseHover(object sender, EventArgs e)
        {
            if (radioButton28.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(radioButton28.Text);
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
            buttonShowAnswer.Hide();
            buttonShowAnswer2.Show();
            buttonNewExercise.Hide();

            labelCerinta.Text = Environment.NewLine + "          Pronouns                                                                                                                                                                    " + Environment.NewLine + "          Choose which form of the personal pronoun you can find in the given sentence/question – subject or object?                                                                                                                                                                    " + Environment.NewLine;


            string fileName = "XMLPronume.xml";
            string path = Path.Combine(Environment.CurrentDirectory, @"", fileName);

            XmlTextReader xtr = new XmlTextReader(path);
            try
            {
                while (xtr.Read())
                {
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "one")
                    {
                        string s1 = xtr.ReadElementString();
                        textBox1.Text = ("" + s1);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "two")
                    {
                        string s2 = xtr.ReadElementString();
                        textBox2.Text = ("" + s2);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "three")
                    {
                        string s3 = xtr.ReadElementString();
                        textBox3.Text = ("" + s3);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "four")
                    {
                        string s4 = xtr.ReadElementString();
                        textBox4.Text = ("" + s4);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "five")
                    {
                        string s5 = xtr.ReadElementString();
                        textBox5.Text = ("" + s5);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "six")
                    {
                        string s6 = xtr.ReadElementString();
                        textBox6.Text = ("" + s6);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "seven")
                    {
                        string s7 = xtr.ReadElementString();
                        textBox7.Text = ("" + s7);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "eight")
                    {
                        string s8 = xtr.ReadElementString();
                        textBox8.Text = ("" + s8);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "nine")
                    {
                        string s9 = xtr.ReadElementString();
                        textBox9.Text = ("" + s9);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "ten")
                    {
                        string s10 = xtr.ReadElementString();
                        textBox10.Text = ("" + s10);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            radioButton31.Text = "subject form";
            radioButton32.Text = "object form";
            radioButton33.Text = "subject form";
            radioButton34.Text = "object form";
            radioButton35.Text = "subject form";
            radioButton36.Text = "object form";
            radioButton37.Text = "subject form";
            radioButton38.Text = "object form";
            radioButton39.Text = "subject form";
            radioButton40.Text = "object form";
            radioButton41.Text = "subject form";
            radioButton42.Text = "object form";
            radioButton43.Text = "subject form";
            radioButton44.Text = "object form";
            radioButton45.Text = "subject form";
            radioButton46.Text = "object form";
            radioButton47.Text = "subject form";
            radioButton48.Text = "object form";
            radioButton49.Text = "subject form";
            radioButton50.Text = "object form";

            radioButton1.Hide();
            radioButton2.Hide();
            radioButton3.Hide();
            radioButton4.Hide();
            radioButton5.Hide();
            radioButton6.Hide();
            radioButton7.Hide();
            radioButton8.Hide();
            radioButton9.Hide();
            radioButton10.Hide();
            radioButton11.Hide();
            radioButton12.Hide();
            radioButton13.Hide();
            radioButton14.Hide();
            radioButton15.Hide();
            radioButton16.Hide();
            radioButton17.Hide();
            radioButton18.Hide();
            radioButton19.Hide();
            radioButton20.Hide();
            radioButton21.Hide();
            radioButton22.Hide();
            radioButton23.Hide();
            radioButton24.Hide();
            radioButton25.Hide();
            radioButton26.Hide();
            radioButton27.Hide();
            radioButton28.Hide();
            radioButton29.Hide();
            radioButton30.Hide();

        }

        int newscore = 0;

        private void radioButton31_CheckedChanged(object sender, EventArgs e)
        {
            radioButton31.ForeColor = Color.Green;
            label11.Text = "✓";
            label11.ForeColor = Color.Green;
            radioButton32.Enabled = false;
            if (radioButton31.Checked)
            {
                newscore++;
                labelScore.Text = Convert.ToString(Convert.ToInt32(score) + Convert.ToInt32(newscore));
            }
        }

        private void radioButton32_CheckedChanged(object sender, EventArgs e)
        {
            radioButton32.ForeColor = Color.Red;
            label11.Text = "subject form";
            label11.ForeColor = Color.Green;
            radioButton31.Enabled = false;
        }

        private void radioButton33_CheckedChanged(object sender, EventArgs e)
        {
            radioButton33.ForeColor = Color.Red;
            label12.Text = "object form";
            label12.ForeColor = Color.Green;
            radioButton34.Enabled = false;
        }

        private void radioButton34_CheckedChanged(object sender, EventArgs e)
        {
            radioButton34.ForeColor = Color.Green;
            label12.Text = "✓";
            label12.ForeColor = Color.Green;
            radioButton33.Enabled = false;
            if (radioButton34.Checked)
            {
                newscore++;
                labelScore.Text = Convert.ToString(Convert.ToInt32(score) + Convert.ToInt32(newscore));
            }
        }

        private void radioButton35_CheckedChanged(object sender, EventArgs e)
        {
            radioButton35.ForeColor = Color.Green;
            label13.Text = "✓";
            label13.ForeColor = Color.Green;
            radioButton36.Enabled = false;
            if (radioButton35.Checked)
            {
                newscore++;
                labelScore.Text = Convert.ToString(Convert.ToInt32(score) + Convert.ToInt32(newscore));
            }
        }

        private void radioButton36_CheckedChanged(object sender, EventArgs e)
        {
            radioButton36.ForeColor = Color.Red;
            label13.Text = "subject form";
            label13.ForeColor = Color.Green;
            radioButton35.Enabled = false;
        }

        private void radioButton37_CheckedChanged(object sender, EventArgs e)
        {
            radioButton37.ForeColor = Color.Red;
            label14.Text = "object form";
            label14.ForeColor = Color.Green;
            radioButton38.Enabled = false;
        }

        private void radioButton38_CheckedChanged(object sender, EventArgs e)
        {
            radioButton31.ForeColor = Color.Green;
            label14.Text = "✓";
            label14.ForeColor = Color.Green;
            radioButton32.Enabled = false;
            if (radioButton38.Checked)
            {
                newscore++;
                labelScore.Text = Convert.ToString(Convert.ToInt32(score) + Convert.ToInt32(newscore));
            }
        }

        private void radioButton39_CheckedChanged(object sender, EventArgs e)
        {
            radioButton39.ForeColor = Color.Green;
            label15.Text = "✓";
            label15.ForeColor = Color.Green;
            radioButton38.Enabled = false;
            if (radioButton39.Checked)
            {
                newscore++;
                labelScore.Text = Convert.ToString(Convert.ToInt32(score) + Convert.ToInt32(newscore));
            }
        }

        private void radioButton40_CheckedChanged(object sender, EventArgs e)
        {
            radioButton40.ForeColor = Color.Red;
            label15.Text = "subject form";
            label15.ForeColor = Color.Green;
            radioButton39.Enabled = false;
        }

        private void radioButton41_CheckedChanged(object sender, EventArgs e)
        {
            radioButton41.ForeColor = Color.Red;
            label16.Text = "object form";
            label16.ForeColor = Color.Green;
            radioButton42.Enabled = false;
        }

        private void radioButton42_CheckedChanged(object sender, EventArgs e)
        {
            radioButton42.ForeColor = Color.Green;
            label16.Text = "✓";
            label16.ForeColor = Color.Green;
            radioButton41.Enabled = false;
            if (radioButton42.Checked)
            {
                newscore++;
                labelScore.Text = Convert.ToString(Convert.ToInt32(score) + Convert.ToInt32(newscore));
            }
        }

        private void radioButton43_CheckedChanged(object sender, EventArgs e)
        {
            radioButton43.ForeColor = Color.Green;
            label17.Text = "✓";
            label17.ForeColor = Color.Green;
            radioButton44.Enabled = false;
            if (radioButton43.Checked)
            {
                newscore++;
                labelScore.Text = Convert.ToString(Convert.ToInt32(score) + Convert.ToInt32(newscore));
            }
        }

        private void radioButton44_CheckedChanged(object sender, EventArgs e)
        {
            radioButton44.ForeColor = Color.Red;
            label17.Text = "subject form";
            label17.ForeColor = Color.Green;
            radioButton43.Enabled = false;
        }

        private void radioButton45_CheckedChanged(object sender, EventArgs e)
        {
            radioButton45.ForeColor = Color.Green;
            label18.Text = "✓";
            label18.ForeColor = Color.Green;
            radioButton46.Enabled = false;
            if (radioButton45.Checked)
            {
                newscore++;
                labelScore.Text = Convert.ToString(Convert.ToInt32(score) + Convert.ToInt32(newscore));
            }
        }

        private void radioButton46_CheckedChanged(object sender, EventArgs e)
        {
            radioButton46.ForeColor = Color.Red;
            label18.Text = "subject form";
            label18.ForeColor = Color.Green;
            radioButton45.Enabled = false;
        }

        private void radioButton47_CheckedChanged(object sender, EventArgs e)
        {
            radioButton47.ForeColor = Color.Red;
            label19.Text = "object form";
            label19.ForeColor = Color.Green;
            radioButton48.Enabled = false;
        }

        private void radioButton48_CheckedChanged(object sender, EventArgs e)
        {
            radioButton48.ForeColor = Color.Green;
            label19.Text = "✓";
            label19.ForeColor = Color.Green;
            radioButton47.Enabled = false;
            if (radioButton48.Checked)
            {
                newscore++;
                labelScore.Text = Convert.ToString(Convert.ToInt32(score) + Convert.ToInt32(newscore));
            }
        }

        private void radioButton49_CheckedChanged(object sender, EventArgs e)
        {
            radioButton49.ForeColor = Color.Red;
            label20.Text = "object form";
            label20.ForeColor = Color.Green;
            radioButton50.Enabled = false;
        }

        private void radioButton50_CheckedChanged(object sender, EventArgs e)
        {
            radioButton50.ForeColor = Color.Green;
            label20.Text = "✓";
            label20.ForeColor = Color.Green;
            radioButton49.Enabled = false;
            if (radioButton50.Checked)
            {
                newscore++;
                labelScore.Text = Convert.ToString(Convert.ToInt32(score) + Convert.ToInt32(newscore));
            }
        }

        private void buttonShowAnswer2_Click(object sender, EventArgs e)
        {
            radioButton31.ForeColor = Color.Green;
            radioButton34.ForeColor = Color.Green;
            radioButton35.ForeColor = Color.Green;
            radioButton38.ForeColor = Color.Green;
            radioButton39.ForeColor = Color.Green;
            radioButton42.ForeColor = Color.Green;
            radioButton43.ForeColor = Color.Green;
            radioButton45.ForeColor = Color.Green;
            radioButton48.ForeColor = Color.Green;
            radioButton50.ForeColor = Color.Green;
        }

        private void Pronouns_MouseEnter(object sender, EventArgs e)
        {
            passingText = labelScore.Text;
        }
    }
}
