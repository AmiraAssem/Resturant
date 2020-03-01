namespace Restaurant_Project_Files_
{
    partial class Edit_menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit_menu));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.order_id = new System.Windows.Forms.TextBox();
            this.order_price = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_back = new ns1.BunifuThinButton2();
            this.bt_add = new ns1.BunifuThinButton2();
            this.order_qty = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_qty)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(78, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 24);
            this.label1.TabIndex = 124;
            this.label1.Text = "ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(250, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 24);
            this.label2.TabIndex = 126;
            this.label2.Text = "Price :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(115, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 24);
            this.label3.TabIndex = 128;
            this.label3.Text = "Quantity :";
            // 
            // order_id
            // 
            this.order_id.Location = new System.Drawing.Point(124, 110);
            this.order_id.Multiline = true;
            this.order_id.Name = "order_id";
            this.order_id.Size = new System.Drawing.Size(105, 24);
            this.order_id.TabIndex = 133;
            // 
            // order_price
            // 
            this.order_price.Location = new System.Drawing.Point(317, 111);
            this.order_price.Multiline = true;
            this.order_price.Name = "order_price";
            this.order_price.Size = new System.Drawing.Size(109, 24);
            this.order_price.TabIndex = 134;
            this.order_price.TextChanged += new System.EventHandler(this.order_price_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Restaurant_Project_Files_.Properties.Resources.icons8_restaurant_menu_641;
            this.pictureBox1.Location = new System.Drawing.Point(169, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 132;
            this.pictureBox1.TabStop = false;
            // 
            // btn_back
            // 
            this.btn_back.ActiveBorderThickness = 1;
            this.btn_back.ActiveCornerRadius = 20;
            this.btn_back.ActiveFillColor = System.Drawing.Color.Transparent;
            this.btn_back.ActiveForecolor = System.Drawing.Color.Transparent;
            this.btn_back.ActiveLineColor = System.Drawing.Color.SteelBlue;
            this.btn_back.BackColor = System.Drawing.Color.Transparent;
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
            this.btn_back.Location = new System.Drawing.Point(284, 229);
            this.btn_back.Margin = new System.Windows.Forms.Padding(5);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(182, 49);
            this.btn_back.TabIndex = 131;
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
            this.bt_add.BackColor = System.Drawing.SystemColors.ButtonFace;
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
            this.bt_add.Location = new System.Drawing.Point(50, 229);
            this.bt_add.Margin = new System.Windows.Forms.Padding(5);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(182, 49);
            this.bt_add.TabIndex = 130;
            this.bt_add.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // order_qty
            // 
            this.order_qty.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.order_qty.Location = new System.Drawing.Point(215, 171);
            this.order_qty.Name = "order_qty";
            this.order_qty.Size = new System.Drawing.Size(134, 26);
            this.order_qty.TabIndex = 135;
            // 
            // Edit_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(500, 305);
            this.Controls.Add(this.order_qty);
            this.Controls.Add(this.order_price);
            this.Controls.Add(this.order_id);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.bt_add);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Edit_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit_menu";
            this.Load += new System.EventHandler(this.Edit_menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_qty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private ns1.BunifuThinButton2 btn_back;
        private ns1.BunifuThinButton2 bt_add;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox order_id;
        private System.Windows.Forms.TextBox order_price;
        private System.Windows.Forms.NumericUpDown order_qty;
    }
}