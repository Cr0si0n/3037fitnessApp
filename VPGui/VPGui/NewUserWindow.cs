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
    public partial class NewUserForm : Form
    {
        public NewUserForm()
        {
            InitializeComponent();
        }

        private void NewUserForm_Load(object sender, EventArgs e)
        {

        }

        private void ExitUserCreation_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();


        }

        private void UserMakeInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void NewUserAndPassEnter_Click(object sender, EventArgs e)
        {
            string userinput = UserMakeInput.Text;
            string passinput = PassMakeInput.Text;
            PassMakeInput.Text = userinput;
            UserMakeInput.Text = passinput;
        }
    }
}
