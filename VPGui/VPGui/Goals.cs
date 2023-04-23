using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VPGui
{
    public partial class Goals : Form
    {
        SqlConnection connection;

        string conString = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Path.GetFullPath("InfoDatabase.mdf").Replace("bin\\Debug\\", "")};Integrated Security=True";
        int userId = VPGui.userId;
        string[] shoulders = { "DB Front Raise", "DB Lateral Rasie", "Dumbbell Press", "Barbell Press", "Arnold Press", "DB Reverse Fly", "Bus Driver", "Face Pull", "Cable Lat Raise" };
        string[] chest = { "Bench Press", "Incline Bench", "Decline Bench", "Flat DB Fly", "Incline DB Fly", "Cable Fly", "Lower Cable Fly", "DB Pullover"};
        string[] arms = { "DB Bicep Curl", "Hammer Curl", "Preacher Curl", "Rev Grip Curl", "Cable Curl", "DB Tricep Ext", "Tricep Pushdown", "OH Cable Ext", "Close Grip Bench", "Tricep Puch-up" };
        string[] upper = {"DB Lateral Row", "DB Shrug", "BB Row", "BB Shrug", "Lat Pulldown", "Lat Cable Row", "Pull up" };
        string[] legs = {"Back Squat", "Front Squat", "Deadlift", "Romanian DL", "Hip Thrust", "Leg Extension", "Leg Curl", "Leg Press", "Hack Squat", "Calf Raise" };
        string[] lower = {"GHD Situp", "Cable Crunch", "Russian Twist", "Barbell Rollout", "GHD Back Ext", "30 sec Plank", "Bird Dogs", "Glute Ham Raises" };

        public Goals()
        {
            InitializeComponent();
            this.AcceptButton = saveBtn;
            comboBox1.Items.AddRange(new string[] {"Shoulders","Chest", "Arms", "Upper Back", "Legs", "Abs/Lower Back"});
            buildGoalList();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void WkClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string goals = "";
            // Grab past goals
            string past = getPastGoals();

            if (past != "")
            {
                // If a workout goal already exists, replace its data
                if (past.Contains(comboBox2.Text))
                {
                    string[] data = past.Split(':');
                    for (int i = 0; i < data.Length; i++)
                    {
                        if (data[i].Contains(comboBox2.Text))
                        {
                            data[i] = comboBox2.Text + "," + int.Parse(SetsTxt.Text) + "," + int.Parse(RepsTxt.Text) + "," + int.Parse(WeightTxt.Text);
                            goals += data[i];
                        }
                        else
                            goals += data[i];

                        // Put the spacer back
                        if (i != data.Length-1)
                            goals += ":";
                    }
                }
                else
                {
                    // Otherwise just append it to the past workouts
                    goals = past + ":" + comboBox2.Text + "," + int.Parse(SetsTxt.Text) + "," + int.Parse(RepsTxt.Text) + "," + int.Parse(WeightTxt.Text);
                }
            }
            else
            {
                // Add goal data if there are none
                goals = comboBox2.Text + "," + int.Parse(SetsTxt.Text) + "," + int.Parse(RepsTxt.Text) + "," + int.Parse(WeightTxt.Text);
            }

            // Put goals into the database
            callDatabase("Goals", goals);
            // Update the goal list
            buildGoalList();

            // Reset info
            comboBox1.Text = "Choose a Muscle Group";
            comboBox2.Text = "Choose an Exercise";
            SetsTxt.Text = "";
            RepsTxt.Text = "";
            WeightTxt.Text = "";
        }

        private string getPastGoals()
        {
            int count = 0;
            string last = "";
            // Query to check and see if there is a previous goal
            string query = $"SELECT COUNT(1) FROM LoginInfo WHERE Id = @id AND Goals IS NOT NULL";

            // Sets up the connection to the local database and has the command query from that connection (handles closing)
            using (connection = new SqlConnection(conString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                // Fills in the parameters needed for comparison
                command.Parameters.AddWithValue("@id", userId);

                // Puts the result of the query into variable
                count = (int)command.ExecuteScalar();
            }

            // If there's a previous weight, get its value
            if (count > 0)
            {
                // Query to get data from the column specified
                query = $"SELECT Goals FROM LoginInfo WHERE Id = @id";

                // Sets up the connection to the local database and has the command query from that connection (handles closing)
                using (connection = new SqlConnection(conString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    // Fills in the parameters needed for comparison
                    command.Parameters.AddWithValue("@id", userId);

                    // Puts the result of the query into variable
                    last = (string)command.ExecuteScalar();
                }
            }

            return last;
        }
        private void callDatabase(string column, string value)
        {
            // Query to update workout info of current user into LoginInfo (column is inserted directly because it doesn't like it otherwise)
            string query = $"UPDATE LoginInfo SET {column} = @value WHERE Id = @id";

            // Sets up the connection to the local database and has the command query from that connection (handles closing)
            using (connection = new SqlConnection(conString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                // Fills in the parameters needed for the command query
                command.Parameters.AddWithValue("@value", value);
                command.Parameters.AddWithValue("@id", userId);

                // Gives comfirmation of updating
                command.ExecuteNonQuery();
            }
        }

        private void buildGoalList()
        {
            string raw = getPastGoals();

            if (raw != "")
            {
                // Deletes previous groupboxes
                int c = flowLayoutPanel1.Controls.Count;
                for (int i = c - 1; i >= 0; i--)
                    flowLayoutPanel1.Controls.Remove(flowLayoutPanel1.Controls[i]);

                // No longer needs no goals label
                label1.Visible = false;

                // Split each goal and call schedule for createLabel
                string[] goals = raw.Split(':');
                ScheduleForm sh = new ScheduleForm();

                foreach (string goal in goals)
                {
                    // Split up the goal data and create a groupbox for the data
                    string[] data = goal.Split(',');
                    GroupBox gbox = new GroupBox();

                    gbox.Text = data[0];
                    gbox.Size = new Size(280, 130);
                    gbox.Font = new Font("Times New Roman", 16);
                    gbox.ForeColor = Color.White;
                    flowLayoutPanel1.Controls.Add(gbox);

                    // Insert data into groupbox
                    sh.createLabel(gbox, "  Sets:", 30, 30);
                    sh.createLabel(gbox, "  Reps:", 30, 60);
                    sh.createLabel(gbox, "Weight:", 30, 90);
                    sh.createLabel(gbox, data[1], 100, 30);
                    sh.createLabel(gbox, data[2], 100, 60);
                    sh.createLabel(gbox, data[3], 100, 90);
                }
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            // Delete goal specified
            deleteGoal(comboBox2.Text);
            // Update the goal list
            buildGoalList();

            // Reset info
            comboBox1.Text = "Choose a Muscle Group";
            comboBox2.Text = "Choose an Exercise";
        }

        public void deleteGoal(string workout)
        {
            string goals = "";
            // Grab past goals
            string past = getPastGoals();

            // Checks if there are goals and the goal to delete exists
            if (past != "" && past.Contains(workout))
            {
                string[] data = past.Split(':');
                for (int i = 0; i < data.Length; i++)
                {
                    // If current is the goal to delete, skip it
                    if (!data[i].Contains(workout))
                    {
                        // Put the spacer back
                        if (i != 0)
                            goals += ":";

                        goals += data[i];
                    }
                }
                goals = goals.Trim(':');
            }
            // Put updated goal list into the database
            callDatabase("Goals", goals);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Updates the exercise combobox relative to the muscle group selected
            if (comboBox1.Text == "Shoulders")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.AddRange(shoulders);
            }
            else if (comboBox1.Text == "Chest")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.AddRange(chest);
            }
            else if (comboBox1.Text == "Arms")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.AddRange(arms);
            }
            else if (comboBox1.Text == "Upper Back")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.AddRange(upper);
            }
            else if (comboBox1.Text == "Legs")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.AddRange(legs);
            }
            else if (comboBox1.Text == "Abs/Lower Back")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.AddRange(lower);
            }
        }
    }
}
