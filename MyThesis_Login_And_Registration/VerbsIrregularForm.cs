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
    public partial class VerbsIrregularForm : Form
    {
        public VerbsIrregularForm()
        {
            InitializeComponent();
        }

        double score = 0;
        public static string passingText;

        private void buttonVerify_Click(object sender, EventArgs e)
        {
            //1)
            if(checkBox1.Checked && checkBox2.Checked && checkBox3.Checked)
            {
                checkBox1.ForeColor = Color.Green;
                checkBox2.ForeColor = Color.Red;
                checkBox3.ForeColor = Color.Red;
                label11.Text = "Correct answer: Infinitive";
                label11.ForeColor = Color.Green;
                score = score + 1;
            }
            else if(!checkBox1.Checked && checkBox2.Checked && checkBox3.Checked)
            {
                checkBox2.ForeColor = Color.Red;
                checkBox3.ForeColor = Color.Red;
                checkBox1.Hide();
                label11.Text = "Correct answer: Infinitive";
                label11.ForeColor = Color.Green;
            }
            else if(checkBox1.Checked && !checkBox2.Checked && checkBox3.Checked)
            {
                checkBox1.ForeColor = Color.Green;
                checkBox3.ForeColor = Color.Red;
                checkBox2.Hide();
                label11.Text = "Correct answer: Infinitive";
                label11.ForeColor = Color.Green;
                score = score + 1; ;
            }
            else if(checkBox1.Checked && checkBox2.Checked && !checkBox3.Checked)
            {
                checkBox1.ForeColor = Color.Green;
                checkBox2.ForeColor = Color.Red;
                checkBox3.Hide();
                label11.Text = "Correct answer: Infinitive";
                label11.ForeColor = Color.Green;
                score = score + 1; ;
            }
            else if(checkBox1.Checked && !checkBox2.Checked && !checkBox3.Checked)
            {
                checkBox1.ForeColor = Color.Green;
                checkBox2.Hide();
                checkBox3.Hide();
                label11.Text = "✓";
                label11.ForeColor = Color.Green;
                score = score + 1; ;
            }
            else if(!checkBox1.Checked && checkBox2.Checked && !checkBox3.Checked)
            {
                checkBox2.ForeColor = Color.Red;
                checkBox1.Hide();
                checkBox3.Hide();
                label11.Text = "Correct answer: Infinitive";
                label11.ForeColor = Color.Green;
            }
            else if (!checkBox1.Checked && !checkBox2.Checked && checkBox3.Checked)
            {
                checkBox3.ForeColor = Color.Red;
                checkBox1.Hide();
                checkBox2.Hide();
                label11.Text = "Correct answer: Infinitive";
                label11.ForeColor = Color.Green;
            }
            else if(!checkBox1.Checked && !checkBox2.Checked && !checkBox3.Checked)
            {
                checkBox1.Hide();
                checkBox2.Hide();
                checkBox3.Hide();
                label11.Text = "Correct answer: Infinitive";
                label11.ForeColor = Color.Green;
            }

            //2)
            if(checkBox4.Checked && checkBox5.Checked && checkBox6.Checked)
            {
                checkBox4.ForeColor = Color.Red;
                checkBox5.ForeColor = Color.Green;
                checkBox6.ForeColor = Color.Red;
                label12.Text = "Correct answer: Simple Past";
                label12.ForeColor = Color.Green;
                score = score + 1; ;
            }
            else if(!checkBox4.Checked && checkBox5.Checked && checkBox6.Checked)
            {
                checkBox5.ForeColor = Color.Green;
                checkBox6.ForeColor = Color.Red;
                checkBox4.Hide();
                label12.Text = "Correct answer: Simple Past";
                label12.ForeColor = Color.Green;
                score = score + 1; ;
            }
            else if(checkBox4.Checked && !checkBox5.Checked && checkBox6.Checked)
            {
                checkBox4.ForeColor = Color.Red;
                checkBox6.ForeColor = Color.Red;
                checkBox5.Hide();
                label12.Text = "Correct answer: Simple Past";
                label12.ForeColor = Color.Green;
            }
            else if(checkBox4.Checked && checkBox5.Checked && !checkBox6.Checked)
            {
                checkBox4.ForeColor = Color.Red;
                checkBox5.ForeColor = Color.Green;
                checkBox6.Hide();
                label12.Text = "Correct answer: Simple Past";
                label12.ForeColor = Color.Green;
                score = score + 1; ;
            }
            else if(checkBox4.Checked && !checkBox5.Checked && !checkBox6.Checked)
            {
                checkBox4.ForeColor = Color.Red;
                checkBox5.Hide();
                checkBox6.Hide();
                label12.Text = "Correct answer: Simple Past";
                label12.ForeColor = Color.Green;
            }
            else if(!checkBox4.Checked && checkBox5.Checked && !checkBox6.Checked)
            {
                checkBox5.ForeColor = Color.Green;
                checkBox4.Hide();
                checkBox6.Hide();
                label12.Text = "✓";
                label12.ForeColor = Color.Green;
                score = score + 1; ;
            }
            else if (!checkBox4.Checked && !checkBox5.Checked && checkBox6.Checked)
            {
                checkBox6.ForeColor = Color.Red;
                checkBox4.Hide();
                checkBox5.Hide();
                label12.Text = "Correct answer: Simple Past";
                label12.ForeColor = Color.Green;
            }
            else if(!checkBox4.Checked && !checkBox5.Checked && !checkBox6.Checked)
            {
                checkBox4.Hide();
                checkBox5.Hide();
                checkBox6.Hide();
                label12.Text = "Correct answer: Infinitive";
                label12.ForeColor = Color.Green;
            }

            //3)
            if (checkBox7.Checked && checkBox8.Checked && checkBox9.Checked)
            {
                checkBox7.ForeColor = Color.Red;
                checkBox8.ForeColor = Color.Green;
                checkBox9.ForeColor = Color.Green;
                label13.Text = "Correct answer: Simple Past, Past participle";
                label13.ForeColor = Color.Green;
                score = score + 1;
            }
            else if (!checkBox7.Checked && checkBox8.Checked && checkBox9.Checked)
            {
                checkBox8.ForeColor = Color.Green;
                checkBox9.ForeColor = Color.Green;
                checkBox7.Hide();
                label13.Text = "✓";
                label13.ForeColor = Color.Green;
                score = score + 1;
            }
            else if (checkBox7.Checked && !checkBox8.Checked && checkBox9.Checked)
            {
                checkBox7.ForeColor = Color.Red;
                checkBox9.ForeColor = Color.Green;
                checkBox8.Hide();
                label13.Text = "Correct answer: Simple Past, Past participle";
                label13.ForeColor = Color.Green;
                score = score + 0.5;
            }
            else if (checkBox7.Checked && checkBox8.Checked && !checkBox9.Checked)
            {
                checkBox7.ForeColor = Color.Red;
                checkBox8.ForeColor = Color.Green;
                checkBox9.Hide();
                label13.Text = "Correct answer: Simple Past, Past participle";
                label13.ForeColor = Color.Green;
                score = score + 0.5;
            }
            else if (checkBox7.Checked && !checkBox8.Checked && !checkBox9.Checked)
            {
                checkBox7.ForeColor = Color.Red;
                checkBox8.Hide();
                checkBox9.Hide();
                label13.Text = "Correct answer: Simple Past, Past participle";
                label13.ForeColor = Color.Green;
            }
            else if (!checkBox7.Checked && checkBox8.Checked && !checkBox9.Checked)
            {
                checkBox8.ForeColor = Color.Green;
                checkBox7.Hide();
                checkBox9.Hide();
                label13.Text = "Correct answer: Simple Past, Past participle";
                label13.ForeColor = Color.Green;
                score = score + 0.5;
            }
            else if (!checkBox7.Checked && !checkBox8.Checked && checkBox9.Checked)
            {
                checkBox9.ForeColor = Color.Green;
                checkBox7.Hide();
                checkBox8.Hide();
                label13.Text = "Correct answer: Simple Past, Past participle";
                label13.ForeColor = Color.Green;
                score = score + 0.5;
            }
            else if (!checkBox7.Checked && !checkBox8.Checked && !checkBox9.Checked)
            {
                checkBox7.Hide();
                checkBox8.Hide();
                checkBox9.Hide();
                label13.Text = "Correct answer: Simple Past, Past participle";
                label13.ForeColor = Color.Green;
            }

            //4)
            if (checkBox10.Checked && checkBox11.Checked && checkBox12.Checked)
            {
                checkBox10.ForeColor = Color.Green;
                checkBox11.ForeColor = Color.Red;
                checkBox12.ForeColor = Color.Green;
                label14.Text = "Correct answer: Infinitive, Past participle";
                label14.ForeColor = Color.Green;
                score = score + 1;
            }
            else if (!checkBox10.Checked && checkBox11.Checked && checkBox12.Checked)
            {
                checkBox11.ForeColor = Color.Red;
                checkBox12.ForeColor = Color.Green;
                checkBox10.Hide();
                label14.Text = "Correct answer: Infinitive, Past participle";
                label14.ForeColor = Color.Green;
                score = score + 0.5;
            }
            else if (checkBox10.Checked && !checkBox11.Checked && checkBox12.Checked)
            {
                checkBox10.ForeColor = Color.Green;
                checkBox12.ForeColor = Color.Green;
                checkBox11.Hide();
                label14.Text = "✓";
                label14.ForeColor = Color.Green;
                score = score + 1;
            }
            else if (checkBox10.Checked && checkBox11.Checked && !checkBox12.Checked)
            {
                checkBox10.ForeColor = Color.Green;
                checkBox11.ForeColor = Color.Red;
                checkBox12.Hide();
                label14.Text = "Correct answer: Infinitive, Past participle";
                label14.ForeColor = Color.Green;
                score = score + 0.5;
            }
            else if (checkBox10.Checked && !checkBox11.Checked && !checkBox12.Checked)
            {
                checkBox10.ForeColor = Color.Green;
                checkBox11.Hide();
                checkBox12.Hide();
                label14.Text = "Correct answer: Infinitive, Past participle";
                label14.ForeColor = Color.Green;
                score = score + 0.5;
            }
            else if (!checkBox10.Checked && checkBox11.Checked && !checkBox12.Checked)
            {
                checkBox11.ForeColor = Color.Red;
                checkBox10.Hide();
                checkBox12.Hide();
                label14.Text = "Correct answer: Infinitive, Past participle";
                label14.ForeColor = Color.Green;
            }
            else if (!checkBox10.Checked && !checkBox11.Checked && checkBox12.Checked)
            {
                checkBox12.ForeColor = Color.Green;
                checkBox10.Hide();
                checkBox11.Hide();
                label14.Text = "Correct answer: Infinitive, Past participle";
                label14.ForeColor = Color.Green;
                score = score + 0.5;
            }
            else if (!checkBox10.Checked && !checkBox11.Checked && !checkBox12.Checked)
            {
                checkBox10.Hide();
                checkBox11.Hide();
                checkBox12.Hide();
                label14.Text = "Correct answer: Infinitive, Past participle";
                label14.ForeColor = Color.Green;
            }

            //5)
            if (checkBox13.Checked && checkBox14.Checked && checkBox15.Checked)
            {
                checkBox13.ForeColor = Color.Green;
                checkBox14.ForeColor = Color.Red;
                checkBox15.ForeColor = Color.Red;
                label15.Text = "Correct answer: Infinitive";
                label15.ForeColor = Color.Green;
                score = score + 1;
            }
            else if (!checkBox13.Checked && checkBox14.Checked && checkBox15.Checked)
            {
                checkBox14.ForeColor = Color.Red;
                checkBox15.ForeColor = Color.Red;
                checkBox13.Hide();
                label15.Text = "Correct answer: Infinitive";
                label15.ForeColor = Color.Green;
            }
            else if (checkBox13.Checked && !checkBox14.Checked && checkBox15.Checked)
            {
                checkBox13.ForeColor = Color.Green;
                checkBox15.ForeColor = Color.Red;
                checkBox14.Hide();
                label15.Text = "Correct answer: Infinitive";
                label15.ForeColor = Color.Green;
                score = score + 1;
            }
            else if (checkBox13.Checked && checkBox14.Checked && !checkBox15.Checked)
            {
                checkBox13.ForeColor = Color.Green;
                checkBox14.ForeColor = Color.Red;
                checkBox15.Hide();
                label15.Text = "Correct answer: Infinitive";
                label15.ForeColor = Color.Green;
                score = score + 1;
            }
            else if (checkBox13.Checked && !checkBox14.Checked && !checkBox15.Checked)
            {
                checkBox13.ForeColor = Color.Green;
                checkBox14.Hide();
                checkBox15.Hide();
                label15.Text = "✓";
                label15.ForeColor = Color.Green;
                score = score + 1;
            }
            else if (!checkBox13.Checked && checkBox14.Checked && !checkBox15.Checked)
            {
                checkBox14.ForeColor = Color.Red;
                checkBox13.Hide();
                checkBox15.Hide();
                label15.Text = "Correct answer: Infinitive";
                label15.ForeColor = Color.Green;
            }
            else if (!checkBox13.Checked && !checkBox14.Checked && checkBox15.Checked)
            {
                checkBox15.ForeColor = Color.Red;
                checkBox13.Hide();
                checkBox15.Hide();
                label15.Text = "Correct answer: Infinitive";
                label15.ForeColor = Color.Green;
            }
            else if (!checkBox13.Checked && !checkBox14.Checked && !checkBox15.Checked)
            {
                checkBox13.Hide();
                checkBox14.Hide();
                checkBox15.Hide();
                label15.Text = "Correct answer: Infinitive";
                label15.ForeColor = Color.Green;
            }

            //6)
            if (checkBox16.Checked && checkBox17.Checked && checkBox18.Checked)
            {
                checkBox16.ForeColor = Color.Red;
                checkBox17.ForeColor = Color.Green;
                checkBox18.ForeColor = Color.Green;
                label16.Text = "Correct answer: Simple Past, Past participle";
                label16.ForeColor = Color.Green;
                score = score + 1;
            }
            else if (!checkBox16.Checked && checkBox17.Checked && checkBox18.Checked)
            {
                checkBox17.ForeColor = Color.Green;
                checkBox18.ForeColor = Color.Green;
                checkBox16.Hide();
                label16.Text = "✓";
                label16.ForeColor = Color.Green;
                score = score + 1;
            }
            else if (checkBox16.Checked && !checkBox17.Checked && checkBox18.Checked)
            {
                checkBox16.ForeColor = Color.Red;
                checkBox18.ForeColor = Color.Green;
                checkBox17.Hide();
                label16.Text = "Correct answer: Simple Past, Past participle";
                label16.ForeColor = Color.Green;
                score = score + 0.5;
            }
            else if (checkBox16.Checked && checkBox17.Checked && !checkBox18.Checked)
            {
                checkBox16.ForeColor = Color.Red;
                checkBox17.ForeColor = Color.Green;
                checkBox18.Hide();
                label16.Text = "Correct answer: Simple Past, Past participle";
                label16.ForeColor = Color.Green;
                score = score + 0.5;
            }
            else if (checkBox16.Checked && !checkBox17.Checked && !checkBox18.Checked)
            {
                checkBox16.ForeColor = Color.Red;
                checkBox17.Hide();
                checkBox18.Hide();
                label16.Text = "Correct answer: Simple Past, Past participle";
                label16.ForeColor = Color.Green;
            }
            else if (!checkBox16.Checked && checkBox17.Checked && !checkBox18.Checked)
            {
                checkBox17.ForeColor = Color.Green;
                checkBox16.Hide();
                checkBox18.Hide();
                label16.Text = "Correct answer: Simple Past, Past participle";
                label16.ForeColor = Color.Green;
                score = score + 0.5;
            }
            else if (!checkBox16.Checked && !checkBox17.Checked && checkBox18.Checked)
            {
                checkBox18.ForeColor = Color.Green;
                checkBox16.Hide();
                checkBox17.Hide();
                label16.Text = "Correct answer: Simple Past, Past participle";
                label16.ForeColor = Color.Green;
                score = score + 0.5;
            }
            else if (!checkBox16.Checked && !checkBox17.Checked && !checkBox18.Checked)
            {
                checkBox16.Hide();
                checkBox17.Hide();
                checkBox18.Hide();
                label16.Text = "Correct answer: Simple Past, Past participle";
                label16.ForeColor = Color.Green;
            }

            //7)
            if (checkBox19.Checked && checkBox20.Checked && checkBox21.Checked)
            {
                checkBox19.ForeColor = Color.Green;
                checkBox20.ForeColor = Color.Red;
                checkBox21.ForeColor = Color.Red;
                label17.Text = "Correct answer: Infinitive";
                label17.ForeColor = Color.Green;
                score = score + 1;
            }
            else if (!checkBox19.Checked && checkBox20.Checked && checkBox21.Checked)
            {
                checkBox20.ForeColor = Color.Red;
                checkBox21.ForeColor = Color.Red;
                checkBox19.Hide();
                label17.Text = "Correct answer: Infinitive";
                label17.ForeColor = Color.Green;
            }
            else if (checkBox19.Checked && !checkBox20.Checked && checkBox21.Checked)
            {
                checkBox19.ForeColor = Color.Green;
                checkBox21.ForeColor = Color.Red;
                checkBox20.Hide();
                label17.Text = "Correct answer: Infinitive";
                label17.ForeColor = Color.Green;
                score = score + 1;
            }
            else if (checkBox19.Checked && checkBox20.Checked && !checkBox21.Checked)
            {
                checkBox19.ForeColor = Color.Green;
                checkBox20.ForeColor = Color.Red;
                checkBox21.Hide();
                label17.Text = "Correct answer: Infinitive";
                label17.ForeColor = Color.Green;
                score = score + 1;
            }
            else if (checkBox19.Checked && !checkBox20.Checked && !checkBox21.Checked)
            {
                checkBox19.ForeColor = Color.Green;
                checkBox20.Hide();
                checkBox21.Hide();
                label17.Text = "✓";
                label17.ForeColor = Color.Green;
                score = score + 1;
            }
            else if (!checkBox19.Checked && checkBox20.Checked && !checkBox21.Checked)
            {
                checkBox20.ForeColor = Color.Red;
                checkBox19.Hide();
                checkBox21.Hide();
                label17.Text = "Correct answer: Infinitive";
                label17.ForeColor = Color.Green;
            }
            else if (!checkBox19.Checked && !checkBox20.Checked && checkBox21.Checked)
            {
                checkBox21.ForeColor = Color.Red;
                checkBox19.Hide();
                checkBox20.Hide();
                label17.Text = "Correct answer: Infinitive";
                label17.ForeColor = Color.Green;
            }
            else if (!checkBox19.Checked && !checkBox20.Checked && !checkBox21.Checked)
            {
                checkBox19.Hide();
                checkBox20.Hide();
                checkBox21.Hide();
                label17.Text = "Correct answer: Infinitive";
                label17.ForeColor = Color.Green;
            }

            //8)
            if (checkBox22.Checked && checkBox23.Checked && checkBox24.Checked)
            {
                checkBox22.ForeColor = Color.Green;
                checkBox23.ForeColor = Color.Green;
                checkBox24.ForeColor = Color.Green;
                label18.Text = "✓";
                label18.ForeColor = Color.Green;
                score = score + 1;
            }
            else if (!checkBox22.Checked && checkBox23.Checked && checkBox24.Checked)
            {
                checkBox23.ForeColor = Color.Green;
                checkBox24.ForeColor = Color.Green;
                checkBox22.Hide();
                label18.Text = "Correct answer: Infinitive, Simple Past, Past participle";
                label18.ForeColor = Color.Green;
                score = score + 0.666;
            }
            else if (checkBox22.Checked && !checkBox23.Checked && checkBox24.Checked)
            {
                checkBox22.ForeColor = Color.Green;
                checkBox24.ForeColor = Color.Green;
                checkBox23.Hide();
                label18.Text = "Correct answer: Infinitive, Simple Past, Past participle";
                label18.ForeColor = Color.Green;
                score = score + 0.666;
            }
            else if (checkBox22.Checked && checkBox23.Checked && !checkBox24.Checked)
            {
                checkBox22.ForeColor = Color.Green;
                checkBox23.ForeColor = Color.Green;
                checkBox24.Hide();
                label18.Text = "Correct answer: Infinitive, Simple Past, Past participle";
                label18.ForeColor = Color.Green;
                score = score + 0.666;
            }
            else if (checkBox22.Checked && !checkBox23.Checked && !checkBox24.Checked)
            {
                checkBox22.ForeColor = Color.Green;
                checkBox23.Hide();
                checkBox24.Hide();
                label18.Text = "Correct answer: Infinitive, Simple Past, Past participle";
                label18.ForeColor = Color.Green;
                score = score + 0.333;
            }
            else if (!checkBox22.Checked && checkBox23.Checked && !checkBox24.Checked)
            {
                checkBox23.ForeColor = Color.Green;
                checkBox22.Hide();
                checkBox24.Hide();
                label18.Text = "Correct answer: Infinitive, Simple Past, Past participle";
                label18.ForeColor = Color.Green;
                score = score + 0.333;
            }
            else if (!checkBox22.Checked && !checkBox23.Checked && checkBox24.Checked)
            {
                checkBox24.ForeColor = Color.Green;
                checkBox22.Hide();
                checkBox23.Hide();
                label18.Text = "Correct answer: Infinitive, Simple Past, Past participle";
                label18.ForeColor = Color.Green;
                score = score + 0.333;
            }
            else if (!checkBox22.Checked && !checkBox23.Checked && !checkBox24.Checked)
            {
                checkBox22.Hide();
                checkBox23.Hide();
                checkBox24.Hide();
                label18.Text = "Correct answer: Infinitive, Simple Past, Past participle";
                label18.ForeColor = Color.Green;
            }

            //9)
            if (checkBox25.Checked && checkBox26.Checked && checkBox27.Checked)
            {
                checkBox25.ForeColor = Color.Red;
                checkBox26.ForeColor = Color.Red;
                checkBox27.ForeColor = Color.Green;
                label19.Text = "Correct answer: Past participle";
                label19.ForeColor = Color.Green;
                score = score + 1;
            }
            else if (!checkBox25.Checked && checkBox26.Checked && checkBox27.Checked)
            {
                checkBox26.ForeColor = Color.Red;
                checkBox27.ForeColor = Color.Green;
                checkBox25.Hide();
                label19.Text = "Correct answer: Past participle";
                label19.ForeColor = Color.Green;
                score = score + 1;
            }
            else if (checkBox25.Checked && !checkBox26.Checked && checkBox27.Checked)
            {
                checkBox27.ForeColor = Color.Green;
                checkBox25.ForeColor = Color.Red;
                checkBox26.Hide();
                label19.Text = "Correct answer: Past participle";
                label19.ForeColor = Color.Green;
                score = score + 1;
            }
            else if (checkBox25.Checked && checkBox26.Checked && !checkBox27.Checked)
            {
                checkBox25.ForeColor = Color.Red;
                checkBox26.ForeColor = Color.Red;
                checkBox27.Hide();
                label19.Text = "Correct answer: Past participle";
                label19.ForeColor = Color.Green;
            }
            else if (checkBox25.Checked && !checkBox26.Checked && !checkBox27.Checked)
            {
                checkBox25.ForeColor = Color.Red;
                checkBox26.Hide();
                checkBox27.Hide();
                label19.Text = "Correct answer: Past participle";
                label19.ForeColor = Color.Green;
            }
            else if (!checkBox25.Checked && checkBox26.Checked && !checkBox27.Checked)
            {
                checkBox26.ForeColor = Color.Red;
                checkBox25.Hide();
                checkBox27.Hide();
                label19.Text = "Correct answer: Past participle";
                label19.ForeColor = Color.Green;
            }
            else if (!checkBox25.Checked && !checkBox26.Checked && checkBox27.Checked)
            {
                checkBox27.ForeColor = Color.Green;
                checkBox25.Hide();
                checkBox26.Hide();
                label19.Text = "✓";
                label19.ForeColor = Color.Green;
                score = score + 1;
            }
            else if (!checkBox25.Checked && !checkBox26.Checked && !checkBox27.Checked)
            {
                checkBox25.Hide();
                checkBox26.Hide();
                checkBox27.Hide();
                label19.Text = "Correct answer: Past participle";
                label19.ForeColor = Color.Green;
            }

            //10)
            if (checkBox28.Checked && checkBox29.Checked && checkBox30.Checked)
            {
                checkBox28.ForeColor = Color.Red;
                checkBox29.ForeColor = Color.Green;
                checkBox30.ForeColor = Color.Green;
                label20.Text = "Correct answer: Simple Past, Past participle";
                label20.ForeColor = Color.Green;
                score = score + 1;
            }
            else if (!checkBox28.Checked && checkBox29.Checked && checkBox30.Checked)
            {
                checkBox29.ForeColor = Color.Green;
                checkBox30.ForeColor = Color.Green;
                checkBox28.Hide();
                label20.Text = "✓";
                label20.ForeColor = Color.Green;
                score = score + 1;
            }
            else if (checkBox28.Checked && !checkBox29.Checked && checkBox30.Checked)
            {
                checkBox28.ForeColor = Color.Red;
                checkBox30.ForeColor = Color.Green;
                checkBox29.Hide();
                label20.Text = "Correct answer: Simple Past, Past participle";
                label20.ForeColor = Color.Green;
                score = score + 0.5;
            }
            else if (checkBox28.Checked && checkBox29.Checked && !checkBox30.Checked)
            {
                checkBox28.ForeColor = Color.Red;
                checkBox29.ForeColor = Color.Green;
                checkBox30.Hide();
                label20.Text = "Correct answer: Simple Past, Past participle";
                label20.ForeColor = Color.Green;
                score = score + 0.5;
            }
            else if (checkBox28.Checked && !checkBox29.Checked && !checkBox30.Checked)
            {
                checkBox28.ForeColor = Color.Red;
                checkBox29.Hide();
                checkBox30.Hide();
                label20.Text = "Correct answer: Simple Past, Past participle";
                label20.ForeColor = Color.Green;
            }
            else if (!checkBox28.Checked && checkBox29.Checked && !checkBox30.Checked)
            {
                checkBox17.ForeColor = Color.Green;
                checkBox16.Hide();
                checkBox18.Hide();
                label16.Text = "Correct answer: Simple Past, Past participle";
                label16.ForeColor = Color.Green;
                score = score + 0.5;
            }
            else if (!checkBox28.Checked && !checkBox29.Checked && checkBox30.Checked)
            {
                checkBox30.ForeColor = Color.Green;
                checkBox28.Hide();
                checkBox29.Hide();
                label20.Text = "Correct answer: Simple Past, Past participle";
                label20.ForeColor = Color.Green;
                score = score + 0.5;
            }
            else if (!checkBox28.Checked && !checkBox29.Checked && !checkBox30.Checked)
            {
                checkBox28.Hide();
                checkBox29.Hide();
                checkBox30.Hide();
                label20.Text = "Correct answer: Simple Past, Past participle";
                label20.ForeColor = Color.Green;
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
            checkBox1.ForeColor = Color.Green;
            checkBox5.ForeColor = Color.Green;
            checkBox8.ForeColor = Color.Green;
            checkBox9.ForeColor = Color.Green;
            checkBox10.ForeColor = Color.Green;
            checkBox12.ForeColor = Color.Green;
            checkBox13.ForeColor = Color.Green;
            checkBox17.ForeColor = Color.Green;
            checkBox18.ForeColor = Color.Green;
            checkBox19.ForeColor = Color.Green;
            checkBox22.ForeColor = Color.Green;
            checkBox23.ForeColor = Color.Green;
            checkBox24.ForeColor = Color.Green;
            checkBox27.ForeColor = Color.Green;
            checkBox29.ForeColor = Color.Green;
            checkBox30.ForeColor = Color.Green;
            buttonVerify.Enabled = false;
            buttonVerify2.Hide();

        }

        private void buttonGoBack2_Click(object sender, EventArgs e)
        {
            GrammarExercises openForm = new GrammarExercises();
            openForm.Show();
            Visible = false;
        }

        private void buttonRepetaExercitiul_Click(object sender, EventArgs e)
        {
            VerbsIrregularForm openForm = new VerbsIrregularForm();
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
            WordOrderInAffirmative wordOrderInAffirmative = new WordOrderInAffirmative();
            wordOrderInAffirmative.Show();
        }

        private void buttonExercitiulUrmator_Click(object sender, EventArgs e)
        {
            this.Close();
            TensesPresentPerfect tensesPresentPerfect = new TensesPresentPerfect();
            tensesPresentPerfect.Show();
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

            checkBox1.Hide();
            checkBox2.Hide();
            checkBox3.Hide();
            checkBox4.Hide();
            checkBox5.Hide();
            checkBox6.Hide();
            checkBox7.Hide();
            checkBox8.Hide();
            checkBox9.Hide();
            checkBox10.Hide();
            checkBox11.Hide();
            checkBox12.Hide();
            checkBox13.Hide();
            checkBox14.Hide();
            checkBox15.Hide();
            checkBox16.Hide();
            checkBox17.Hide();
            checkBox18.Hide();
            checkBox19.Hide();
            checkBox20.Hide();
            checkBox21.Hide();
            checkBox22.Hide();
            checkBox23.Hide();
            checkBox24.Hide();
            checkBox25.Hide();
            checkBox26.Hide();
            checkBox27.Hide();
            checkBox28.Hide();
            checkBox29.Hide();
            checkBox30.Hide();

            checkBox31.Show();
            checkBox32.Show();
            checkBox33.Show();
            checkBox34.Show();
            checkBox35.Show();
            checkBox36.Show();
            checkBox37.Show();
            checkBox38.Show();
            checkBox39.Show();
            checkBox40.Show();
            checkBox41.Show();
            checkBox42.Show();
            checkBox43.Show();
            checkBox44.Show();
            checkBox45.Show();
            checkBox46.Show();
            checkBox47.Show();
            checkBox48.Show();
            checkBox49.Show();
            checkBox50.Show();
            checkBox51.Show();
            checkBox52.Show();
            checkBox53.Show();
            checkBox54.Show();
            checkBox55.Show();
            checkBox56.Show();
            checkBox57.Show();
            checkBox58.Show();
            checkBox59.Show();
            checkBox60.Show();

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

            string fileName = "XMLVerbeFormaNeregulata.xml";
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

        double newscore = 0;

        private void buttonVerify2_Click(object sender, EventArgs e)
        {
            //1)
            if (checkBox31.Checked && checkBox32.Checked && checkBox33.Checked)
            {
                checkBox31.ForeColor = Color.Red;
                checkBox32.ForeColor = Color.Green;
                checkBox33.ForeColor = Color.Red;
                label11.Text = "Correct answer: Past simple";
                label11.ForeColor = Color.Green;
                newscore = newscore + 1;
            }
            else if (!checkBox31.Checked && checkBox32.Checked && checkBox33.Checked)
            {
                checkBox32.ForeColor = Color.Green;
                checkBox33.ForeColor = Color.Red;
                checkBox31.Hide();
                label11.Text = "Correct answer: Past simple";
                label11.ForeColor = Color.Green;
                newscore = newscore + 1;
            }
            else if (checkBox31.Checked && !checkBox32.Checked && checkBox33.Checked)
            {
                checkBox31.ForeColor = Color.Red;
                checkBox33.ForeColor = Color.Red;
                checkBox32.Hide();
                label11.Text = "Correct answer: Past simple";
                label11.ForeColor = Color.Green;
            }
            else if (checkBox31.Checked && checkBox32.Checked && !checkBox33.Checked)
            {
                checkBox31.ForeColor = Color.Red;
                checkBox32.ForeColor = Color.Green;
                checkBox33.Hide();
                label11.Text = "Correct answer: Past simple";
                label11.ForeColor = Color.Green;
                newscore = newscore + 1;
            }
            else if (checkBox31.Checked && !checkBox32.Checked && !checkBox33.Checked)
            {
                checkBox31.ForeColor = Color.Red;
                checkBox32.Hide();
                checkBox33.Hide();
                label11.Text = "Correct answer: Past simple";
                label11.ForeColor = Color.Green;
            }
            else if (!checkBox31.Checked && checkBox32.Checked && !checkBox33.Checked)
            {
                checkBox32.ForeColor = Color.Green;
                checkBox31.Hide();
                checkBox33.Hide();
                label11.Text = "✓";
                label11.ForeColor = Color.Green;
                newscore = newscore + 1;
            }
            else if (!checkBox31.Checked && !checkBox32.Checked && checkBox33.Checked)
            {
                checkBox33.ForeColor = Color.Red;
                checkBox31.Hide();
                checkBox32.Hide();
                label11.Text = "Correct answer: Past simple";
                label11.ForeColor = Color.Green;
            }
            else if (!checkBox31.Checked && !checkBox32.Checked && !checkBox33.Checked)
            {
                checkBox31.Hide();
                checkBox32.Hide();
                checkBox33.Hide();
                label11.Text = "Correct answer: Past simple";
                label11.ForeColor = Color.Green;
            }

            //2)
            if (checkBox34.Checked && checkBox35.Checked && checkBox36.Checked)
            {
                checkBox34.ForeColor = Color.Green;
                checkBox35.ForeColor = Color.Green;
                checkBox36.ForeColor = Color.Green;
                label12.Text = "✓";
                label12.ForeColor = Color.Green;
                newscore = newscore + 1;
            }
            else if (!checkBox34.Checked && checkBox35.Checked && checkBox36.Checked)
            {
                checkBox35.ForeColor = Color.Green;
                checkBox36.ForeColor = Color.Green;
                checkBox34.Hide();
                label12.Text = "Correct answer: Infinitive, Simple Past, Past part.";
                label12.ForeColor = Color.Green;
                newscore = newscore + 0.666;
            }
            else if (checkBox34.Checked && !checkBox35.Checked && checkBox36.Checked)
            {
                checkBox34.ForeColor = Color.Green;
                checkBox36.ForeColor = Color.Green;
                checkBox35.Hide();
                label12.Text = "Correct answer: Infinitive, Simple Past, Past participle";
                label12.ForeColor = Color.Green;
                newscore = newscore + 0.666;
            }
            else if (checkBox34.Checked && checkBox35.Checked && !checkBox36.Checked)
            {
                checkBox34.ForeColor = Color.Green;
                checkBox35.ForeColor = Color.Green;
                checkBox36.Hide();
                label12.Text = "Correct answer: Infinitive, Simple Past, Past participle";
                label12.ForeColor = Color.Green;
                newscore = newscore + 0.666;
            }
            else if (checkBox34.Checked && !checkBox35.Checked && !checkBox36.Checked)
            {
                checkBox34.ForeColor = Color.Green;
                checkBox35.Hide();
                checkBox36.Hide();
                label12.Text = "Correct answer: Infinitive, Simple Past, Past participle";
                label12.ForeColor = Color.Green;
                newscore = newscore + 0.333;
            }
            else if (!checkBox34.Checked && checkBox35.Checked && !checkBox36.Checked)
            {
                checkBox35.ForeColor = Color.Green;
                checkBox34.Hide();
                checkBox36.Hide();
                label12.Text = "Correct answer: Infinitive, Simple Past, Past participle";
                label12.ForeColor = Color.Green;
                newscore = newscore + 0.333;
            }
            else if (!checkBox34.Checked && !checkBox35.Checked && checkBox36.Checked)
            {
                checkBox36.ForeColor = Color.Green;
                checkBox34.Hide();
                checkBox35.Hide();
                label12.Text = "Correct answer: Infinitive, Simple Past, Past participle";
                label12.ForeColor = Color.Green;
                newscore = newscore + 0.333;
            }
            else if (!checkBox34.Checked && !checkBox35.Checked && !checkBox36.Checked)
            {
                checkBox34.Hide();
                checkBox35.Hide();
                checkBox36.Hide();
                label12.Text = "Correct answer: Infinitive, Simple Past, Past participle";
                label12.ForeColor = Color.Green;
            }

            //3)
            if (checkBox37.Checked && checkBox38.Checked && checkBox39.Checked)
            {
                checkBox37.ForeColor = Color.Red;
                checkBox38.ForeColor = Color.Green;
                checkBox39.ForeColor = Color.Green;
                label13.Text = "Correct answer: Simple Past, Past participle";
                label13.ForeColor = Color.Green;
                newscore = newscore + 1;
            }
            else if (!checkBox37.Checked && checkBox38.Checked && checkBox39.Checked)
            {
                checkBox38.ForeColor = Color.Green;
                checkBox39.ForeColor = Color.Green;
                checkBox37.Hide();
                label13.Text = "✓";
                label13.ForeColor = Color.Green;
                newscore = newscore + 1;
            }
            else if (checkBox37.Checked && !checkBox38.Checked && checkBox39.Checked)
            {
                checkBox37.ForeColor = Color.Red;
                checkBox39.ForeColor = Color.Green;
                checkBox38.Hide();
                label13.Text = "Correct answer: Simple Past, Past participle";
                label13.ForeColor = Color.Green;
                newscore = newscore + 0.5;
            }
            else if (checkBox37.Checked && checkBox38.Checked && !checkBox39.Checked)
            {
                checkBox37.ForeColor = Color.Red;
                checkBox38.ForeColor = Color.Green;
                checkBox39.Hide();
                label13.Text = "Correct answer: Simple Past, Past participle";
                label13.ForeColor = Color.Green;
                newscore = newscore + 0.5;
            }
            else if (checkBox37.Checked && !checkBox38.Checked && !checkBox39.Checked)
            {
                checkBox37.ForeColor = Color.Red;
                checkBox38.Hide();
                checkBox39.Hide();
                label13.Text = "Correct answer: Simple Past, Past participle";
                label13.ForeColor = Color.Green;
            }
            else if (!checkBox37.Checked && checkBox38.Checked && !checkBox39.Checked)
            {
                checkBox38.ForeColor = Color.Green;
                checkBox37.Hide();
                checkBox39.Hide();
                label13.Text = "Correct answer: Simple Past, Past participle";
                label13.ForeColor = Color.Green;
                newscore = newscore + 0.5;
            }
            else if (!checkBox37.Checked && !checkBox38.Checked && checkBox39.Checked)
            {
                checkBox39.ForeColor = Color.Green;
                checkBox37.Hide();
                checkBox38.Hide();
                label13.Text = "Correct answer: Simple Past, Past participle";
                label13.ForeColor = Color.Green;
                newscore = newscore + 0.5;
            }
            else if (!checkBox37.Checked && !checkBox38.Checked && !checkBox39.Checked)
            {
                checkBox37.Hide();
                checkBox38.Hide();
                checkBox39.Hide();
                label13.Text = "Correct answer: Simple Past, Past participle";
                label13.ForeColor = Color.Green;
            }

            //4)
            if (checkBox40.Checked && checkBox41.Checked && checkBox42.Checked)
            {
                checkBox40.ForeColor = Color.Green;
                checkBox41.ForeColor = Color.Red;
                checkBox42.ForeColor = Color.Red;
                label14.Text = "Correct answer: Infinitive";
                label14.ForeColor = Color.Green;
                newscore = newscore + 1;
            }
            else if (!checkBox40.Checked && checkBox41.Checked && checkBox42.Checked)
            {
                checkBox41.ForeColor = Color.Red;
                checkBox42.ForeColor = Color.Red;
                checkBox40.Hide();
                label14.Text = "Correct answer: Infinitive";
                label14.ForeColor = Color.Green;
            }
            else if (checkBox40.Checked && !checkBox41.Checked && checkBox42.Checked)
            {
                checkBox40.ForeColor = Color.Green;
                checkBox42.ForeColor = Color.Red;
                checkBox41.Hide();
                label14.Text = "Correct answer: Infinitive";
                label14.ForeColor = Color.Green;
                newscore = newscore + 1;
            }
            else if (checkBox40.Checked && checkBox41.Checked && !checkBox42.Checked)
            {
                checkBox40.ForeColor = Color.Green;
                checkBox41.ForeColor = Color.Red;
                checkBox42.Hide();
                label14.Text = "Correct answer: Infinitive";
                label14.ForeColor = Color.Green;
                newscore = newscore + 1;
            }
            else if (checkBox40.Checked && !checkBox41.Checked && !checkBox42.Checked)
            {
                checkBox40.ForeColor = Color.Green;
                checkBox41.Hide();
                checkBox42.Hide();
                label14.Text = "✓";
                label14.ForeColor = Color.Green;
                newscore = newscore + 1;
            }
            else if (!checkBox40.Checked && checkBox41.Checked && !checkBox42.Checked)
            {
                checkBox41.ForeColor = Color.Red;
                checkBox40.Hide();
                checkBox42.Hide();
                label14.Text = "Correct answer: Infinitive";
                label14.ForeColor = Color.Green;
            }
            else if (!checkBox40.Checked && !checkBox41.Checked && checkBox42.Checked)
            {
                checkBox42.ForeColor = Color.Green;
                checkBox40.Hide();
                checkBox41.Hide();
                label14.Text = "Correct answer: Infinitive";
                label14.ForeColor = Color.Green;
            }
            else if (!checkBox40.Checked && !checkBox41.Checked && !checkBox42.Checked)
            {
                checkBox10.Hide();
                checkBox11.Hide();
                checkBox12.Hide();
                label14.Text = "Correct answer: Infinitive";
                label14.ForeColor = Color.Green;
            }

            //5)
            if (checkBox43.Checked && checkBox44.Checked && checkBox45.Checked)
            {
                checkBox43.ForeColor = Color.Red;
                checkBox44.ForeColor = Color.Green;
                checkBox45.ForeColor = Color.Red;
                label15.Text = "Correct answer: Simple Past";
                label15.ForeColor = Color.Green;
                newscore = newscore + 1;
            }
            else if (!checkBox43.Checked && checkBox44.Checked && checkBox45.Checked)
            {
                checkBox44.ForeColor = Color.Green;
                checkBox45.ForeColor = Color.Red;
                checkBox43.Hide();
                label15.Text = "Correct answer: Simple Past";
                label15.ForeColor = Color.Green;
                newscore = newscore + 1;
            }
            else if (checkBox43.Checked && !checkBox44.Checked && checkBox45.Checked)
            {
                checkBox43.ForeColor = Color.Red;
                checkBox45.ForeColor = Color.Red;
                checkBox44.Hide();
                label15.Text = "Correct answer: Simple Past";
                label15.ForeColor = Color.Green;
            }
            else if (checkBox43.Checked && checkBox44.Checked && !checkBox45.Checked)
            {
                checkBox43.ForeColor = Color.Red;
                checkBox44.ForeColor = Color.Green;
                checkBox45.Hide();
                label15.Text = "Correct answer: Simple Past";
                label15.ForeColor = Color.Green;
                newscore = newscore + 1;
            }
            else if (checkBox43.Checked && !checkBox44.Checked && !checkBox45.Checked)
            {
                checkBox43.ForeColor = Color.Red;
                checkBox44.Hide();
                checkBox45.Hide();
                label15.Text = "Correct answer: Simple Past";
                label15.ForeColor = Color.Green;
            }
            else if (!checkBox43.Checked && checkBox44.Checked && !checkBox45.Checked)
            {
                checkBox44.ForeColor = Color.Green;
                checkBox43.Hide();
                checkBox45.Hide();
                label15.Text = "✓";
                label15.ForeColor = Color.Green;
                newscore = newscore + 1;
            }
            else if (!checkBox43.Checked && !checkBox44.Checked && checkBox45.Checked)
            {
                checkBox45.ForeColor = Color.Red;
                checkBox43.Hide();
                checkBox44.Hide();
                label15.Text = "Correct answer: Simple Past";
                label15.ForeColor = Color.Green;
            }
            else if (!checkBox43.Checked && !checkBox44.Checked && !checkBox45.Checked)
            {
                checkBox43.Hide();
                checkBox44.Hide();
                checkBox45.Hide();
                label15.Text = "Correct answer: Simple Past";
                label15.ForeColor = Color.Green;
            }

            //6)
            if (checkBox46.Checked && checkBox47.Checked && checkBox48.Checked)
            {
                checkBox46.ForeColor = Color.Red;
                checkBox47.ForeColor = Color.Green;
                checkBox48.ForeColor = Color.Red;
                label16.Text = "Correct answer: Simple Past";
                label16.ForeColor = Color.Green;
                newscore = newscore + 1;
            }
            else if (!checkBox46.Checked && checkBox47.Checked && checkBox48.Checked)
            {
                checkBox47.ForeColor = Color.Green;
                checkBox48.ForeColor = Color.Red;
                checkBox46.Hide();
                label16.Text = "Correct answer: Simple Past";
                label16.ForeColor = Color.Green;
                newscore = newscore + 1;
            }
            else if (checkBox46.Checked && !checkBox47.Checked && checkBox48.Checked)
            {
                checkBox46.ForeColor = Color.Red;
                checkBox48.ForeColor = Color.Red;
                checkBox47.Hide();
                label16.Text = "Correct answer: Simple Past";
                label16.ForeColor = Color.Green;
            }
            else if (checkBox46.Checked && checkBox47.Checked && !checkBox48.Checked)
            {
                checkBox46.ForeColor = Color.Red;
                checkBox47.ForeColor = Color.Green;
                checkBox48.Hide();
                label16.Text = "Correct answer: Simple Past";
                label16.ForeColor = Color.Green;
                newscore = newscore + 1;
            }
            else if (checkBox46.Checked && !checkBox47.Checked && !checkBox48.Checked)
            {
                checkBox46.ForeColor = Color.Red;
                checkBox47.Hide();
                checkBox48.Hide();
                label16.Text = "Correct answer: Simple Past";
                label16.ForeColor = Color.Green;
            }
            else if (!checkBox46.Checked && checkBox47.Checked && !checkBox48.Checked)
            {
                checkBox47.ForeColor = Color.Green;
                checkBox46.Hide();
                checkBox48.Hide();
                label16.Text = "✓";
                label16.ForeColor = Color.Green;
                newscore = newscore + 1;
            }
            else if (!checkBox46.Checked && !checkBox47.Checked && checkBox48.Checked)
            {
                checkBox48.ForeColor = Color.Red;
                checkBox46.Hide();
                checkBox47.Hide();
                label16.Text = "Correct answer: Simple Past";
                label16.ForeColor = Color.Green;
            }
            else if (!checkBox46.Checked && !checkBox47.Checked && !checkBox48.Checked)
            {
                checkBox46.Hide();
                checkBox47.Hide();
                checkBox48.Hide();
                label16.Text = "Correct answer: Simple Past";
                label16.ForeColor = Color.Green;
            }

            //7)
            if (checkBox49.Checked && checkBox50.Checked && checkBox51.Checked)
            {
                checkBox49.ForeColor = Color.Green;
                checkBox50.ForeColor = Color.Red;
                checkBox51.ForeColor = Color.Green;
                label17.Text = "Correct answer: Infinitive, Past participle";
                label17.ForeColor = Color.Green;
                newscore = newscore + 1;
            }
            else if (!checkBox49.Checked && checkBox40.Checked && checkBox41.Checked)
            {
                checkBox50.ForeColor = Color.Red;
                checkBox51.ForeColor = Color.Green;
                checkBox49.Hide();
                label17.Text = "Correct answer: Infinitive, Past participle";
                label17.ForeColor = Color.Green;
                newscore = newscore + 0.5;
            }
            else if (checkBox49.Checked && !checkBox50.Checked && checkBox51.Checked)
            {
                checkBox49.ForeColor = Color.Green;
                checkBox51.ForeColor = Color.Green;
                checkBox50.Hide();
                label17.Text = "✓";
                label17.ForeColor = Color.Green;
                newscore = newscore + 1;
            }
            else if (checkBox49.Checked && checkBox50.Checked && !checkBox51.Checked)
            {
                checkBox49.ForeColor = Color.Green;
                checkBox50.ForeColor = Color.Red;
                checkBox51.Hide();
                label17.Text = "Correct answer: Infinitive, Past participle";
                label17.ForeColor = Color.Green;
                newscore = newscore + 0.5;
            }
            else if (checkBox49.Checked && !checkBox50.Checked && !checkBox51.Checked)
            {
                checkBox49.ForeColor = Color.Green;
                checkBox50.Hide();
                checkBox51.Hide();
                label17.Text = "Correct answer: Infinitive, Past participle";
                label17.ForeColor = Color.Green;
                newscore = newscore + 0.5;
            }
            else if (!checkBox49.Checked && checkBox50.Checked && !checkBox51.Checked)
            {
                checkBox50.ForeColor = Color.Red;
                checkBox49.Hide();
                checkBox51.Hide();
                label17.Text = "Correct answer: Infinitive, Past participlee";
                label17.ForeColor = Color.Green;
            }
            else if (!checkBox49.Checked && !checkBox50.Checked && checkBox51.Checked)
            {
                checkBox51.ForeColor = Color.Green;
                checkBox49.Hide();
                checkBox50.Hide();
                label17.Text = "Correct answer: Infinitive, Past participle";
                label17.ForeColor = Color.Green;
                newscore = newscore + 0.5;
            }
            else if (!checkBox49.Checked && !checkBox50.Checked && !checkBox51.Checked)
            {
                checkBox49.Hide();
                checkBox50.Hide();
                checkBox51.Hide();
                label17.Text = "Correct answer: Infinitive, Past participle";
                label17.ForeColor = Color.Green;
            }

            //8)
            if (checkBox52.Checked && checkBox53.Checked && checkBox54.Checked)
            {
                checkBox52.ForeColor = Color.Green;
                checkBox53.ForeColor = Color.Red;
                checkBox54.ForeColor = Color.Red;
                label18.Text = "Correct answer: Infinitive";
                label18.ForeColor = Color.Green;
                newscore = newscore + 1;
            }
            else if (!checkBox52.Checked && checkBox53.Checked && checkBox54.Checked)
            {
                checkBox53.ForeColor = Color.Red;
                checkBox54.ForeColor = Color.Red;
                checkBox52.Hide();
                label18.Text = "Correct answer: Infinitive";
                label18.ForeColor = Color.Green;
            }
            else if (checkBox52.Checked && !checkBox53.Checked && checkBox54.Checked)
            {
                checkBox52.ForeColor = Color.Green;
                checkBox54.ForeColor = Color.Red;
                checkBox53.Hide();
                label18.Text = "Correct answer: Infinitive";
                label18.ForeColor = Color.Green;
                newscore = newscore + 1;
            }
            else if (checkBox52.Checked && checkBox53.Checked && !checkBox54.Checked)
            {
                checkBox52.ForeColor = Color.Green;
                checkBox53.ForeColor = Color.Red;
                checkBox54.Hide();
                label18.Text = "Correct answer: Infinitive";
                label18.ForeColor = Color.Green;
                newscore = newscore + 1;
            }
            else if (checkBox52.Checked && !checkBox53.Checked && !checkBox54.Checked)
            {
                checkBox52.ForeColor = Color.Green;
                checkBox53.Hide();
                checkBox54.Hide();
                label18.Text = "✓";
                label18.ForeColor = Color.Green;
                newscore = newscore + 1;
            }
            else if (!checkBox52.Checked && checkBox53.Checked && !checkBox54.Checked)
            {
                checkBox53.ForeColor = Color.Red;
                checkBox52.Hide();
                checkBox54.Hide();
                label18.Text = "Correct answer: Infinitive";
                label18.ForeColor = Color.Green;
            }
            else if (!checkBox52.Checked && !checkBox53.Checked && checkBox54.Checked)
            {
                checkBox54.ForeColor = Color.Red;
                checkBox52.Hide();
                checkBox53.Hide();
                label18.Text = "Correct answer: Infinitive";
                label18.ForeColor = Color.Green;
            }
            else if (!checkBox52.Checked && !checkBox53.Checked && !checkBox54.Checked)
            {
                checkBox52.Hide();
                checkBox53.Hide();
                checkBox54.Hide();
                label18.Text = "Correct answer: Infinitive";
                label18.ForeColor = Color.Green;
            }

            //9)
            if (checkBox55.Checked && checkBox56.Checked && checkBox57.Checked)
            {
                checkBox55.ForeColor = Color.Red;
                checkBox56.ForeColor = Color.Green;
                checkBox57.ForeColor = Color.Green;
                label19.Text = "Correct answer: Simple Past, Past participle";
                label19.ForeColor = Color.Green;
                newscore = newscore + 1;
            }
            else if (!checkBox55.Checked && checkBox56.Checked && checkBox57.Checked)
            {
                checkBox56.ForeColor = Color.Green;
                checkBox57.ForeColor = Color.Green;
                checkBox55.Hide();
                label19.Text = "✓";
                label19.ForeColor = Color.Green;
                newscore = newscore + 1;
            }
            else if (checkBox55.Checked && !checkBox56.Checked && checkBox57.Checked)
            {
                checkBox57.ForeColor = Color.Green;
                checkBox55.ForeColor = Color.Red;
                checkBox56.Hide();
                label19.Text = "Correct answer: Simple Past, Past participle";
                label19.ForeColor = Color.Green;
                newscore = newscore + 0.5;
            }
            else if (checkBox55.Checked && checkBox56.Checked && !checkBox57.Checked)
            {
                checkBox55.ForeColor = Color.Red;
                checkBox56.ForeColor = Color.Green;
                checkBox57.Hide();
                label19.Text = "Correct answer: Simple Past, Past participle";
                label19.ForeColor = Color.Green;
                newscore = newscore + 0.5;
            }
            else if (checkBox55.Checked && !checkBox56.Checked && !checkBox57.Checked)
            {
                checkBox55.ForeColor = Color.Red;
                checkBox56.Hide();
                checkBox57.Hide();
                label19.Text = "Correct answer: Simple Past, Past participle";
                label19.ForeColor = Color.Green;
            }
            else if (!checkBox55.Checked && checkBox56.Checked && !checkBox57.Checked)
            {
                checkBox56.ForeColor = Color.Green;
                checkBox55.Hide();
                checkBox57.Hide();
                label19.Text = "Correct answer: Simple Past, Past participle";
                label19.ForeColor = Color.Green;
                newscore = newscore + 0.5;
            }
            else if (!checkBox55.Checked && !checkBox56.Checked && checkBox57.Checked)
            {
                checkBox57.ForeColor = Color.Green;
                checkBox55.Hide();
                checkBox56.Hide();
                label19.Text = "Correct answer: Simple Past, Past participle";
                label19.ForeColor = Color.Green;
                newscore = newscore + 0.5;
            }
            else if (!checkBox55.Checked && !checkBox56.Checked && !checkBox57.Checked)
            {
                checkBox55.Hide();
                checkBox56.Hide();
                checkBox57.Hide();
                label19.Text = "Correct answer: Simple Past, Past participle";
                label19.ForeColor = Color.Green;
            }

            //10)
            if (checkBox58.Checked && checkBox59.Checked && checkBox60.Checked)
            {
                checkBox58.ForeColor = Color.Red;
                checkBox59.ForeColor = Color.Red;
                checkBox60.ForeColor = Color.Green;
                label20.Text = "Correct answer: Past participle";
                label20.ForeColor = Color.Green;
                newscore = newscore + 1;
            }
            else if (!checkBox58.Checked && checkBox59.Checked && checkBox60.Checked)
            {
                checkBox59.ForeColor = Color.Red;
                checkBox60.ForeColor = Color.Green;
                checkBox58.Hide();
                label20.Text = "Correct answer: Past participle";
                label20.ForeColor = Color.Green;
                newscore = newscore + 1;
            }
            else if (checkBox58.Checked && !checkBox59.Checked && checkBox60.Checked)
            {
                checkBox58.ForeColor = Color.Red;
                checkBox60.ForeColor = Color.Green;
                checkBox59.Hide();
                label20.Text = "Correct answer: Past participle";
                label20.ForeColor = Color.Green;
                newscore = newscore + 1;
            }
            else if (checkBox58.Checked && checkBox59.Checked && !checkBox60.Checked)
            {
                checkBox58.ForeColor = Color.Red;
                checkBox59.ForeColor = Color.Red;
                checkBox60.Hide();
                label20.Text = "Correct answer: Past participle";
                label20.ForeColor = Color.Green;
            }
            else if (checkBox58.Checked && !checkBox59.Checked && !checkBox60.Checked)
            {
                checkBox58.ForeColor = Color.Red;
                checkBox59.Hide();
                checkBox60.Hide();
                label20.Text = "Correct answer: Past participle";
                label20.ForeColor = Color.Green;
            }
            else if (!checkBox58.Checked && checkBox59.Checked && !checkBox60.Checked)
            {
                checkBox59.ForeColor = Color.Green;
                checkBox58.Hide();
                checkBox60.Hide();
                label16.Text = "Correct answer: Past participle";
                label16.ForeColor = Color.Green;
            }
            else if (!checkBox58.Checked && !checkBox59.Checked && checkBox60.Checked)
            {
                checkBox60.ForeColor = Color.Green;
                checkBox58.Hide();
                checkBox59.Hide();
                label20.Text = "✓";
                label20.ForeColor = Color.Green;
                newscore = newscore + 1;
            }
            else if (!checkBox58.Checked && !checkBox59.Checked && !checkBox60.Checked)
            {
                checkBox58.Hide();
                checkBox59.Hide();
                checkBox60.Hide();
                label20.Text = "Correct answer: Past participle";
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
            checkBox32.ForeColor = Color.Green;
            checkBox34.ForeColor = Color.Green;
            checkBox35.ForeColor = Color.Green;
            checkBox36.ForeColor = Color.Green;
            checkBox38.ForeColor = Color.Green;
            checkBox39.ForeColor = Color.Green;
            checkBox40.ForeColor = Color.Green;
            checkBox44.ForeColor = Color.Green;
            checkBox47.ForeColor = Color.Green;
            checkBox49.ForeColor = Color.Green;
            checkBox51.ForeColor = Color.Green;
            checkBox52.ForeColor = Color.Green;
            checkBox56.ForeColor = Color.Green;
            checkBox57.ForeColor = Color.Green;
            checkBox60.ForeColor = Color.Green;
            buttonVerify2.Enabled = false;
        }
    }
}
