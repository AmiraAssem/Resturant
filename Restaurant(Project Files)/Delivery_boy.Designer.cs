namespace Restaurant_Project_Files_
{
    partial class Delivery_boy
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DVG_deliveryboy = new ns1.BunifuCustomDataGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_add_deliboy = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Area = new System.Windows.Forms.Label();
            this.display = new System.Windows.Forms.Button();
            this.txt_Area = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DVG_deliveryboy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DVG_deliveryboy
            // 
            this.DVG_deliveryboy.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Sitka Subheading", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DVG_deliveryboy.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DVG_deliveryboy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DVG_deliveryboy.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DVG_deliveryboy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DVG_deliveryboy.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DVG_deliveryboy.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DVG_deliveryboy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DVG_deliveryboy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.DVG_deliveryboy.DoubleBuffered = true;
            this.DVG_deliveryboy.EnableHeadersVisualStyles = false;
            this.DVG_deliveryboy.GridColor = System.Drawing.Color.SteelBlue;
            this.DVG_deliveryboy.HeaderBgColor = System.Drawing.Color.SteelBlue;
            this.DVG_deliveryboy.HeaderForeColor = System.Drawing.Color.WhiteSmoke;
            this.DVG_deliveryboy.Location = new System.Drawing.Point(48, 144);
            this.DVG_deliveryboy.Name = "DVG_deliveryboy";
            this.DVG_deliveryboy.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DVG_deliveryboy.RowTemplate.Height = 26;
            this.DVG_deliveryboy.Size = new System.Drawing.Size(817, 334);
            this.DVG_deliveryboy.TabIndex = 6;
            this.DVG_deliveryboy.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DVG_deliveryboy_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "name";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "ID";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Phone";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Assigned_Area";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "NomOfOrders";
            this.Column5.Name = "Column5";
            // 
            // btn_add_deliboy
            // 
            this.btn_add_deliboy.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_add_deliboy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_deliboy.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_deliboy.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_add_deliboy.Location = new System.Drawing.Point(342, 486);
            this.btn_add_deliboy.Name = "btn_add_deliboy";
            this.btn_add_deliboy.Size = new System.Drawing.Size(197, 37);
            this.btn_add_deliboy.TabIndex = 7;
            this.btn_add_deliboy.Text = "Add DeliveryBoy";
            this.btn_add_deliboy.UseVisualStyleBackColor = false;
            this.btn_add_deliboy.Click += new System.EventHandler(this.btn_add_deliboy_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Restaurant_Project_Files_.Properties.Resources.icons8_supplier_80;
            this.pictureBox1.Location = new System.Drawing.Point(365, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Area
            // 
            this.Area.AutoSize = true;
            this.Area.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Area.ForeColor = System.Drawing.Color.SteelBlue;
            this.Area.Location = new System.Drawing.Point(266, 112);
            this.Area.Name = "Area";
            this.Area.Size = new System.Drawing.Size(64, 24);
            this.Area.TabIndex = 9;
            this.Area.Text = "Area :";
            // 
            // display
            // 
            this.display.BackColor = System.Drawing.Color.SteelBlue;
            this.display.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.display.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.display.Location = new System.Drawing.Point(581, 103);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(179, 37);
            this.display.TabIndex = 10;
            this.display.Text = "Best Delivery Boy";
            this.display.UseVisualStyleBackColor = false;
            this.display.Click += new System.EventHandler(this.display_Click);
            // 
            // txt_Area
            // 
            this.txt_Area.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Area.FormattingEnabled = true;
            this.txt_Area.Location = new System.Drawing.Point(327, 109);
            this.txt_Area.Name = "txt_Area";
            this.txt_Area.Size = new System.Drawing.Size(217, 29);
            this.txt_Area.TabIndex = 138;
            // 
            // Delivery_boy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txt_Area);
            this.Controls.Add(this.display);
            this.Controls.Add(this.Area);
            this.Controls.Add(this.btn_add_deliboy);
            this.Controls.Add(this.DVG_deliveryboy);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Delivery_boy";
            this.Size = new System.Drawing.Size(870, 571);
            this.Load += new System.EventHandler(this.Delivery_boy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DVG_deliveryboy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ns1.BunifuCustomDataGrid DVG_deliveryboy;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_add_deliboy;
        private System.Windows.Forms.Label Area;
        private System.Windows.Forms.Button display;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.ComboBox txt_Area;
    }
}
