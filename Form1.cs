using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DWSIM.ExtensionMethods;

namespace DWSIM.Analytics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Process.Start("https://dwsim.org/index.php/analytics-privacy-policy/");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Enabled = true;
            Properties.Settings.Default.Save();
            Close();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Enabled = false;
            Properties.Settings.Default.Save();
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ChangeDefaultFont();

            FormMain.TranslateFormFunction?.Invoke(this);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Process.Start("https://dwsim.org/index.php/sample-collected-data/");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Process.Start("https://github.com/DanWBR/DWSIM.Analytics");
        }
    }
}
