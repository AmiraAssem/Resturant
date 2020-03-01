namespace Restaurant_Project_Files_
{
    partial class Chart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chart));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_Area = new System.Windows.Forms.ComboBox();
            this.display = new System.Windows.Forms.Button();
            this.Area = new System.Windows.Forms.Label();
            this.Area_Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Area_Chart)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(365, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // txt_Area
            // 
            this.txt_Area.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Area.FormattingEnabled = true;
            this.txt_Area.Location = new System.Drawing.Point(321, 106);
            this.txt_Area.Name = "txt_Area";
            this.txt_Area.Size = new System.Drawing.Size(217, 29);
            this.txt_Area.TabIndex = 141;
            // 
            // display
            // 
            this.display.BackColor = System.Drawing.Color.SteelBlue;
            this.display.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.display.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.display.Location = new System.Drawing.Point(550, 101);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(179, 37);
            this.display.TabIndex = 140;
            this.display.Text = "Display Chart";
            this.display.UseVisualStyleBackColor = false;
            this.display.Click += new System.EventHandler(this.display_Click);
            // 
            // Area
            // 
            this.Area.AutoSize = true;
            this.Area.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Area.ForeColor = System.Drawing.Color.SteelBlue;
            this.Area.Location = new System.Drawing.Point(260, 109);
            this.Area.Name = "Area";
            this.Area.Size = new System.Drawing.Size(64, 24);
            this.Area.TabIndex = 139;
            this.Area.Text = "Area :";
            // 
            // Area_Chart
            // 
            chartArea1.Name = "ChartArea1";
            this.Area_Chart.ChartAreas.Add(chartArea1);
            legend1.ItemColumnSpacing = 40;
            legend1.Name = "Legend1";
            this.Area_Chart.Legends.Add(legend1);
            this.Area_Chart.Location = new System.Drawing.Point(63, 160);
            this.Area_Chart.Name = "Area_Chart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "NomOfOrders";
            this.Area_Chart.Series.Add(series1);
            this.Area_Chart.Size = new System.Drawing.Size(760, 385);
            this.Area_Chart.TabIndex = 142;
            this.Area_Chart.Text = "chart1";
            // 
            // Chart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Area_Chart);
            this.Controls.Add(this.txt_Area);
            this.Controls.Add(this.display);
            this.Controls.Add(this.Area);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Chart";
            this.Size = new System.Drawing.Size(870, 571);
            this.Load += new System.EventHandler(this.Chart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Area_Chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox txt_Area;
        private System.Windows.Forms.Button display;
        private System.Windows.Forms.Label Area;
        private System.Windows.Forms.DataVisualization.Charting.Chart Area_Chart;
    }
}
