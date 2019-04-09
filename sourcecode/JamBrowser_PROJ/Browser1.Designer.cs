namespace JamBrowser_PROJ
{
    partial class Browser1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Browser1));
            this.buttonback1 = new System.Windows.Forms.Button();
            this.buttonfoward1 = new System.Windows.Forms.Button();
            this.searchbar1 = new System.Windows.Forms.TextBox();
            this.buttonsearch1 = new System.Windows.Forms.Button();
            this.buttonnewpage1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.buttonclosepage1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonback1
            // 
            this.buttonback1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonback1.Location = new System.Drawing.Point(12, 12);
            this.buttonback1.Name = "buttonback1";
            this.buttonback1.Size = new System.Drawing.Size(27, 23);
            this.buttonback1.TabIndex = 0;
            this.buttonback1.Text = "<--";
            this.buttonback1.UseVisualStyleBackColor = false;
            this.buttonback1.Click += new System.EventHandler(this.buttonback1_Click);
            // 
            // buttonfoward1
            // 
            this.buttonfoward1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonfoward1.Location = new System.Drawing.Point(45, 12);
            this.buttonfoward1.Name = "buttonfoward1";
            this.buttonfoward1.Size = new System.Drawing.Size(27, 23);
            this.buttonfoward1.TabIndex = 1;
            this.buttonfoward1.Text = "-->";
            this.buttonfoward1.UseVisualStyleBackColor = false;
            this.buttonfoward1.Click += new System.EventHandler(this.buttonfoward1_Click);
            // 
            // searchbar1
            // 
            this.searchbar1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchbar1.Location = new System.Drawing.Point(126, 14);
            this.searchbar1.Name = "searchbar1";
            this.searchbar1.Size = new System.Drawing.Size(771, 20);
            this.searchbar1.TabIndex = 2;
            this.searchbar1.TextChanged += new System.EventHandler(this.searchbar1_TextChanged);
            this.searchbar1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchbar1_KeyPress);
            // 
            // buttonsearch1
            // 
            this.buttonsearch1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonsearch1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonsearch1.Location = new System.Drawing.Point(903, 12);
            this.buttonsearch1.Name = "buttonsearch1";
            this.buttonsearch1.Size = new System.Drawing.Size(55, 23);
            this.buttonsearch1.TabIndex = 3;
            this.buttonsearch1.Text = "Search";
            this.buttonsearch1.UseVisualStyleBackColor = false;
            this.buttonsearch1.Click += new System.EventHandler(this.buttonsearch1_Click);
            // 
            // buttonnewpage1
            // 
            this.buttonnewpage1.BackColor = System.Drawing.Color.MintCream;
            this.buttonnewpage1.Location = new System.Drawing.Point(78, 12);
            this.buttonnewpage1.Name = "buttonnewpage1";
            this.buttonnewpage1.Size = new System.Drawing.Size(18, 23);
            this.buttonnewpage1.TabIndex = 4;
            this.buttonnewpage1.Text = "+";
            this.buttonnewpage1.UseVisualStyleBackColor = false;
            this.buttonnewpage1.Click += new System.EventHandler(this.buttonnewpage1_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(964, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Settings";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button2.Location = new System.Drawing.Point(1025, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(-1, 41);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1077, 534);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.webBrowser1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1069, 508);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(3, 3);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1063, 502);
            this.webBrowser1.TabIndex = 0;
            // 
            // buttonclosepage1
            // 
            this.buttonclosepage1.BackColor = System.Drawing.Color.Cornsilk;
            this.buttonclosepage1.Location = new System.Drawing.Point(102, 12);
            this.buttonclosepage1.Name = "buttonclosepage1";
            this.buttonclosepage1.Size = new System.Drawing.Size(18, 23);
            this.buttonclosepage1.TabIndex = 1;
            this.buttonclosepage1.Text = "x";
            this.buttonclosepage1.UseVisualStyleBackColor = false;
            this.buttonclosepage1.Click += new System.EventHandler(this.buttonclosepage1_Click);
            // 
            // Browser1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(146)))), ((int)(((byte)(146)))));
            this.ClientSize = new System.Drawing.Size(1075, 570);
            this.Controls.Add(this.buttonclosepage1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.searchbar1);
            this.Controls.Add(this.buttonnewpage1);
            this.Controls.Add(this.buttonsearch1);
            this.Controls.Add(this.buttonfoward1);
            this.Controls.Add(this.buttonback1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Browser1";
            this.Text = "JamBrowser";
            this.Load += new System.EventHandler(this.Browser1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonback1;
        private System.Windows.Forms.Button buttonfoward1;
        private System.Windows.Forms.TextBox searchbar1;
        private System.Windows.Forms.Button buttonsearch1;
        private System.Windows.Forms.Button buttonnewpage1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button buttonclosepage1;
    }
}