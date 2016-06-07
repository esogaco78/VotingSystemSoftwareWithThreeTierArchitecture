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
    public partial class CastVoteUI : Form
    {
        public CastVoteUI(string voterID)
        {
            InitializeComponent();
            voterIDTextBox.Text = voterID;
        }

        CandidateManager aCandidateManager = new CandidateManager();

        public void CastVoteUI_Load(object sender, EventArgs e)
        {
            StatusManager aStatusManager = new StatusManager();

            if (aStatusManager.CheckSystemStatus())
            {
                VoterManager aVoterManager = new VoterManager();
                List<ManageCandidate> cList = new List<ManageCandidate>();
                cList = aCandidateManager.LoadCandidateGridview();

                int slNo = 1;
                foreach (var candidate in cList)
                {
                    candidateListDataGridView.Rows.Add(slNo, candidate.CandidateName, candidate.CandidateSymbol);
                    slNo++;
                }

                bool chkVoteStatus = aVoterManager.CheckVoterVoteStatus(voterIDTextBox.Text);
                if (chkVoteStatus)
                {
                    castVoteButton.Enabled = false;
                    castVoteButton.Text = "Voted Already";
                    candidateSymbolComboBox.Enabled = false;
                }
                else
                {
                    List<ManageCandidate> candidatesList = new List<ManageCandidate>();
                    candidatesList = aCandidateManager.FillCombo();
                    candidateSymbolComboBox.DisplayMember = "CandidateSymbol";
                    candidateSymbolComboBox.DataSource = candidatesList;
                }
            }
            else
            {
                castVoteButton.Text = "SYSTEM IS OFFLINE";
                castVoteButton.Enabled = false;
                candidateSymbolComboBox.Hide();
            }
        }


        private void castVoteButton_Click(object sender, EventArgs e)
        {
            string voterID = voterIDTextBox.Text;
            VoteManager aVoteManager = new VoteManager();
            string candidateName = candidateSymbolComboBox.Text;
            bool ifCastVoteSuccessful=aVoteManager.CastVote(candidateName);


            if (ifCastVoteSuccessful)
            {
                bool ifVoteStatusUpdated = aVoteManager.UpdateVoterVoteStatus(voterID);
                if (ifVoteStatusUpdated)
                {
                    MessageBox.Show("You have given vote successfully");
                    castVoteButton.Enabled = false;
                    candidateSymbolComboBox.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Vote Status not updated");
                }
            }
            else
            {
                MessageBox.Show("Something is wrong");
            }
        }

        private void CastVoteUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            ChooseLoginUI aLoginUi = new ChooseLoginUI();
            aLoginUi.Show();
        }

        
    }
}
