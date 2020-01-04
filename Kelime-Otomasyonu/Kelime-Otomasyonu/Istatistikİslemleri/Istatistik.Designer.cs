namespace Kelime_Otomasyonu.Istatistikİslemleri
{
    partial class Istatistik
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.cKelime = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.cKelime)).BeginInit();
            this.SuspendLayout();
            // 
            // cKelime
            // 
            this.cKelime.BackColor = System.Drawing.Color.Wheat;
            chartArea1.AxisX.InterlacedColor = System.Drawing.Color.White;
            chartArea1.AxisX.Maximum = 12D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisX.Title = "AYLAR";
            chartArea1.AxisY2.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Months;
            chartArea1.CursorX.Interval = 0D;
            chartArea1.CursorX.LineWidth = 0;
            chartArea1.IsSameFontSizeForAllAxes = true;
            chartArea1.Name = "ChartArea1";
            this.cKelime.ChartAreas.Add(chartArea1);
            this.cKelime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cKelime.Location = new System.Drawing.Point(0, 0);
            this.cKelime.Name = "cKelime";
            this.cKelime.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.Name = "Kelime";
            this.cKelime.Series.Add(series1);
            this.cKelime.Size = new System.Drawing.Size(724, 482);
            this.cKelime.TabIndex = 0;
            this.cKelime.Text = "chart1";
            // 
            // Istatistik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 482);
            this.Controls.Add(this.cKelime);
            this.Name = "Istatistik";
            this.Text = "Istatistik";
            this.Load += new System.EventHandler(this.Istatistik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cKelime)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart cKelime;
    }
}