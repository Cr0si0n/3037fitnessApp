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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.WkClose = new System.Windows.Forms.Button();
            this.WkLabel1 = new System.Windows.Forms.Label();
            this.WeekChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.WeekChart)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // WkClose
            // 
            this.WkClose.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WkClose.Location = new System.Drawing.Point(381, 259);
            this.WkClose.Name = "WkClose";
            this.WkClose.Size = new System.Drawing.Size(87, 22);
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
            this.WkLabel1.ForeColor = System.Drawing.Color.White;
            this.WkLabel1.Location = new System.Drawing.Point(32, 16);
            this.WkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WkLabel1.Name = "WkLabel1";
            this.WkLabel1.Size = new System.Drawing.Size(147, 19);
            this.WkLabel1.TabIndex = 22;
            this.WkLabel1.Text = "Weekly Workout Stats";
            // 
            // WeekChart
            // 
            chartArea2.Name = "ChartArea1";
            this.WeekChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.WeekChart.Legends.Add(legend2);
            this.WeekChart.Location = new System.Drawing.Point(35, 45);
            this.WeekChart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.WeekChart.Name = "WeekChart";
            series4.ChartArea = "ChartArea1";
            series4.IsXValueIndexed = true;
            series4.Legend = "Legend1";
            series4.Name = "Body Building";
            series4.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series4.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series5.ChartArea = "ChartArea1";
            series5.IsXValueIndexed = true;
            series5.Legend = "Legend1";
            series5.Name = "HIT";
            series5.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series5.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series6.ChartArea = "ChartArea1";
            series6.IsXValueIndexed = true;
            series6.Legend = "Legend1";
            series6.Name = "Cardio";
            series6.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series6.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.WeekChart.Series.Add(series4);
            this.WeekChart.Series.Add(series5);
            this.WeekChart.Series.Add(series6);
            this.WeekChart.Size = new System.Drawing.Size(370, 205);
            this.WeekChart.TabIndex = 23;
            this.WeekChart.Text = "chart1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(59)))), ((int)(((byte)(57)))));
            this.panel1.Controls.Add(this.WeekChart);
            this.panel1.Controls.Add(this.WkLabel1);
            this.panel1.Controls.Add(this.WkClose);
            this.panel1.Location = new System.Drawing.Point(41, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(517, 301);
            this.panel1.TabIndex = 24;
            // 
            // StatsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(37)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(605, 343);
            this.Controls.Add(this.panel1);
            this.Name = "StatsForm";
            this.Text = "Body Building";
            ((System.ComponentModel.ISupportInitialize)(this.WeekChart)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button WkClose;
        private System.Windows.Forms.Label WkLabel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart WeekChart;
        private System.Windows.Forms.Panel panel1;
    }
}