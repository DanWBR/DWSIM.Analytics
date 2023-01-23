
namespace DWSIM.Analytics
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.White;
            this.Panel1.Controls.Add(this.Label2);
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Controls.Add(this.PictureBox1);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(812, 83);
            this.Panel1.TabIndex = 5;
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(13, 43);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(639, 33);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "As a part of its commitment to continuous improvement of DWSIM, the developer req" +
    "uests your permission to collect anonymous usage statistics and error (crash) in" +
    "formation.";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(13, 17);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(283, 13);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "Share Anonymous Usage Data and Error Reports";
            // 
            // PictureBox1
            // 
            this.PictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.PictureBox1.Image = global::DWSIM.Analytics.Properties.Resources.icons8_improvement;
            this.PictureBox1.Location = new System.Drawing.Point(688, 0);
            this.PictureBox1.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.PictureBox1.Size = new System.Drawing.Size(124, 83);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox1.TabIndex = 0;
            this.PictureBox1.TabStop = false;
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.White;
            this.Panel2.Controls.Add(this.button2);
            this.Panel2.Controls.Add(this.Button3);
            this.Panel2.Controls.Add(this.Button1);
            this.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel2.Location = new System.Drawing.Point(0, 441);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(812, 67);
            this.Panel2.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(164, 23);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "View Sample Collected Data";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Button3
            // 
            this.Button3.DialogResult = System.Windows.Forms.DialogResult.No;
            this.Button3.Location = new System.Drawing.Point(658, 23);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(130, 23);
            this.Button3.TabIndex = 2;
            this.Button3.Text = "Close";
            this.Button3.UseVisualStyleBackColor = true;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(12, 23);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(134, 23);
            this.Button1.TabIndex = 0;
            this.Button1.Text = "View Privacy Policy";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(147, 408);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(287, 20);
            this.TextBox1.TabIndex = 9;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(16, 411);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(125, 13);
            this.Label4.TabIndex = 8;
            this.Label4.Text = "E-mail Address (optional):";
            // 
            // Label3
            // 
            this.Label3.Location = new System.Drawing.Point(13, 96);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(787, 305);
            this.Label3.TabIndex = 7;
            this.Label3.Text = resources.GetString("Label3.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(812, 508);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contribute to DWSIM Continuous Improvement";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.Panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.Panel Panel2;
        internal System.Windows.Forms.Button Button3;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.TextBox TextBox1;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Button button2;
    }
}