using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VPGui
{
    public partial class StatsForm : Form
    {
        public StatsForm()
        {
            InitializeComponent();
            WeekChartLoad();
        }

        private void WeekChartLoad()
        {
            //if empty(no excersize was done) do the following


            //WeekChart.ChartAreas[0].AxisX.Interval = 1;
            WeekChart.Series["Body Building"].Points.AddXY("Mon", 0);
            WeekChart.Series["Body Building"].Points.AddXY("Tues", 0);
            WeekChart.Series["Body Building"].Points.AddXY("Weds", 0);
            WeekChart.Series["Body Building"].Points.AddXY("Thurs", 0);
            WeekChart.Series["Body Building"].Points.AddXY("Fri", 0);
            WeekChart.Series["Body Building"].Points.AddXY("Sat", 0);

        }

        

        private void WkClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void WeekChart_Click(object sender, EventArgs e)
        {

        }
    }
}
