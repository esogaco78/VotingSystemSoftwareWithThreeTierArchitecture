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
    public partial class CandidateLoginUI : Form
    {
        public CandidateLoginUI()
        {
            InitializeComponent();
        }

        private void candidateSignInButton_Click(object sender, EventArgs e)
        {
            CandidateLogin aCandidateLogin = new CandidateLogin();
            aCandidateLogin.CandidateName = candidateNameTextBox.Text;
            aCandidateLogin.CandidatePassword = candidatePasswordTextBox.Text;

            if (candidateNameTextBox.Text == "" || candidatePasswordTextBox.Text == "")
            {
                MessageBox.Show("Please fill up required the field");
            }
            else
            {
                LoginManager aLoginManager = new LoginManager();
                bool candidateLoginPermission = aLoginManager.GivePermitToCandidateToLogin(aCandidateLogin);

                if (candidateLoginPermission)
                {
                    Hide();
                    CandidateUI aCandidateUi = new CandidateUI(aCandidateLogin.CandidateName);
                    aCandidateUi.Show();
                }
                else
                {
                    MessageBox.Show("Invalid Candidate Name or Password");
                }
            }
        }

        private void CandidateLoginUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            ChooseLoginUI aLoginUi = new ChooseLoginUI();
            aLoginUi.Show();
        }
    }
}
