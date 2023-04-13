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
    public partial class Arms : Form
    {
        public Arms()
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
            textBox2.Text = "The dumbbell biceps curl with static hold increases strength in the biceps and forearms."; 
        }

        private void button22_Click(object sender, EventArgs e)
        {
            textBox2.Text = "A hammer curl is a variation of the biceps curl and targets muscles in the upper and lower arm.";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox2.Text = "The preacher curl is an effective exercise for isolating and focusing on the arm flexors.";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox2.Text = "The reverse-grip barbell curl is a variation on the biceps curl where the palms face downward.";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox2.Text = "Cable curl is an alternative to the barbell curl that offers more of a constant tension on your muscles throughout the movement.";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox2.Text = "A tricep extension is a movement in which the back of the arm is targeted for strength and hypertrophy through extension of the elbow.";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox2.Text = "The tricep pushdown is an isolation exercise for your triceps where it is easy to focus on the muscles working.";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox2.Text = "The cable overhead triceps extension is a cable exercise performed in a seated position, targeting the triceps muscles.";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox2.Text = "The close-grip bench press is a popular exercise targeting the triceps and chest.";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox2.Text = "Tricep pushups, also known as diamond pushups or triangle pushups, are a great bodyweight exercise you can do at " +
                "               home to build lean muscle in your triceps, and increased strength as well.";
        }
    }
}
