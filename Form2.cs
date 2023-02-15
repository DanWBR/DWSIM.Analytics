using Microsoft.AppCenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DWSIM.ExtensionMethods;

namespace DWSIM.Analytics
{
    public partial class Form2 : Form
    {

        public FormMain mainform;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            this.ChangeDefaultFont();

            label1.Font = new Font(label1.Font.FontFamily.Name, 14.25f, FontStyle.Bold);
            label2.Font = SystemFonts.MessageBoxFont;

            statusStrip1.Visible = false;
            mainform.StatusStrip1.Items.Add(toolStripSplitButton1);

            UpdateText();

            FormMain.TranslateFormFunction?.Invoke(this);

#if !DEBUG
            if (!Properties.Settings.Default.ShouldAsk) Close();
#endif
        }

        private void UpdateText()
        {
            if (Properties.Settings.Default.Enabled)
            {
                toolStripSplitButton1.Text = FormMain.TranslateFunction?.Invoke("Anonymous Analytics Sharing is ON");
            }
            else
            {
                toolStripSplitButton1.Text = FormMain.TranslateFunction?.Invoke("Anonymous Analytics Sharing is OFF");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var f = new Form1();
            f.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Enabled = false;
            Properties.Settings.Default.Save(); 
            UpdateText();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Enabled = true;
            Properties.Settings.Default.Save();
            UpdateText();
            Close();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.ShouldAsk = false;
            Properties.Settings.Default.Save();
        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Enabled)
            {
                Properties.Settings.Default.Enabled = false;
                AppCenter.SetEnabledAsync(false);
                toolStripSplitButton1.Text = FormMain.TranslateFunction?.Invoke("Anonymous Analytics Sharing is OFF");
            }
            else {
                Properties.Settings.Default.Enabled = true;
                AppCenter.SetEnabledAsync(true);
                toolStripSplitButton1.Text = FormMain.TranslateFunction?.Invoke("Anonymous Analytics Sharing is ON");
            }
            Properties.Settings.Default.Save();
        }
    }
}
