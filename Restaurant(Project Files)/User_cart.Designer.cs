namespace Restaurant_Project_Files_
{
    partial class User_cart
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_cart));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DGV_customerCart = new ns1.BunifuCustomDataGrid();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UserPhoneNom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Total_purchase = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_order = new System.Windows.Forms.Button();
            this.address_txt = new System.Windows.Forms.ComboBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_customerCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Restaurant_Project_Files_.Properties.Resources.icons8_shopping_cart_with_money_100;
            this.pictureBox1.Location = new System.Drawing.Point(364, -15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // DGV_customerCart
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Sitka Subheading", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGV_customerCart.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DGV_customerCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_customerCart.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DGV_customerCart.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV_customerCart.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_customerCart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DGV_customerCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_customerCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.DGV_customerCart.DoubleBuffered = true;
            this.DGV_customerCart.EnableHeadersVisualStyles = false;
            this.DGV_customerCart.GridColor = System.Drawing.Color.SteelBlue;
            this.DGV_customerCart.HeaderBgColor = System.Drawing.Color.SteelBlue;
            this.DGV_customerCart.HeaderForeColor = System.Drawing.Color.WhiteSmoke;
            this.DGV_customerCart.Location = new System.Drawing.Point(71, 168);
            this.DGV_customerCart.Name = "DGV_customerCart";
            this.DGV_customerCart.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGV_customerCart.RowTemplate.Height = 26;
            this.DGV_customerCart.Size = new System.Drawing.Size(753, 290);
            this.DGV_customerCart.TabIndex = 1;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(169, 127);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(36, 31);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 124;
            this.pictureBox5.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(258, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(415, 24);
            this.label1.TabIndex = 123;
            this.label1.Text = "Please Enter Your PhoneNumber And Address\r\n";
            // 
            // UserPhoneNom
            // 
            this.UserPhoneNom.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserPhoneNom.Location = new System.Drawing.Point(205, 127);
            this.UserPhoneNom.Multiline = true;
            this.UserPhoneNom.Name = "UserPhoneNom";
            this.UserPhoneNom.Size = new System.Drawing.Size(164, 31);
            this.UserPhoneNom.TabIndex = 125;
            this.UserPhoneNom.TextChanged += new System.EventHandler(this.UserPhoneNom_TextChanged);
            this.UserPhoneNom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UserPhoneNom_KeyDown);
            this.UserPhoneNom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UserPhoneNom_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(69, 470);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 24);
            this.label2.TabIndex = 127;
            this.label2.Text = "Total_Purchased :";
            // 
            // Total_purchase
            // 
            this.Total_purchase.Location = new System.Drawing.Point(238, 469);
            this.Total_purchase.Multiline = true;
            this.Total_purchase.Name = "Total_purchase";
            this.Total_purchase.Size = new System.Drawing.Size(164, 26);
            this.Total_purchase.TabIndex = 128;
            this.Total_purchase.TextChanged += new System.EventHandler(this.Total_purchase_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(449, 129);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 29);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 134;
            this.pictureBox2.TabStop = false;
            // 
            // btn_order
            // 
            this.btn_order.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_order.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_order.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_order.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_order.Location = new System.Drawing.Point(501, 464);
            this.btn_order.Name = "btn_order";
            this.btn_order.Size = new System.Drawing.Size(197, 37);
            this.btn_order.TabIndex = 136;
            this.btn_order.Text = "Order";
            this.btn_order.UseVisualStyleBackColor = false;
            this.btn_order.Click += new System.EventHandler(this.btn_order_Click);
            // 
            // address_txt
            // 
            this.address_txt.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address_txt.FormattingEnabled = true;
            this.address_txt.Location = new System.Drawing.Point(486, 129);
            this.address_txt.Name = "address_txt";
            this.address_txt.Size = new System.Drawing.Size(164, 29);
            this.address_txt.TabIndex = 137;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Order_ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Quantity";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Total_Price";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // User_cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.address_txt);
            this.Controls.Add(this.btn_order);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Total_purchase);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UserPhoneNom);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGV_customerCart);
            this.Controls.Add(this.pictureBox1);
            this.Name = "User_cart";
            this.Size = new System.Drawing.Size(759, 571);
            this.Load += new System.EventHandler(this.User_cart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_customerCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private ns1.BunifuCustomDataGrid DGV_customerCart;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UserPhoneNom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Total_purchase;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_order;
        private System.Windows.Forms.ComboBox address_txt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}
