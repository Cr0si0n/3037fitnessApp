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
    public partial class bodybuilding : Form
    {
        public bodybuilding()
        {
            InitializeComponent();
        }

        private void bodybuilding_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //VPGui.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Shoulders f1 = new Shoulders();
            f1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Chest f1 = new Chest();
            f1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Arms f1 = new Arms();
            f1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Legs f1 = new Legs();
            f1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UpperBack f1 = new UpperBack();
            f1.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Abs f1 = new Abs();
            f1.Show();
        }
    }
}
