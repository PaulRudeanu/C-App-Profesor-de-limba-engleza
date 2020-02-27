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
    public partial class ConditionalSentences : Form
    {
        public ConditionalSentences()
        {
            InitializeComponent();
        }

        int score = 0;
        public static string passingText;

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.ForeColor = Color.Green;
            label11.Text = "✓";
            label11.ForeColor = Color.Green;
            radioButton2.Enabled = false;
            radioButton3.Enabled = false;
            if(radioButton1.Checked)
            {
                score++;
                labelScore.Text = Convert.ToString(score);
            }       
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radioButton2.ForeColor = Color.Red;
            label11.Text = "type I (probable condition)";
            label11.ForeColor = Color.Green;
            radioButton1.Enabled = false;
            radioButton3.Enabled = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            radioButton3.ForeColor = Color.Red;
            label11.Text = "type I (probable condition)";
            label11.ForeColor = Color.Green;
            radioButton2.Enabled = false;
            radioButton1.Enabled = false;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            radioButton6.ForeColor = Color.Red;
            label12.Text = "type III (impossible condition)";
            label12.ForeColor = Color.Green;
            radioButton5.Enabled = false;
            radioButton4.Enabled = false;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            radioButton5.ForeColor = Color.Red;
            label12.Text = "type III (impossible condition)";
            label12.ForeColor = Color.Green;
            radioButton4.Enabled = false;
            radioButton6.Enabled = false;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            radioButton4.ForeColor = Color.Green;
            label12.Text = "✓";
            label12.ForeColor = Color.Green;
            radioButton5.Enabled = false;
            radioButton6.Enabled = false;
            if (radioButton4.Checked)
            {
                score++;
                labelScore.Text = Convert.ToString(score);
            }
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            radioButton9.ForeColor = Color.Red;
            label13.Text = "type II (improbable condition)";
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
            label13.Text = "type II (improbable condition)";
            label13.ForeColor = Color.Green;
            radioButton8.Enabled = false;
            radioButton9.Enabled = false;
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            radioButton12.ForeColor = Color.Red;
            label14.Text = "type II (improbable condition)";
            label14.ForeColor = Color.Green;
            radioButton11.Enabled = false;
            radioButton10.Enabled = false;
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            radioButton11.ForeColor = Color.Green;
            label14.Text = "✓";
            label14.ForeColor = Color.Green;
            radioButton12.Enabled = false;
            radioButton10.Enabled = false;
            if (radioButton11.Checked)
            {
                score++;
                labelScore.Text = Convert.ToString(score);
            }
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            radioButton10.ForeColor = Color.Red;
            label14.Text = "type II (improbable condition)";
            label14.ForeColor = Color.Green;
            radioButton11.Enabled = false;
            radioButton12.Enabled = false;
        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {
            radioButton15.ForeColor = Color.Green;
            label15.Text = "✓";
            label15.ForeColor = Color.Green;
            radioButton13.Enabled = false;
            radioButton14.Enabled = false;
            if (radioButton15.Checked)
            {
                score++;
                labelScore.Text = Convert.ToString(score);
            }
        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            radioButton14.ForeColor = Color.Red;
            label15.Text = "type I (probable condition)";
            label15.ForeColor = Color.Green;
            radioButton15.Enabled = false;
            radioButton13.Enabled = false;
        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            radioButton13.ForeColor = Color.Red;
            label15.Text = "type I (probable condition)";
            label15.ForeColor = Color.Green;
            radioButton14.Enabled = false;
            radioButton15.Enabled = false;
        }

        private void radioButton18_CheckedChanged(object sender, EventArgs e)
        {
            radioButton18.ForeColor = Color.Red;
            label16.Text = "type II (improbable condition)";
            label16.ForeColor = Color.Green;
            radioButton16.Enabled = false;
            radioButton17.Enabled = false;
        }

        private void radioButton17_CheckedChanged(object sender, EventArgs e)
        {
            radioButton17.ForeColor = Color.Green;
            label16.Text = "✓";
            label16.ForeColor = Color.Green;
            radioButton16.Enabled = false;
            radioButton18.Enabled = false;
            if (radioButton17.Checked)
            {
                score++;
                labelScore.Text = Convert.ToString(score);
            }
        }

        private void radioButton16_CheckedChanged(object sender, EventArgs e)
        {
            radioButton16.ForeColor = Color.Red;
            label16.Text = "type II (improbable condition)";
            label16.ForeColor = Color.Green;
            radioButton17.Enabled = false;
            radioButton18.Enabled = false;
        }

        private void radioButton21_CheckedChanged(object sender, EventArgs e)
        {
            radioButton21.ForeColor = Color.Red;
            label17.Text = "type III (impossible condition)";
            label17.ForeColor = Color.Green;
            radioButton20.Enabled = false;
            radioButton19.Enabled = false;
        }

        private void radioButton20_CheckedChanged(object sender, EventArgs e)
        {
            radioButton20.ForeColor = Color.Red;
            label17.Text = "type III (impossible condition)";
            label17.ForeColor = Color.Green;
            radioButton21.Enabled = false;
            radioButton19.Enabled = false;
        }

        private void radioButton19_CheckedChanged(object sender, EventArgs e)
        {
            radioButton19.ForeColor = Color.Green;
            label17.Text = "✓";
            label17.ForeColor = Color.Green;
            radioButton20.Enabled = false;
            radioButton21.Enabled = false;
            if (radioButton19.Checked)
            {
                score++;
                labelScore.Text = Convert.ToString(score);
            }
        }

        private void radioButton24_CheckedChanged(object sender, EventArgs e)
        {
            radioButton24.ForeColor = Color.Red;
            label18.Text = "type II (improbable condition)";
            label18.ForeColor = Color.Green;
            radioButton23.Enabled = false;
            radioButton22.Enabled = false;
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
            label18.Text = "type II (improbable condition)";
            label18.ForeColor = Color.Green;
            radioButton24.Enabled = false;
            radioButton23.Enabled = false;
        }

        private void radioButton27_CheckedChanged(object sender, EventArgs e)
        {
            radioButton27.ForeColor = Color.Red;
            label19.Text = "type II (improbable condition)";
            label19.ForeColor = Color.Green;
            radioButton26.Enabled = false;
            radioButton25.Enabled = false;
        }

        private void radioButton26_CheckedChanged(object sender, EventArgs e)
        {
            radioButton26.ForeColor = Color.Green;
            label19.Text = "✓";
            label19.ForeColor = Color.Green;
            radioButton25.Enabled = false;
            radioButton27.Enabled = false;
            if (radioButton26.Checked)
            {
                score++;
                labelScore.Text = Convert.ToString(score);
            }
        }

        private void radioButton25_CheckedChanged(object sender, EventArgs e)
        {
            radioButton25.ForeColor = Color.Red;
            label19.Text = "type II (improbable condition)";
            label19.ForeColor = Color.Green;
            radioButton26.Enabled = false;
            radioButton27.Enabled = false;
        }

        private void radioButton30_CheckedChanged(object sender, EventArgs e)
        {
            radioButton30.ForeColor = Color.Red;
            label20.Text = "type III (impossible condition)";
            label20.ForeColor = Color.Green;
            radioButton29.Enabled = false;
            radioButton28.Enabled = false;
        }

        private void radioButton29_CheckedChanged(object sender, EventArgs e)
        {
            radioButton29.ForeColor = Color.Red;
            label20.Text = "type III (impossible condition)";
            label20.ForeColor = Color.Green;
            radioButton28.Enabled = false;
            radioButton30.Enabled = false;
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


        private void buttonGoBack2_Click(object sender, EventArgs e)
        {
            GrammarExercises openForm = new GrammarExercises();
            openForm.Show();
            Visible = false;
        }

        private void buttonShowAnswer_Click(object sender, EventArgs e)
        {
            radioButton1.ForeColor = Color.Green;
            radioButton4.ForeColor = Color.Green;
            radioButton8.ForeColor = Color.Green;
            radioButton11.ForeColor = Color.Green;
            radioButton15.ForeColor = Color.Green;
            radioButton17.ForeColor = Color.Green;
            radioButton19.ForeColor = Color.Green;
            radioButton23.ForeColor = Color.Green;
            radioButton26.ForeColor = Color.Green;
            radioButton28.ForeColor = Color.Green;
        }

        private void buttonRepetaExercitiul_Click(object sender, EventArgs e)
        {
            ConditionalSentences openForm = new ConditionalSentences();
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

        private void buttonExercitiulUrmator_Click(object sender, EventArgs e)
        {
            this.Close();
            GerundAndInfinitive gerundAndInfinitive = new GerundAndInfinitive();
            gerundAndInfinitive.Show();
        }

        private void buttonExercitiulAnterior_Click(object sender, EventArgs e)
        {
            this.Close();
            Articles articole = new Articles();
            articole.Show();
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
            buttonShowAnswer.Hide();
            buttonShowAnswer2.Show();
            buttonNewExercise.Hide();

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

            radioButton1.Visible = false;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            radioButton4.Visible = false;
            radioButton5.Visible = false;
            radioButton6.Visible = false;
            radioButton7.Visible = false;
            radioButton8.Visible = false;
            radioButton9.Visible = false;
            radioButton10.Visible = false;
            radioButton11.Visible = false;
            radioButton12.Visible = false;
            radioButton13.Visible = false;
            radioButton14.Visible = false;
            radioButton15.Visible = false;
            radioButton16.Visible = false;
            radioButton17.Visible = false;
            radioButton18.Visible = false;
            radioButton19.Visible = false;
            radioButton20.Visible = false;
            radioButton21.Visible = false;
            radioButton22.Visible = false;
            radioButton23.Visible = false;
            radioButton24.Visible = false;
            radioButton25.Visible = false;
            radioButton26.Visible = false;
            radioButton27.Visible = false;
            radioButton28.Visible = false;
            radioButton29.Visible = false;
            radioButton30.Visible = false;

            radioButton31.Visible = true;
            radioButton32.Visible = true;
            radioButton33.Visible = true;
            radioButton34.Visible = true;
            radioButton35.Visible = true;
            radioButton36.Visible = true;
            radioButton37.Visible = true;
            radioButton38.Visible = true;
            radioButton39.Visible = true;
            radioButton40.Visible = true;
            radioButton41.Visible = true;
            radioButton42.Visible = true;
            radioButton43.Visible = true;
            radioButton44.Visible = true;
            radioButton45.Visible = true;
            radioButton46.Visible = true;
            radioButton47.Visible = true;
            radioButton48.Visible = true;
            radioButton49.Visible = true;
            radioButton50.Visible = true;
            radioButton51.Visible = true;
            radioButton52.Visible = true;
            radioButton53.Visible = true;
            radioButton54.Visible = true;
            radioButton55.Visible = true;
            radioButton56.Visible = true;
            radioButton57.Visible = true;
            radioButton58.Visible = true;
            radioButton59.Visible = true;
            radioButton60.Visible = true;


            string fileName = "XMLPropozitiiConditionale.xml";
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

        private void ConditionalSentences_Load(object sender, EventArgs e)
        {
            radioButton31.Visible = false;
            radioButton32.Visible = false;
            radioButton33.Visible = false;
            radioButton34.Visible = false;
            radioButton35.Visible = false;
            radioButton36.Visible = false;
            radioButton37.Visible = false;
            radioButton38.Visible = false;
            radioButton39.Visible = false;
            radioButton40.Visible = false;
            radioButton41.Visible = false;
            radioButton42.Visible = false;
            radioButton43.Visible = false;
            radioButton44.Visible = false;
            radioButton45.Visible = false;
            radioButton46.Visible = false;
            radioButton47.Visible = false;
            radioButton48.Visible = false;
            radioButton49.Visible = false;
            radioButton50.Visible = false;
            radioButton51.Visible = false;
            radioButton52.Visible = false;
            radioButton53.Visible = false;
            radioButton54.Visible = false;
            radioButton55.Visible = false;
            radioButton56.Visible = false;
            radioButton57.Visible = false;
            radioButton58.Visible = false;
            radioButton59.Visible = false;
            radioButton60.Visible = false;
        }

        int newscore = 0;

        private void radioButton33_CheckedChanged(object sender, EventArgs e)
        {
            radioButton33.ForeColor = Color.Red;
            label11.Text = "type 2 (improbable condition)";
            label11.ForeColor = Color.Green;
            radioButton31.Enabled = false;
            radioButton32.Enabled = false;
        }

        private void radioButton32_CheckedChanged(object sender, EventArgs e)
        {
            radioButton32.ForeColor = Color.Green;
            label11.Text = "✓";
            label11.ForeColor = Color.Green;
            radioButton31.Enabled = false;
            radioButton33.Enabled = false;
            if (radioButton32.Checked)
            {
                newscore++;
                labelScore.Text = Convert.ToString(Convert.ToInt32(score) + Convert.ToInt32(newscore));
            }
        }

        private void radioButton31_CheckedChanged(object sender, EventArgs e)
        {
            radioButton31.ForeColor = Color.Red;
            label11.Text = "type 2 (improbable condition)";
            label11.ForeColor = Color.Green;
            radioButton32.Enabled = false;
            radioButton33.Enabled = false;
        }

        private void radioButton36_CheckedChanged(object sender, EventArgs e)
        {
            radioButton36.ForeColor = Color.Red;
            label12.Text = "type 3 (impossible condition)";
            label12.ForeColor = Color.Green;
            radioButton34.Enabled = false;
            radioButton35.Enabled = false;
        }

        private void radioButton35_CheckedChanged(object sender, EventArgs e)
        {
            radioButton35.ForeColor = Color.Red;
            label12.Text = "type 3 (impossible condition)";
            label12.ForeColor = Color.Green;
            radioButton34.Enabled = false;
            radioButton36.Enabled = false;
        }

        private void radioButton34_CheckedChanged(object sender, EventArgs e)
        {
            radioButton34.ForeColor = Color.Green;
            label12.Text = "✓";
            label12.ForeColor = Color.Green;
            radioButton35.Enabled = false;
            radioButton36.Enabled = false;
            if (radioButton34.Checked)
            {
                newscore++;
                labelScore.Text = Convert.ToString(Convert.ToInt32(score) + Convert.ToInt32(newscore));
            }
        }

        private void radioButton39_CheckedChanged(object sender, EventArgs e)
        {
            radioButton39.ForeColor = Color.Red;
            label13.Text = "type 2 (improbable condition)";
            label13.ForeColor = Color.Green;
            radioButton37.Enabled = false;
            radioButton38.Enabled = false;
        }

        private void radioButton38_CheckedChanged(object sender, EventArgs e)
        {
            radioButton38.ForeColor = Color.Green;
            label13.Text = "✓";
            label13.ForeColor = Color.Green;
            radioButton37.Enabled = false;
            radioButton39.Enabled = false;
            if (radioButton38.Checked)
            {
                newscore++;
                labelScore.Text = Convert.ToString(Convert.ToInt32(score) + Convert.ToInt32(newscore));
            }
        }

        private void radioButton37_CheckedChanged(object sender, EventArgs e)
        {
            radioButton37.ForeColor = Color.Red;
            label13.Text = "type 2 (improbable condition)";
            label13.ForeColor = Color.Green;
            radioButton38.Enabled = false;
            radioButton39.Enabled = false;
        }

        private void radioButton42_CheckedChanged(object sender, EventArgs e)
        {
            radioButton42.ForeColor = Color.Red;
            label14.Text = "type 3 (impossible condition)";
            label14.ForeColor = Color.Green;
            radioButton40.Enabled = false;
            radioButton41.Enabled = false;
        }

        private void radioButton41_CheckedChanged(object sender, EventArgs e)
        {
            radioButton41.ForeColor = Color.Red;
            label14.Text = "type 3 (impossible condition)";
            label14.ForeColor = Color.Green;
            radioButton40.Enabled = false;
            radioButton42.Enabled = false;
        }

        private void radioButton40_CheckedChanged(object sender, EventArgs e)
        {
            radioButton40.ForeColor = Color.Green;
            label14.Text = "✓";
            label14.ForeColor = Color.Green;
            radioButton41.Enabled = false;
            radioButton42.Enabled = false;
            if (radioButton40.Checked)
            {
                newscore++;
                labelScore.Text = Convert.ToString(Convert.ToInt32(score) + Convert.ToInt32(newscore));
            }
        }

        private void radioButton45_CheckedChanged(object sender, EventArgs e)
        {
            radioButton45.ForeColor = Color.Red;
            label15.Text = "type 3 (impossible condition)";
            label15.ForeColor = Color.Green;
            radioButton43.Enabled = false;
            radioButton44.Enabled = false;
        }

        private void radioButton44_CheckedChanged(object sender, EventArgs e)
        {
            radioButton44.ForeColor = Color.Red;
            label15.Text = "type 3 (impossible condition)";
            label15.ForeColor = Color.Green;
            radioButton43.Enabled = false;
            radioButton45.Enabled = false;
        }

        private void radioButton43_CheckedChanged(object sender, EventArgs e)
        {
            radioButton43.ForeColor = Color.Green;
            label15.Text = "✓";
            label15.ForeColor = Color.Green;
            radioButton44.Enabled = false;
            radioButton45.Enabled = false;
            if (radioButton43.Checked)
            {
                newscore++;
                labelScore.Text = Convert.ToString(Convert.ToInt32(score) + Convert.ToInt32(newscore));
            }
        }

        private void radioButton48_CheckedChanged(object sender, EventArgs e)
        {
            radioButton48.ForeColor = Color.Red;
            label16.Text = "type 2 (improbable condition)";
            label16.ForeColor = Color.Green;
            radioButton46.Enabled = false;
            radioButton47.Enabled = false;
        }

        private void radioButton47_CheckedChanged(object sender, EventArgs e)
        {
            radioButton47.ForeColor = Color.Green;
            label16.Text = "✓";
            label16.ForeColor = Color.Green;
            radioButton46.Enabled = false;
            radioButton48.Enabled = false;
            if (radioButton47.Checked)
            {
                newscore++;
                labelScore.Text = Convert.ToString(Convert.ToInt32(score) + Convert.ToInt32(newscore));
            }
        }

        private void radioButton46_CheckedChanged(object sender, EventArgs e)
        {
            radioButton46.ForeColor = Color.Red;
            label16.Text = "type 2 (improbable condition)";
            label16.ForeColor = Color.Green;
            radioButton47.Enabled = false;
            radioButton48.Enabled = false;
        }

        private void radioButton51_CheckedChanged(object sender, EventArgs e)
        {
            radioButton51.ForeColor = Color.Red;
            label17.Text = "type 3 (impossible condition)";
            label17.ForeColor = Color.Green;
            radioButton49.Enabled = false;
            radioButton50.Enabled = false;
        }

        private void radioButton50_CheckedChanged(object sender, EventArgs e)
        {
            radioButton50.ForeColor = Color.Red;
            label17.Text = "type 3 (impossible condition)";
            label17.ForeColor = Color.Green;
            radioButton49.Enabled = false;
            radioButton51.Enabled = false;
        }

        private void radioButton49_CheckedChanged(object sender, EventArgs e)
        {
            radioButton49.ForeColor = Color.Green;
            label17.Text = "✓";
            label17.ForeColor = Color.Green;
            radioButton50.Enabled = false;
            radioButton51.Enabled = false;
            if (radioButton49.Checked)
            {
                newscore++;
                labelScore.Text = Convert.ToString(Convert.ToInt32(score) + Convert.ToInt32(newscore));
            }
        }

        private void radioButton54_CheckedChanged(object sender, EventArgs e)
        {
            radioButton54.ForeColor = Color.Red;
            label18.Text = "type 3 (impossible condition)";
            label18.ForeColor = Color.Green;
            radioButton52.Enabled = false;
            radioButton53.Enabled = false;
        }

        private void radioButton53_CheckedChanged(object sender, EventArgs e)
        {
            radioButton53.ForeColor = Color.Red;
            label18.Text = "type 3 (impossible condition)";
            label18.ForeColor = Color.Green;
            radioButton52.Enabled = false;
            radioButton54.Enabled = false;
        }

        private void radioButton52_CheckedChanged(object sender, EventArgs e)
        {
            radioButton52.ForeColor = Color.Green;
            label18.Text = "✓";
            label18.ForeColor = Color.Green;
            radioButton53.Enabled = false;
            radioButton54.Enabled = false;
            if (radioButton52.Checked)
            {
                newscore++;
                labelScore.Text = Convert.ToString(Convert.ToInt32(score) + Convert.ToInt32(newscore));
            }
        }

        private void radioButton57_CheckedChanged(object sender, EventArgs e)
        {
            radioButton57.ForeColor = Color.Green;
            label19.Text = "✓";
            label19.ForeColor = Color.Green;
            radioButton55.Enabled = false;
            radioButton56.Enabled = false;
            if (radioButton57.Checked)
            {
                newscore++;
                labelScore.Text = Convert.ToString(Convert.ToInt32(score) + Convert.ToInt32(newscore));
            }
        }

        private void radioButton56_CheckedChanged(object sender, EventArgs e)
        {
            radioButton56.ForeColor = Color.Red;
            label19.Text = "type 1 (probable condition)";
            label19.ForeColor = Color.Green;
            radioButton55.Enabled = false;
            radioButton57.Enabled = false;
        }

        private void radioButton55_CheckedChanged(object sender, EventArgs e)
        {
            radioButton55.ForeColor = Color.Red;
            label19.Text = "type 1 (probable condition)";
            label19.ForeColor = Color.Green;
            radioButton56.Enabled = false;
            radioButton57.Enabled = false;
        }

        private void radioButton60_CheckedChanged(object sender, EventArgs e)
        {
            radioButton60.ForeColor = Color.Red;
            label20.Text = "type 3 (impossible condition)";
            label20.ForeColor = Color.Green;
            radioButton58.Enabled = false;
            radioButton59.Enabled = false;
        }

        private void radioButton59_CheckedChanged(object sender, EventArgs e)
        {
            radioButton59.ForeColor = Color.Red;
            label20.Text = "type 3 (impossible condition)";
            label20.ForeColor = Color.Green;
            radioButton58.Enabled = false;
            radioButton60.Enabled = false;
        }

        private void radioButton58_CheckedChanged(object sender, EventArgs e)
        {
            radioButton58.ForeColor = Color.Green;
            label20.Text = "✓";
            label20.ForeColor = Color.Green;
            radioButton59.Enabled = false;
            radioButton60.Enabled = false;
            if (radioButton58.Checked)
            {
                newscore++;
                labelScore.Text = Convert.ToString(Convert.ToInt32(score) + Convert.ToInt32(newscore));
            }
        }

        private void buttonShowAnswer2_Click(object sender, EventArgs e)
        {
            radioButton32.ForeColor = Color.Green;
            radioButton34.ForeColor = Color.Green;
            radioButton38.ForeColor = Color.Green;
            radioButton40.ForeColor = Color.Green;
            radioButton43.ForeColor = Color.Green;
            radioButton47.ForeColor = Color.Green;
            radioButton49.ForeColor = Color.Green;
            radioButton52.ForeColor = Color.Green;
            radioButton57.ForeColor = Color.Green;
            radioButton58.ForeColor = Color.Green;
        }

        private void ConditionalSentences_MouseEnter(object sender, EventArgs e)
        {
            passingText = labelScore.Text;
        }
    }
}
