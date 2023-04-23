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
        string buttonText;
        public Chest()
        {
            InitializeComponent();
            this.AcceptButton = button12;
            label4.Hide();
            label5.Hide();
            Sets.Hide();
            Reps.Hide();
            Weight.Hide();
            button22.Hide();

            comboBox1.Items.AddRange(new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" });
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
            this.AcceptButton = button22;
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
            this.AcceptButton = button22;
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
            this.AcceptButton = button22;
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
            this.AcceptButton = button22;
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
            this.AcceptButton = button22;
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
            this.AcceptButton = button22;
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
            this.AcceptButton = button22;
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
            this.AcceptButton = button22;
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
            label1.Hide();
            label2.Hide();
            label3.Hide();
            textBox1.Hide();
            textBox2.Hide();
            comboBox1.Hide();
            Button button = (Button)sender;
            buttonText = button.Text;
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

        private void button22_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox1.Text = textBox1.Text + buttonText + "\t\t"
                + Sets.Text + "   x   " + Reps.Text +
                "\t\t" + Weight.Text + " lbs" + "\r\n" + "\r\n";
            this.AcceptButton = button12;
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

        private void button12_Click(object sender, EventArgs e)
        {
            Shoulders sh = new Shoulders();
            sh.workoutSaveButton(textBox1, comboBox1);
        }
    }
}
