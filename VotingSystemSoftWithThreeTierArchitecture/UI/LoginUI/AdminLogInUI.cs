using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VotingSystemSoftWithThreeTierArchitecture.BLL;
using VotingSystemSoftWithThreeTierArchitecture.DAL.DAO;
using VotingSystemSoftWithThreeTierArchitecture.DAL.Gateway;
using VotingSystemSoftWithThreeTierArchitecture.UI;

namespace VotingSystemSoftWithThreeTierArchitecture
{
    public partial class AdminLogInUI : Form
    {
        public AdminLogInUI()
        {
            InitializeComponent();
        }


        private void signInButton_Click(object sender, EventArgs e)
        {
            AdminLogin aAdminLogin = new AdminLogin();
            aAdminLogin.Username = userNameTextBox.Text;
            aAdminLogin.Password = passwordTextBox.Text;

            if (userNameTextBox.Text == "" || passwordTextBox.Text == "")
            {
                MessageBox.Show("Please fill up required the field");
            }
            else
            {
                LoginManager aLoginManager = new LoginManager();
                bool loginPermission = aLoginManager.GivePermitToLogin(aAdminLogin);
                if (loginPermission)
                {
                    Hide();
                    AdminUI aAdminUi = new AdminUI();
                    aAdminUi.Show();
                }
                else
                {
                    MessageBox.Show("Invalid username or password");
                }
            }
        }

        private void AdminLogInUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            ChooseLoginUI aLoginUi = new ChooseLoginUI();
            aLoginUi.Show();
        }
    }
}
