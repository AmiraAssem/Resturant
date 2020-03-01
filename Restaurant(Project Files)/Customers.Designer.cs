namespace Restaurant_Project_Files_
{
    partial class Customers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DVG_customers = new ns1.BunifuCustomDataGrid();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DVG_customers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DVG_customers
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Sitka Subheading", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DVG_customers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DVG_customers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DVG_customers.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DVG_customers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DVG_customers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DVG_customers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DVG_customers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DVG_customers.DoubleBuffered = true;
            this.DVG_customers.EnableHeadersVisualStyles = false;
            this.DVG_customers.GridColor = System.Drawing.Color.SteelBlue;
            this.DVG_customers.HeaderBgColor = System.Drawing.Color.SteelBlue;
            this.DVG_customers.HeaderForeColor = System.Drawing.Color.WhiteSmoke;
            this.DVG_customers.Location = new System.Drawing.Point(69, 127);
            this.DVG_customers.Name = "DVG_customers";
            this.DVG_customers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DVG_customers.RowTemplate.Height = 26;
            this.DVG_customers.Size = new System.Drawing.Size(804, 395);
            this.DVG_customers.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Restaurant_Project_Files_.Properties.Resources.e55f00659c1;
            this.pictureBox1.Location = new System.Drawing.Point(362, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DVG_customers);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Customers";
            this.Size = new System.Drawing.Size(910, 596);
            this.Load += new System.EventHandler(this.Customers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DVG_customers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ns1.BunifuCustomDataGrid DVG_customers;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
