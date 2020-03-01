namespace Restaurant_Project_Files_
{
    partial class UC_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Login));
            this.txt_Username = new ns1.BunifuMaterialTextbox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.bt_login = new ns1.BunifuThinButton2();
            this.txt_password = new ns1.BunifuMaterialTextbox();
            this.close_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Username
            // 
            this.txt_Username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Username.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_Username.HintForeColor = System.Drawing.Color.Silver;
            this.txt_Username.HintText = "Username";
            this.txt_Username.isPassword = false;
            this.txt_Username.LineFocusedColor = System.Drawing.Color.SteelBlue;
            this.txt_Username.LineIdleColor = System.Drawing.Color.SteelBlue;
            this.txt_Username.LineMouseHoverColor = System.Drawing.Color.SteelBlue;
            this.txt_Username.LineThickness = 3;
            this.txt_Username.Location = new System.Drawing.Point(65, 261);
            this.txt_Username.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(217, 48);
            this.txt_Username.TabIndex = 69;
            this.txt_Username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(21, 276);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 66;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(21, 339);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 65;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Restaurant_Project_Files_.Properties.Resources.received_997326447130539;
            this.pictureBox3.Location = new System.Drawing.Point(0, 39);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(306, 229);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 64;
            this.pictureBox3.TabStop = false;
            // 
            // bt_login
            // 
            this.bt_login.ActiveBorderThickness = 1;
            this.bt_login.ActiveCornerRadius = 20;
            this.bt_login.ActiveFillColor = System.Drawing.Color.Transparent;
            this.bt_login.ActiveForecolor = System.Drawing.Color.Transparent;
            this.bt_login.ActiveLineColor = System.Drawing.Color.SteelBlue;
            this.bt_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bt_login.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_login.BackgroundImage")));
            this.bt_login.ButtonText = "Login";
            this.bt_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_login.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_login.ForeColor = System.Drawing.Color.Transparent;
            this.bt_login.IdleBorderThickness = 1;
            this.bt_login.IdleCornerRadius = 20;
            this.bt_login.IdleFillColor = System.Drawing.Color.SteelBlue;
            this.bt_login.IdleForecolor = System.Drawing.Color.AliceBlue;
            this.bt_login.IdleLineColor = System.Drawing.Color.SteelBlue;
            this.bt_login.Location = new System.Drawing.Point(29, 435);
            this.bt_login.Margin = new System.Windows.Forms.Padding(5);
            this.bt_login.Name = "bt_login";
            this.bt_login.Size = new System.Drawing.Size(253, 49);
            this.bt_login.TabIndex = 68;
            this.bt_login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bt_login.Click += new System.EventHandler(this.bt_login_Click);
            // 
            // txt_password
            // 
            this.txt_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_password.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_password.ForeColor = System.Drawing.Color.Silver;
            this.txt_password.HintForeColor = System.Drawing.Color.Silver;
            this.txt_password.HintText = "Password";
            this.txt_password.isPassword = true;
            this.txt_password.LineFocusedColor = System.Drawing.Color.SteelBlue;
            this.txt_password.LineIdleColor = System.Drawing.Color.SteelBlue;
            this.txt_password.LineMouseHoverColor = System.Drawing.Color.SteelBlue;
            this.txt_password.LineThickness = 3;
            this.txt_password.Location = new System.Drawing.Point(65, 337);
            this.txt_password.Margin = new System.Windows.Forms.Padding(4);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(217, 44);
            this.txt_password.TabIndex = 70;
            this.txt_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // close_btn
            // 
            this.close_btn.BackColor = System.Drawing.Color.Transparent;
            this.close_btn.FlatAppearance.BorderSize = 0;
            this.close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_btn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_btn.ForeColor = System.Drawing.Color.Gray;
            this.close_btn.Image = ((System.Drawing.Image)(resources.GetObject("close_btn.Image")));
            this.close_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.close_btn.Location = new System.Drawing.Point(3, 4);
            this.close_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(37, 27);
            this.close_btn.TabIndex = 71;
            this.close_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.close_btn.UseVisualStyleBackColor = false;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(74, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 35);
            this.label2.TabIndex = 72;
            this.label2.Text = "Restaurant";
            // 
            // UC_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.label2);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.txt_Username);
            this.Controls.Add(this.bt_login);
            this.Name = "UC_Login";
            this.Size = new System.Drawing.Size(306, 529);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private ns1.BunifuMaterialTextbox txt_Username;
        private ns1.BunifuThinButton2 bt_login;
        private ns1.BunifuMaterialTextbox txt_password;
        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.Label label2;
    }
}
