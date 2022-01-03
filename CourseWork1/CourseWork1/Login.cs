using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.Text = "Sign in";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textUsername.Text;
            string password = textPassword.Text;

            if(String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username and password is required");
            }
            else if(username == "staff" && password == "staff")
            {
                this.Hide();
                StaffDashboard staffDashboard = new StaffDashboard();
                staffDashboard.ShowDialog();
                
            }
            else if(username == "admin" && password == "admin")
            {
                this.Hide();
                AdminDashboard adminDashboard = new AdminDashboard(); 
                adminDashboard.ShowDialog();
            }
            else
            {
                MessageBox.Show("Incorrect Username or Password");
            }
       
        }

        private void textPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            int width       = Screen.PrimaryScreen.Bounds.Width;
            int height      = Screen.PrimaryScreen.Bounds.Height;
            this.Location   = new Point(0, 0);
            this.Size       = new Size(width, height);

        }
    }
}
