namespace ClassProject_V1._0
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.mainPage_WhatsPopularPanel1 = new ClassProject_V1._0.UserDefinedControls.MainPage_WhatsPopularPanel();
            this.mainPage_WelcomePanel1 = new ClassProject_V1._0.UserDefinedControls.MainPage_WelcomePanel();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(60, 532);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(170, 529);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(170, 22);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(366, 529);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(170, 22);
            this.textBox2.TabIndex = 4;
            // 
            // mainPage_WhatsPopularPanel1
            // 
            this.mainPage_WhatsPopularPanel1.BackColor = System.Drawing.Color.White;
            this.mainPage_WhatsPopularPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainPage_WhatsPopularPanel1.Location = new System.Drawing.Point(0, 188);
            this.mainPage_WhatsPopularPanel1.Name = "mainPage_WhatsPopularPanel1";
            this.mainPage_WhatsPopularPanel1.Size = new System.Drawing.Size(941, 310);
            this.mainPage_WhatsPopularPanel1.TabIndex = 1;
            // 
            // mainPage_WelcomePanel1
            // 
            this.mainPage_WelcomePanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mainPage_WelcomePanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mainPage_WelcomePanel1.BackgroundImage")));
            this.mainPage_WelcomePanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainPage_WelcomePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainPage_WelcomePanel1.Location = new System.Drawing.Point(0, 0);
            this.mainPage_WelcomePanel1.Name = "mainPage_WelcomePanel1";
            this.mainPage_WelcomePanel1.Size = new System.Drawing.Size(941, 188);
            this.mainPage_WelcomePanel1.TabIndex = 0;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 633);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mainPage_WhatsPopularPanel1);
            this.Controls.Add(this.mainPage_WelcomePanel1);
            this.Name = "MainPage";
            this.Text = "TMDB_APP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserDefinedControls.MainPage_WelcomePanel mainPage_WelcomePanel1;
        private UserDefinedControls.MainPage_WhatsPopularPanel mainPage_WhatsPopularPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

