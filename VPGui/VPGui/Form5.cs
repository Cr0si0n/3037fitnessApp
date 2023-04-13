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
    public partial class UpperBack : Form
    {
        public UpperBack()
        {
            InitializeComponent();
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

        private void button5_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox1.Text = textBox1.Text + button.Text + "\r\n" + "\r\n";
        }

        private void button2_Click(object sender, EventArgs e)
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
    }
}
