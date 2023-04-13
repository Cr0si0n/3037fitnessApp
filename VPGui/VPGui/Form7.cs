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
    public partial class Abs : Form
    {
        public Abs()
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

        private void button19_Click(object sender, EventArgs e)
        {
            textBox2.Text = "The GHD sit-up is an ab and hip flexion exercise with an extended range of motion.";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox2.Text = "Cable crunches, also known as kneeling cable crunches, are a weighted crunch variation that target your abdominal muscles.";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox2.Text = "The GHD back extension is a variation of the hyperextension and an exercise used to strengthen the muscles of the glutes, hamstrings, and lower back.";

        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox2.Text = "The plank is an isometric core strength exercise that involves maintaining a position similar to a push-up for the maximum possible time ";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox2.Text = "The bird dog exercise works the erector spinae, rectus abdominis, and glutes. These muscles allow for correct movement, control, and stability of the whole body.";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox2.Text = "The glute-ham raise is a posterior-chain exercise. That is, it trains the muscles on the back side of the body that work together in unison. The hamstrings, however, get hit the hardest";

        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox2.Text = "The Russian twist is an exercise targeting the abdominals and the obliques";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox2.Text = "The barbell roll-out is an abdominal exercise that utilizes a barbell in the place of an ab roller.";
        }
    }
}
