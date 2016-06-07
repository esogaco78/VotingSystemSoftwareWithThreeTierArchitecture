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

namespace VotingSystemSoftWithThreeTierArchitecture.UI
{
    public partial class VoterLoginUi : Form
    {
        public VoterLoginUi()
        {
            InitializeComponent();
        }

        private void voterSignInButton_Click(object sender, EventArgs e)
        {
            VoterLogin aVoterLogin = new VoterLogin();
            aVoterLogin.VoterID = voterIDTextBox.Text;
            aVoterLogin.VoterPassword = voterPasswordTextBox.Text;

            if (voterIDTextBox.Text == "" || voterPasswordTextBox.Text == "")
            {
                MessageBox.Show("Please fill up required the field");
            }
            else
            {
                LoginManager aLoginManager = new LoginManager();
                bool voterLoginPermission = aLoginManager.GivePermitToVoterToLogin(aVoterLogin);
                if (voterLoginPermission)
                {
                    Hide();
                    CastVoteUI aCastVoteUi = new CastVoteUI(aVoterLogin.VoterID);
                    aCastVoteUi.Show();
                }
                else
                {
                    MessageBox.Show("Invalid username or password");
                }
            }
        }

        private void VoterLoginUi_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            ChooseLoginUI aLoginUi = new ChooseLoginUI();
            aLoginUi.Show();
        }
    }
}
