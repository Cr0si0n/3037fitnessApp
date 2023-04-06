using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VPGui
{
    public partial class StatsForm : Form
    {
        /*SqlConnection connection;

        string conString = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Path.GetFullPath("InfoDatabase.mdf").Replace("bin\\Debug\\", "")};Integrated Security=True";
        */
        public StatsForm()
        {
            InitializeComponent();
            WeekChartLoad();
        }

        private void WeekChartLoad()
        {
            /*// Query to insert new column for excersize into LoginInfo
            string query = "ALTER TABLE LoginInfo ADD COLUMN IF NOT EXISTS Workout VARCHAR(255)";

            // Sets up the connection to the local database and has the command query from that connection (handles closing)
            using (connection = new SqlConnection(conString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                // Fills in the parameters needed for the command query
                command.Parameters.AddWithValue("@workout", "Deadlift");

                // Gives comfirmation of inserting
                command.ExecuteNonQuery();
            }*/

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

        
    }
}
