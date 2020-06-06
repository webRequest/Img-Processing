using ImageProcessingApp.Forms;

namespace ImageProcessingApp.Forms
{
    partial class HistogramFormRgb
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
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistogramFormRgb));
            this.histogramChartRed = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.histogramChartGreen = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.histogramChartBlue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnHistoStretching = new System.Windows.Forms.Button();
            this.btnHistoEqualization = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.histogramChartRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.histogramChartGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.histogramChartBlue)).BeginInit();
            this.SuspendLayout();
            // 
            // histogramChartRed
            // 
            chartArea1.AxisX.Interval = 50D;
            chartArea1.AxisX.IsMarginVisible = false;
            chartArea1.AxisX.LabelAutoFitMaxFontSize = 6;
            chartArea1.AxisY.LabelAutoFitMaxFontSize = 6;
            chartArea1.Name = "ChartArea1";
            this.histogramChartRed.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.histogramChartRed.Legends.Add(legend1);
            this.histogramChartRed.Location = new System.Drawing.Point(12, 12);
            this.histogramChartRed.Name = "histogramChartRed";
            series1.BorderColor = System.Drawing.Color.Red;
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.Red;
            series1.Legend = "Legend1";
            series1.Name = "red";
            series1.ShadowColor = System.Drawing.Color.Transparent;
            this.histogramChartRed.Series.Add(series1);
            this.histogramChartRed.Size = new System.Drawing.Size(682, 215);
            this.histogramChartRed.TabIndex = 0;
            this.histogramChartRed.Text = "chart1";
            // 
            // histogramChartGreen
            // 
            chartArea2.AxisX.Interval = 50D;
            chartArea2.AxisX.IsMarginVisible = false;
            chartArea2.AxisX.LabelAutoFitMaxFontSize = 6;
            chartArea2.Name = "ChartArea2";
            this.histogramChartGreen.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.histogramChartGreen.Legends.Add(legend2);
            this.histogramChartGreen.Location = new System.Drawing.Point(12, 233);
            this.histogramChartGreen.Name = "histogramChartGreen";
            series2.BorderColor = System.Drawing.Color.Lime;
            series2.ChartArea = "ChartArea2";
            series2.Color = System.Drawing.Color.Lime;
            series2.Legend = "Legend1";
            series2.Name = "green";
            series2.ShadowColor = System.Drawing.Color.Transparent;
            this.histogramChartGreen.Series.Add(series2);
            this.histogramChartGreen.Size = new System.Drawing.Size(682, 215);
            this.histogramChartGreen.TabIndex = 1;
            this.histogramChartGreen.Text = "chart1";
            // 
            // histogramChartBlue
            // 
            chartArea3.AxisX.Interval = 50D;
            chartArea3.AxisX.IsMarginVisible = false;
            chartArea3.Name = "ChartArea3";
            this.histogramChartBlue.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.histogramChartBlue.Legends.Add(legend3);
            this.histogramChartBlue.Location = new System.Drawing.Point(12, 454);
            this.histogramChartBlue.Name = "histogramChartBlue";
            series3.BorderColor = System.Drawing.Color.Blue;
            series3.ChartArea = "ChartArea3";
            series3.Color = System.Drawing.Color.Blue;
            series3.Legend = "Legend1";
            series3.Name = "blue";
            series3.ShadowColor = System.Drawing.Color.Transparent;
            this.histogramChartBlue.Series.Add(series3);
            this.histogramChartBlue.Size = new System.Drawing.Size(682, 215);
            this.histogramChartBlue.TabIndex = 2;
            this.histogramChartBlue.Text = "chart1";
            // 
            // btnHistoStretching
            // 
            this.btnHistoStretching.Location = new System.Drawing.Point(741, 12);
            this.btnHistoStretching.Name = "btnHistoStretching";
            this.btnHistoStretching.Size = new System.Drawing.Size(198, 48);
            this.btnHistoStretching.TabIndex = 3;
            this.btnHistoStretching.Text = "Rozciągnij histogram";
            this.btnHistoStretching.UseVisualStyleBackColor = true;
            this.btnHistoStretching.Click += new System.EventHandler(this.btnHistoStretching_Click);
            // 
            // btnHistoEqualization
            // 
            this.btnHistoEqualization.Location = new System.Drawing.Point(741, 66);
            this.btnHistoEqualization.Name = "btnHistoEqualization";
            this.btnHistoEqualization.Size = new System.Drawing.Size(198, 48);
            this.btnHistoEqualization.TabIndex = 4;
            this.btnHistoEqualization.Text = "Wyrównaj histogram";
            this.btnHistoEqualization.UseVisualStyleBackColor = true;
            this.btnHistoEqualization.Click += new System.EventHandler(this.btnHistoEqualization_Click);
            // 
            // HistogramFormRgb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(951, 677);
            this.Controls.Add(this.btnHistoEqualization);
            this.Controls.Add(this.btnHistoStretching);
            this.Controls.Add(this.histogramChartBlue);
            this.Controls.Add(this.histogramChartGreen);
            this.Controls.Add(this.histogramChartRed);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(967, 716);
            this.MinimumSize = new System.Drawing.Size(967, 716);
            this.Name = "HistogramFormRgb";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Histogram";
            ((System.ComponentModel.ISupportInitialize)(this.histogramChartRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.histogramChartGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.histogramChartBlue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataVisualization.Charting.Chart histogramChartRed;
        public System.Windows.Forms.DataVisualization.Charting.Chart histogramChartGreen;
        public System.Windows.Forms.DataVisualization.Charting.Chart histogramChartBlue;
        private System.Windows.Forms.Button btnHistoStretching;
        private System.Windows.Forms.Button btnHistoEqualization;
        //private static int[] red;
        //private static int[] green;
        //private static int[] blue;
    }
}