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
    public partial class WordOrderInAffirmative : Form
    {
        public WordOrderInAffirmative()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += " I";
            button1.ForeColor = Color.Black;
            button1.Text = " I̶";
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += " watch";
            button2.ForeColor = Color.Black;
            button2.Text = " w̶a̶t̶c̶h̶";
            button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += " sport";
            button3.ForeColor = Color.Black;
            button3.Text = " s̶p̶o̶r̶t̶";
            button3.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += " on TV";
            button4.ForeColor = Color.Black;
            button4.Text = " o̶n̶ ̶T̶V̶";
            button4.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += " often";
            button5.ForeColor = Color.Black;
            button5.Text = " o̶f̶t̶e̶n̶";
            button5.Enabled = false;
        }

        private void button44_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            button1.Text = " I";
            button1.ForeColor = Color.White;
            button2.Text = " watch";
            button2.ForeColor = Color.White;
            button3.Text = " sport";
            button3.ForeColor = Color.White;
            button4.Text = " on TV";
            button4.ForeColor = Color.White;
            button5.Text = " often";
            button5.ForeColor = Color.White;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox2.Text += " usually";
            button6.ForeColor = Color.Black;
            button6.Text = " u̶s̶u̶a̶l̶l̶y̶";
            button6.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox2.Text += " in the garden";
            button7.ForeColor = Color.Black;
            button7.Text = " i̶n̶ ̶t̶h̶e̶ ̶g̶a̶r̶d̶e̶n̶";
            button7.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox2.Text += " my father";
            button8.ForeColor = Color.Black;
            button8.Text = " m̶y̶ ̶f̶a̶t̶h̶e̶r̶";
            button8.Enabled = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox2.Text += " in the afternoon";
            button9.ForeColor = Color.Black;
            button9.Text = " i̶n̶ ̶t̶h̶e̶ ̶a̶f̶t̶e̶r̶n̶o̶o̶n̶";
            button9.Enabled = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox2.Text += " is";
            button10.ForeColor = Color.Black;
            button10.Text = " i̶s̶";
            button10.Enabled = false;
        }

        private void button45_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            button6.Text = " usually";
            button6.ForeColor = Color.White;
            button7.Text = " in the garden";
            button7.ForeColor = Color.White;
            button8.Text = " my father";
            button8.ForeColor = Color.White;
            button9.Text = " in the afternoon";
            button9.ForeColor = Color.White;
            button10.Text = " is";
            button10.ForeColor = Color.White;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox3.Text += " lives";
            button11.ForeColor = Color.Black;
            button11.Text = " l̶i̶v̶e̶s̶";
            button11.Enabled = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox3.Text += " in Mexico";
            button12.ForeColor = Color.Black;
            button12.Text = " i̶n̶ ̶M̶e̶x̶i̶c̶o̶";
            button12.Enabled = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox3.Text += " she";
            button13.ForeColor = Color.Black;
            button13.Text = " s̶h̶e̶";
            button13.Enabled = false;
        }

        private void button46_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            button11.Text = " lives";
            button11.ForeColor = Color.White;
            button12.Text = " in Mexico";
            button12.ForeColor = Color.White;
            button13.Text = " she";
            button13.ForeColor = Color.White;
            button11.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox4.Text += " is";
            button14.ForeColor = Color.Black;
            button14.Text = " i̶s̶";
            button14.Enabled = false;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox4.Text += " worksheet";
            button15.ForeColor = Color.Black;
            button15.Text = " w̶o̶r̶k̶s̶h̶e̶e̶t̶";
            button15.Enabled = false;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox4.Text += " he";
            button16.ForeColor = Color.Black;
            button16.Text = " h̶e̶";
            button16.Enabled = false;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox4.Text += " the";
            button17.ForeColor = Color.Black;
            button17.Text = " t̶h̶e̶";
            button17.Enabled = false;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox4.Text += " reading";
            button18.ForeColor = Color.Black;
            button18.Text = " r̶e̶a̶d̶i̶n̶g̶";
            button18.Enabled = false;
        }

        private void button47_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
            button14.Text = " is";
            button14.ForeColor = Color.White;
            button15.Text = " worksheet";
            button15.ForeColor = Color.White;
            button16.Text = " he";
            button16.ForeColor = Color.White;
            button17.Text = " the";
            button17.ForeColor = Color.White;
            button18.Text = " reading";
            button18.ForeColor = Color.White;
            button14.Enabled = true;
            button15.Enabled = true;
            button16.Enabled = true;
            button17.Enabled = true;
            button18.Enabled = true;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox5.Text += " our cat";
            button19.ForeColor = Color.Black;
            button19.Text = " o̶u̶r̶ ̶c̶a̶t̶";
            button19.Enabled = false;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox5.Text += " in my bed";
            button20.ForeColor = Color.Black;
            button20.Text = " i̶n̶ ̶m̶y̶ ̶b̶e̶d̶";
            button20.Enabled = false;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox5.Text += " sleeps";
            button21.ForeColor = Color.Black;
            button21.Text = " s̶l̶e̶e̶p̶s̶";
            button21.Enabled = false;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            textBox5.Text += " never";
            button22.ForeColor = Color.Black;
            button22.Text = " n̶e̶v̶e̶r̶";
            button22.Enabled = false;
        }

        private void button48_Click(object sender, EventArgs e)
        {
            textBox5.Clear();
            button19.Text = " our cat";
            button19.ForeColor = Color.White;
            button20.Text = " in my bed";
            button20.ForeColor = Color.White;
            button21.Text = " sleeps";
            button21.ForeColor = Color.White;
            button22.Text = " never";
            button22.ForeColor = Color.White;
            button19.Enabled = true;
            button20.Enabled = true;
            button21.Enabled = true;
            button22.Enabled = true;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            textBox6.Text += " window";
            button23.ForeColor = Color.Black;
            button23.Text = " w̶i̶n̶d̶o̶w̶";
            button23.Enabled = false;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            textBox6.Text += " now";
            button24.ForeColor = Color.Black;
            button24.Text = " n̶o̶w̶";
            button24.Enabled = false;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            textBox6.Text += " the";
            button25.ForeColor = Color.Black;
            button25.Text = " t̶h̶e̶";
            button25.Enabled = false;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            textBox6.Text += " Lisa";
            button26.ForeColor = Color.Black;
            button26.Text = " L̶i̶s̶a̶";
            button26.Enabled = false;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            textBox6.Text += " is";
            button27.ForeColor = Color.Black;
            button27.Text = " i̶s̶";
            button27.Enabled = false;
        }

        private void button28_Click(object sender, EventArgs e)
        {
            textBox6.Text += " opening";
            button28.ForeColor = Color.Black;
            button28.Text = " o̶p̶e̶n̶i̶n̶g̶";
            button28.Enabled = false;
        }

        private void button49_Click(object sender, EventArgs e)
        {
            textBox6.Clear();
            button23.Text = " window";
            button23.ForeColor = Color.White;
            button24.Text = " now";
            button24.ForeColor = Color.White;
            button25.Text = " the";
            button25.ForeColor = Color.White;
            button26.Text = " Lisa";
            button26.ForeColor = Color.White;
            button27.Text = " is";
            button27.ForeColor = Color.White;
            button28.Text = " opening";
            button28.ForeColor = Color.White;
            button23.Enabled = true;
            button24.Enabled = true;
            button25.Enabled = true;
            button26.Enabled = true;
            button27.Enabled = true;
            button28.Enabled = true;
        }

        private void button29_Click(object sender, EventArgs e)
        {
            textBox7.Text += " the bus";
            button29.ForeColor = Color.Black;
            button29.Text = " t̶h̶e̶ ̶b̶u̶s̶";
            button29.Enabled = false;
        }

        private void button30_Click(object sender, EventArgs e)
        {
            textBox7.Text += " always";
            button30.ForeColor = Color.Black;
            button30.Text = " a̶l̶w̶a̶y̶s̶";
            button30.Enabled = false;
        }

        private void button31_Click(object sender, EventArgs e)
        {
            textBox7.Text += " we";
            button31.ForeColor = Color.Black;
            button31.Text = " w̶e̶";
            button31.Enabled = false;
        }

        private void button32_Click(object sender, EventArgs e)
        {
            textBox7.Text += " take";
            button32.ForeColor = Color.Black;
            button32.Text = " t̶a̶k̶e̶";
            button32.Enabled = false;
        }

        private void button33_Click(object sender, EventArgs e)
        {
            textBox7.Text += " to school";
            button33.ForeColor = Color.Black;
            button33.Text = " t̶o̶ ̶s̶c̶h̶o̶o̶l̶";
            button33.Enabled = false;
        }

        private void button50_Click(object sender, EventArgs e)
        {
            textBox7.Clear();
            button29.Text = " the bus";
            button29.ForeColor = Color.White;
            button30.Text = " always";
            button30.ForeColor = Color.White;
            button31.Text = " we";
            button31.ForeColor = Color.White;
            button32.Text = " take";
            button32.ForeColor = Color.White;
            button33.Text = " to school";
            button33.ForeColor = Color.White;
            button29.Enabled = true;
            button30.Enabled = true;
            button31.Enabled = true;
            button32.Enabled = true;
            button33.Enabled = true;
        }

        private void button34_Click(object sender, EventArgs e)
        {
            textBox8.Text += " on";
            button34.ForeColor = Color.Black;
            button34.Text = " o̶n̶";
            button34.Enabled = false;
        }

        private void button35_Click(object sender, EventArgs e)
        {
            textBox8.Text += " are";
            button35.ForeColor = Color.Black;
            button35.Text = " a̶r̶e̶";
            button35.Enabled = false;
        }

        private void button36_Click(object sender, EventArgs e)
        {
            textBox8.Text += " sitting";
            button36.ForeColor = Color.Black;
            button36.Text = " s̶i̶t̶t̶i̶n̶g̶";
            button36.Enabled = false;
        }

        private void button37_Click(object sender, EventArgs e)
        {
            textBox8.Text += " sofa";
            button37.ForeColor = Color.Black;
            button37.Text = " s̶o̶f̶a̶";
            button37.Enabled = false;
        }

        private void button38_Click(object sender, EventArgs e)
        {
            textBox8.Text += " the";
            button38.ForeColor = Color.Black;
            button38.Text = " t̶h̶e̶";
            button38.Enabled = false;
        }

        private void button39_Click(object sender, EventArgs e)
        {
            textBox8.Text += " the grandparents";
            button39.ForeColor = Color.Black;
            button39.Text = " t̶h̶e̶ ̶g̶r̶a̶n̶d̶p̶a̶r̶e̶n̶t̶s̶";
            button39.Enabled = false;
        }

        private void button51_Click(object sender, EventArgs e)
        {
            textBox8.Clear();
            button34.Text = " on";
            button34.ForeColor = Color.White;
            button35.Text = " are";
            button35.ForeColor = Color.White;
            button36.Text = " sitting";
            button36.ForeColor = Color.White;
            button37.Text = " sofa";
            button37.ForeColor = Color.White;
            button38.Text = " the";
            button38.ForeColor = Color.White;
            button39.Text = " the grandparents";
            button39.ForeColor = Color.White;
            button34.Enabled = true;
            button35.Enabled = true;
            button36.Enabled = true;
            button37.Enabled = true;
            button38.Enabled = true;
            button39.Enabled = true;
        }

        private void button40_Click(object sender, EventArgs e)
        {
            textBox9.Text += " to";
            button40.ForeColor = Color.Black;
            button40.Text = " t̶o̶";
            button40.Enabled = false;
        }

        private void button41_Click(object sender, EventArgs e)
        {
            textBox9.Text += " school";
            button41.ForeColor = Color.Black;
            button41.Text = " s̶c̶h̶o̶o̶l̶";
            button41.Enabled = false;
        }

        private void button42_Click(object sender, EventArgs e)
        {
            textBox9.Text += " go";
            button42.ForeColor = Color.Black;
            button42.Text = " g̶o̶";
            button42.Enabled = false;
        }

        private void button43_Click(object sender, EventArgs e)
        {
            textBox9.Text += " breakfast";
            button43.ForeColor = Color.Black;
            button43.Text = " b̶r̶e̶a̶k̶f̶a̶s̶t̶";
            button43.Enabled = false;
        }

        private void button54_Click(object sender, EventArgs e)
        {
            textBox9.Text += " after";
            button54.ForeColor = Color.Black;
            button54.Text = " a̶f̶t̶e̶r̶";
            button54.Enabled = false;
        }

        private void button55_Click(object sender, EventArgs e)
        {
            textBox9.Text += " I";
            button55.ForeColor = Color.Black;
            button55.Text = " I̶";
            button55.Enabled = false;
        }

        private void button52_Click(object sender, EventArgs e)
        {
            textBox9.Clear();
            button40.Text = " to";
            button40.ForeColor = Color.White;
            button41.Text = " school";
            button41.ForeColor = Color.White;
            button42.Text = " go";
            button42.ForeColor = Color.White;
            button43.Text = " breakfast";
            button43.ForeColor = Color.White;
            button54.Text = " after";
            button54.ForeColor = Color.White;
            button55.Text = " I";
            button55.ForeColor = Color.White;
            button40.Enabled = true;
            button41.Enabled = true;
            button42.Enabled = true;
            button43.Enabled = true;
            button54.Enabled = true;
            button55.Enabled = true;
        }

        private void button56_Click(object sender, EventArgs e)
        {
            textBox10.Text += " seldom";
            button56.ForeColor = Color.Black;
            button56.Text = " s̶e̶l̶d̶o̶m̶";
            button56.Enabled = false;
        }

        private void button57_Click(object sender, EventArgs e)
        {
            textBox10.Text += " home";
            button57.ForeColor = Color.Black;
            button57.Text = " h̶o̶m̶e̶";
            button57.Enabled = false;
        }

        private void button58_Click(object sender, EventArgs e)
        {
            textBox10.Text += " before";
            button58.ForeColor = Color.Black;
            button58.Text = " b̶e̶f̶o̶r̶e̶";
            button58.Enabled = false;
        }

        private void button59_Click(object sender, EventArgs e)
        {
            textBox10.Text += " 9 pm";
            button59.ForeColor = Color.Black;
            button59.Text = " 9̶ ̶p̶m̶";
            button59.Enabled = false;
        }

        private void button60_Click(object sender, EventArgs e)
        {
            textBox10.Text += " comes";
            button60.ForeColor = Color.Black;
            button60.Text = " c̶o̶m̶e̶s̶";
            button60.Enabled = false;
        }

        private void button61_Click(object sender, EventArgs e)
        {
            textBox10.Text += " Andy";
            button61.ForeColor = Color.Black;
            button61.Text = " A̶n̶d̶y̶";
            button61.Enabled = false;
        }

        private void button53_Click(object sender, EventArgs e)
        {
            textBox10.Clear();
            button56.Text = " seldom";
            button56.ForeColor = Color.White;
            button57.Text = " home";
            button57.ForeColor = Color.White;
            button58.Text = " before";
            button58.ForeColor = Color.White;
            button59.Text = " 9 pm";
            button59.ForeColor = Color.White;
            button60.Text = " comes";
            button60.ForeColor = Color.White;
            button61.Text = " Andy";
            button61.ForeColor = Color.White;
            button56.Enabled = true;
            button57.Enabled = true;
            button58.Enabled = true;
            button59.Enabled = true;
            button60.Enabled = true;
            button61.Enabled = true;
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
            if (textBox1.Text.Equals(" I often watch sport on TV"))
            {
                label11.Text = "✓";
                label11.ForeColor = Color.Green;
                textBox1.BackColor = Color.Green;
                score = score + 1;
            }
            else
            {
                label11.Text = "I often watch sport on TV.";
                label11.ForeColor = Color.Green;
                textBox1.BackColor = Color.Red;
            }

            if (textBox2.Text.Equals(" my father is usually in the garden in the afternoon"))
            {
                label12.Text = "✓";
                label12.ForeColor = Color.Green;
                textBox2.BackColor = Color.Green;
                score = score + 1;
            }
            else
            {
                label12.Text = "My father is usually in the garden in the afternoon.";
                label12.ForeColor = Color.Green;
                textBox2.BackColor = Color.Red;
            }

            if (textBox3.Text.Equals(" she lives in Mexico"))
            {
                label13.Text = "✓";
                label13.ForeColor = Color.Green;
                textBox3.BackColor = Color.Green;
                score = score + 1;
            }
            else
            {
                label13.Text = "She lives in Mexico.";
                label13.ForeColor = Color.Green;
                textBox3.BackColor = Color.Red;
            }

            if (textBox4.Text.Equals(" he is reading the worksheet"))
            {
                label14.Text = "✓";
                label14.ForeColor = Color.Green;
                textBox4.BackColor = Color.Green;
                score = score + 1;
            }
            else
            {
                label14.Text = "He is reading the worksheet.";
                label14.ForeColor = Color.Green;
                textBox4.BackColor = Color.Red;
            }

            if (textBox5.Text.Equals(" our cat never sleeps in my bed"))
            {
                label15.Text = "✓";
                label15.ForeColor = Color.Green;
                textBox5.BackColor = Color.Green;
                score = score + 1;
            }
            else
            {
                label15.Text = "Our cat never sleeps in my bed.";
                label15.ForeColor = Color.Green;
                textBox5.BackColor = Color.Red;
            }

            if (textBox6.Text.Equals(" Lisa is opening the window now"))
            {
                label16.Text = "✓";
                label16.ForeColor = Color.Green;
                textBox6.BackColor = Color.Green;
                score = score + 1;
            }
            else
            {
                label16.Text = "Lisa is opening the window now.";
                label16.ForeColor = Color.Green;
                textBox6.BackColor = Color.Red;
            }

            if (textBox7.Text.Equals(" we always take the bus to school"))
            {
                label17.Text = "✓";
                label17.ForeColor = Color.Green;
                textBox7.BackColor = Color.Green;
                score = score + 1;
            }
            else
            {
                label17.Text = "We always take the bus to school.";
                label17.ForeColor = Color.Green;
                textBox7.BackColor = Color.Red;
            }

            if (textBox8.Text.Equals(" the grandparents are sitting on the sofa"))
            {
                label18.Text = "✓";
                label18.ForeColor = Color.Green;
                textBox8.BackColor = Color.Green;
                score = score + 1;
            }
            else
            {
                label18.Text = "The grandparents are sitting on the sofa.";
                label18.ForeColor = Color.Green;
                textBox8.BackColor = Color.Red;
            }

            if (textBox9.Text.Equals(" I go to school after breakfast"))
            {
                label19.Text = "✓";
                label19.ForeColor = Color.Green;
                textBox9.BackColor = Color.Green;
                score = score + 1;
            }
            else
            {
                label19.Text = "I go to school after breakfast.";
                label19.ForeColor = Color.Green;
                textBox9.BackColor = Color.Red;
            }

            if (textBox10.Text.Equals(" Andy seldom comes home before 9 pm"))
            {
                label20.Text = "✓";
                label20.ForeColor = Color.Green;
                textBox10.BackColor = Color.Green;
                score = score + 1;
            }
            else
            {
                label20.Text = "Andy seldom comes home before 9 pm.";
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
            textBox1.Text = " I often watch sport on TV";
            textBox2.Text = " my father is usually in the garden in the afternoon";
            textBox3.Text = " she lives in Mexico";
            textBox4.Text = " he is reading the worksheet";
            textBox5.Text = " our cat never sleeps in my bed";
            textBox6.Text = " Lisa is opening the window now";
            textBox7.Text = " we always take the bus to school";
            textBox8.Text = " the grandparents are sitting on the sofa";
            textBox9.Text = " I go to school after breakfast";
            textBox10.Text = " Andy seldom comes home before 9 pm";
            buttonVerify.Enabled = false;
            buttonVerify2.Hide();
        }

        private void buttonReseteazaExercitiul_Click(object sender, EventArgs e)
        {
            WordOrderInAffirmative openForm = new WordOrderInAffirmative();
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

        private void button63_Click(object sender, EventArgs e)
        {
            this.Close();
            WordOrderInPassive wordOrderInPassive = new WordOrderInPassive();
            wordOrderInPassive.Show();
        }

        private void button62_Click(object sender, EventArgs e)
        {
            this.Close();
            VerbsIrregularForm verbsIrregularForm = new VerbsIrregularForm();
            verbsIrregularForm.Show();
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

        private void button5_MouseHover(object sender, EventArgs e)
        {
            if (button5.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(button5.Text);
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

        private void label11_MouseHover(object sender, EventArgs e)
        {
            if (label11.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(label11.Text);
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

        private void textBox2_MouseHover(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(textBox2.Text);
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

        private void button13_MouseHover(object sender, EventArgs e)
        {
            if (button13.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(button13.Text);
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

        private void button34_MouseHover(object sender, EventArgs e)
        {
            if (button34.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(button34.Text);
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

        private void button54_MouseHover(object sender, EventArgs e)
        {
            if (button54.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(button54.Text);
            }
        }

        private void button55_MouseHover(object sender, EventArgs e)
        {
            if (button55.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(button55.Text);
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

        private void button56_MouseHover(object sender, EventArgs e)
        {
            if (button56.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(button56.Text);
            }
        }

        private void button57_MouseHover(object sender, EventArgs e)
        {
            if (button57.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(button57.Text);
            }
        }

        private void button58_MouseHover(object sender, EventArgs e)
        {
            if (button58.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(button58.Text);
            }
        }

        private void button59_MouseHover(object sender, EventArgs e)
        {
            if (button59.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(button59.Text);
            }
        }

        private void button60_MouseHover(object sender, EventArgs e)
        {
            if (button60.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(button60.Text);
            }
        }

        private void button61_MouseHover(object sender, EventArgs e)
        {
            if (button61.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(button61.Text);
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
            button54.Hide();
            button55.Hide();
            button56.Hide();
            button57.Hide();
            button58.Hide();
            button59.Hide();
            button60.Hide();
            button61.Hide();
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
            button109.Show();
            button110.Show();
            button111.Show();
            button112.Show();
            button113.Show();
            button114.Show();
            button115.Show();
            button116.Show();
            button117.Show();
            button118.Show();
            button119.Show();
            button120.Show();
            button121.Show();
            button122.Show();
            button123.Show();
            button124.Show();

            string fileName = "XMLOrdineaCuvintelorInPropozitiiAfirmative.xml";
            string path = Path.Combine(Environment.CurrentDirectory, @"", fileName);

            XmlTextReader xtr = new XmlTextReader(path);
            try
            {
                while (xtr.Read())
                {
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "one")
                    {
                        string s1 = xtr.ReadElementString();
                        button64.Text = ("" + s1);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "two")
                    {
                        string s2 = xtr.ReadElementString();
                        button65.Text = ("" + s2);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "three")
                    {
                        string s3 = xtr.ReadElementString();
                        button66.Text = ("" + s3);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "four")
                    {
                        string s4 = xtr.ReadElementString();
                        button67.Text = ("" + s4);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "five")
                    {
                        string s5 = xtr.ReadElementString();
                        button68.Text = ("" + s5);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "six")
                    {
                        string s6 = xtr.ReadElementString();
                        button69.Text = ("" + s6);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "seven")
                    {
                        string s7 = xtr.ReadElementString();
                        button70.Text = ("" + s7);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "eight")
                    {
                        string s8 = xtr.ReadElementString();
                        button71.Text = ("" + s8);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "nine")
                    {
                        string s9 = xtr.ReadElementString();
                        button72.Text = ("" + s9);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "ten")
                    {
                        string s10 = xtr.ReadElementString();
                        button73.Text = ("" + s10);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "eleven")
                    {
                        string s11 = xtr.ReadElementString();
                        button74.Text = ("" + s11);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "twelve")
                    {
                        string s12 = xtr.ReadElementString();
                        button75.Text = ("" + s12);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "thirteen")
                    {
                        string s13 = xtr.ReadElementString();
                        button76.Text = ("" + s13);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "fourteen")
                    {
                        string s14 = xtr.ReadElementString();
                        button77.Text = ("" + s14);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "fifteen")
                    {
                        string s15 = xtr.ReadElementString();
                        button78.Text = ("" + s15);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "sixteen")
                    {
                        string s16 = xtr.ReadElementString();
                        button79.Text = ("" + s16);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "seventeen")
                    {
                        string s17 = xtr.ReadElementString();
                        button80.Text = ("" + s17);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "eighteen")
                    {
                        string s18 = xtr.ReadElementString();
                        button81.Text = ("" + s18);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "nineteen")
                    {
                        string s19 = xtr.ReadElementString();
                        button82.Text = ("" + s19);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "twenty")
                    {
                        string s20 = xtr.ReadElementString();
                        button83.Text = ("" + s20);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "twentyone")
                    {
                        string s21 = xtr.ReadElementString();
                        button84.Text = ("" + s21);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "twentytwo")
                    {
                        string s22 = xtr.ReadElementString();
                        button85.Text = ("" + s22);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "twentythree")
                    {
                        string s23 = xtr.ReadElementString();
                        button86.Text = ("" + s23);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "thwentyfour")
                    {
                        string s24 = xtr.ReadElementString();
                        button87.Text = ("" + s24);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "twentyfive")
                    {
                        string s25 = xtr.ReadElementString();
                        button88.Text = ("" + s25);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "twentysix")
                    {
                        string s26 = xtr.ReadElementString();
                        button89.Text = ("" + s26);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "twentyseven")
                    {
                        string s27 = xtr.ReadElementString();
                        button90.Text = ("" + s27);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "twentyeight")
                    {
                        string s28 = xtr.ReadElementString();
                        button91.Text = ("" + s28);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "thirty")
                    {
                        string s30 = xtr.ReadElementString();
                        button93.Text = ("" + s30);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "thirtyone")
                    {
                        string s31 = xtr.ReadElementString();
                        button94.Text = ("" + s31);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "thirtytwo")
                    {
                        string s32 = xtr.ReadElementString();
                        button95.Text = ("" + s32);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "thirtythree")
                    {
                        string s33 = xtr.ReadElementString();
                        button96.Text = ("" + s33);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "thirtyfour")
                    {
                        string s34 = xtr.ReadElementString();
                        button97.Text = ("" + s34);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "thirtyfive")
                    {
                        string s35 = xtr.ReadElementString();
                        button98.Text = ("" + s35);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "thirtysix")
                    {
                        string s36 = xtr.ReadElementString();
                        button99.Text = ("" + s36);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "thirtyseven")
                    {
                        string s37 = xtr.ReadElementString();
                        button100.Text = ("" + s37);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "thirtyeight")
                    {
                        string s38 = xtr.ReadElementString();
                        button101.Text = ("" + s38);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "thirtynine")
                    {
                        string s39 = xtr.ReadElementString();
                        button102.Text = ("" + s39);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "fourty")
                    {
                        string s40 = xtr.ReadElementString();
                        button103.Text = ("" + s40);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "fourtyone")
                    {
                        string s41 = xtr.ReadElementString();
                        button104.Text = ("" + s41);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "fourtytwo")
                    {
                        string s42 = xtr.ReadElementString();
                        button105.Text = ("" + s42);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "fourtythree")
                    {
                        string s43 = xtr.ReadElementString();
                        button106.Text = ("" + s43);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "fourtyfour")
                    {
                        string s44 = xtr.ReadElementString();
                        button107.Text = ("" + s44);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "fourtyfive")
                    {
                        string s45 = xtr.ReadElementString();
                        button108.Text = ("" + s45);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "fourtysix")
                    {
                        string s46 = xtr.ReadElementString();
                        button109.Text = ("" + s46);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "fourtyseven")
                    {
                        string s47 = xtr.ReadElementString();
                        button110.Text = ("" + s47);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "fourtyeight")
                    {
                        string s48 = xtr.ReadElementString();
                        button111.Text = ("" + s48);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "fourtynine")
                    {
                        string s49 = xtr.ReadElementString();
                        button112.Text = ("" + s49);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "fifty")
                    {
                        string s50 = xtr.ReadElementString();
                        button113.Text = ("" + s50);
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "fiftyone")
                    {
                        string s51 = xtr.ReadElementString();
                        button114.Text = ("" + s51);
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
            if (textBox1.Text.Equals(" they sit on the beach"))
            {
                label11.Text = "✓";
                label11.ForeColor = Color.Green;
                textBox1.BackColor = Color.Green;
                newscore = newscore + 1;
            }
            else
            {
                label11.Text = "They sit on the beach.";
                label11.ForeColor = Color.Green;
                textBox1.BackColor = Color.Red;
            }

            if (textBox2.Text.Equals(" we often walk in the forest"))
            {
                label12.Text = "✓";
                label12.ForeColor = Color.Green;
                textBox2.BackColor = Color.Green;
                newscore = newscore + 1;
            }
            else
            {
                label12.Text = "We often walk in the forest.";
                label12.ForeColor = Color.Green;
                textBox2.BackColor = Color.Red;
            }

            if (textBox3.Text.Equals(" she is from Scotland"))
            {
                label13.Text = "✓";
                label13.ForeColor = Color.Green;
                textBox3.BackColor = Color.Green;
                newscore = newscore + 1;
            }
            else
            {
                label13.Text = "She is from Scotland.";
                label13.ForeColor = Color.Green;
                textBox3.BackColor = Color.Red;
            }

            if (textBox4.Text.Equals(" the boys are playing hockey"))
            {
                label14.Text = "✓";
                label14.ForeColor = Color.Green;
                textBox4.BackColor = Color.Green;
                newscore = newscore + 1;
            }
            else
            {
                label14.Text = "The boys are playing hockey.";
                label14.ForeColor = Color.Green;
                textBox4.BackColor = Color.Red;
            }

            if (textBox5.Text.Equals(" we sometimes write tests"))
            {
                label15.Text = "✓";
                label15.ForeColor = Color.Green;
                textBox5.BackColor = Color.Green;
                newscore = newscore + 1;
            }
            else
            {
                label15.Text = "We sometimes write tests.";
                label15.ForeColor = Color.Green;
                textBox5.BackColor = Color.Red;
            }

            if (textBox6.Text.Equals(" he has two brothers and one sister"))
            {
                label16.Text = "✓";
                label16.ForeColor = Color.Green;
                textBox6.BackColor = Color.Green;
                newscore = newscore + 1;
            }
            else
            {
                label16.Text = "He has two brothers and one sister.";
                label16.ForeColor = Color.Green;
                textBox6.BackColor = Color.Red;
            }

            if (textBox7.Text.Equals(" the girls go to the club every Saturday"))
            {
                label17.Text = "✓";
                label17.ForeColor = Color.Green;
                textBox7.BackColor = Color.Green;
                newscore = newscore + 1;
            }
            else
            {
                label17.Text = "The girls go to the club every Saturday.";
                label17.ForeColor = Color.Green;
                textBox7.BackColor = Color.Red;
            }

            if (textBox8.Text.Equals(" my father can take you home"))
            {
                label18.Text = "✓";
                label18.ForeColor = Color.Green;
                textBox8.BackColor = Color.Green;
                newscore = newscore + 1;
            }
            else
            {
                label18.Text = "My father can take you home.";
                label18.ForeColor = Color.Green;
                textBox8.BackColor = Color.Red;
            }

            if (textBox9.Text.Equals(" I get up after my sister"))
            {
                label19.Text = "✓";
                label19.ForeColor = Color.Green;
                textBox9.BackColor = Color.Green;
                newscore = newscore + 1;
            }
            else
            {
                label19.Text = "I get up after my sister.";
                label19.ForeColor = Color.Green;
                textBox9.BackColor = Color.Red;
            }

            if (textBox10.Text.Equals(" he always goes skating on Fridays"))
            {
                label20.Text = "✓";
                label20.ForeColor = Color.Green;
                textBox10.BackColor = Color.Green;
                newscore = newscore + 1;
            }
            else
            {
                label20.Text = "He always goes skating on Fridays.";
                label20.ForeColor = Color.Green;
                textBox10.BackColor = Color.Red;
            }

            buttonVerify2.Enabled = false;
            buttonShowAnswer2.Enabled = false;
            labelScore.Text = "";
            labelScore.Text += Convert.ToInt32(score) + Convert.ToInt32(newscore);
            passingText = labelScore.Text;
        }

        private void button64_Click(object sender, EventArgs e)
        {
            textBox1.Text += " they";
            button64.ForeColor = Color.Black;
            button64.Enabled = false;
        }

        private void button65_Click(object sender, EventArgs e)
        {
            textBox1.Text += " sit";
            button65.ForeColor = Color.Black;
            button65.Enabled = false;
        }

        private void button66_Click(object sender, EventArgs e)
        {
            textBox1.Text += " on";
            button66.ForeColor = Color.Black;
            button66.Enabled = false;
        }

        private void button67_Click(object sender, EventArgs e)
        {
            textBox1.Text += " the";
            button67.ForeColor = Color.Black;
            button67.Enabled = false;
        }

        private void button68_Click(object sender, EventArgs e)
        {
            textBox1.Text += " beach";
            button68.ForeColor = Color.Black;
            button68.Enabled = false;
        }

        private void button70_Click(object sender, EventArgs e)
        {
            textBox2.Text += " in the";
            button70.ForeColor = Color.Black;
            button70.Enabled = false;
        }

        private void button69_Click(object sender, EventArgs e)
        {
            textBox2.Text += " forest";
            button69.ForeColor = Color.Black;
            button69.Enabled = false;
        }

        private void button73_Click(object sender, EventArgs e)
        {
            textBox2.Text += " we";
            button73.ForeColor = Color.Black;
            button73.Enabled = false;
        }

        private void button72_Click(object sender, EventArgs e)
        {
            textBox2.Text += " walk";
            button72.ForeColor = Color.Black;
            button72.Enabled = false;
        }

        private void button71_Click(object sender, EventArgs e)
        {
            textBox2.Text += " often";
            button71.ForeColor = Color.Black;
            button71.Enabled = false;
        }

        private void button74_Click(object sender, EventArgs e)
        {
            textBox3.Text += " from Scotland";
            button74.ForeColor = Color.Black;
            button74.Enabled = false;
        }

        private void button76_Click(object sender, EventArgs e)
        {
            textBox3.Text += " she";
            button76.ForeColor = Color.Black;
            button76.Enabled = false;
        }

        private void button75_Click(object sender, EventArgs e)
        {
            textBox3.Text += " is";
            button75.ForeColor = Color.Black;
            button75.Enabled = false;
        }

        private void button78_Click(object sender, EventArgs e)
        {
            textBox4.Text += " are";
            button78.ForeColor = Color.Black;
            button78.Enabled = false;
        }

        private void button81_Click(object sender, EventArgs e)
        {
            textBox4.Text += " playing";
            button81.ForeColor = Color.Black;
            button81.Enabled = false;
        }

        private void button77_Click(object sender, EventArgs e)
        {
            textBox4.Text += " hockey";
            button77.ForeColor = Color.Black;
            button77.Enabled = false;
        }

        private void button80_Click(object sender, EventArgs e)
        {
            textBox4.Text += " the";
            button80.ForeColor = Color.Black;
            button80.Enabled = false;
        }

        private void button79_Click(object sender, EventArgs e)
        {
            textBox4.Text += " boys";
            button79.ForeColor = Color.Black;
            button79.Enabled = false;
        }

        private void button82_Click(object sender, EventArgs e)
        {
            textBox5.Text += " write";
            button82.ForeColor = Color.Black;
            button82.Enabled = false;
        }

        private void button83_Click(object sender, EventArgs e)
        {
            textBox5.Text += " sometimes";
            button83.ForeColor = Color.Black;
            button83.Enabled = false;
        }

        private void button85_Click(object sender, EventArgs e)
        {
            textBox5.Text += " we";
            button85.ForeColor = Color.Black;
            button85.Enabled = false;
        }

        private void button84_Click(object sender, EventArgs e)
        {
            textBox5.Text += " tests";
            button84.ForeColor = Color.Black;
            button84.Enabled = false;
        }

        private void button89_Click(object sender, EventArgs e)
        {
            textBox6.Text += " has";
            button89.ForeColor = Color.Black;
            button89.Enabled = false;
        }

        private void button88_Click(object sender, EventArgs e)
        {
            textBox6.Text += " he";
            button88.ForeColor = Color.Black;
            button88.Enabled = false;
        }

        private void button87_Click(object sender, EventArgs e)
        {
            textBox6.Text += " brothers";
            button87.ForeColor = Color.Black;
            button87.Enabled = false;
        }

        private void button86_Click(object sender, EventArgs e)
        {
            textBox6.Text += " sister";
            button86.ForeColor = Color.Black;
            button86.Enabled = false;
        }

        private void button91_Click(object sender, EventArgs e)
        {
            textBox6.Text += " two";
            button91.ForeColor = Color.Black;
            button91.Enabled = false;
        }

        private void button90_Click(object sender, EventArgs e)
        {
            textBox6.Text += " one";
            button90.ForeColor = Color.Black;
            button90.Enabled = false;
        }

        private void button92_Click(object sender, EventArgs e)
        {
            textBox7.Text += " the girls";
            button92.ForeColor = Color.Black;
            button92.Enabled = false;
        }

        private void button96_Click(object sender, EventArgs e)
        {
            textBox7.Text += " every";
            button96.ForeColor = Color.Black;
            button96.Enabled = false;
        }

        private void button95_Click(object sender, EventArgs e)
        {
            textBox7.Text += " go";
            button95.ForeColor = Color.Black;
            button95.Enabled = false;
        }

        private void button94_Click(object sender, EventArgs e)
        {
            textBox7.Text += " Saturday";
            button94.ForeColor = Color.Black;
            button94.Enabled = false;
        }

        private void button93_Click(object sender, EventArgs e)
        {
            textBox7.Text += " to the club";
            button93.ForeColor = Color.Black;
            button93.Enabled = false;
        }

        private void button99_Click(object sender, EventArgs e)
        {
            textBox8.Text += " take";
            button99.ForeColor = Color.Black;
            button99.Enabled = false;
        }

        private void button98_Click(object sender, EventArgs e)
        {
            textBox8.Text += " home";
            button98.ForeColor = Color.Black;
            button98.Enabled = false;
        }

        private void button97_Click(object sender, EventArgs e)
        {
            textBox8.Text += " my";
            button97.ForeColor = Color.Black;
            button97.Enabled = false;
        }

        private void button102_Click(object sender, EventArgs e)
        {
            textBox8.Text += " father";
            button102.ForeColor = Color.Black;
            button102.Enabled = false;
        }

        private void button101_Click(object sender, EventArgs e)
        {
            textBox8.Text += " can";
            button101.ForeColor = Color.Black;
            button101.Enabled = false;
        }

        private void button100_Click(object sender, EventArgs e)
        {
            textBox8.Text += " you";
            button100.ForeColor = Color.Black;
            button100.Enabled = false;
        }

        private void button103_Click(object sender, EventArgs e)
        {
            textBox9.Text += " I";
            button103.ForeColor = Color.Black;
            button103.Enabled = false;
        }

        private void button104_Click(object sender, EventArgs e)
        {
            textBox9.Text += " get";
            button104.ForeColor = Color.Black;
            button104.Enabled = false;
        }

        private void button105_Click(object sender, EventArgs e)
        {
            textBox9.Text += " up";
            button105.ForeColor = Color.Black;
            button105.Enabled = false;
        }

        private void button106_Click(object sender, EventArgs e)
        {
            textBox9.Text += " my";
            button106.ForeColor = Color.Black;
            button106.Enabled = false;
        }

        private void button107_Click(object sender, EventArgs e)
        {
            textBox9.Text += " sister";
            button107.ForeColor = Color.Black;
            button107.Enabled = false;
        }

        private void button108_Click(object sender, EventArgs e)
        {
            textBox9.Text += " after";
            button108.ForeColor = Color.Black;
            button108.Enabled = false;
        }

        private void button109_Click(object sender, EventArgs e)
        {
            textBox10.Text += " goes";
            button109.ForeColor = Color.Black;
            button109.Enabled = false;
        }

        private void button110_Click(object sender, EventArgs e)
        {
            textBox10.Text += " skating";
            button110.ForeColor = Color.Black;
            button110.Enabled = false;
        }

        private void button111_Click(object sender, EventArgs e)
        {
            textBox10.Text += " on";
            button111.ForeColor = Color.Black;
            button111.Enabled = false;
        }

        private void button112_Click(object sender, EventArgs e)
        {
            textBox10.Text += " Fridays";
            button112.ForeColor = Color.Black;
            button112.Enabled = false;
        }

        private void button113_Click(object sender, EventArgs e)
        {
            textBox10.Text += " he";
            button113.ForeColor = Color.Black;
            button113.Enabled = false;
        }

        private void button114_Click(object sender, EventArgs e)
        {
            textBox10.Text += " always";
            button114.ForeColor = Color.Black;
            button114.Enabled = false;
        }

        private void button115_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            button64.ForeColor = Color.White;
            button65.ForeColor = Color.White;
            button66.ForeColor = Color.White;
            button67.ForeColor = Color.White;
            button68.ForeColor = Color.White;
            button64.Enabled = true;
            button65.Enabled = true;
            button66.Enabled = true;
            button67.Enabled = true;
            button68.Enabled = true;
        }

        private void button116_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            button69.ForeColor = Color.White;
            button70.ForeColor = Color.White;
            button71.ForeColor = Color.White;
            button72.ForeColor = Color.White;
            button73.ForeColor = Color.White;
            button69.Enabled = true;
            button70.Enabled = true;
            button71.Enabled = true;
            button72.Enabled = true;
            button73.Enabled = true;
        }

        private void button117_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            button74.ForeColor = Color.White;
            button75.ForeColor = Color.White;
            button76.ForeColor = Color.White;
            button74.Enabled = true;
            button75.Enabled = true;
            button76.Enabled = true;
        }

        private void button118_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
            button77.ForeColor = Color.White;
            button78.ForeColor = Color.White;
            button79.ForeColor = Color.White;
            button80.ForeColor = Color.White;
            button81.ForeColor = Color.White;
            button77.Enabled = true;
            button78.Enabled = true;
            button79.Enabled = true;
            button80.Enabled = true;
            button81.Enabled = true;
        }

        private void button119_Click(object sender, EventArgs e)
        {
            textBox5.Clear();
            button82.ForeColor = Color.White;
            button83.ForeColor = Color.White;
            button84.ForeColor = Color.White;
            button85.ForeColor = Color.White;
            button82.Enabled = true;
            button83.Enabled = true;
            button84.Enabled = true;
            button85.Enabled = true;
        }

        private void button120_Click(object sender, EventArgs e)
        {
            textBox6.Clear();
            button86.ForeColor = Color.White;
            button87.ForeColor = Color.White;
            button88.ForeColor = Color.White;
            button89.ForeColor = Color.White;
            button90.ForeColor = Color.White;
            button91.ForeColor = Color.White;
            button86.Enabled = true;
            button87.Enabled = true;
            button88.Enabled = true;
            button89.Enabled = true;
            button90.Enabled = true;
            button91.Enabled = true;
        }

        private void button121_Click(object sender, EventArgs e)
        {
            textBox7.Clear();
            button92.ForeColor = Color.White;
            button93.ForeColor = Color.White;
            button94.ForeColor = Color.White;
            button95.ForeColor = Color.White;
            button96.ForeColor = Color.White;
            button92.Enabled = true;
            button93.Enabled = true;
            button94.Enabled = true;
            button95.Enabled = true;
            button96.Enabled = true;
        }

        private void button122_Click(object sender, EventArgs e)
        {
            textBox8.Clear();
            button97.ForeColor = Color.White;
            button98.ForeColor = Color.White;
            button99.ForeColor = Color.White;
            button100.ForeColor = Color.White;
            button101.ForeColor = Color.White;
            button102.ForeColor = Color.White;
            button97.Enabled = true;
            button98.Enabled = true;
            button99.Enabled = true;
            button100.Enabled = true;
            button101.Enabled = true;
            button102.Enabled = true;
        }

        private void button123_Click(object sender, EventArgs e)
        {
            textBox9.Clear();
            button103.ForeColor = Color.White;
            button104.ForeColor = Color.White;
            button105.ForeColor = Color.White;
            button106.ForeColor = Color.White;
            button107.ForeColor = Color.White;
            button108.ForeColor = Color.White;
            button103.Enabled = true;
            button104.Enabled = true;
            button105.Enabled = true;
            button106.Enabled = true;
            button107.Enabled = true;
            button108.Enabled = true;
        }

        private void button124_Click(object sender, EventArgs e)
        {
            textBox10.Clear();
            button109.ForeColor = Color.White;
            button110.ForeColor = Color.White;
            button111.ForeColor = Color.White;
            button112.ForeColor = Color.White;
            button113.ForeColor = Color.White;
            button114.ForeColor = Color.White;
            button109.Enabled = true;
            button110.Enabled = true;
            button111.Enabled = true;
            button112.Enabled = true;
            button113.Enabled = true;
            button114.Enabled = true;
        }

        private void buttonShowAnswer2_Click(object sender, EventArgs e)
        {
            textBox1.Text = " they sit on the beach";
            textBox2.Text = " we often walk in the forest";
            textBox3.Text = " she is from Scotland";
            textBox4.Text = " the boys are playing hockey";
            textBox5.Text = " we sometimes write tests";
            textBox6.Text = " he has two brothers and one sister";
            textBox7.Text = " the girls go to the club every Saturday";
            textBox8.Text = " my father can take you home";
            textBox9.Text = " I get up after my sister";
            textBox10.Text = " he always goes skating on Fridays";
            buttonVerify2.Enabled = false;
        }
    }
}
