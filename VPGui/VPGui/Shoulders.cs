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
    public partial class Shoulders : Form
    {
        SqlConnection connection;

        string conString = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Path.GetFullPath("InfoDatabase.mdf").Replace("bin\\Debug\\", "")};Integrated Security=True";
        int userId = VPGui.userId;
        string buttonText;
        public Shoulders()
        {
            InitializeComponent();
            label4.Hide();
            label5.Hide();
            Sets.Hide();
            Reps.Hide();
            Weight.Hide();
            button22.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label4.Show();
            label5.Show();
            Sets.Show();
            Reps.Show();
            Weight.Show();
            button22.Show();
            button1.Hide();
            button2.Hide();
            button3.Hide();
            button4.Hide();
            button5.Hide();
            button6.Hide();
            button7.Hide();
            button8.Hide();
            button9.Hide();
            button10.Hide();
            button11.Hide();
            button12.Hide();
            button13.Hide();
            button14.Hide();
            button15.Hide();
            button16.Hide();
            button17.Hide();
            button18.Hide();
            button19.Hide();
            button20.Hide();
            button21.Hide();
            label1.Hide();
            label2.Hide();
            label3.Hide();
            textBox1.Hide();
            textBox2.Hide();
            Button button = (Button)sender;
            buttonText = button.Text;
        }

        private void Shoulders_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label4.Show();
            label5.Show();
            Sets.Show();
            Reps.Show();
            Weight.Show();
            button22.Show();
            button1.Hide();
            button2.Hide();
            button3.Hide();
            button4.Hide();
            button5.Hide();
            button6.Hide();
            button7.Hide();
            button8.Hide();
            button9.Hide();
            button10.Hide();
            button11.Hide();
            button12.Hide();
            button13.Hide();
            button14.Hide();
            button15.Hide();
            button16.Hide();
            button17.Hide();
            button18.Hide();
            button19.Hide();
            button20.Hide();
            button21.Hide();
            label1.Hide();
            label2.Hide();
            label3.Hide();
            textBox1.Hide();
            textBox2.Hide();
            Button button = (Button)sender;
            buttonText = button.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label4.Show();
            label5.Show();
            Sets.Show();
            Reps.Show();
            Weight.Show();
            button22.Show();
            button1.Hide();
            button2.Hide();
            button3.Hide();
            button4.Hide();
            button5.Hide();
            button6.Hide();
            button7.Hide();
            button8.Hide();
            button9.Hide();
            button10.Hide();
            button11.Hide();
            button12.Hide();
            button13.Hide();
            button14.Hide();
            button15.Hide();
            button16.Hide();
            button17.Hide();
            button18.Hide();
            button19.Hide();
            button20.Hide();
            button21.Hide();
            label1.Hide();
            label2.Hide();
            label3.Hide();
            textBox1.Hide();
            textBox2.Hide();
            Button button = (Button)sender;
            buttonText = button.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label4.Show();
            label5.Show();
            Sets.Show();
            Reps.Show();
            Weight.Show();
            button22.Show();
            button1.Hide();
            button2.Hide();
            button3.Hide();
            button4.Hide();
            button5.Hide();
            button6.Hide();
            button7.Hide();
            button8.Hide();
            button9.Hide();
            button10.Hide();
            button11.Hide();
            button12.Hide();
            button13.Hide();
            button14.Hide();
            button15.Hide();
            button16.Hide();
            button17.Hide();
            button18.Hide();
            button19.Hide();
            button20.Hide();
            button21.Hide();
            label1.Hide();
            label2.Hide();
            label3.Hide();
            textBox1.Hide();
            textBox2.Hide();
            Button button = (Button)sender;
            buttonText = button.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label4.Show();
            label5.Show();
            Sets.Show();
            Reps.Show();
            Weight.Show();
            button22.Show();
            button1.Hide();
            button2.Hide();
            button3.Hide();
            button4.Hide();
            button5.Hide();
            button6.Hide();
            button7.Hide();
            button8.Hide();
            button9.Hide();
            button10.Hide();
            button11.Hide();
            button12.Hide();
            button13.Hide();
            button14.Hide();
            button15.Hide();
            button16.Hide();
            button17.Hide();
            button18.Hide();
            button19.Hide();
            button20.Hide();
            button21.Hide();
            label1.Hide();
            label2.Hide();
            label3.Hide();
            textBox1.Hide();
            textBox2.Hide();
            Button button = (Button)sender;
            buttonText = button.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label4.Show();
            label5.Show();
            Sets.Show();
            Reps.Show();
            Weight.Show();
            button22.Show();
            button1.Hide();
            button2.Hide();
            button3.Hide();
            button4.Hide();
            button5.Hide();
            button6.Hide();
            button7.Hide();
            button8.Hide();
            button9.Hide();
            button10.Hide();
            button11.Hide();
            button12.Hide();
            button13.Hide();
            button14.Hide();
            button15.Hide();
            button16.Hide();
            button17.Hide();
            button18.Hide();
            button19.Hide();
            button20.Hide();
            button21.Hide();
            label1.Hide();
            label2.Hide();
            label3.Hide();
            textBox1.Hide();
            textBox2.Hide();
            Button button = (Button)sender;
            buttonText = button.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label4.Show();
            label5.Show();
            Sets.Show();
            Reps.Show();
            Weight.Show();
            button22.Show();
            button1.Hide();
            button2.Hide();
            button3.Hide();
            button4.Hide();
            button5.Hide();
            button6.Hide();
            button7.Hide();
            button8.Hide();
            button9.Hide();
            button10.Hide();
            button11.Hide();
            button12.Hide();
            button13.Hide();
            button14.Hide();
            button15.Hide();
            button16.Hide();
            button17.Hide();
            button18.Hide();
            button19.Hide();
            button20.Hide();
            button21.Hide();
            label1.Hide();
            label2.Hide();
            label3.Hide();
            textBox1.Hide();
            textBox2.Hide();
            Button button = (Button)sender;
            buttonText = button.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label4.Show();
            label5.Show();
            Sets.Show();
            Reps.Show();
            Weight.Show();
            button22.Show();
            button1.Hide();
            button2.Hide();
            button3.Hide();
            button4.Hide();
            button5.Hide();
            button6.Hide();
            button7.Hide();
            button8.Hide();
            button9.Hide();
            button10.Hide();
            button11.Hide();
            button12.Hide();
            button13.Hide();
            button14.Hide();
            button15.Hide();
            button16.Hide();
            button17.Hide();
            button18.Hide();
            button19.Hide();
            button20.Hide();
            button21.Hide();
            label1.Hide();
            label2.Hide();
            label3.Hide();
            textBox1.Hide();
            textBox2.Hide();
            Button button = (Button)sender;
            buttonText = button.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label4.Show();
            label5.Show();
            Sets.Show();
            Reps.Show();
            Weight.Show();
            button22.Show();
            button1.Hide();
            button2.Hide();
            button3.Hide();
            button4.Hide();
            button5.Hide();
            button6.Hide();
            button7.Hide();
            button8.Hide();
            button9.Hide();
            button10.Hide();
            button11.Hide();
            button12.Hide();
            button13.Hide();
            button14.Hide();
            button15.Hide();
            button16.Hide();
            button17.Hide();
            button18.Hide();
            button19.Hide();
            button20.Hide();
            button21.Hide();
            label1.Hide();
            label2.Hide();
            label3.Hide();
            textBox1.Hide();
            textBox2.Hide();
            Button button = (Button)sender;
            buttonText = button.Text; 
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox2.Text = "The dumbbell front raise is a fundamental weight training exercise that is great for people who want to build strength or create more definition in the shoulders. " +
                "You can use the dumbbell front raise in any upper body workout; just be sure to pick a weight you can lift with proper form.";        
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox2.Text = "The dumbbell lateral raise is an upper body isolation exercise for building shoulder strength and muscle. " +
                "It's a staple strength training move and is a great option for accessory work on upper body training days. " +
                "This exercise particularly focuses on the lateral or medial head of the deltoid, making them appear wider and more developed.";        
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox2.Text = "As its name suggests, the dumbbell shoulder press builds your shoulder muscles." +
                " When done correctly, it can also help strengthen the back and core. " +
                "Incorporate this exercise into your strength training, bodybuilding, or high-intensity interval training (HIIT) workout.";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox2.Text = "As its name suggests, the barbell shoulder press builds your shoulder muscles." +
                " When done correctly, it can also help strengthen the back and core. " +
                "Incorporate this exercise into your strength training, bodybuilding, or high-intensity interval training (HIIT) workout.";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox2.Text = "Named after the iconic bodybuilder and movie star, the Arnold press adds rotation to a classic shoulder press. " +
                "It allows the hands to rotate naturally, while also hitting all three heads of the deltoids in one motion. " +
                "It is usually performed for moderate to high reps, such as 8-12 reps or more, as part of the upper-body or shoulder-focused portion of a workout.";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox2.Text = "The bent over dumbbell reverse fly, also known as the bent over rear delt fly, is a great exercise to assist you in building a complete set of shoulders." +
                "Many lifters utilize the bent over dumbbell reverse fly to target the rear delts, an often lagging muscle for many lifters alike." +
                "Strengthening the rear delts by using the bent over rear delt fly can lead to improved posture and a greater level of strength on other lifts.";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox2.Text = "The bus driver exercise is a great prehab and warm up exercise to perform to promote rotator cuff health." +
                "Rotator cuffs are one of the more common injuries, especially as lifters get older. " +
                "Performing prehab exercises such as bus drivers can help prevent injury and increase your longevity in the gym.";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox2.Text = "The cable face pull with external rotation is a variation of the cable face pull and a great shoulder exercise that can be used to target the rear deltoids. " +
                "Not many exercises can effectively target the rear delts like cable face pull can." +
                "Add the cable face pull exercise in your body part split on either shoulder or back day, on your upper day during your upper/lower splits, or on your pull day for push/pull/leg splits.";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox2.Text = "The cable face pull with external rotation is a variation of the cable face pull and a great shoulder exercise that can be used to target the rear deltoids." +
                " Not many exercises can effectively target the rear delts like cable face pull can.";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            workoutSaveButton(textBox1);
        }

        public void workoutSaveButton(TextBox text)
        {
            // A look at the list of the different variables at play
            //    rawList = textBox1.Text + buttonText + "\t\t" + Sets.Text + "   x   " + Reps.Text + "\t\t" + Weight.Text + " lbs" + "\r\n" + "\r\n";
            //    data = buttonText + "\t\t" + Sets.Text + "   x   " + Reps.Text + "\t\t" + Weight.Text + " lbs"
            //    workoutList = buttonText, "", Sets.Text, Reps.Text, "", Weight.Text + " lbs"
            //    subData = Weight.Text, " lbs"

            // Splits the textbox data by row
            string[] rawList = text.Text.Split(new string[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);

            foreach (string data in rawList)
            {
                // Splits the textbox row by words
                string[] workoutList = data.Split(new string[] { "\t", "   x   " }, StringSplitOptions.None);

                // To prevent the spacer rows from giving error
                if (workoutList[0] != "")
                {
                    // For the one case where numbers are in the name
                    if (workoutList[0] == "30 sec Plank")
                        workoutList[0] = "Thirty sec Plank";

                    // Translate the workout names to the database ones
                    string workout = workoutList[0].Replace(' ', '_');

                    // call the database to insert each value into respective column
                    callDatabase(workout + "_Set", int.Parse(workoutList[2]));
                    callDatabase(workout + "_Rep", int.Parse(workoutList[3]));

                    // Just to get rid of the " lbs" fragment
                    string[] subData = workoutList[5].Split(' ');
                    callDatabase(workout + "_Wht", int.Parse(subData[0]));
                }
            }
            // Tells the user that it has been saved
            MessageBox.Show("Workout(s) Successfully Saved!");
        }

        public void callDatabase(string column, int value)
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

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Sets_TextChanged(object sender, EventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox1.Text = textBox1.Text + buttonText + "\t\t" 
                + Sets.Text + "   x   " + Reps.Text + 
                "\t\t" + Weight.Text + " lbs" + "\r\n" + "\r\n";
            label4.Hide();
            label5.Hide();
            Sets.Hide();
            Reps.Hide();
            Weight.Hide();
            button22.Hide();
            button1.Show();
            button2.Show();
            button3.Show();
            button4.Show();
            button5.Show();
            button6.Show();
            button7.Show();
            button8.Show();
            button9.Show();
            button10.Show();
            button11.Show();
            button12.Show();
            button13.Show();
            button14.Show();
            button15.Show();
            button16.Show();
            button17.Show();
            button18.Show();
            button19.Show();
            button20.Show();
            button21.Show();
            label1.Show();
            label2.Show();
            label3.Show();
            textBox1.Show();
            textBox2.Show();
            Reps.Clear();
            Sets.Clear();
            Weight.Clear();
        }
    }
}
