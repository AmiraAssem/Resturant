namespace Restaurant_Project_Files_
{
    partial class LoginForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.fixedpanel = new System.Windows.Forms.Panel();
            this.slide_timer = new System.Windows.Forms.Timer(this.components);
            this.slideimg = new System.Windows.Forms.PictureBox();
            this.home = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.slideimg)).BeginInit();
            this.home.SuspendLayout();
            this.SuspendLayout();
            // 
            // fixedpanel
            // 
            this.fixedpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fixedpanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.fixedpanel.Location = new System.Drawing.Point(0, 0);
            this.fixedpanel.Name = "fixedpanel";
            this.fixedpanel.Size = new System.Drawing.Size(306, 519);
            this.fixedpanel.TabIndex = 1;
            // 
            // slide_timer
            // 
            this.slide_timer.Enabled = true;
            this.slide_timer.Interval = 2000;
            this.slide_timer.Tick += new System.EventHandler(this.slide_timer_Tick);
            // 
            // slideimg
            // 
            this.slideimg.BackColor = System.Drawing.Color.Transparent;
            this.slideimg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.slideimg.Image = ((System.Drawing.Image)(resources.GetObject("slideimg.Image")));
            this.slideimg.Location = new System.Drawing.Point(0, 0);
            this.slideimg.Name = "slideimg";
            this.slideimg.Size = new System.Drawing.Size(695, 517);
            this.slideimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.slideimg.TabIndex = 53;
            this.slideimg.TabStop = false;
            this.slideimg.Click += new System.EventHandler(this.slideimg_Click);
            // 
            // home
            // 
            this.home.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.home.Controls.Add(this.slideimg);
            this.home.Dock = System.Windows.Forms.DockStyle.Fill;
            this.home.Location = new System.Drawing.Point(306, 0);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(697, 519);
            this.home.TabIndex = 2;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1003, 519);
            this.Controls.Add(this.home);
            this.Controls.Add(this.fixedpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.slideimg)).EndInit();
            this.home.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel fixedpanel;
        private System.Windows.Forms.PictureBox slideimg;
        private System.Windows.Forms.Timer slide_timer;
        private System.Windows.Forms.Panel home;
    }
}

