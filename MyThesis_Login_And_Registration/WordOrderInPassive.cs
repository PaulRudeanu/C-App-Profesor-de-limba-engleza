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
    public partial class WordOrderInPassive : Form
    {
        public WordOrderInPassive()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += " these toys";
            button1.ForeColor = Color.Black;
            button1.Text = " t̶h̶e̶s̶e̶ ̶t̶o̶y̶s̶";
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += " made";
            button2.ForeColor = Color.Black;
            button2.Text = " m̶a̶d̶e̶";
            button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += " from plastic";
            button3.ForeColor = Color.Black;
            button3.Text = " f̶r̶o̶m̶ p̶l̶a̶s̶t̶i̶c̶";
            button3.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += " are";
            button4.ForeColor = Color.Black;
            button4.Text = " a̶r̶e̶";
            button4.Enabled = false;
        }

        private void button44_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            button1.Text = " these toys";
            button1.ForeColor = Color.White;
            button2.Text = " made";
            button2.ForeColor = Color.White;
            button3.Text = " from plastic";
            button3.ForeColor = Color.White;
            button4.Text = " are";
            button4.ForeColor = Color.White;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox2.Text += " the doors";
            button5.ForeColor = Color.Black;
            button5.Text = " t̶h̶e̶ ̶d̶o̶o̶r̶s̶";
            button5.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox2.Text += " are";
            button6.ForeColor = Color.Black;
            button6.Text = " a̶r̶e̶";
            button6.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox2.Text += " at 10 pm";
            button7.ForeColor = Color.Black;
            button7.Text = " a̶t̶ ̶1̶0̶ ̶p̶m̶";
            button7.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox2.Text += " locked";
            button8.ForeColor = Color.Black;
            button8.Text = " l̶o̶c̶k̶e̶d̶";
            button8.Enabled = false;
        }

        private void button45_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            button5.Text = " the doors";
            button5.ForeColor = Color.White;
            button6.Text = " are";
            button6.ForeColor = Color.White;
            button7.Text = " at 10 pm";
            button7.ForeColor = Color.White;
            button8.Text = " locked";
            button8.ForeColor = Color.White;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox3.Text += " born";
            button9.ForeColor = Color.Black;
            button9.Text = " b̶o̶r̶n̶";
            button9.Enabled = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox3.Text += " on 12 March";
            button10.ForeColor = Color.Black;
            button10.Text = " o̶n̶ ̶1̶2̶ ̶M̶a̶r̶c̶h̶";
            button10.Enabled = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox3.Text += " was";
            button11.ForeColor = Color.Black;
            button11.Text = " w̶a̶s̶";
            button11.Enabled = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox3.Text += " Emily";
            button12.ForeColor = Color.Black;
            button12.Text = " E̶m̶i̶l̶y̶";
            button12.Enabled = false;
        }

        private void button46_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            button9.Text = " born";
            button9.ForeColor = Color.White;
            button10.Text = " on 12 March";
            button10.ForeColor = Color.White;
            button11.Text = " was";
            button11.ForeColor = Color.White;
            button12.Text = " Emily";
            button12.ForeColor = Color.White;
            button9.Enabled = true;
            button10.Enabled = true;
            button11.Enabled = true;
            button12.Enabled = true;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox4.Text += " the reports";
            button13.ForeColor = Color.Black;
            button13.Text = " t̶h̶e̶ ̶r̶e̶p̶o̶r̶t̶s̶";
            button13.Enabled = false;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox4.Text += " read";
            button14.ForeColor = Color.Black;
            button14.Text = " r̶e̶a̶d̶";
            button13.Enabled = false;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox4.Text += " be";
            button15.ForeColor = Color.Black;
            button15.Text = " b̶e̶";
            button15.Enabled = false;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox4.Text += " will";
            button16.ForeColor = Color.Black;
            button16.Text = " w̶i̶l̶l̶";
            button16.Enabled = false;
        }

        private void button47_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
            button13.Text = " the reports";
            button13.ForeColor = Color.White;
            button14.Text = " read";
            button14.ForeColor = Color.White;
            button15.Text = " be";
            button15.ForeColor = Color.White;
            button16.Text = " will";
            button16.ForeColor = Color.White;
            button9.Enabled = true;
            button10.Enabled = true;
            button11.Enabled = true;
            button12.Enabled = true;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox5.Text += " stolen";
            button17.ForeColor = Color.Black;
            button17.Text = " s̶t̶o̶l̶e̶n̶";
            button17.Enabled = false;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox5.Text += " his bike";
            button18.ForeColor = Color.Black;
            button18.Text = " h̶i̶s̶ ̶b̶i̶k̶e̶";
            button18.Enabled = false;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox5.Text += " was";
            button19.ForeColor = Color.Black;
            button19.Text = " w̶a̶s̶";
            button19.Enabled = false;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox5.Text += " last night";
            button20.ForeColor = Color.Black;
            button20.Text = " l̶a̶s̶t̶ ̶n̶i̶g̶h̶t̶";
            button20.Enabled = false;
        }

        private void button48_Click(object sender, EventArgs e)
        {
            textBox5.Clear();
            button17.Text = " stolen";
            button17.ForeColor = Color.White;
            button18.Text = " his bike";
            button18.ForeColor = Color.White;
            button19.Text = " was";
            button19.ForeColor = Color.White;
            button20.Text = " last night";
            button20.ForeColor = Color.White;
            button17.Enabled = true;
            button18.Enabled = true;
            button18.Enabled = true;
            button20.Enabled = true;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox6.Text += " is";
            button21.ForeColor = Color.Black;
            button21.Text = " i̶s̶";
            button21.Enabled = false;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            textBox6.Text += " Spanish";
            button22.ForeColor = Color.Black;
            button22.Text = " S̶p̶a̶n̶i̶s̶h̶";
            button22.Enabled = false;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            textBox6.Text += " in Latin America";
            button23.ForeColor = Color.Black;
            button23.Text = " i̶n̶ ̶L̶a̶t̶i̶n̶ ̶A̶m̶e̶r̶i̶c̶a̶";
            button23.Enabled = false;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            textBox6.Text += " spoken";
            button24.ForeColor = Color.Black;
            button24.Text = " s̶p̶o̶k̶e̶n̶";
            button24.Enabled = false;
        }

        private void button49_Click(object sender, EventArgs e)
        {
            textBox6.Clear();
            button21.Text = " is";
            button21.ForeColor = Color.White;
            button22.Text = " Spanish";
            button22.ForeColor = Color.White;
            button23.Text = " in Latin America";
            button23.ForeColor = Color.White;
            button24.Text = " spoken";
            button24.ForeColor = Color.White;
            button21.Enabled = true;
            button22.Enabled = true;
            button23.Enabled = true;
            button24.Enabled = true;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            textBox7.Text += " oranges";
            button25.ForeColor = Color.Black;
            button25.Text = " o̶r̶a̶n̶g̶e̶s̶";
            button25.Enabled = false;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            textBox7.Text += " are";
            button26.ForeColor = Color.Black;
            button26.Text = " a̶r̶e̶";
            button26.Enabled = false;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            textBox7.Text += " picked";
            button27.ForeColor = Color.Black;
            button27.Text = " p̶i̶c̶k̶e̶d̶";
            button27.Enabled = false;
        }

        private void button28_Click(object sender, EventArgs e)
        {
            textBox7.Text += " in winter";
            button28.ForeColor = Color.Black;
            button28.Text = " i̶n̶ ̶w̶i̶n̶t̶e̶r̶";
            button28.Enabled = false;
        }

        private void button50_Click(object sender, EventArgs e)
        {
            textBox7.Clear();
            button25.Text = " oranges";
            button25.ForeColor = Color.White;
            button26.Text = " are";
            button26.ForeColor = Color.White;
            button27.Text = " picked";
            button27.ForeColor = Color.White;
            button28.Text = " in winter";
            button28.ForeColor = Color.White;
            button25.Enabled = true;
            button26.Enabled = true;
            button27.Enabled = true;
            button28.Enabled = true;
        }

        private void button29_Click(object sender, EventArgs e)
        {
            textBox8.Text += " produced";
            button29.ForeColor = Color.Black;
            button29.Text = " p̶r̶o̶d̶u̶c̶e̶d̶";
            button29.Enabled = false;
        }

        private void button30_Click(object sender, EventArgs e)
        {
            textBox8.Text += " in France";
            button30.ForeColor = Color.Black;
            button30.Text = " i̶n̶ ̶F̶r̶a̶n̶c̶e̶";
            button30.Enabled = false;
        }

        private void button31_Click(object sender, EventArgs e)
        {
            textBox8.Text += " is";
            button31.ForeColor = Color.Black;
            button31.Text = " i̶s̶";
            button31.Enabled = false;
        }

        private void button32_Click(object sender, EventArgs e)
        {
            textBox8.Text += " the";
            button32.ForeColor = Color.Black;
            button32.Text = " t̶h̶e̶";
            button32.Enabled = false;
        }

        private void button33_Click(object sender, EventArgs e)
        {
            textBox8.Text += " best";
            button33.ForeColor = Color.Black;
            button33.Text = " b̶e̶s̶t̶";
            button33.Enabled = false;
        }

        private void button34_Click(object sender, EventArgs e)
        {
            textBox8.Text += " cheese";
            button34.ForeColor = Color.Black;
            button34.Text = " c̶h̶e̶e̶s̶e̶";
            button34.Enabled = false;
        }

        private void button51_Click(object sender, EventArgs e)
        {
            textBox8.Clear();
            button29.Text = " produced";
            button29.ForeColor = Color.White;
            button30.Text = " in France";
            button30.ForeColor = Color.White;
            button31.Text = " is";
            button31.ForeColor = Color.White;
            button32.Text = " the";
            button32.ForeColor = Color.White;
            button33.Text = " best";
            button33.ForeColor = Color.White;
            button34.Text = " cheese";
            button34.ForeColor = Color.White;
            button29.Enabled = true;
            button30.Enabled = true;
            button31.Enabled = true;
            button32.Enabled = true;
            button33.Enabled = true;
            button34.Enabled = true;
        }

        private void button35_Click(object sender, EventArgs e)
        {
            textBox9.Text += " to a hospital";
            button35.ForeColor = Color.Black;
            button35.Text = " t̶o̶ ̶a̶ ̶h̶o̶s̶p̶i̶t̶a̶l̶";
            button35.Enabled = false;
        }

        private void button36_Click(object sender, EventArgs e)
        {
            textBox9.Text += " the";
            button36.ForeColor = Color.Black;
            button36.Text = " t̶h̶e̶";
            button36.Enabled = false;
        }

        private void button37_Click(object sender, EventArgs e)
        {
            textBox9.Text += " will";
            button37.ForeColor = Color.Black;
            button37.Text = " w̶i̶l̶l̶";
            button37.Enabled = false;
        }

        private void button38_Click(object sender, EventArgs e)
        {
            textBox9.Text += " be";
            button38.ForeColor = Color.Black;
            button38.Text = " b̶e̶";
            button38.Enabled = false;
        }

        private void button39_Click(object sender, EventArgs e)
        {
            textBox9.Text += " taken";
            button39.ForeColor = Color.Black;
            button39.Text = " t̶a̶k̶e̶n̶";
            button39.Enabled = false;
        }

        private void button52_Click(object sender, EventArgs e)
        {
            textBox9.Clear();
            button35.Text = " to a hospital";
            button35.ForeColor = Color.White;
            button36.Text = " the";
            button36.ForeColor = Color.White;
            button37.Text = " will";
            button37.ForeColor = Color.White;
            button38.Text = " be";
            button38.ForeColor = Color.White;
            button39.Text = " taken";
            button39.ForeColor = Color.White;
            button35.Enabled = true;
            button36.Enabled = true;
            button37.Enabled = true;
            button38.Enabled = true;
            button39.Enabled = true;
        }

        private void button40_Click(object sender, EventArgs e)
        {
            textBox10.Text += " by millions of tourists";
            button40.ForeColor = Color.Black;
            button40.Text = " b̶y̶ ̶m̶i̶l̶l̶i̶o̶n̶s̶ ̶o̶f̶ ̶t̶o̶u̶r̶i̶s̶t̶s̶";
            button40.Enabled = false;
        }

        private void button41_Click(object sender, EventArgs e)
        {
            textBox10.Text += " visited";
            button41.ForeColor = Color.Black;
            button41.Text = " v̶i̶s̶i̶t̶e̶d̶";
            button41.Enabled = false;
        }

        private void button42_Click(object sender, EventArgs e)
        {
            textBox10.Text += " is";
            button42.ForeColor = Color.Black;
            button42.Text = " i̶s̶";
            button42.Enabled = false;
        }

        private void button43_Click(object sender, EventArgs e)
        {
            textBox10.Text += " Italy";
            button43.ForeColor = Color.Black;
            button43.Text = " I̶t̶a̶l̶y̶";
            button43.Enabled = false;
        }

        private void button53_Click(object sender, EventArgs e)
        {
            textBox10.Clear();
            button40.Text = " by millions of tourists";
            button40.ForeColor = Color.White;
            button41.Text = " visited";
            button41.ForeColor = Color.White;
            button42.Text = " is";
            button42.ForeColor = Color.White;
            button43.Text = " Italy";
            button43.ForeColor = Color.White;
            button40.Enabled = true;
            button41.Enabled = true;
            button42.Enabled = true;
            button43.Enabled = true;
        }

        private void buttonGoBack2_Click(object sender, EventArgs e)
        {
            GrammarExercises openForm = new GrammarExercises();
            openForm.Show();
            Visible = false;
        }

        int score = 0;
        public static string passingText;

        private void buttonVerify_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals(" these toys are made from plastic"))
            {
                label11.Text = "✓";
                label11.ForeColor = Color.Green;
                textBox1.BackColor = Color.Green;
                score = score + 1;
            }
            else
            {
                label11.Text = "These toys are made from plastic.";
                label11.ForeColor = Color.Green;
                textBox1.BackColor = Color.Red;
            }


            if (textBox2.Text.Equals(" the doors are locked at 10 pm"))
            {
                label12.Text = "✓";
                label12.ForeColor = Color.Green;
                textBox2.BackColor = Color.Green;
                score = score + 1;
            }
            else
            {
                label12.Text = "The doors are locked at 10 pm.";
                label12.ForeColor = Color.Green;
                textBox2.BackColor = Color.Red;
            }

                if (textBox3.Text.Equals(" Emily was born on 12 March"))
                {
                    label13.Text = "✓";
                    label13.ForeColor = Color.Green;
                    textBox3.BackColor = Color.Green;
                    score = score + 1;
                }
                else
                {
                    label13.Text = "Emily was born on 12 March.";
                    label13.ForeColor = Color.Green;
                    textBox3.BackColor = Color.Red;
                }


                if (textBox4.Text.Equals(" the reports will be read"))
                {
                    label14.Text = "✓";
                    label14.ForeColor = Color.Green;
                    textBox4.BackColor = Color.Green;
                    score = score + 1;
                }
                else
                {
                    label14.Text = "The reports will be read.";
                    label14.ForeColor = Color.Green;
                    textBox4.BackColor = Color.Red;
                }



            if (textBox5.Text.Equals(" his bike was stolen last night"))
            {
                label15.Text = "✓";
                label15.ForeColor = Color.Green;
                textBox5.BackColor = Color.Green;
                score = score + 1;
            }
            else
            {
                label15.Text = "His bike was stolen last night.";
                label15.ForeColor = Color.Green;
                textBox5.BackColor = Color.Red;
            }


            if (textBox6.Text.Equals(" Spanish is spoken in Latin America"))
            {
                label16.Text = "✓";
                label16.ForeColor = Color.Green;
                textBox6.BackColor = Color.Green;
                score = score + 1;
            }
            else
            {
                label16.Text = "Spanish is spoken in Latin America.";
                label16.ForeColor = Color.Green;
                textBox6.BackColor = Color.Red;
            }


            if (textBox7.Text.Equals(" oranges are picked in winter"))
            {
                label17.Text = "✓";
                label17.ForeColor = Color.Green;
                textBox7.BackColor = Color.Green;
                score = score + 1;
            }
            else
            {
                label17.Text = "Oranges are picked in winter.";
                label17.ForeColor = Color.Green;
                textBox7.BackColor = Color.Red;
            }


            if (textBox8.Text.Equals(" the best cheese is produced in France"))
            {
                label18.Text = "✓";
                label18.ForeColor = Color.Green;
                textBox8.BackColor = Color.Green;
                score = score + 1;
            }
            else
            {
                label18.Text = "The best cheese is produced in France.";
                label18.ForeColor = Color.Green;
                textBox8.BackColor = Color.Red;
            }


            if (textBox9.Text.Equals(" the woman will be taken to a hospital"))
            {
                label19.Text = "✓";
                label19.ForeColor = Color.Green;
                textBox9.BackColor = Color.Green;
                score = score + 1;
            }
            else
            {
                label19.Text = "The woman will be taken to a hospital.";
                label19.ForeColor = Color.Green;
                textBox9.BackColor = Color.Red;
            }


            if (textBox10.Text.Equals(" Italy is visited by millions of tourists"))
            {
                label20.Text = "✓";
                label20.ForeColor = Color.Green;
                textBox10.BackColor = Color.Green;
                score = score + 1;
            }
            else
            {
                label20.Text = "Italy is visited by millions of tourists.";
                label20.ForeColor = Color.Green;
                textBox10.BackColor = Color.Red;
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
            textBox1.Text = " these toys are made from plastic";
            textBox2.Text = " the doors are locked at 10 pm";
            textBox3.Text = " Emily was born on 12 March";
            textBox4.Text = " the reports will be read";
            textBox5.Text = " his bike was stolen last night";
            textBox6.Text = " Spanish is spoken in Latin America";
            textBox7.Text = " oranges are picked in winter";
            textBox8.Text = " the best cheese is produced in France";
            textBox9.Text = " the woman will be taken to a hospital";
            textBox10.Text = " Italy is visited by millions of tourists";
            buttonVerify.Enabled = false;
            buttonVerify2.Hide();
        }

        private void buttonReseteazaExercitiul_Click(object sender, EventArgs e)
        {
            WordOrderInPassive openForm = new WordOrderInPassive();
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

        private void button54_Click(object sender, EventArgs e)
        {
            this.Close();
            NounsCapitalization nounsCapitalization = new NounsCapitalization();
            nounsCapitalization.Show();
        }

        private void button55_Click(object sender, EventArgs e)
        {
            this.Close();
            WordOrderInAffirmative wordOrderInAffirmative = new WordOrderInAffirmative();
            wordOrderInAffirmative.Show();
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

        private void button1_MouseHover(object sender, EventArgs e)
        {
            if (button1.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(button1.Text);
            }
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            if (button2.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(button2.Text);
            }
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            if (button3.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(button3.Text);
            }
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            if (button4.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(button4.Text);
            }
        }

        private void textBox1_MouseHover(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(textBox1.Text);
            }
        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            if (button5.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(button5.Text);
            }
        }

        private void button6_MouseHover(object sender, EventArgs e)
        {
            if (button6.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(button6.Text);
            }
        }

        private void button7_MouseHover(object sender, EventArgs e)
        {
            if (button7.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(button7.Text);
            }
        }

        private void button8_MouseHover(object sender, EventArgs e)
        {
            if (button8.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(button8.Text);
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

        private void button9_MouseHover(object sender, EventArgs e)
        {
            if (button9.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(button9.Text);
            }
        }

        private void button10_MouseHover(object sender, EventArgs e)
        {
            if (button10.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(button10.Text);
            }
        }

        private void button11_MouseHover(object sender, EventArgs e)
        {
            if (button11.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(button11.Text);
            }
        }

        private void button12_MouseHover(object sender, EventArgs e)
        {
            if (button12.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(button12.Text);
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

        private void label13_MouseHover(object sender, EventArgs e)
        {
            if (label13.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(label13.Text);
            }
        }

        private void button13_MouseHover(object sender, EventArgs e)
        {
            if (button13.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(button13.Text);
            }
        }

        private void button14_MouseHover(object sender, EventArgs e)
        {
            if (button14.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(button14.Text);
            }
        }

        private void button15_MouseHover(object sender, EventArgs e)
        {
            if (button15.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(button15.Text);
            }
        }

        private void button16_MouseHover(object sender, EventArgs e)
        {
            if (button16.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(button16.Text);
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

        private void label14_MouseHover(object sender, EventArgs e)
        {
            if (label14.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(label14.Text);
            }
        }

        private void button17_MouseHover(object sender, EventArgs e)
        {
            if (button17.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(button17.Text);
            }
        }

        private void button18_MouseHover(object sender, EventArgs e)
        {
            if (button18.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(button18.Text);
            }
        }

        private void button19_MouseHover(object sender, EventArgs e)
        {
            if (button19.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(button19.Text);
            }
        }

        private void button20_MouseHover(object sender, EventArgs e)
        {
            if (button20.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(button20.Text);
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

        private void label15_MouseHover(object sender, EventArgs e)
        {
            if (label15.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(label15.Text);
            }
        }

        private void button21_MouseHover(object sender, EventArgs e)
        {
            if (button21.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(button21.Text);
            }
        }

        private void button22_MouseHover(object sender, EventArgs e)
        {
            if (button22.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(button22.Text);
            }
        }

        private void button23_MouseHover(object sender, EventArgs e)
        {
            if (button23.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(button23.Text);
            }
        }

        private void button24_MouseHover(object sender, EventArgs e)
        {
            if (button24.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(button24.Text);
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

        private void label16_MouseHover(object sender, EventArgs e)
        {
            if (label16.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(label16.Text);
            }
        }

        private void button25_MouseHover(object sender, EventArgs e)
        {
            if (button25.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(button25.Text);
            }
        }

        private void button26_MouseHover(object sender, EventArgs e)
        {
            if (button26.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(button26.Text);
            }
        }

        private void button27_MouseHover(object sender, EventArgs e)
        {
            if (button27.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(button27.Text);
            }
        }

        private void button28_MouseHover(object sender, EventArgs e)
        {
            if (button28.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(button28.Text);
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

        private void label17_MouseHover(object sender, EventArgs e)
        {
            if (label17.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(label17.Text);
            }
        }

        private void button29_MouseHover(object sender, EventArgs e)
        {
            if (button29.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(button29.Text);
            }
        }

        private void button30_MouseHover(object sender, EventArgs e)
        {
            if (button30.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(button30.Text);
            }
        }

        private void button31_MouseHover(object sender, EventArgs e)
        {
            if (button31.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(button31.Text);
            }
        }

        private void button32_MouseHover(object sender, EventArgs e)
        {
            if (button32.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(button32.Text);
            }
        }

        private void button33_MouseHover(object sender, EventArgs e)
        {
            if (button33.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(button33.Text);
            }
        }

        private void button34_MouseHover(object sender, EventArgs e)
        {
            if (button34.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(button34.Text);
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

        private void label18_MouseHover(object sender, EventArgs e)
        {
            if (label18.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(label18.Text);
            }
        }

        private void button35_MouseHover(object sender, EventArgs e)
        {
            if (button35.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(button35.Text);
            }
        }

        private void button36_MouseHover(object sender, EventArgs e)
        {
            if (button36.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(button36.Text);
            }
        }

        private void button37_MouseHover(object sender, EventArgs e)
        {
            if (button37.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(button37.Text);
            }
        }

        private void button38_MouseHover(object sender, EventArgs e)
        {
            if (button38.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(button38.Text);
            }
        }

        private void button39_MouseHover(object sender, EventArgs e)
        {
            if (button39.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(button39.Text);
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

        private void label19_MouseHover(object sender, EventArgs e)
        {
            if (label19.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(label19.Text);
            }
        }

        private void button40_MouseHover(object sender, EventArgs e)
        {
            if (button40.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(button40.Text);
            }
        }

        private void button41_MouseHover(object sender, EventArgs e)
        {
            if (button41.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(button41.Text);
            }
        }

        private void button42_MouseHover(object sender, EventArgs e)
        {
            if (button42.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(button42.Text);
            }
        }

        private void button43_MouseHover(object sender, EventArgs e)
        {
            if (button43.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(button43.Text);
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

        private void buttonNewExercise_Click(object sender, EventArgs e)
        {
            buttonVerify.Hide();
            buttonVerify2.Show();
            buttonShowAnswer.Hide();
            buttonShowAnswer2.Show();
            buttonNewExercise.Hide();
            buttonVerify2.Enabled = true;
            buttonShowAnswer2.Enabled = true;

            button1.Hide();
            button2.Hide();
            button3.Hide();
            button4.Hide();
            button5.Hide();
            button6.Hide();
            button7.Hide();
            button8.Hide();
            button9.Hide();
            button10.Hide();
            button11.Hide();
            button12.Hide();
            button13.Hide();
            button14.Hide();
            button15.Hide();
            button16.Hide();
            button17.Hide();
            button18.Hide();
            button19.Hide();
            button20.Hide();
            button21.Hide();
            button22.Hide();
            button23.Hide();
            button24.Hide();
            button25.Hide();
            button26.Hide();
            button27.Hide();
            button28.Hide();
            button29.Hide();
            button30.Hide();
            button31.Hide();
            button32.Hide();
            button33.Hide();
            button34.Hide();
            button35.Hide();
            button36.Hide();
            button37.Hide();
            button38.Hide();
            button39.Hide();
            button40.Hide();
            button41.Hide();
            button42.Hide();
            button43.Hide();
            button44.Hide();
            button45.Hide();
            button46.Hide();
            button47.Hide();
            button48.Hide();
            button49.Hide();
            button50.Hide();
            button51.Hide();
            button52.Hide();
            button53.Hide();

            button56.Show();
            button57.Show();
            button58.Show();
            button59.Show();
            button60.Show();
            button61.Show();
            button62.Show();
            button63.Show();
            button64.Show();
            button65.Show();
            button66.Show();
            button67.Show();
            button68.Show();
            button69.Show();
            button70.Show();
            button71.Show();
            button72.Show();
            button73.Show();
            button74.Show();
            button75.Show();
            button76.Show();
            button77.Show();
            button78.Show();
            button79.Show();
            button80.Show();
            button81.Show();
            button82.Show();
            button83.Show();
            button84.Show();
            button85.Show();
            button86.Show();
            button87.Show();
            button88.Show();
            button89.Show();
            button90.Show();
            button91.Show();
            button92.Show();
            button93.Show();
            button94.Show();
            button95.Show();
            button96.Show();
            button97.Show();
            button98.Show();
            button99.Show();
            button100.Show();
            button101.Show();
            button102.Show();
            button103.Show();
            button104.Show();
            button105.Show();
            button106.Show();
            button107.Show();
            button108.Show();

            string fileName = "XMLOrdineaCuvintelorInPropozitiiPasive.xml";
            string path = Path.Combine(Environment.CurrentDirectory, @"", fileName);

            XmlTextReader xtr = new XmlTextReader(path);
            try
            {
                while (xtr.Read())
                {
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "one")
                    {
                        string s1 = xtr.ReadElementString();
                        button56.Text = ("" + s1);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "two")
                    {
                        string s2 = xtr.ReadElementString();
                        button57.Text = ("" + s2);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "three")
                    {
                        string s3 = xtr.ReadElementString();
                        button58.Text = ("" + s3);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "four")
                    {
                        string s4 = xtr.ReadElementString();
                        button59.Text = ("" + s4);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "five")
                    {
                        string s5 = xtr.ReadElementString();
                        button60.Text = ("" + s5);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "six")
                    {
                        string s6 = xtr.ReadElementString();
                        button61.Text = ("" + s6);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "seven")
                    {
                        string s7 = xtr.ReadElementString();
                        button62.Text = ("" + s7);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "eight")
                    {
                        string s8 = xtr.ReadElementString();
                        button63.Text = ("" + s8);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "nine")
                    {
                        string s9 = xtr.ReadElementString();
                        button64.Text = ("" + s9);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "ten")
                    {
                        string s10 = xtr.ReadElementString();
                        button65.Text = ("" + s10);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "eleven")
                    {
                        string s11 = xtr.ReadElementString();
                        button66.Text = ("" + s11);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "twelve")
                    {
                        string s12 = xtr.ReadElementString();
                        button67.Text = ("" + s12);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "thirteen")
                    {
                        string s13 = xtr.ReadElementString();
                        button68.Text = ("" + s13);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "fourteen")
                    {
                        string s14 = xtr.ReadElementString();
                        button69.Text = ("" + s14);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "fifteen")
                    {
                        string s15 = xtr.ReadElementString();
                        button70.Text = ("" + s15);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "sixteen")
                    {
                        string s16 = xtr.ReadElementString();
                        button71.Text = ("" + s16);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "seventeen")
                    {
                        string s17 = xtr.ReadElementString();
                        button72.Text = ("" + s17);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "eighteen")
                    {
                        string s18 = xtr.ReadElementString();
                        button73.Text = ("" + s18);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "nineteen")
                    {
                        string s19 = xtr.ReadElementString();
                        button74.Text = ("" + s19);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "twenty")
                    {
                        string s20 = xtr.ReadElementString();
                        button75.Text = ("" + s20);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "twentyone")
                    {
                        string s21 = xtr.ReadElementString();
                        button76.Text = ("" + s21);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "twentytwo")
                    {
                        string s22 = xtr.ReadElementString();
                        button77.Text = ("" + s22);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "twentythree")
                    {
                        string s23 = xtr.ReadElementString();
                        button78.Text = ("" + s23);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "twentyfour")
                    {
                        string s24 = xtr.ReadElementString();
                        button79.Text = ("" + s24);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "twentyfive")
                    {
                        string s25 = xtr.ReadElementString();
                        button80.Text = ("" + s25);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "twentysix")
                    {
                        string s26 = xtr.ReadElementString();
                        button81.Text = ("" + s26);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "twentyseven")
                    {
                        string s27 = xtr.ReadElementString();
                        button82.Text = ("" + s27);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "twentyeight")
                    {
                        string s28 = xtr.ReadElementString();
                        button83.Text = ("" + s28);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "twentynine")
                    {
                        string s30 = xtr.ReadElementString();
                        button84.Text = ("" + s30);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "thirty")
                    {
                        string s31 = xtr.ReadElementString();
                        button85.Text = ("" + s31);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "thirtyone")
                    {
                        string s32 = xtr.ReadElementString();
                        button86.Text = ("" + s32);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "thirtytwo")
                    {
                        string s33 = xtr.ReadElementString();
                        button87.Text = ("" + s33);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "thirtythree")
                    {
                        string s34 = xtr.ReadElementString();
                        button88.Text = ("" + s34);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "thirtyfour")
                    {
                        string s35 = xtr.ReadElementString();
                        button89.Text = ("" + s35);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "thirtyfive")
                    {
                        string s36 = xtr.ReadElementString();
                        button90.Text = ("" + s36);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "thirtysix")
                    {
                        string s37 = xtr.ReadElementString();
                        button91.Text = ("" + s37);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "thirtyseven")
                    {
                        string s38 = xtr.ReadElementString();
                        button92.Text = ("" + s38);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "thirtyeight")
                    {
                        string s39 = xtr.ReadElementString();
                        button93.Text = ("" + s39);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "thirtynine")
                    {
                        string s40 = xtr.ReadElementString();
                        button94.Text = ("" + s40);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "fourty")
                    {
                        string s41 = xtr.ReadElementString();
                        button95.Text = ("" + s41);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "fourtyone")
                    {
                        string s42 = xtr.ReadElementString();
                        button96.Text = ("" + s42);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "fourtytwo")
                    {
                        string s43 = xtr.ReadElementString();
                        button97.Text = ("" + s43);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "fourtythree")
                    {
                        string s44 = xtr.ReadElementString();
                        button98.Text = ("" + s44);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";

            textBox1.BackColor = Color.White;
            textBox2.BackColor = Color.White;
            textBox3.BackColor = Color.White;
            textBox4.BackColor = Color.White;
            textBox5.BackColor = Color.White;
            textBox6.BackColor = Color.White;
            textBox7.BackColor = Color.White;
            textBox8.BackColor = Color.White;
            textBox9.BackColor = Color.White;
            textBox10.BackColor = Color.White;

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
        }

        int newscore = 0;

        private void buttonVerify2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals(" the thief was arrested this morning"))
            {
                label11.Text = "✓";
                label11.ForeColor = Color.Green;
                textBox1.BackColor = Color.Green;
                newscore = newscore + 1;
            }
            else
            {
                label11.Text = "The thief was arrested this morning.";
                label11.ForeColor = Color.Green;
                textBox1.BackColor = Color.Red;
            }

            if (textBox2.Text.Equals(" this song was released many years ago"))
            {
                label12.Text = "✓";
                label12.ForeColor = Color.Green;
                textBox2.BackColor = Color.Green;
                newscore = newscore + 1;
            }
            else
            {
                label12.Text = "This song was released many years ago.";
                label12.ForeColor = Color.Green;
                textBox2.BackColor = Color.Red;
            }

            if (textBox3.Text.Equals(" I was given a present"))
            {
                label13.Text = "✓";
                label13.ForeColor = Color.Green;
                textBox3.BackColor = Color.Green;
                newscore = newscore + 1;
            }
            else
            {
                label13.Text = "I was given a present.";
                label13.ForeColor = Color.Green;
                textBox3.BackColor = Color.Red;
            }

            if (textBox4.Text.Equals(" the candidates are being interviewed"))
            {
                label14.Text = "✓";
                label14.ForeColor = Color.Green;
                textBox4.BackColor = Color.Green;
                newscore = newscore + 1;
            }
            else
            {
                label14.Text = "The candidates are being interviewed.";
                label14.ForeColor = Color.Green;
                textBox4.BackColor = Color.Red;
            }

            if (textBox5.Text.Equals(" all flights have been cancelled"))
            {
                label15.Text = "✓";
                label15.ForeColor = Color.Green;
                textBox5.BackColor = Color.Green;
                newscore = newscore + 1;
            }
            else
            {
                label15.Text = "All flights have been cancelled.";
                label15.ForeColor = Color.Green;
                textBox5.BackColor = Color.Red;
            }

            if (textBox6.Text.Equals(" our efforts are not fully appreciated"))
            {
                label16.Text = "✓";
                label16.ForeColor = Color.Green;
                textBox6.BackColor = Color.Green;
                newscore = newscore + 1;
            }
            else
            {
                label16.Text = "Our efforts are not fully appreciated.";
                label16.ForeColor = Color.Green;
                textBox6.BackColor = Color.Red;
            }

            if (textBox7.Text.Equals(" Abraham Lincoln was killed at Ford's Theater"))
            {
                label17.Text = "✓";
                label17.ForeColor = Color.Green;
                textBox7.BackColor = Color.Green;
                newscore = newscore + 1;
            }
            else
            {
                label17.Text = "Abraham Lincoln was killed at Ford's Theater.";
                label17.ForeColor = Color.Green;
                textBox7.BackColor = Color.Red;
            }

            if (textBox8.Text.Equals(" mobile phones may not be used during lessons"))
            {
                label18.Text = "✓";
                label18.ForeColor = Color.Green;
                textBox8.BackColor = Color.Green;
                newscore = newscore + 1;
            }
            else
            {
                label18.Text = "Mobile phones may not be used during lessons.";
                label18.ForeColor = Color.Green;
                textBox8.BackColor = Color.Red;
            }

            if (textBox9.Text.Equals(" it was so dark that nothing could be seen"))
            {
                label19.Text = "✓";
                label19.ForeColor = Color.Green;
                textBox9.BackColor = Color.Green;
                newscore = newscore + 1;
            }
            else
            {
                label19.Text = "It was so dark that nothing could be seen.";
                label19.ForeColor = Color.Green;
                textBox9.BackColor = Color.Red;
            }

            if (textBox10.Text.Equals(" we were asked to study the map"))
            {
                label20.Text = "✓";
                label20.ForeColor = Color.Green;
                textBox10.BackColor = Color.Green;
                newscore = newscore + 1;
            }
            else
            {
                label20.Text = "We were asked to study the map.";
                label20.ForeColor = Color.Green;
                textBox10.BackColor = Color.Red;
            }

            buttonVerify2.Enabled = false;
            buttonShowAnswer2.Enabled = false;
            labelScore.Text = "";
            labelScore.Text += Convert.ToInt32(score) + Convert.ToInt32(newscore);
            passingText = labelScore.Text;
        }

        private void button56_Click(object sender, EventArgs e)
        {
            textBox1.Text += " arrested";
            button56.ForeColor = Color.Black;
            button56.Enabled = false;
        }

        private void button57_Click(object sender, EventArgs e)
        {
            textBox1.Text += " this morning";
            button57.ForeColor = Color.Black;
            button57.Enabled = false;
        }

        private void button58_Click(object sender, EventArgs e)
        {
            textBox1.Text += " was";
            button58.ForeColor = Color.Black;
            button58.Enabled = false;
        }

        private void button59_Click(object sender, EventArgs e)
        {
            textBox1.Text += " the thief";
            button59.ForeColor = Color.Black;
            button59.Enabled = false;
        }

        private void button60_Click(object sender, EventArgs e)
        {
            textBox2.Text += " many years ago";
            button60.ForeColor = Color.Black;
            button60.Enabled = false;
        }

        private void button61_Click(object sender, EventArgs e)
        {
            textBox2.Text += " was";
            button61.ForeColor = Color.Black;
            button61.Enabled = false;
        }

        private void button62_Click(object sender, EventArgs e)
        {
            textBox2.Text += " this song";
            button62.ForeColor = Color.Black;
            button62.Enabled = false;
        }

        private void button63_Click(object sender, EventArgs e)
        {
            textBox2.Text += " released";
            button63.ForeColor = Color.Black;
            button63.Enabled = false;
        }

        private void button64_Click(object sender, EventArgs e)
        {
            textBox3.Text += " given";
            button64.ForeColor = Color.Black;
            button64.Enabled = false;
        }

        private void button65_Click(object sender, EventArgs e)
        {
            textBox3.Text += " I";
            button65.ForeColor = Color.Black;
            button65.Enabled = false;
        }

        private void button66_Click(object sender, EventArgs e)
        {
            textBox3.Text += " a present";
            button66.ForeColor = Color.Black;
            button66.Enabled = false;
        }

        private void button67_Click(object sender, EventArgs e)
        {
            textBox3.Text += " was";
            button67.ForeColor = Color.Black;
            button67.Enabled = false;
        }

        private void button68_Click(object sender, EventArgs e)
        {
            textBox4.Text += " are";
            button68.ForeColor = Color.Black;
            button68.Enabled = false;
        }

        private void button69_Click(object sender, EventArgs e)
        {
            textBox4.Text += " the candidates";
            button69.ForeColor = Color.Black;
            button69.Enabled = false;
        }

        private void button70_Click(object sender, EventArgs e)
        {
            textBox4.Text += " being";
            button70.ForeColor = Color.Black;
            button70.Enabled = false;
        }

        private void button71_Click(object sender, EventArgs e)
        {
            textBox4.Text += " interviewed";
            button71.ForeColor = Color.Black;
            button71.Enabled = false;
        }

        private void button72_Click(object sender, EventArgs e)
        {
            textBox5.Text += " all flights";
            button72.ForeColor = Color.Black;
            button72.Enabled = false;
        }

        private void button73_Click(object sender, EventArgs e)
        {
            textBox5.Text += " been";
            button73.ForeColor = Color.Black;
            button73.Enabled = false;
        }

        private void button74_Click(object sender, EventArgs e)
        {
            textBox5.Text += " have";
            button74.ForeColor = Color.Black;
            button74.Enabled = false;
        }

        private void button75_Click(object sender, EventArgs e)
        {
            textBox5.Text += " cancelled";
            button75.ForeColor = Color.Black;
            button75.Enabled = false;
        }

        private void button76_Click(object sender, EventArgs e)
        {
            textBox6.Text += " our efforts";
            button76.ForeColor = Color.Black;
            button76.Enabled = false;
        }

        private void button77_Click(object sender, EventArgs e)
        {
            textBox6.Text += " are not";
            button77.ForeColor = Color.Black;
            button77.Enabled = false;
        }

        private void button78_Click(object sender, EventArgs e)
        {
            textBox6.Text += " appreciated";
            button78.ForeColor = Color.Black;
            button78.Enabled = false;
        }

        private void button79_Click(object sender, EventArgs e)
        {
            textBox6.Text += " fully";
            button79.ForeColor = Color.Black;
            button79.Enabled = false;
        }

        private void button80_Click(object sender, EventArgs e)
        {
            textBox7.Text += " at Ford's Theater";
            button80.ForeColor = Color.Black;
            button80.Enabled = false;
        }

        private void button81_Click(object sender, EventArgs e)
        {
            textBox7.Text += " was";
            button81.ForeColor = Color.Black;
            button81.Enabled = false;
        }

        private void button82_Click(object sender, EventArgs e)
        {
            textBox7.Text += " killed";
            button82.ForeColor = Color.Black;
            button82.Enabled = false;
        }

        private void button83_Click(object sender, EventArgs e)
        {
            textBox7.Text += " Abraham Lincoln";
            button83.ForeColor = Color.Black;
            button83.Enabled = false;
        }

        private void button86_Click(object sender, EventArgs e)
        {
            textBox8.Text += " mobile phones";
            button86.ForeColor = Color.Black;
            button86.Enabled = false;
        }

        private void button87_Click(object sender, EventArgs e)
        {
            textBox8.Text += " during lessons";
            button87.ForeColor = Color.Black;
            button87.Enabled = false;
        }

        private void button88_Click(object sender, EventArgs e)
        {
            textBox8.Text += " may";
            button88.ForeColor = Color.Black;
            button88.Enabled = false;
        }

        private void button89_Click(object sender, EventArgs e)
        {
            textBox8.Text += " used";
            button89.ForeColor = Color.Black;
            button89.Enabled = false;
        }

        private void button84_Click(object sender, EventArgs e)
        {
            textBox8.Text += " be";
            button84.ForeColor = Color.Black;
            button84.Enabled = false;
        }

        private void button85_Click(object sender, EventArgs e)
        {
            textBox8.Text += " not";
            button85.ForeColor = Color.Black;
            button85.Enabled = false;
        }

        private void button93_Click(object sender, EventArgs e)
        {
            textBox9.Text += " seen";
            button93.ForeColor = Color.Black;
            button93.Enabled = false;
        }

        private void button94_Click(object sender, EventArgs e)
        {
            textBox9.Text += " could";
            button94.ForeColor = Color.Black;
            button94.Enabled = false;
        }

        private void button90_Click(object sender, EventArgs e)
        {
            textBox9.Text += " be";
            button90.ForeColor = Color.Black;
            button90.Enabled = false;
        }

        private void button91_Click(object sender, EventArgs e)
        {
            textBox9.Text += " it was so dark that";
            button91.ForeColor = Color.Black;
            button91.Enabled = false;
        }

        private void button92_Click(object sender, EventArgs e)
        {
            textBox9.Text += " nothing";
            button92.ForeColor = Color.Black;
            button92.Enabled = false;
        }

        private void button98_Click(object sender, EventArgs e)
        {
            textBox10.Text += " asked";
            button98.ForeColor = Color.Black;
            button98.Enabled = false;
        }

        private void button97_Click(object sender, EventArgs e)
        {
            textBox10.Text += " we were";
            button97.ForeColor = Color.Black;
            button97.Enabled = false;
        }

        private void button96_Click(object sender, EventArgs e)
        {
            textBox10.Text += " the map";
            button96.ForeColor = Color.Black;
            button96.Enabled = false;
        }

        private void button95_Click(object sender, EventArgs e)
        {
            textBox10.Text += " to study";
            button95.ForeColor = Color.Black;
            button95.Enabled = false;
        }

        private void button99_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            button56.ForeColor = Color.White;
            button57.ForeColor = Color.White;
            button58.ForeColor = Color.White;
            button59.ForeColor = Color.White;
            button56.Enabled = true;
            button57.Enabled = true;
            button58.Enabled = true;
            button59.Enabled = true;
        }

        private void button100_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            button60.ForeColor = Color.White;
            button61.ForeColor = Color.White;
            button62.ForeColor = Color.White;
            button63.ForeColor = Color.White;
            button60.Enabled = true;
            button61.Enabled = true;
            button62.Enabled = true;
            button63.Enabled = true;
        }

        private void button101_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            button64.ForeColor = Color.White;
            button65.ForeColor = Color.White;
            button66.ForeColor = Color.White;
            button67.ForeColor = Color.White;
            button64.Enabled = true;
            button65.Enabled = true;
            button66.Enabled = true;
            button67.Enabled = true;
        }

        private void button102_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
            button68.ForeColor = Color.White;
            button69.ForeColor = Color.White;
            button70.ForeColor = Color.White;
            button71.ForeColor = Color.White;
            button68.Enabled = true;
            button69.Enabled = true;
            button70.Enabled = true;
            button71.Enabled = true;
        }

        private void button103_Click(object sender, EventArgs e)
        {
            textBox5.Clear();
            button72.ForeColor = Color.White;
            button73.ForeColor = Color.White;
            button74.ForeColor = Color.White;
            button75.ForeColor = Color.White;
            button72.Enabled = true;
            button73.Enabled = true;
            button74.Enabled = true;
            button75.Enabled = true;
        }

        private void button104_Click(object sender, EventArgs e)
        {
            textBox6.Clear();
            button76.ForeColor = Color.White;
            button77.ForeColor = Color.White;
            button78.ForeColor = Color.White;
            button79.ForeColor = Color.White;
            button76.Enabled = true;
            button77.Enabled = true;
            button78.Enabled = true;
            button79.Enabled = true;
        }

        private void button105_Click(object sender, EventArgs e)
        {
            textBox7.Clear();
            button80.ForeColor = Color.White;
            button81.ForeColor = Color.White;
            button82.ForeColor = Color.White;
            button83.ForeColor = Color.White;
            button80.Enabled = true;
            button81.Enabled = true;
            button82.Enabled = true;
            button83.Enabled = true;
        }

        private void button106_Click(object sender, EventArgs e)
        {
            textBox8.Clear();
            button84.ForeColor = Color.White;
            button85.ForeColor = Color.White;
            button86.ForeColor = Color.White;
            button87.ForeColor = Color.White;
            button88.ForeColor = Color.White;
            button89.ForeColor = Color.White;
            button84.Enabled = true;
            button85.Enabled = true;
            button86.Enabled = true;
            button87.Enabled = true;
            button88.Enabled = true;
            button89.Enabled = true;
        }

        private void button107_Click(object sender, EventArgs e)
        {
            textBox9.Clear();
            button90.ForeColor = Color.White;
            button91.ForeColor = Color.White;
            button92.ForeColor = Color.White;
            button93.ForeColor = Color.White;
            button94.ForeColor = Color.White;
            button90.Enabled = true;
            button91.Enabled = true;
            button92.Enabled = true;
            button93.Enabled = true;
            button94.Enabled = true;
        }

        private void button108_Click(object sender, EventArgs e)
        {
            textBox10.Clear();
            button95.ForeColor = Color.White;
            button96.ForeColor = Color.White;
            button97.ForeColor = Color.White;
            button98.ForeColor = Color.White;
            button95.Enabled = true;
            button96.Enabled = true;
            button97.Enabled = true;
            button98.Enabled = true;
        }

        private void buttonShowAnswer2_Click(object sender, EventArgs e)
        {
            textBox1.Text = " the thief was arrested this morning";
            textBox2.Text = " this song was released many years ago";
            textBox3.Text = " I was given a present";
            textBox4.Text = " the candidates are being interviewed";
            textBox5.Text = " all flights have been cancelled";
            textBox6.Text = " our efforts are not fully appreciated";
            textBox7.Text = " Abraham Lincoln was killed at Ford's Theater";
            textBox8.Text = " mobile phones may not be used during lessons";
            textBox9.Text = " it was so dark that nothing could be seen";
            textBox10.Text = " we were asked to study the map";
            buttonVerify2.Enabled = false;
        }
    }
}
