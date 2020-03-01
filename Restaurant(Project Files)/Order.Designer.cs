namespace Restaurant_Project_Files_
{
    partial class Order
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Order));
            this.close_bt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_back = new ns1.BunifuThinButton2();
            this.btn_order = new ns1.BunifuThinButton2();
            this.address_txt = new ns1.BunifuMaterialTextbox();
            this.tx_phone_order = new ns1.BunifuMaterialTextbox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // close_bt
            // 
            this.close_bt.BackColor = System.Drawing.Color.Transparent;
            this.close_bt.FlatAppearance.BorderSize = 0;
            this.close_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_bt.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_bt.ForeColor = System.Drawing.Color.Gray;
            this.close_bt.Image = ((System.Drawing.Image)(resources.GetObject("close_bt.Image")));
            this.close_bt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.close_bt.Location = new System.Drawing.Point(393, -1);
            this.close_bt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.close_bt.Name = "close_bt";
            this.close_bt.Size = new System.Drawing.Size(37, 34);
            this.close_bt.TabIndex = 137;
            this.close_bt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.close_bt.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(415, 24);
            this.label1.TabIndex = 136;
            this.label1.Text = "Please Enter Your PhoneNumber And Address\r\n";
            // 
            // btn_back
            // 
            this.btn_back.ActiveBorderThickness = 1;
            this.btn_back.ActiveCornerRadius = 20;
            this.btn_back.ActiveFillColor = System.Drawing.Color.Transparent;
            this.btn_back.ActiveForecolor = System.Drawing.Color.Transparent;
            this.btn_back.ActiveLineColor = System.Drawing.Color.SteelBlue;
            this.btn_back.BackColor = System.Drawing.SystemColors.Control;
            this.btn_back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_back.BackgroundImage")));
            this.btn_back.ButtonText = "Back";
            this.btn_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_back.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.Transparent;
            this.btn_back.IdleBorderThickness = 1;
            this.btn_back.IdleCornerRadius = 20;
            this.btn_back.IdleFillColor = System.Drawing.Color.SteelBlue;
            this.btn_back.IdleForecolor = System.Drawing.Color.AliceBlue;
            this.btn_back.IdleLineColor = System.Drawing.Color.SteelBlue;
            this.btn_back.Location = new System.Drawing.Point(272, 184);
            this.btn_back.Margin = new System.Windows.Forms.Padding(5);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(140, 45);
            this.btn_back.TabIndex = 135;
            this.btn_back.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_order
            // 
            this.btn_order.ActiveBorderThickness = 1;
            this.btn_order.ActiveCornerRadius = 20;
            this.btn_order.ActiveFillColor = System.Drawing.Color.Transparent;
            this.btn_order.ActiveForecolor = System.Drawing.Color.Transparent;
            this.btn_order.ActiveLineColor = System.Drawing.Color.SteelBlue;
            this.btn_order.BackColor = System.Drawing.SystemColors.Control;
            this.btn_order.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_order.BackgroundImage")));
            this.btn_order.ButtonText = "Order";
            this.btn_order.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_order.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_order.ForeColor = System.Drawing.Color.Transparent;
            this.btn_order.IdleBorderThickness = 1;
            this.btn_order.IdleCornerRadius = 20;
            this.btn_order.IdleFillColor = System.Drawing.Color.SteelBlue;
            this.btn_order.IdleForecolor = System.Drawing.Color.AliceBlue;
            this.btn_order.IdleLineColor = System.Drawing.Color.SteelBlue;
            this.btn_order.Location = new System.Drawing.Point(38, 184);
            this.btn_order.Margin = new System.Windows.Forms.Padding(5);
            this.btn_order.Name = "btn_order";
            this.btn_order.Size = new System.Drawing.Size(139, 45);
            this.btn_order.TabIndex = 134;
            this.btn_order.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_order.Click += new System.EventHandler(this.btn_order_Click);
            // 
            // address_txt
            // 
            this.address_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.address_txt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.address_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.address_txt.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.address_txt.HintText = "Address";
            this.address_txt.isPassword = false;
            this.address_txt.LineFocusedColor = System.Drawing.Color.LightSteelBlue;
            this.address_txt.LineIdleColor = System.Drawing.Color.SteelBlue;
            this.address_txt.LineMouseHoverColor = System.Drawing.Color.LightSteelBlue;
            this.address_txt.LineThickness = 3;
            this.address_txt.Location = new System.Drawing.Point(149, 65);
            this.address_txt.Margin = new System.Windows.Forms.Padding(4);
            this.address_txt.Name = "address_txt";
            this.address_txt.Size = new System.Drawing.Size(177, 44);
            this.address_txt.TabIndex = 133;
            this.address_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tx_phone_order
            // 
            this.tx_phone_order.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tx_phone_order.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tx_phone_order.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tx_phone_order.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tx_phone_order.HintText = "Phone";
            this.tx_phone_order.isPassword = false;
            this.tx_phone_order.LineFocusedColor = System.Drawing.Color.Blue;
            this.tx_phone_order.LineIdleColor = System.Drawing.Color.SteelBlue;
            this.tx_phone_order.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tx_phone_order.LineThickness = 3;
            this.tx_phone_order.Location = new System.Drawing.Point(150, 129);
            this.tx_phone_order.Margin = new System.Windows.Forms.Padding(4);
            this.tx_phone_order.Name = "tx_phone_order";
            this.tx_phone_order.Size = new System.Drawing.Size(176, 35);
            this.tx_phone_order.TabIndex = 132;
            this.tx_phone_order.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(107, 83);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 131;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(108, 128);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(36, 36);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 130;
            this.pictureBox5.TabStop = false;
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 241);
            this.Controls.Add(this.close_bt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_order);
            this.Controls.Add(this.address_txt);
            this.Controls.Add(this.tx_phone_order);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Order";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button close_bt;
        private System.Windows.Forms.Label label1;
        private ns1.BunifuThinButton2 btn_back;
        private ns1.BunifuThinButton2 btn_order;
        private ns1.BunifuMaterialTextbox address_txt;
        private ns1.BunifuMaterialTextbox tx_phone_order;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}