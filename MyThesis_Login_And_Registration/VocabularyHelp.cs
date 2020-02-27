using RestSharp;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft;
using System.Speech;
using System.Speech.Synthesis;
using Microsoft.Office.Interop;

namespace MyThesis_Login_And_Registration
{
    public partial class VocabularyHelp : Form
    {
        private List<string> AvailLangs;

        public VocabularyHelp()
        {
            InitializeComponent();
            Button button1 = new Button(), buttonDetecteazaLimba = new Button();
            button1.Click += new EventHandler(button1_Click);
            buttonDetecteazaLimba.Click += new EventHandler(buttonDetecteazaLimba_Click);
        }

        private void buttonDetecteazaLimba_Click(object sender, EventArgs e)
        {
            IRestResponse response = RequestService(string.Format(AppCache.UrlDetectSrcLanguage, AppCache.API, textBoxSource.Text));

            var dict = JsonConvert.DeserializeObject<IDictionary>(response.Content);

            var statusCode = dict["code"].ToString();
            if (statusCode.Equals("200"))
            {
                labelSrcLanguage.Text = dict["lang"].ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            buttonDetecteazaLimba.PerformClick();

            IRestResponse response = RequestService(string.Format(AppCache.UrlGetAvailableLanguages, AppCache.API, labelSrcLanguage.Text));
            var dict = JsonConvert.DeserializeObject<IDictionary>(response.Content);
            foreach (DictionaryEntry entry in dict)
            {
                if (entry.Key.Equals("langs"))
                {
                    var availableConverts = (JObject)entry.Value;
                    AvailLangs = new List<string>();

                    comboAvailableLangs.Items.Clear();
                    foreach (var Lang in availableConverts)
                    {
                        if (!Lang.Equals(labelSrcLanguage.Text))
                        {
                            comboAvailableLangs.Items.Add(Lang.Value);
                            AvailLangs.Add(Lang.Key);
                        }
                    }
                }
            }
        }

        private void buttonTranslate_Click(object sender, EventArgs e)
        {
            if (comboAvailableLangs.SelectedItem == null)
            {
                MessageBox.Show("Alegeți o limbă în care să traduceți", "Empty Language Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                IRestResponse response = RequestService(string.Format(AppCache.UrlTranslateLanguage, AppCache.API, textBoxSource.Text, AvailLangs[comboAvailableLangs.SelectedIndex]));
                if (AvailLangs != null)
                {
                    var dict = JsonConvert.DeserializeObject<IDictionary>(response.Content);
                    var statusCode = dict["code"].ToString();
                    if (statusCode.Equals("200"))
                    {
                        richTextBoxDestination.Text = string.Join(",", dict["text"]);
                    }
                }
            }
        }

        private IRestResponse RequestService(string strUrl)
        {
            var client = new RestClient()
            {
                BaseUrl = new Uri(strUrl)
            };

            var request = new RestRequest()
            {
                Method = Method.GET
            };

            return client.Execute(request);

        }

        SpeechSynthesizer reader = new SpeechSynthesizer();

        private void buttonSpeak_Click(object sender, EventArgs e)
        {
            if (richTextBoxDestination.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(richTextBoxDestination.Text);
            }
            else
            {
                MessageBox.Show("Nu este nimic de citit");
            }
        }

        private void textBoxSource_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxSource.Text = "";
            richTextBoxDestination.Text = "";
        }

        private void label21_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void textBoxSource_MouseClick_1(object sender, MouseEventArgs e)
        {
            textBoxSource.Text = "";
            richTextBoxDestination.Text = "";
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelMinimize_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void labelClose_MouseEnter(object sender, EventArgs e)
        {
            labelClose.ForeColor = Color.White;
        }

        private void labelClose_MouseLeave(object sender, EventArgs e)
        {
            labelClose.ForeColor = Color.Black;
        }

        private void labelMinimize_MouseEnter(object sender, EventArgs e)
        {
            labelClose.ForeColor = Color.White;
        }

        private void labelMinimize_MouseLeave(object sender, EventArgs e)
        {
            labelClose.ForeColor = Color.Black;
        }
    }
}
