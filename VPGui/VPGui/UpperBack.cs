using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VPGui
{
    public partial class UpperBack : Form
    {
        string buttonText;
        public UpperBack()
        {
            InitializeComponent();
            label4.Hide();
            label5.Hide();
            Sets.Hide();
            Reps.Hide();
            Weight.Hide();
            button18.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label4.Show();
            label5.Show();
            Sets.Show();
            Reps.Show();
            Weight.Show();
            button18.Show();
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
            button18.Show();
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
            button18.Show();
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
            button18.Show();
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
            label1.Hide();
            label2.Hide();
            label3.Hide();
            textBox1.Hide();
            textBox2.Hide();
            Button button = (Button)sender;
            buttonText = button.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label4.Show();
            label5.Show();
            Sets.Show();
            Reps.Show();
            Weight.Show();
            button18.Show();
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
            button18.Show();
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
            button18.Show();
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
            label1.Hide();
            label2.Hide();
            label3.Hide();
            textBox1.Hide();
            textBox2.Hide();
            Button button = (Button)sender;
            buttonText = button.Text;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox2.Text = "The dumbbell lateral raise is an upper body isolation exercise for building shoulder strength and muscle.";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox2.Text = "The dumbbell shrug is a variation of the shrug and an exercise used to build trap muscle size.";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox2.Text = "The barbell row is an excellent exercise for building up your back muscles.";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox2.Text = "The barbell shrug is a simple lift that'll make your upper back bigger, stronger, and more resilient to injury.";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox2.Text = "The lat pulldown is a compound exercise designed to target many muscles of the back, most notably the latissimus dorsi.";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox2.Text = "The cable seated row is a popular exercise to train the muscles of the upper back, including the lats.";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox2.Text = "Pull-ups are one of the best ways to make serious strength gains and build your upper body without needing a lot of equipment.";
        }

        private void button18_Click(object sender, EventArgs e)
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
            button18.Hide();
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
            label1.Show();
            label2.Show();
            label3.Show();
            textBox1.Show();
            textBox2.Show();
            Reps.Clear();
            Sets.Clear();
            Weight.Clear();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Shoulders sh = new Shoulders();
            sh.workoutSaveButton(textBox1);
        }
    }
}
