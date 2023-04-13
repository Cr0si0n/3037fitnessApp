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
    public partial class Chest : Form
    {
        public Chest()
        {
            InitializeComponent();
        }

        private void Chest_Load(object sender, EventArgs e)
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

        private void button7_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox1.Text = textBox1.Text + button.Text + "\r\n" + "\r\n";
        }

        private void button6_Click(object sender, EventArgs e)
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
            textBox2.Text = "The bench press is a compound exercise that targets the muscles of the upper body.";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox2.Text = "The incline bench press is a variation of the bench press and an exercise used to build the muscles of the chest.";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox2.Text = "The decline bench press is the press variation on a bench that puts the least amount of stress on your lower back.";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox2.Text = "The incline dumbbell fly predominantly targets the upper pectorals and is a great way to build the size of your chest.";

        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox2.Text = "The cable chest fly is an isolation movement aimed at targeting the chest. It is a great alternative to a standard dumbbell fly.";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox2.Text = "The low cable fly is a great exercise to target your chest and takes advantage of the cable machine while working with a different plane of motion.";

        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox2.Text = "The dumbbell pullover is a classic bodybuilding exercise that works your chest and back primarily";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox2.Text = "The dumbbell fly utilizes a chest fly movement pattern to isolate the muscles fo the chest to better help the muscles grow and become stronger.";
        }
    }
}
