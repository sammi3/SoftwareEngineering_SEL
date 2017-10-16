using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareEngineering_Project
{
    public partial class LoginPage : Form
    {
        private Login login;
        private LoginSuccess loginSuccess;
        private string staffID;
        private string password;
        private Receptionist user;

        public LoginPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            staffID = staffIDText.Text;
            password = passwordText.Text;

            login = new SoftwareEngineering_Project.Login(staffID, password);

            if(login.checkLogin() == true)
            {
                loginSuccess = new LoginSuccess();
                user = Program.User;
                user.StaffID = staffID;
                loginSuccess.Show();
            }
        }
    }
}
