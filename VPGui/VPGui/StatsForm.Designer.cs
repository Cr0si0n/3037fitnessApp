namespace VPGui
{
    partial class StatsForm
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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.WkClose = new System.Windows.Forms.Button();
            this.WkLabel1 = new System.Windows.Forms.Label();
            this.WeekChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.WeekChart)).BeginInit();
            this.SuspendLayout();
            // 
            // WkClose
            // 
            this.WkClose.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WkClose.Location = new System.Drawing.Point(799, 514);
            this.WkClose.Margin = new System.Windows.Forms.Padding(6);
            this.WkClose.Name = "WkClose";
            this.WkClose.Size = new System.Drawing.Size(174, 42);
            this.WkClose.TabIndex = 15;
            this.WkClose.Text = "Close";
            this.WkClose.UseVisualStyleBackColor = true;
            this.WkClose.Click += new System.EventHandler(this.WkClose_Click);
            // 
            // WkLabel1
            // 
            this.WkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WkLabel1.AutoSize = true;
            this.WkLabel1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.WkLabel1.Location = new System.Drawing.Point(102, 46);
            this.WkLabel1.Name = "WkLabel1";
            this.WkLabel1.Size = new System.Drawing.Size(294, 36);
            this.WkLabel1.TabIndex = 22;
            this.WkLabel1.Text = "Weekly Workout Stats";
            // 
            // WeekChart
            // 
            chartArea1.Name = "ChartArea1";
            this.WeekChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.WeekChart.Legends.Add(legend1);
            this.WeekChart.Location = new System.Drawing.Point(108, 101);
            this.WeekChart.Name = "WeekChart";
            series1.ChartArea = "ChartArea1";
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.Name = "Body Building";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.ChartArea = "ChartArea1";
            series2.IsXValueIndexed = true;
            series2.Legend = "Legend1";
            series2.Name = "HIT";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series3.ChartArea = "ChartArea1";
            series3.IsXValueIndexed = true;
            series3.Legend = "Legend1";
            series3.Name = "Cardio";
            series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series3.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.WeekChart.Series.Add(series1);
            this.WeekChart.Series.Add(series2);
            this.WeekChart.Series.Add(series3);
            this.WeekChart.Size = new System.Drawing.Size(741, 395);
            this.WeekChart.TabIndex = 23;
            this.WeekChart.Text = "chart1";
            this.WeekChart.Click += new System.EventHandler(this.WeekChart_Click);
            // 
            // StatsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 660);
            this.Controls.Add(this.WeekChart);
            this.Controls.Add(this.WkLabel1);
            this.Controls.Add(this.WkClose);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "StatsForm";
            this.Text = "Body Building";
            ((System.ComponentModel.ISupportInitialize)(this.WeekChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button WkClose;
        private System.Windows.Forms.Label WkLabel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart WeekChart;
    }
}