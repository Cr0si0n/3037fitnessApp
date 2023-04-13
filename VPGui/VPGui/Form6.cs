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
    public partial class Legs : Form
    {
        public Legs()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void button6_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox1.Text = textBox1.Text + button.Text + "\r\n" + "\r\n";
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void button11_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox1.Text = textBox1.Text + button.Text + "\r\n" + "\r\n";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox1.Text = textBox1.Text + button.Text + "\r\n" + "\r\n";
        }

        private void button23_Click(object sender, EventArgs e)
        {
            textBox2.Text = "The back squat requires the structures of the lower body and core to work synergistically. ";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            textBox2.Text = "The front squat is a variation of the squat and an exercise used to build the muscles of the legs";

        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox2.Text = "The deadlift is a foundational movement to build a stronger back, legs, and core";

        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox2.Text = "The Romanian deadlift (or RDL) is a classic barbell exercise for strengthening your posterior chain muscles, such as your glutes, hamstrings, and lower back.";

        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox2.Text = "The hip thruster effectively improves hip extension by engaging the hamstrings and gluteal muscles.";

        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox2.Text = "The seated leg extension is an isolation exercise and one used to target the muscles of the quads";

        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox2.Text = "The lying leg curl is a great exercise to isolate the hamstrings.";

        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox2.Text = "The leg press is a variation of the squat and an exercise used to target the muscles of the leg.";

        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox2.Text = "The hack squat is a machine-based exercise that targets the muscles of the legs, particularly the quadriceps.";

        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox2.Text = "Calf raises are just one way to strengthen calf muscles.";

        }
    }
}
