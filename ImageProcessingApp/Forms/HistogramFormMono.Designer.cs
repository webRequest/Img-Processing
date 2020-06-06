namespace ImageProcessingApp.Forms
{
    partial class HistogramFormMono
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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistogramFormMono));
            this.histogramChartMono = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnHistoStretching = new System.Windows.Forms.Button();
            this.btnHistogramEqualization = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.histogramChartMono)).BeginInit();
            this.SuspendLayout();
            // 
            // histogramChartMono
            // 
            chartArea1.AxisX.Interval = 50D;
            chartArea1.AxisX.IsMarginVisible = false;
            chartArea1.AxisX.LabelAutoFitMaxFontSize = 6;
            chartArea1.Name = "ChartArea1";
            this.histogramChartMono.ChartAreas.Add(chartArea1);
            this.histogramChartMono.Location = new System.Drawing.Point(12, 12);
            this.histogramChartMono.Name = "histogramChartMono";
            series1.BorderColor = System.Drawing.Color.Gray;
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.Gray;
            series1.Name = "red";
            series1.ShadowColor = System.Drawing.Color.Transparent;
            series2.BorderColor = System.Drawing.Color.Gray;
            series2.ChartArea = "ChartArea1";
            series2.Color = System.Drawing.Color.Gray;
            series2.Name = "green";
            series2.ShadowColor = System.Drawing.Color.Transparent;
            series3.BorderColor = System.Drawing.Color.Gray;
            series3.ChartArea = "ChartArea1";
            series3.Color = System.Drawing.Color.Gray;
            series3.Name = "blue";
            series3.ShadowColor = System.Drawing.Color.Transparent;
            this.histogramChartMono.Series.Add(series1);
            this.histogramChartMono.Series.Add(series2);
            this.histogramChartMono.Series.Add(series3);
            this.histogramChartMono.Size = new System.Drawing.Size(900, 392);
            this.histogramChartMono.TabIndex = 0;
            this.histogramChartMono.Text = "chart1";
            // 
            // btnHistoStretching
            // 
            this.btnHistoStretching.Location = new System.Drawing.Point(927, 12);
            this.btnHistoStretching.Name = "btnHistoStretching";
            this.btnHistoStretching.Size = new System.Drawing.Size(240, 50);
            this.btnHistoStretching.TabIndex = 1;
            this.btnHistoStretching.Text = "Rozciągnij histogram";
            this.btnHistoStretching.UseVisualStyleBackColor = true;
            this.btnHistoStretching.Click += new System.EventHandler(this.btnHistoStretching_Click);
            // 
            // btnHistogramEqualization
            // 
            this.btnHistogramEqualization.Location = new System.Drawing.Point(927, 68);
            this.btnHistogramEqualization.Name = "btnHistogramEqualization";
            this.btnHistogramEqualization.Size = new System.Drawing.Size(240, 50);
            this.btnHistogramEqualization.TabIndex = 2;
            this.btnHistogramEqualization.Text = "Wyrównaj histogram";
            this.btnHistogramEqualization.UseVisualStyleBackColor = true;
            this.btnHistogramEqualization.Click += new System.EventHandler(this.btnHistogramEqualization_Click);
            // 
            // HistogramFormMono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1183, 416);
            this.Controls.Add(this.btnHistogramEqualization);
            this.Controls.Add(this.btnHistoStretching);
            this.Controls.Add(this.histogramChartMono);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1199, 455);
            this.MinimumSize = new System.Drawing.Size(1199, 455);
            this.Name = "HistogramFormMono";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Histogram";
            ((System.ComponentModel.ISupportInitialize)(this.histogramChartMono)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataVisualization.Charting.Chart histogramChartMono;
        private System.Windows.Forms.Button btnHistoStretching;
        private System.Windows.Forms.Button btnHistogramEqualization;
    }
}