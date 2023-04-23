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
        string buttonText;
        public Abs()
        {
            InitializeComponent();
            this.AcceptButton = button13;
            label4.Hide();
            label5.Hide();
            Sets.Hide();
            Reps.Hide();
            Weight.Hide();
            button20.Hide();

            comboBox1.Items.AddRange(new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" });
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
            this.AcceptButton = button20;
            label4.Show();
            label5.Show();
            Sets.Show();
            Reps.Show();
            Weight.Show();
            button20.Show();
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
            label1.Hide();
            label2.Hide();
            label3.Hide();
            textBox1.Hide();
            textBox2.Hide();
            comboBox1.Hide();
            Button button = (Button)sender;
            buttonText = button.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.AcceptButton = button20;
            label4.Show();
            label5.Show();
            Sets.Show();
            Reps.Show();
            Weight.Show();
            button20.Show();
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
            label1.Hide();
            label2.Hide();
            label3.Hide();
            textBox1.Hide();
            textBox2.Hide();
            comboBox1.Hide();
            Button button = (Button)sender;
            buttonText = button.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.AcceptButton = button20;
            label4.Show();
            label5.Show();
            Sets.Show();
            Reps.Show();
            Weight.Show();
            button20.Show();
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
            label1.Hide();
            label2.Hide();
            label3.Hide();
            textBox1.Hide();
            textBox2.Hide();
            comboBox1.Hide();
            Button button = (Button)sender;
            buttonText = button.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.AcceptButton = button20;
            label4.Show();
            label5.Show();
            Sets.Show();
            Reps.Show();
            Weight.Show();
            button20.Show();
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
            label1.Hide();
            label2.Hide();
            label3.Hide();
            textBox1.Hide();
            textBox2.Hide();
            comboBox1.Hide();
            Button button = (Button)sender;
            buttonText = button.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.AcceptButton = button20;
            label4.Show();
            label5.Show();
            Sets.Show();
            Reps.Show();
            Weight.Show();
            button20.Show();
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
            label1.Hide();
            label2.Hide();
            label3.Hide();
            textBox1.Hide();
            textBox2.Hide();
            comboBox1.Hide();
            Button button = (Button)sender;
            buttonText = button.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.AcceptButton = button20;
            label4.Show();
            label5.Show();
            Sets.Show();
            Reps.Show();
            Weight.Show();
            button20.Show();
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
            label1.Hide();
            label2.Hide();
            label3.Hide();
            textBox1.Hide();
            textBox2.Hide();
            comboBox1.Hide();
            Button button = (Button)sender;
            buttonText = button.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.AcceptButton = button20;
            label4.Show();
            label5.Show();
            Sets.Show();
            Reps.Show();
            Weight.Show();
            button20.Show();
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
            label1.Hide();
            label2.Hide();
            label3.Hide();
            textBox1.Hide();
            textBox2.Hide();
            comboBox1.Hide();
            Button button = (Button)sender;
            buttonText = button.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.AcceptButton = button20;
            label4.Show();
            label5.Show();
            Sets.Show();
            Reps.Show();
            Weight.Show();
            button20.Show();
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
            label1.Hide();
            label2.Hide();
            label3.Hide();
            textBox1.Hide();
            textBox2.Hide();
            comboBox1.Hide();
            Button button = (Button)sender;
            buttonText = button.Text;
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

        private void button20_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox1.Text = textBox1.Text + buttonText + "\t\t"
                + Sets.Text + "   x   " + Reps.Text +
                "\t\t" + Weight.Text + " lbs" + "\r\n" + "\r\n";
            this.AcceptButton = button13;
            label4.Hide();
            label5.Hide();
            Sets.Hide();
            Reps.Hide();
            Weight.Hide();
            button20.Hide();
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
            label1.Show();
            label2.Show();
            label3.Show();
            textBox1.Show();
            textBox2.Show();
            comboBox1.Show();
            Reps.Clear();
            Sets.Clear();
            Weight.Clear();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Shoulders sh = new Shoulders();
            sh.workoutSaveButton(textBox1, comboBox1);
        }
    }
}
