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
    public partial class NounsCapitalization : Form
    {
        public NounsCapitalization()
        {
            InitializeComponent();
        }

        int score = 0;
        public static string passingText;

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.ForeColor = Color.Red;
            label11.Text = "My birthday is next Friday.";
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
            label11.Text = "My birthday is next Friday.";
            label11.ForeColor = Color.Green;
            radioButton2.Enabled = false;
            radioButton1.Enabled = false;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            radioButton4.ForeColor = Color.Red;
            label12.Text = "He loves Italian food.";
            label12.ForeColor = Color.Green;
            radioButton5.Enabled = false;
            radioButton6.Enabled = false;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            radioButton5.ForeColor = Color.Green;
            label12.Text = "✓";
            label12.ForeColor = Color.Green;
            radioButton4.Enabled = false;
            radioButton6.Enabled = false;
            if (radioButton5.Checked)
            {
                score++;
                labelScore.Text = Convert.ToString(score);
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            radioButton6.ForeColor = Color.Red;
            label12.Text = "He loves Italian food.";
            label12.ForeColor = Color.Green;
            radioButton5.Enabled = false;
            radioButton4.Enabled = false;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            radioButton7.ForeColor = Color.Red;
            label13.Text = "Independence Day is celebrated on July 4.";
            label13.ForeColor = Color.Green;
            radioButton8.Enabled = false;
            radioButton9.Enabled = false;
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            radioButton8.ForeColor = Color.Red;
            label13.Text = "Independence Day is celebrated on July 4.";
            label13.ForeColor = Color.Green;
            radioButton7.Enabled = false;
            radioButton9.Enabled = false;
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            radioButton9.ForeColor = Color.Green;
            label13.Text = "✓";
            label13.ForeColor = Color.Green;
            radioButton7.Enabled = false;
            radioButton8.Enabled = false;
            if (radioButton9.Checked)
            {
                score++;
                labelScore.Text = Convert.ToString(score);
            }
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            radioButton10.ForeColor = Color.Red;
            label14.Text = "Gerry speaks English, French and Spanish.";
            label14.ForeColor = Color.Green;
            radioButton11.Enabled = false;
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            radioButton11.ForeColor = Color.Green;
            label14.Text = "✓";
            label14.ForeColor = Color.Green;
            radioButton10.Enabled = false;
            if (radioButton11.Checked)
            {
                score++;
                labelScore.Text = Convert.ToString(score);
            }
        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            radioButton13.ForeColor = Color.Red;
            label15.Text = "The highest mountain is Mount Everest.";
            label15.ForeColor = Color.Green;
            radioButton14.Enabled = false;
        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            radioButton14.ForeColor = Color.Green;
            label15.Text = "✓";
            label15.ForeColor = Color.Green;
            radioButton13.Enabled = false;
            if (radioButton14.Checked)
            {
                score++;
                labelScore.Text = Convert.ToString(score);
            }
        }

        private void radioButton16_CheckedChanged(object sender, EventArgs e)
        {
            radioButton16.ForeColor = Color.Green;
            label16.Text = "✓";
            label16.ForeColor = Color.Green;
            radioButton17.Enabled = false;
            if (radioButton16.Checked)
            {
                score++;
                labelScore.Text = Convert.ToString(score);
            }
        }

        private void radioButton17_CheckedChanged(object sender, EventArgs e)
        {
            radioButton17.ForeColor = Color.Red;
            label16.Text = "His favourite season is summer.";
            label16.ForeColor = Color.Green;
            radioButton16.Enabled = false;
        }

        private void radioButton19_CheckedChanged(object sender, EventArgs e)
        {
            radioButton19.ForeColor = Color.Red;
            label17.Text = "She lives in London and I live in Paris.";
            label17.ForeColor = Color.Green;
            radioButton20.Enabled = false;
            radioButton21.Enabled = false;
        }

        private void radioButton20_CheckedChanged(object sender, EventArgs e)
        {
            radioButton20.ForeColor = Color.Red;
            label17.Text = "She lives in London and I live in Paris.";
            label17.ForeColor = Color.Green;
            radioButton19.Enabled = false;
            radioButton21.Enabled = false;
        }

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

        private void radioButton22_CheckedChanged(object sender, EventArgs e)
        {
            radioButton22.ForeColor = Color.Red;
            label18.Text = "Do they like Shakespearean sonnets?";
            label18.ForeColor = Color.Green;
            radioButton23.Enabled = false;
            radioButton24.Enabled = false;
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

        private void radioButton24_CheckedChanged(object sender, EventArgs e)
        {
            radioButton24.ForeColor = Color.Red;
            label18.Text = "Do they like Shakespearean sonnets?";
            label18.ForeColor = Color.Green;
            radioButton23.Enabled = false;
            radioButton22.Enabled = false;
        }

        private void radioButton25_CheckedChanged(object sender, EventArgs e)
        {
            radioButton25.ForeColor = Color.Red;
            label19.Text = "The Nobel Prize in Literature was first awarded in 1901.";
            label19.ForeColor = Color.Green;
            radioButton26.Enabled = false;
            radioButton27.Enabled = false;
        }

        private void radioButton26_CheckedChanged(object sender, EventArgs e)
        {
            radioButton26.ForeColor = Color.Red;
            label19.Text = "The Nobel Prize in Literature was first awarded in 1901.";
            label19.ForeColor = Color.Green;
            radioButton25.Enabled = false;
            radioButton27.Enabled = false;
        }

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

        private void radioButton28_CheckedChanged(object sender, EventArgs e)
        {
            radioButton28.ForeColor = Color.Red;
            label20.Text = "We spent our holidays in the South of France and stayed at a nice hotel.";
            label20.ForeColor = Color.Green;
            radioButton29.Enabled = false;
            radioButton30.Enabled = false;
        }

        private void radioButton29_CheckedChanged(object sender, EventArgs e)
        {
            radioButton29.ForeColor = Color.Green;
            label20.Text = "✓";
            label20.ForeColor = Color.Green;
            radioButton28.Enabled = false;
            radioButton30.Enabled = false;
            if (radioButton29.Checked)
            {
                score++;
                labelScore.Text = Convert.ToString(score);
            }
        }

        private void radioButton30_CheckedChanged(object sender, EventArgs e)
        {
            radioButton30.ForeColor = Color.Red;
            label20.Text = "We spent our holidays in the South of France and stayed at a nice hotel.";
            label20.ForeColor = Color.Green;
            radioButton28.Enabled = false;
            radioButton29.Enabled = false;
        }

        private void buttonGoBack2_Click(object sender, EventArgs e)
        {
            GrammarExercises openForm = new GrammarExercises();
            openForm.Show();
            Visible = false;
        }

        private void buttonShowAnswer_Click(object sender, EventArgs e)
        {
            radioButton2.ForeColor = Color.Green;
            radioButton5.ForeColor = Color.Green;
            radioButton9.ForeColor = Color.Green;
            radioButton11.ForeColor = Color.Green;
            radioButton14.ForeColor = Color.Green;
            radioButton16.ForeColor = Color.Green;
            radioButton21.ForeColor = Color.Green;
            radioButton23.ForeColor = Color.Green;
            radioButton27.ForeColor = Color.Green;
            radioButton29.ForeColor = Color.Green;
        }

        private void buttonRepetaExercitiul_Click(object sender, EventArgs e)
        {
            NounsCapitalization openForm = new NounsCapitalization();
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
            NounsApostrophe nounsApostrophe = new NounsApostrophe();
            nounsApostrophe.Show();
        }

        private void buttonExercitiulUrmator_Click(object sender, EventArgs e)
        {
            this.Close();
            WordOrderInPassive wordOrderInPassive = new WordOrderInPassive();
            wordOrderInPassive.Show();
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
            radioButton13.Visible = false;
            radioButton14.Visible = false;
            radioButton16.Visible = false;
            radioButton17.Visible = false;
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

            radioButton12.Visible = true;
            radioButton15.Visible = true;
            radioButton18.Visible = true;
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

            radioButton12.Text = "The coldest winter month is January.";
            radioButton15.Text = "The coldest Winter month is January.";
            radioButton18.Text = "The coldest winter month is january.";
            radioButton31.Text = "My parents are Engineers.";
            radioButton32.Text = "My Parents are Engineers.";
            radioButton33.Text = "My parents are engineers.";
            radioButton34.Text = "Germany has many Turkish people.";
            radioButton35.Text = "Germany has many turkish people.";
            radioButton36.Text = "Germany has many Turkish People.";
            radioButton37.Text = "Christians believe there is only one god.";
            radioButton38.Text = "Christians believe there is only One God.";
            radioButton39.Text = "Christians believe there is only one God.";
            radioButton40.Text = "The Romans are an ancient people.";
            radioButton41.Text = "The romans are an ancient people.";
            radioButton42.Text = "The Romans are an Ancient People.";
            radioButton43.Text = "The Empire of Rome gets its name from the city of Rome.";
            radioButton44.Text = "The empire of Rome gets its name from the city of Rome.";
            radioButton45.Text = "The Empire of Rome gets its name from the City of Rome.";
            radioButton46.Text = "British english is learned in many european countries.";
            radioButton47.Text = "British English is learned in many european countries.";
            radioButton48.Text = "British English is learned in many European countries.";
            radioButton49.Text = "A bachelor's degree is obtained in 4 years.";
            radioButton50.Text = "A Bachelor's degree is obtained in 4 years.";
            radioButton51.Text = "A Bachelor's Degree is obtained in 4 years.";
            radioButton52.Text = "The furthest planet from the sun is neptune.";
            radioButton53.Text = "The furthest planet from the Sun is Neptune.";
            radioButton54.Text = "The furthest planet from the sun is Neptune.";
            radioButton55.Text = "The ancient greeks believed in many gods.";
            radioButton56.Text = "The ancient Greeks believed in many gods.";
            radioButton57.Text = "The ancient Greeks believed in many Gods.";

            string fileName = "XMLSubstantiveScriereaCuLiteraMare.xml";
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

        private void NounsCapitalization_Load(object sender, EventArgs e)
        {
            radioButton12.Visible = false;
            radioButton15.Visible = false;
            radioButton18.Visible = false;
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
        }


        private void buttonShowAnswer2_Click(object sender, EventArgs e)
        {
            radioButton12.ForeColor = Color.Green;
            radioButton33.ForeColor = Color.Green;
            radioButton35.ForeColor = Color.Green;
            radioButton39.ForeColor = Color.Green;
            radioButton41.ForeColor = Color.Green;
            radioButton43.ForeColor = Color.Green;
            radioButton48.ForeColor = Color.Green;
            radioButton49.ForeColor = Color.Green;
            radioButton53.ForeColor = Color.Green;
            radioButton56.ForeColor = Color.Green;
        }

        int newscore = 0;

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            radioButton12.ForeColor = Color.Green;
            label11.Text = "✓";
            label11.ForeColor = Color.Green;
            radioButton15.Enabled = false;
            radioButton18.Enabled = false;
            if (radioButton12.Checked)
            {
                newscore++;
                labelScore.Text = Convert.ToString(Convert.ToInt32(score) + Convert.ToInt32(newscore));
            }
        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {
            radioButton15.ForeColor = Color.Red;
            label11.Text = "The coldest winter month is January.";
            label11.ForeColor = Color.Green;
            radioButton12.Enabled = false;
            radioButton18.Enabled = false;
        }

        private void radioButton18_CheckedChanged(object sender, EventArgs e)
        {
            radioButton18.ForeColor = Color.Red;
            label11.Text = "The coldest winter month is January.";
            label11.ForeColor = Color.Green;
            radioButton12.Enabled = false;
            radioButton15.Enabled = false;
        }

        private void radioButton33_CheckedChanged(object sender, EventArgs e)
        {
            radioButton33.ForeColor = Color.Green;
            label12.Text = "✓";
            label12.ForeColor = Color.Green;
            radioButton31.Enabled = false;
            radioButton32.Enabled = false;
            if (radioButton33.Checked)
            {
                newscore++;
                labelScore.Text = Convert.ToString(Convert.ToInt32(score) + Convert.ToInt32(newscore));
            }
        }

        private void radioButton32_CheckedChanged(object sender, EventArgs e)
        {
            radioButton32.ForeColor = Color.Red;
            label12.Text = "My parents are engineers.";
            label12.ForeColor = Color.Green;
            radioButton31.Enabled = false;
            radioButton33.Enabled = false;
        }

        private void radioButton31_CheckedChanged(object sender, EventArgs e)
        {
            radioButton31.ForeColor = Color.Red;
            label12.Text = "My parents are engineers.";
            label12.ForeColor = Color.Green;
            radioButton32.Enabled = false;
            radioButton33.Enabled = false;
        }

        private void radioButton36_CheckedChanged(object sender, EventArgs e)
        {
            radioButton36.ForeColor = Color.Red;
            label13.Text = "Germany has many turkish people.";
            label13.ForeColor = Color.Green;
            radioButton34.Enabled = false;
            radioButton35.Enabled = false;
        }

        private void radioButton35_CheckedChanged(object sender, EventArgs e)
        {
            radioButton35.ForeColor = Color.Green;
            label13.Text = "✓";
            label13.ForeColor = Color.Green;
            radioButton34.Enabled = false;
            radioButton36.Enabled = false;
            if (radioButton35.Checked)
            {
                newscore++;
                labelScore.Text = Convert.ToString(Convert.ToInt32(score) + Convert.ToInt32(newscore));
            }
        }

        private void radioButton34_CheckedChanged(object sender, EventArgs e)
        {
            radioButton34.ForeColor = Color.Red;
            label13.Text = "Germany has many turkish people.";
            label13.ForeColor = Color.Green;
            radioButton35.Enabled = false;
            radioButton36.Enabled = false;
        }

        private void radioButton39_CheckedChanged(object sender, EventArgs e)
        {
            radioButton39.ForeColor = Color.Green;
            label14.Text = "✓";
            label14.ForeColor = Color.Green;
            radioButton37.Enabled = false;
            radioButton38.Enabled = false;
            if (radioButton39.Checked)
            {
                newscore++;
                labelScore.Text = Convert.ToString(Convert.ToInt32(score) + Convert.ToInt32(newscore));
            }
        }

        private void radioButton38_CheckedChanged(object sender, EventArgs e)
        {
            radioButton38.ForeColor = Color.Red;
            label14.Text = "Christians believe there is only one God.";
            label14.ForeColor = Color.Green;
            radioButton37.Enabled = false;
            radioButton39.Enabled = false;
        }

        private void radioButton37_CheckedChanged(object sender, EventArgs e)
        {
            radioButton37.ForeColor = Color.Red;
            label14.Text = "Christians believe there is only one God.";
            label14.ForeColor = Color.Green;
            radioButton38.Enabled = false;
            radioButton39.Enabled = false;
        }

        private void radioButton42_CheckedChanged(object sender, EventArgs e)
        {
            radioButton42.ForeColor = Color.Red;
            label15.Text = "The romans are an ancient people.";
            label15.ForeColor = Color.Green;
            radioButton40.Enabled = false;
            radioButton41.Enabled = false;
        }

        private void radioButton41_CheckedChanged(object sender, EventArgs e)
        {
            radioButton41.ForeColor = Color.Green;
            label15.Text = "✓";
            label15.ForeColor = Color.Green;
            radioButton40.Enabled = false;
            radioButton42.Enabled = false;
            if (radioButton41.Checked)
            {
                newscore++;
                labelScore.Text = Convert.ToString(Convert.ToInt32(score) + Convert.ToInt32(newscore));
            }
        }

        private void radioButton40_CheckedChanged(object sender, EventArgs e)
        {
            radioButton40.ForeColor = Color.Red;
            label15.Text = "The romans are an ancient people.";
            label15.ForeColor = Color.Green;
            radioButton41.Enabled = false;
            radioButton42.Enabled = false;
        }

        private void radioButton45_CheckedChanged(object sender, EventArgs e)
        {
            radioButton45.ForeColor = Color.Red;
            label16.Text = "The Empire of Rome gets its name from the city of Rome.";
            label16.ForeColor = Color.Green;
            radioButton43.Enabled = false;
            radioButton44.Enabled = false;
        }

        private void radioButton44_CheckedChanged(object sender, EventArgs e)
        {
            radioButton44.ForeColor = Color.Red;
            label16.Text = "The Empire of Rome gets its name from the city of Rome.";
            label16.ForeColor = Color.Green;
            radioButton43.Enabled = false;
            radioButton45.Enabled = false;
        }

        private void radioButton43_CheckedChanged(object sender, EventArgs e)
        {
            radioButton43.ForeColor = Color.Green;
            label16.Text = "✓";
            label16.ForeColor = Color.Green;
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
            radioButton48.ForeColor = Color.Green;
            label17.Text = "✓";
            label17.ForeColor = Color.Green;
            radioButton46.Enabled = false;
            radioButton47.Enabled = false;
            if (radioButton48.Checked)
            {
                newscore++;
                labelScore.Text = Convert.ToString(Convert.ToInt32(score) + Convert.ToInt32(newscore));
            }
        }

        private void radioButton47_CheckedChanged(object sender, EventArgs e)
        {
            radioButton47.ForeColor = Color.Red;
            label17.Text = "British English is learned in many European countries.";
            label17.ForeColor = Color.Green;
            radioButton46.Enabled = false;
            radioButton48.Enabled = false;
        }

        private void radioButton46_CheckedChanged(object sender, EventArgs e)
        {
            radioButton46.ForeColor = Color.Red;
            label17.Text = "British English is learned in many European countries.";
            label17.ForeColor = Color.Green;
            radioButton47.Enabled = false;
            radioButton48.Enabled = false;
        }

        private void radioButton51_CheckedChanged(object sender, EventArgs e)
        {
            radioButton51.ForeColor = Color.Red;
            label18.Text = "A bachelor's degree is obtained in 4 years.";
            label18.ForeColor = Color.Green;
            radioButton49.Enabled = false;
            radioButton50.Enabled = false;
        }

        private void radioButton50_CheckedChanged(object sender, EventArgs e)
        {
            radioButton50.ForeColor = Color.Red;
            label18.Text = "A bachelor's degree is obtained in 4 years.";
            label18.ForeColor = Color.Green;
            radioButton49.Enabled = false;
            radioButton51.Enabled = false;
        }

        private void radioButton49_CheckedChanged(object sender, EventArgs e)
        {
            radioButton49.ForeColor = Color.Green;
            label18.Text = "✓";
            label18.ForeColor = Color.Green;
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
            label19.Text = "The furthest planet from the Sun is Neptune.";
            label19.ForeColor = Color.Green;
            radioButton52.Enabled = false;
            radioButton53.Enabled = false;
        }

        private void radioButton53_CheckedChanged(object sender, EventArgs e)
        {
            radioButton53.ForeColor = Color.Green;
            label19.Text = "✓";
            label19.ForeColor = Color.Green;
            radioButton52.Enabled = false;
            radioButton54.Enabled = false;
            if (radioButton53.Checked)
            {
                newscore++;
                labelScore.Text = Convert.ToString(Convert.ToInt32(score) + Convert.ToInt32(newscore));
            }
        }

        private void radioButton52_CheckedChanged(object sender, EventArgs e)
        {
            radioButton52.ForeColor = Color.Red;
            label19.Text = "The furthest planet from the Sun is Neptune.";
            label19.ForeColor = Color.Green;
            radioButton53.Enabled = false;
            radioButton54.Enabled = false;
        }

        private void radioButton57_CheckedChanged(object sender, EventArgs e)
        {
            radioButton57.ForeColor = Color.Red;
            label20.Text = "The ancient Greeks believed in many gods.";
            label20.ForeColor = Color.Green;
            radioButton55.Enabled = false;
            radioButton56.Enabled = false;
        }

        private void radioButton56_CheckedChanged(object sender, EventArgs e)
        {
            radioButton56.ForeColor = Color.Green;
            label20.Text = "✓";
            label20.ForeColor = Color.Green;
            radioButton55.Enabled = false;
            radioButton57.Enabled = false;
            if (radioButton56.Checked)
            {
                newscore++;
                labelScore.Text = Convert.ToString(Convert.ToInt32(score) + Convert.ToInt32(newscore));
            }
        }

        private void radioButton55_CheckedChanged(object sender, EventArgs e)
        {
            radioButton55.ForeColor = Color.Red;
            label20.Text = "The ancient Greeks believed in many gods.";
            label20.ForeColor = Color.Green;
            radioButton56.Enabled = false;
            radioButton57.Enabled = false;
        }

        private void NounsCapitalization_MouseEnter(object sender, EventArgs e)
        {
            passingText = labelScore.Text;
        }
    }
}
