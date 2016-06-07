using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VotingSystemSoftWithThreeTierArchitecture.UI
{
    public partial class ChooseLoginUI : Form
    {
        public ChooseLoginUI()
        {
            InitializeComponent();
        }

        private void adminLoginButton_Click(object sender, EventArgs e)
        {
            Hide();
            AdminLogInUI aAdminLogInUi = new AdminLogInUI();
            aAdminLogInUi.Show();
        }

        private void VoterLoginButton_Click(object sender, EventArgs e)
        {
            Hide();
            VoterLoginUi aVoterLoginUi = new VoterLoginUi();
            aVoterLoginUi.Show();
        }

        private void CandidateLoginButton_Click(object sender, EventArgs e)
        {
            Hide();
            CandidateLoginUI aCandidateLoginUi = new CandidateLoginUI();
            aCandidateLoginUi.Show();
        }

        private void resultButton_Click(object sender, EventArgs e)
        {
            Hide();
            ResultUI aResultUi = new ResultUI();
            aResultUi.Show();
        }

        private void ChooseLoginUI_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }
    }
}
