using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyThesis_Login_And_Registration
{
    public partial class GrammarExercises : Form
    {
        public GrammarExercises()
        {
            InitializeComponent();
        }

        private void buttonAdjectiveAdverbe_Click(object sender, EventArgs e)
        {
            this.Hide();
            Adjectives adjective = new Adjectives();
            adjective.Show();
        }

        private void buttonArticole_Click(object sender, EventArgs e)
        {
            this.Hide();
            Articles articole = new Articles();
            articole.Show();
        }

        private void buttonGoBack4_Click(object sender, EventArgs e)
        {
            MainForm openForm = new MainForm();
            openForm.Show();
            Visible = false;
        }

        private void buttonConditionalSentences_Click(object sender, EventArgs e)
        {
            this.Hide();
            ConditionalSentences conditionalSentences = new ConditionalSentences();
            conditionalSentences.Show();
        }

        private void buttonGerundInfinitiv_Click(object sender, EventArgs e)
        {
            this.Hide();
            GerundAndInfinitive gerundAndInfinitive = new GerundAndInfinitive();
            gerundAndInfinitive.Show();
        }

        private void buttonSubstantiveApostrof_Click(object sender, EventArgs e)
        {
            this.Hide();
            NounsApostrophe nounsApostrophe = new NounsApostrophe();
            nounsApostrophe.Show();
        }

        private void buttonSubstantiveCapitalizare_Click(object sender, EventArgs e)
        {
            this.Hide();
            NounsCapitalization nouns = new NounsCapitalization();
            nouns.Show();
        }

        private void buttonWordOrderInPassive_Click(object sender, EventArgs e)
        {
            this.Hide();
            WordOrderInPassive wordOrderInPassive = new WordOrderInPassive();
            wordOrderInPassive.Show();
        }

        private void buttonWordOrderInAffirmative_Click(object sender, EventArgs e)
        {
            this.Hide();
            WordOrderInAffirmative wordOrderInAffirmative = new WordOrderInAffirmative();
            wordOrderInAffirmative.Show();
        }

        private void buttonVerbsIrregularForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            VerbsIrregularForm verbsIrregularForm = new VerbsIrregularForm();
            verbsIrregularForm.Show();
        }

        private void buttonTensesPresentPerfect_Click(object sender, EventArgs e)
        {
            this.Hide();
            TensesPresentPerfect tensesPresentPerfect = new TensesPresentPerfect();
            tensesPresentPerfect.Show();
        }

        private void buttonPhrasalVerbs_Click(object sender, EventArgs e)
        {
            this.Close();
            PhrasalVerbs phrasalVerbs = new PhrasalVerbs();
            phrasalVerbs.Show();
        }

        private void buttonPrepositions_Click(object sender, EventArgs e)
        {
            this.Close();
            Pronouns prepositions = new Pronouns();
            prepositions.Show();
        }

        private void labelCLose_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm openForm = new MainForm();
            openForm.Show();
        }

        private void labelCLose_MouseEnter(object sender, EventArgs e)
        {
            labelCLose.ForeColor = Color.White;
        }

        private void labelCLose_MouseLeave(object sender, EventArgs e)
        {
            labelCLose.ForeColor = Color.Black;
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
    }
}
