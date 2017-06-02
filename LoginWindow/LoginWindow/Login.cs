using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Login : Form
    {
        private UserService _userService;
        private FileUserStore _fileUserStore;
        public Login(UserService userService, FileUserStore fileUserStore)
        {
            InitializeComponent();
            _userService = userService;
            _fileUserStore = fileUserStore;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_2(object sender, EventArgs e)
        {

            var signupForm = new SignUp(_userService, _fileUserStore);
            signupForm.Show();

        }

private void button1_Click(object sender, EventArgs e)
        
        {
            var userExists = _userService.Check(this.username.Text, this.password.Text);
            if (userExists)
            {
                MessageBox.Show("Welcome to our page!", "Welcome!", 0, MessageBoxIcon.Information);
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Something is wrong. Please try again!", "Error!",
                    0, MessageBoxIcon.Error);
            }
        }

       
    }
}
