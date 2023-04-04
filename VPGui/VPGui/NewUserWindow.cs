using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace VPGui
{
    public partial class NewUserForm : Form
    {
        SqlConnection connection;
        
        string conString = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Path.GetFullPath("InfoDatabase.mdf").Replace("bin\\Debug\\", "")};Integrated Security=True";

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
            // Query to insert new username and password into LoginInfo
            string query = "INSERT INTO LoginInfo VALUES (@Username, @Password)";

            // Sets up the connection to the local database and has the command query from that connection (handles closing)
            using (connection = new SqlConnection(conString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                // Fills in the parameters needed for the command query
                command.Parameters.AddWithValue("@Username", UserMakeInput.Text);
                command.Parameters.AddWithValue("@Password", PassMakeInput.Text);

                // Gives comfirmation of inserting
                command.ExecuteNonQuery();
            }

            UserMakeInput.Text = "";
            PassMakeInput.Text = "";

            MessageBox.Show("Account Successfully Created!");
        }
    }
}
