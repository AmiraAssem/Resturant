namespace Restaurant_Project_Files_
{
    partial class UserPhoneNumber
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserPhoneNumber));
            this.label1 = new System.Windows.Forms.Label();
            this.UserPhoneNom = new ns1.BunifuMaterialTextbox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.btn_add = new ns1.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(81, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please Enter Your PhoneNumber";
            // 
            // UserPhoneNom
            // 
            this.UserPhoneNom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UserPhoneNom.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.UserPhoneNom.ForeColor = System.Drawing.Color.White;
            this.UserPhoneNom.HintForeColor = System.Drawing.Color.Silver;
            this.UserPhoneNom.HintText = "Phone";
            this.UserPhoneNom.isPassword = false;
            this.UserPhoneNom.LineFocusedColor = System.Drawing.Color.Blue;
            this.UserPhoneNom.LineIdleColor = System.Drawing.Color.Azure;
            this.UserPhoneNom.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.UserPhoneNom.LineThickness = 3;
            this.UserPhoneNom.Location = new System.Drawing.Point(159, 84);
            this.UserPhoneNom.Margin = new System.Windows.Forms.Padding(4);
            this.UserPhoneNom.Name = "UserPhoneNom";
            this.UserPhoneNom.Size = new System.Drawing.Size(176, 35);
            this.UserPhoneNom.TabIndex = 122;
            this.UserPhoneNom.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(117, 83);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(36, 36);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 121;
            this.pictureBox5.TabStop = false;
            // 
            // btn_add
            // 
            this.btn_add.ActiveBorderThickness = 1;
            this.btn_add.ActiveCornerRadius = 20;
            this.btn_add.ActiveFillColor = System.Drawing.Color.Transparent;
            this.btn_add.ActiveForecolor = System.Drawing.Color.Transparent;
            this.btn_add.ActiveLineColor = System.Drawing.Color.SteelBlue;
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_add.BackgroundImage")));
            this.btn_add.ButtonText = "Add";
            this.btn_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.Transparent;
            this.btn_add.IdleBorderThickness = 1;
            this.btn_add.IdleCornerRadius = 20;
            this.btn_add.IdleFillColor = System.Drawing.Color.SteelBlue;
            this.btn_add.IdleForecolor = System.Drawing.Color.AliceBlue;
            this.btn_add.IdleLineColor = System.Drawing.Color.SteelBlue;
            this.btn_add.Location = new System.Drawing.Point(159, 140);
            this.btn_add.Margin = new System.Windows.Forms.Padding(5);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(172, 49);
            this.btn_add.TabIndex = 123;
            this.btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // UserPhoneNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(439, 194);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.UserPhoneNom);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserPhoneNumber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserPhoneNumber";
            this.Load += new System.EventHandler(this.UserPhoneNumber_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private ns1.BunifuMaterialTextbox UserPhoneNom;
        private System.Windows.Forms.PictureBox pictureBox5;
        private ns1.BunifuThinButton2 btn_add;
    }
}