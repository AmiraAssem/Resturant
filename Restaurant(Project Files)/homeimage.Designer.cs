namespace Restaurant_Project_Files_
{
    partial class homeimage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer_Home = new System.Windows.Forms.Timer(this.components);
            this.slideimg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.slideimg)).BeginInit();
            this.SuspendLayout();
            // 
            // timer_Home
            // 
            this.timer_Home.Enabled = true;
            this.timer_Home.Interval = 2000;
            this.timer_Home.Tick += new System.EventHandler(this.timer_Home_Tick);
            // 
            // slideimg
            // 
            this.slideimg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.slideimg.Image = global::Restaurant_Project_Files_.Properties.Resources.open_576209_960_720;
            this.slideimg.Location = new System.Drawing.Point(0, 0);
            this.slideimg.Name = "slideimg";
            this.slideimg.Size = new System.Drawing.Size(926, 525);
            this.slideimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.slideimg.TabIndex = 2;
            this.slideimg.TabStop = false;
            this.slideimg.Click += new System.EventHandler(this.slideimg_Click);
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.slideimg);
            this.Name = "home";
            this.Size = new System.Drawing.Size(926, 525);
            ((System.ComponentModel.ISupportInitialize)(this.slideimg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer_Home;
        private System.Windows.Forms.PictureBox slideimg;
    }
}
