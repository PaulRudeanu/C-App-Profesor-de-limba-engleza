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

    public partial class Vocabulary : Form
    {
        private List<string> AvailLangs;

        public Vocabulary()
        {
            InitializeComponent();
            Button button1 = new Button(), buttonDetecteazaLimba = new Button();
            button1.Click += new EventHandler(buttonPopulateCombobox_Click);
            buttonDetectLanguage.Click += new EventHandler(buttonDetectLanguage_Click);
        }

        private void buttonDetectLanguage_Click(object sender, EventArgs e)
        {
            IRestResponse response = RequestService(string.Format(AppCache.UrlDetectSrcLanguage, AppCache.API, textBoxSource.Text));

            var dict = JsonConvert.DeserializeObject<IDictionary>(response.Content);

            var statusCode = dict["code"].ToString();
            if(statusCode.Equals("200"))
            {
                labelSrcLanguage.Text = dict["lang"].ToString();
            }
        }



        private void buttonPopulateCombobox_Click(object sender, EventArgs e)
        {
            buttonDetectLanguage.PerformClick();

            IRestResponse response = RequestService(string.Format(AppCache.UrlGetAvailableLanguages, AppCache.API, labelSrcLanguage.Text));
            var dict = JsonConvert.DeserializeObject<IDictionary>(response.Content);
            foreach (DictionaryEntry entry in dict)
            {
                if(entry.Key.Equals("langs"))
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

        private void buttonGoBack_Click(object sender, EventArgs e)
        {
            MainForm openForm = new MainForm();
            openForm.Show();
            Visible = false;
        }

        private void textBoxSource_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxSource.Text = "";
            richTextBoxDestination.Text = "";
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm openForm = new MainForm();
            openForm.Show();
        }

        private void labelMinimize_Click(object sender, EventArgs e)
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
            labelMinimize.ForeColor = Color.White;
        }

        private void labelMinimize_MouseLeave(object sender, EventArgs e)
        {
            labelMinimize.ForeColor = Color.Black;
        }
    }
}
