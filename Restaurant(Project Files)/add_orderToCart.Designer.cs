namespace Restaurant_Project_Files_
{
    partial class add_orderToCart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(add_orderToCart));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.order_id = new System.Windows.Forms.TextBox();
            this.order_price = new System.Windows.Forms.TextBox();
            this.btn_back = new ns1.BunifuThinButton2();
            this.bt_add = new ns1.BunifuThinButton2();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.qt_txt = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qt_txt)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(118, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 23);
            this.label2.TabIndex = 113;
            this.label2.Text = "Quantity :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(25, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 23);
            this.label1.TabIndex = 112;
            this.label1.Text = "Order_ID :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(256, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 23);
            this.label3.TabIndex = 124;
            this.label3.Text = "Total Price :";
            // 
            // order_id
            // 
            this.order_id.Location = new System.Drawing.Point(124, 104);
            this.order_id.Name = "order_id";
            this.order_id.Size = new System.Drawing.Size(113, 24);
            this.order_id.TabIndex = 126;
            this.order_id.TextChanged += new System.EventHandler(this.order_id_TextChanged);
            // 
            // order_price
            // 
            this.order_price.Location = new System.Drawing.Point(361, 104);
            this.order_price.Name = "order_price";
            this.order_price.Size = new System.Drawing.Size(115, 24);
            this.order_price.TabIndex = 127;
            this.order_price.TextChanged += new System.EventHandler(this.order_price_TextChanged);
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
            this.btn_back.Location = new System.Drawing.Point(276, 203);
            this.btn_back.Margin = new System.Windows.Forms.Padding(5);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(182, 49);
            this.btn_back.TabIndex = 119;
            this.btn_back.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // bt_add
            // 
            this.bt_add.ActiveBorderThickness = 1;
            this.bt_add.ActiveCornerRadius = 20;
            this.bt_add.ActiveFillColor = System.Drawing.Color.Transparent;
            this.bt_add.ActiveForecolor = System.Drawing.Color.Transparent;
            this.bt_add.ActiveLineColor = System.Drawing.Color.SteelBlue;
            this.bt_add.BackColor = System.Drawing.SystemColors.Control;
            this.bt_add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_add.BackgroundImage")));
            this.bt_add.ButtonText = "Add";
            this.bt_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_add.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_add.ForeColor = System.Drawing.Color.Transparent;
            this.bt_add.IdleBorderThickness = 1;
            this.bt_add.IdleCornerRadius = 20;
            this.bt_add.IdleFillColor = System.Drawing.Color.SteelBlue;
            this.bt_add.IdleForecolor = System.Drawing.Color.AliceBlue;
            this.bt_add.IdleLineColor = System.Drawing.Color.SteelBlue;
            this.bt_add.Location = new System.Drawing.Point(42, 203);
            this.bt_add.Margin = new System.Windows.Forms.Padding(5);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(181, 49);
            this.bt_add.TabIndex = 118;
            this.bt_add.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Restaurant_Project_Files_.Properties.Resources.icons8_add_shopping_cart_64;
            this.pictureBox1.Location = new System.Drawing.Point(166, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 109;
            this.pictureBox1.TabStop = false;
            // 
            // qt_txt
            // 
            this.qt_txt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qt_txt.Location = new System.Drawing.Point(206, 152);
            this.qt_txt.Name = "qt_txt";
            this.qt_txt.Size = new System.Drawing.Size(137, 26);
            this.qt_txt.TabIndex = 128;
            this.qt_txt.ValueChanged += new System.EventHandler(this.qt_txt_ValueChanged);
            // 
            // add_orderToCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(513, 272);
            this.Controls.Add(this.qt_txt);
            this.Controls.Add(this.order_price);
            this.Controls.Add(this.order_id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.bt_add);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "add_orderToCart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "add_order";
            this.Load += new System.EventHandler(this.add_order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qt_txt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ns1.BunifuThinButton2 btn_back;
        private ns1.BunifuThinButton2 bt_add;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox order_id;
        private System.Windows.Forms.TextBox order_price;
        private System.Windows.Forms.NumericUpDown qt_txt;
    }
}