namespace Restaurant_Project_Files_
{
    partial class Delivery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Delivery));
            this.DGV_delivery = new ns1.BunifuCustomDataGrid();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_display = new System.Windows.Forms.Button();
            this.txt_Area = new System.Windows.Forms.TextBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_delivery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_delivery
            // 
            this.DGV_delivery.AllowUserToAddRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Sitka Subheading", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGV_delivery.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DGV_delivery.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_delivery.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DGV_delivery.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV_delivery.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_delivery.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DGV_delivery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_delivery.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3});
            this.DGV_delivery.DoubleBuffered = true;
            this.DGV_delivery.EnableHeadersVisualStyles = false;
            this.DGV_delivery.GridColor = System.Drawing.Color.SteelBlue;
            this.DGV_delivery.HeaderBgColor = System.Drawing.Color.SteelBlue;
            this.DGV_delivery.HeaderForeColor = System.Drawing.Color.WhiteSmoke;
            this.DGV_delivery.Location = new System.Drawing.Point(89, 176);
            this.DGV_delivery.Name = "DGV_delivery";
            this.DGV_delivery.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGV_delivery.RowTemplate.Height = 26;
            this.DGV_delivery.Size = new System.Drawing.Size(736, 315);
            this.DGV_delivery.TabIndex = 4;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Area_Code";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "DeliverBoysID";
            this.Column3.Name = "Column3";
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Restaurant_Project_Files_.Properties.Resources.icons8_in_transit_100;
            this.pictureBox1.Location = new System.Drawing.Point(376, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btn_display
            // 
            this.btn_display.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_display.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_display.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_display.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_display.Location = new System.Drawing.Point(563, 136);
            this.btn_display.Name = "btn_display";
            this.btn_display.Size = new System.Drawing.Size(128, 34);
            this.btn_display.TabIndex = 130;
            this.btn_display.Text = "Display";
            this.btn_display.UseVisualStyleBackColor = false;
            this.btn_display.Click += new System.EventHandler(this.btn_display_Click);
            // 
            // txt_Area
            // 
            this.txt_Area.Location = new System.Drawing.Point(361, 136);
            this.txt_Area.Multiline = true;
            this.txt_Area.Name = "txt_Area";
            this.txt_Area.Size = new System.Drawing.Size(196, 33);
            this.txt_Area.TabIndex = 129;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(321, 136);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(36, 36);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 128;
            this.pictureBox5.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(435, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 24);
            this.label1.TabIndex = 127;
            this.label1.Text = "Area";
            // 
            // Delivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_display);
            this.Controls.Add(this.txt_Area);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGV_delivery);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Delivery";
            this.Size = new System.Drawing.Size(828, 567);
            this.Load += new System.EventHandler(this.Delivery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_delivery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ns1.BunifuCustomDataGrid DGV_delivery;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column3;
        private System.Windows.Forms.Button btn_display;
        private System.Windows.Forms.TextBox txt_Area;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label1;
    }
}
