﻿using System;
using System.Collections;
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
    public partial class ScheduleForm : Form
    {
        SqlConnection connection;

        string conString = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Path.GetFullPath("InfoDatabase.mdf").Replace("bin\\Debug\\", "")};Integrated Security=True";
        int userId = VPGui.userId;

        string[] days = new string[] {"Monday","Tuesday","Wednesday","Thursday","Friday","Saturday","Sunday"};
        int sets;
        int reps;
        int weight;

        public ScheduleForm()
        {
            InitializeComponent();
            getSchedule();
        }

        
        private void getSchedule()
        {
            foreach (string day in days)
            {
                string info = "";
                // Query to get the user's non null workout from the specified day
                string query = $"SELECT {day} FROM LoginInfo WHERE Id = @id AND {day} IS NOT NULL";

                // Sets up the connection to the local database and has the command query from that connection (handles closing)
                using (connection = new SqlConnection(conString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    // Fills in the parameters needed for comparison
                    command.Parameters.AddWithValue("@id", userId);

                    // Puts the result of the query into variable
                    info = (string)command.ExecuteScalar();
                }
                // Makes day groupbox visible if there's a workout routine
                if (!string.IsNullOrEmpty(info))
                {
                    label1.Visible = false;
                    if (day == mondayGbx.Text)
                    {
                        mondayGbx.Visible = true;
                        buildSchedule(mondayGbx, info);
                    }
                    else if (day == tuesdayGbx.Text)
                    {
                        tuesdayGbx.Visible = true;
                        buildSchedule(tuesdayGbx, info);
                    }
                    else if (day == wednesdayGbx.Text)
                    {
                        wednesdayGbx.Visible = true;
                        buildSchedule(wednesdayGbx, info);
                    }
                    else if (day == thursdayGbx.Text)
                    {
                        thursdayGbx.Visible = true;
                        buildSchedule(thursdayGbx, info);
                    }
                    else if (day == fridayGbx.Text)
                    {
                        fridayGbx.Visible = true;
                        buildSchedule(fridayGbx, info);
                    }
                    else if (day == saturdayGbx.Text)
                    {
                        saturdayGbx.Visible = true;
                        buildSchedule(saturdayGbx, info);
                    }
                    else if (day == sundayGbx.Text)
                    {
                        sundayGbx.Visible = true;
                        buildSchedule(sundayGbx, info);
                    }
                }
            }
        }

        private void buildSchedule(GroupBox gbox, string info)
        {
            // Separates all workout names for that day
            string[] workouts = info.Split(',');

            // Scales the groupboxes with how many workouts are listed
            int autosize = 70 + (30 * workouts.Length);
            gbox.Size = new Size(483,autosize);

            // Title setup for the workouts
            createLabel(gbox, "Exercise", 20, 30, 15);
            createLabel(gbox, "Sets", 180, 30, 15);
            createLabel(gbox, "Reps", 250, 30, 15);
            createLabel(gbox, "Weight", 320, 30, 15);

            // Builds and places the workouts on the groupbox
            int y = 60;
            foreach (string workout in workouts)
            {
                sets = lookupDatabase(workout.Replace(' ', '_') + "_Set");
                reps = lookupDatabase(workout.Replace(' ', '_') + "_Rep");
                weight = lookupDatabase(workout.Replace(' ', '_') + "_Wht");

                createLabel(gbox, workout, 20, y);
                createLabel(gbox, sets.ToString(), 180, y);
                createLabel(gbox, reps.ToString(), 250, y);
                createLabel(gbox, weight.ToString(), 320, y);
                y += 30;
            }
        }

        private int lookupDatabase(string column)
        {
            // Query to get data from the column specified
            string query = $"SELECT {column} FROM LoginInfo WHERE Id = @id";

            // Sets up the connection to the local database and has the command query from that connection (handles closing)
            using (connection = new SqlConnection(conString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                // Fills in the parameters needed for comparison
                command.Parameters.AddWithValue("@id", userId);

                // Puts the result of the query into variable
                return (int)command.ExecuteScalar();
            }
        }


        public void createLabel(GroupBox gbox, string value, int x, int y, int font=12)
        {
            // Creates new label for data
            Label label = new Label();

            label.Text = value;
            label.Location = new Point(x, y);
            label.AutoSize = true;
            label.Font = new Font("Times New Roman", font);
            label.ForeColor = Color.White;
            gbox.Controls.Add(label);
        }
        

        private void WkClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ScheduleForm_Load(object sender, EventArgs e)
        {

        }

        private void sundayGbx_Enter(object sender, EventArgs e)
        {

        }
    }
}