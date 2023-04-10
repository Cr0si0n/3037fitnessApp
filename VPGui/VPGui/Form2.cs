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
    public partial class Shoulders : Form
    {
        public Shoulders()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox1.Text = textBox1.Text + button.Text + "\r\n" + "\r\n";
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
            Button button = (Button)sender;
            textBox1.Text = textBox1.Text + button.Text + "\r\n" + "\r\n";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox1.Text = textBox1.Text + button.Text + "\r\n" + "\r\n";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox1.Text = textBox1.Text + button.Text + "\r\n" + "\r\n";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox1.Text = textBox1.Text + button.Text + "\r\n" + "\r\n";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox1.Text = textBox1.Text + button.Text + "\r\n" + "\r\n";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox1.Text = textBox1.Text + button.Text + "\r\n" + "\r\n";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox1.Text = textBox1.Text + button.Text + "\r\n" + "\r\n";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox1.Text = textBox1.Text + button.Text + "\r\n" + "\r\n";
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
    }
}
