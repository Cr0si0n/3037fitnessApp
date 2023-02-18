using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VPGui
{
    public partial class VPGui : Form
    {
        public VPGui()
        {
            InitializeComponent();
        }

        private void UserAndPassEnterButton_Click(object sender, EventArgs e)
        {
            //comment out this section if it doesn't compile, the file system is finicky
            string path = "";
            path = Path.GetFullPath("UserAndPass.txt");
            path = path.Substring(0, path.Length - 25);
            path = path + "UserAndPass.txt";
            string[] files = File.ReadAllLines(path);
            string userinput = UsernameInput.Text;
            string passinput = PasswordInput.Text;
            int counter = 0;
            string tempUser = "";
            foreach (string line in files)
            {
                if (counter == 0)
                {
                    counter++;
                    tempUser = line;

                }
                else
                {
                    counter--;
                    if(userinput == tempUser && passinput == line)
                    {
                        HideWelcome();
                        ShowWorkoutSelect();
                    }
                    //WorkoutSelection workoutform = new WorkoutSelection();
                    //IsMdiContainer = true;
                    //workoutform.Show();

                }
            }//end foreach
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        
        private void CreateNewUserButton_Click(object sender, EventArgs e)
        {
            NewUserForm child = new NewUserForm();
            //IsMdiContainer = true;
            child.Show();

        }

        private void VPGui_Load(object sender, EventArgs e)
        {
            HideWorkoutSelect();
        }

        private void HideWelcome()
        {
            ExitButton.Hide();
            PasswordInput.Hide();
            UsernameInput.Hide();
            PasswordLabel.Hide();
            UsernameLabel.Hide();
            WelcomeLabel.Hide();
            SignInLabel.Hide();
            CreateNewUserButton.Hide();
            UserAndPassEnterButton.Hide();
        }

        private void ShowWelcome()
        {
            ExitButton.Show(); 
            PasswordInput.Show();
            UsernameInput.Show();
            PasswordLabel.Show();
            UsernameLabel.Show();
            WelcomeLabel.Show();
            SignInLabel.Show();
            CreateNewUserButton.Show();
            UserAndPassEnterButton.Show();
        }

        private void HideWorkoutSelect()
        {
            WkLabel2.Hide();
            WkLabel1.Hide();
            WkLogout.Hide();
            Wkbutton1.Hide();
            Wkbutton2.Hide();
            Wkbutton3.Hide();
        }

        private void ShowWorkoutSelect()
        {
            WkLabel1.Show();
            WkLabel2.Show();
            WkLogout.Show();
            Wkbutton1.Show();
            Wkbutton2.Show();   
            Wkbutton3.Show();

        }

        private void WkLabel1_Click(object sender, EventArgs e)
        {

        }

        private void WkLogout_Click(object sender, EventArgs e)
        {
            HideWorkoutSelect();
            ShowWelcome();
        }
    }//End VPGui


}
