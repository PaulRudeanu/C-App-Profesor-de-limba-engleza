namespace MyThesis_Login_And_Registration
{
    partial class Vocabulary
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vocabulary));
            this.textBoxSource = new System.Windows.Forms.TextBox();
            this.buttonDetectLanguage = new System.Windows.Forms.Button();
            this.labelSrcLanguage = new System.Windows.Forms.Label();
            this.buttonPopulateCombobox = new System.Windows.Forms.Button();
            this.comboAvailableLangs = new System.Windows.Forms.ComboBox();
            this.buttonTranslate = new System.Windows.Forms.Button();
            this.richTextBoxDestination = new System.Windows.Forms.RichTextBox();
            this.buttonSpeak = new System.Windows.Forms.Button();
            this.buttonGoBack = new System.Windows.Forms.Button();
            this.labelClose = new System.Windows.Forms.Label();
            this.labelCerinta = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelMinimize = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxSource
            // 
            this.textBoxSource.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxSource.Location = new System.Drawing.Point(27, 190);
            this.textBoxSource.Multiline = true;
            this.textBoxSource.Name = "textBoxSource";
            this.textBoxSource.Size = new System.Drawing.Size(304, 186);
            this.textBoxSource.TabIndex = 0;
            this.textBoxSource.Text = "Introduceți text";
            this.textBoxSource.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxSource_MouseClick);
            // 
            // buttonDetectLanguage
            // 
            this.buttonDetectLanguage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(146)))), ((int)(((byte)(206)))));
            this.buttonDetectLanguage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDetectLanguage.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDetectLanguage.Location = new System.Drawing.Point(27, 384);
            this.buttonDetectLanguage.Name = "buttonDetectLanguage";
            this.buttonDetectLanguage.Size = new System.Drawing.Size(258, 37);
            this.buttonDetectLanguage.TabIndex = 1;
            this.buttonDetectLanguage.Text = "Detectează Limba";
            this.buttonDetectLanguage.UseVisualStyleBackColor = false;
            this.buttonDetectLanguage.Click += new System.EventHandler(this.buttonDetectLanguage_Click);
            // 
            // labelSrcLanguage
            // 
            this.labelSrcLanguage.AutoSize = true;
            this.labelSrcLanguage.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSrcLanguage.Location = new System.Drawing.Point(3, 0);
            this.labelSrcLanguage.Name = "labelSrcLanguage";
            this.labelSrcLanguage.Size = new System.Drawing.Size(0, 19);
            this.labelSrcLanguage.TabIndex = 3;
            // 
            // buttonPopulateCombobox
            // 
            this.buttonPopulateCombobox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(146)))), ((int)(((byte)(206)))));
            this.buttonPopulateCombobox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPopulateCombobox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPopulateCombobox.Location = new System.Drawing.Point(337, 190);
            this.buttonPopulateCombobox.Name = "buttonPopulateCombobox";
            this.buttonPopulateCombobox.Size = new System.Drawing.Size(419, 40);
            this.buttonPopulateCombobox.TabIndex = 4;
            this.buttonPopulateCombobox.Text = "Apasă acest buton și selectează limba în care vrei să traduci";
            this.buttonPopulateCombobox.UseVisualStyleBackColor = false;
            this.buttonPopulateCombobox.Click += new System.EventHandler(this.buttonPopulateCombobox_Click);
            // 
            // comboAvailableLangs
            // 
            this.comboAvailableLangs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboAvailableLangs.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboAvailableLangs.FormattingEnabled = true;
            this.comboAvailableLangs.Location = new System.Drawing.Point(337, 236);
            this.comboAvailableLangs.Name = "comboAvailableLangs";
            this.comboAvailableLangs.Size = new System.Drawing.Size(419, 27);
            this.comboAvailableLangs.TabIndex = 5;
            // 
            // buttonTranslate
            // 
            this.buttonTranslate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(146)))), ((int)(((byte)(206)))));
            this.buttonTranslate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTranslate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonTranslate.Location = new System.Drawing.Point(337, 274);
            this.buttonTranslate.Name = "buttonTranslate";
            this.buttonTranslate.Size = new System.Drawing.Size(419, 102);
            this.buttonTranslate.TabIndex = 6;
            this.buttonTranslate.Text = "Tradu";
            this.buttonTranslate.UseVisualStyleBackColor = false;
            this.buttonTranslate.Click += new System.EventHandler(this.buttonTranslate_Click);
            // 
            // richTextBoxDestination
            // 
            this.richTextBoxDestination.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBoxDestination.Location = new System.Drawing.Point(762, 190);
            this.richTextBoxDestination.Name = "richTextBoxDestination";
            this.richTextBoxDestination.Size = new System.Drawing.Size(304, 186);
            this.richTextBoxDestination.TabIndex = 7;
            this.richTextBoxDestination.Text = "Traducerea";
            // 
            // buttonSpeak
            // 
            this.buttonSpeak.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(146)))), ((int)(((byte)(206)))));
            this.buttonSpeak.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSpeak.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSpeak.Location = new System.Drawing.Point(762, 384);
            this.buttonSpeak.Name = "buttonSpeak";
            this.buttonSpeak.Size = new System.Drawing.Size(304, 37);
            this.buttonSpeak.TabIndex = 8;
            this.buttonSpeak.Text = "Citește";
            this.buttonSpeak.UseVisualStyleBackColor = false;
            this.buttonSpeak.Click += new System.EventHandler(this.buttonSpeak_Click);
            // 
            // buttonGoBack
            // 
            this.buttonGoBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(146)))), ((int)(((byte)(206)))));
            this.buttonGoBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGoBack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonGoBack.Location = new System.Drawing.Point(12, 533);
            this.buttonGoBack.Name = "buttonGoBack";
            this.buttonGoBack.Size = new System.Drawing.Size(97, 91);
            this.buttonGoBack.TabIndex = 9;
            this.buttonGoBack.Text = "Înapoi ";
            this.buttonGoBack.UseVisualStyleBackColor = false;
            this.buttonGoBack.Click += new System.EventHandler(this.buttonGoBack_Click);
            // 
            // labelClose
            // 
            this.labelClose.AutoSize = true;
            this.labelClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(29)))));
            this.labelClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelClose.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelClose.Location = new System.Drawing.Point(1062, 9);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(24, 24);
            this.labelClose.TabIndex = 221;
            this.labelClose.Text = "X";
            this.labelClose.Click += new System.EventHandler(this.labelClose_Click);
            this.labelClose.MouseEnter += new System.EventHandler(this.labelClose_MouseEnter);
            this.labelClose.MouseLeave += new System.EventHandler(this.labelClose_MouseLeave);
            // 
            // labelCerinta
            // 
            this.labelCerinta.AutoSize = true;
            this.labelCerinta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(29)))));
            this.labelCerinta.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCerinta.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelCerinta.Location = new System.Drawing.Point(-10, -4);
            this.labelCerinta.Name = "labelCerinta";
            this.labelCerinta.Size = new System.Drawing.Size(1119, 130);
            this.labelCerinta.TabIndex = 220;
            this.labelCerinta.Text = resources.GetString("labelCerinta.Text");
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.labelSrcLanguage);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(299, 382);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(32, 30);
            this.panel1.TabIndex = 222;
            // 
            // labelMinimize
            // 
            this.labelMinimize.AutoSize = true;
            this.labelMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(29)))));
            this.labelMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelMinimize.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMinimize.Location = new System.Drawing.Point(1032, 6);
            this.labelMinimize.Name = "labelMinimize";
            this.labelMinimize.Size = new System.Drawing.Size(24, 26);
            this.labelMinimize.TabIndex = 223;
            this.labelMinimize.Text = "_";
            this.labelMinimize.Click += new System.EventHandler(this.labelMinimize_Click);
            this.labelMinimize.MouseEnter += new System.EventHandler(this.labelMinimize_MouseEnter);
            this.labelMinimize.MouseLeave += new System.EventHandler(this.labelMinimize_MouseLeave);
            // 
            // Vocabulary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(1097, 636);
            this.Controls.Add(this.labelMinimize);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelClose);
            this.Controls.Add(this.labelCerinta);
            this.Controls.Add(this.buttonGoBack);
            this.Controls.Add(this.buttonSpeak);
            this.Controls.Add(this.richTextBoxDestination);
            this.Controls.Add(this.buttonTranslate);
            this.Controls.Add(this.comboAvailableLangs);
            this.Controls.Add(this.buttonPopulateCombobox);
            this.Controls.Add(this.buttonDetectLanguage);
            this.Controls.Add(this.textBoxSource);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Vocabulary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vocabulary";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSource;
        private System.Windows.Forms.Button buttonDetectLanguage;
        private System.Windows.Forms.Label labelSrcLanguage;
        private System.Windows.Forms.Button buttonPopulateCombobox;
        private System.Windows.Forms.ComboBox comboAvailableLangs;
        private System.Windows.Forms.Button buttonTranslate;
        private System.Windows.Forms.RichTextBox richTextBoxDestination;
        private System.Windows.Forms.Button buttonSpeak;
        private System.Windows.Forms.Button buttonGoBack;
        private System.Windows.Forms.Label labelClose;
        private System.Windows.Forms.Label labelCerinta;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelMinimize;
    }
}