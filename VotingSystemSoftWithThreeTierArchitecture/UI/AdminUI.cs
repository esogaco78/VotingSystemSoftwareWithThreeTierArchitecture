using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using VotingSystemSoftWithThreeTierArchitecture.BLL;
using VotingSystemSoftWithThreeTierArchitecture.DAL.DAO;
using VotingSystemSoftWithThreeTierArchitecture.DAL.Gateway;

namespace VotingSystemSoftWithThreeTierArchitecture.UI
{
    public partial class AdminUI : Form
    {
        public AdminUI()
        {
            InitializeComponent();
        }
        ManageVoter aManageVoter = new ManageVoter();
        ManageCandidate aManageCandidate = new ManageCandidate();
        StatusManager aStatusManager = new StatusManager();

        private void AdminUI_Load(object sender, EventArgs e)
        {
            CandidateManager aCandidateManager = new CandidateManager();
            winnerTextBox.Text=aCandidateManager.CheckWinner();

            LoadCandidateGridview();
            LoadVoterGridView();
            if (aStatusManager.CheckSystemStatus())
            {
                systemOnButton.Enabled = false;
            }
            else
            {
                systemOffButton.Enabled = false;
            }


            if (aStatusManager.CheckPublishStatus())
            {
                publishButton.Enabled = false;
            }
            else
            {
                withdrawButton.Enabled = false;
            }
            
        }

        private void LoadVoterGridView()
        {
            VoterManager aVoterManager = new VoterManager();
            List<ManageVoter> voterList = new List<ManageVoter>();
            voterList = aVoterManager.LoadVoterGridview();
            int voterSerialNumber = 1;
            VoterListGridView.Rows.Clear();
            foreach (var voter in voterList)
            {
                VoterListGridView.Rows.Add(voterSerialNumber, voter.VoterID, voter.VoterPassword, voter.VotingStatus);
                voterSerialNumber++;
            }
        }

        private void LoadCandidateGridview()
        {
            CandidateManager aCandidateManager = new CandidateManager();
            List<ManageCandidate> candidateList = new List<ManageCandidate>();
            candidateList = aCandidateManager.LoadCandidateGridview();
            candidateListGridView.Rows.Clear();
            int candidateSerialNumber = 1;
            foreach (var candidate in candidateList)
            {
                candidateListGridView.Rows.Add(candidateSerialNumber, candidate.CandidateName, candidate.CandidateSymbol,
                    candidate.CandidatePassword, candidate.NumberOfVote);
                candidateSerialNumber++;
            }

            resultListDataGridView.Rows.Clear();
            int SerialNumber = 1;
            foreach (var candidate in candidateList)
            {
                resultListDataGridView.Rows.Add(SerialNumber, candidate.CandidateName,candidate.NumberOfVote);
                candidateSerialNumber++;
            }


        }

        //private void LoadResultGridview()
        //{
        //    CandidateManager aCandidateManager = new CandidateManager();
        //    List<ManageCandidate> candidateList = new List<ManageCandidate>();
        //    candidateList = aCandidateManager.LoadCandidateGridview();

        //    int candidateSerialNumber = 1;
        //    foreach (var candidate in candidateList)
        //    {
        //        candidateListGridView.Rows.Add(candidateSerialNumber, candidate.CandidateName, candidate.CandidateSymbol,
        //            candidate.CandidatePassword, candidate.NumberOfVote);
        //        candidateSerialNumber++;
        //    }
        //}


        private void saveVoterButton_Click(object sender, EventArgs e)
        {
            aManageVoter.VoterID = voterIDTextBox.Text;
            aManageVoter.VoterPassword = voterPasswordTextBox.Text;

            if (voterIDTextBox.Text != "" && voterPasswordTextBox.Text != "")
            {
                VoterManager aVoterManager = new VoterManager();
                bool confirmSaveMessage = aVoterManager.SaveVoter(aManageVoter);

                if (confirmSaveMessage)
                {
                    MessageBox.Show("New Voter Saved");
                    voterIDTextBox.Clear();
                    voterPasswordTextBox.Clear();
                    LoadVoterGridView();
                }
                else
                {
                    MessageBox.Show("This id is already exist");
                    voterIDTextBox.Clear();
                    voterPasswordTextBox.Clear();
                }
            }
            else
            {
                MessageBox.Show("Please Fill up the required field");
            }
        }

        private void deleteVoterButton_Click(object sender, EventArgs e)
        {
            if (deleteVoterTextBox.Text != "")
            {
                aManageVoter.DeleteVoter = deleteVoterTextBox.Text;
                VoterManager aVoterManager = new VoterManager();
                bool confirmDeleteVoter = aVoterManager.DeleteVoter(aManageVoter);

                if (confirmDeleteVoter)
                {
                    MessageBox.Show("Delete successfully");
                    deleteVoterTextBox.Clear();
                    LoadVoterGridView();
                }
                else
                {
                    MessageBox.Show("Can not be Deleted.\nError found while deleting the data.");
                }
            }
            else
            {
                MessageBox.Show("Empty field \nEnter Valid Voter ID to Delete");
            }
        }

        private void saveCandidateButton_Click(object sender, EventArgs e)
        {
            if (candidateNameTextBox.Text != "" && candidatePasswordTextBox.Text != "" && CandidateSymbolTextBox.Text != "")
            {
                aManageCandidate.CandidateName = candidateNameTextBox.Text;
                aManageCandidate.CandidatePassword = candidatePasswordTextBox.Text;
                aManageCandidate.CandidateSymbol = CandidateSymbolTextBox.Text;
                CandidateManager aCandidateManager = new CandidateManager();
                bool confirmSaveMessage = aCandidateManager.SaveCandidate(aManageCandidate);

                if (confirmSaveMessage)
                {
                    MessageBox.Show("New Candidate Saved");
                    candidateNameTextBox.Clear();
                    candidatePasswordTextBox.Clear();
                    CandidateSymbolTextBox.Clear();
                    LoadCandidateGridview();
                }
                else
                {
                    MessageBox.Show("This Candidate is already exist");
                    candidateNameTextBox.Clear();
                    candidatePasswordTextBox.Clear();
                    CandidateSymbolTextBox.Clear();
                }
            }
            else
            {
                MessageBox.Show("Please Fill up the required field");
            }
        }

        private void AdminUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            ChooseLoginUI aLoginUi = new ChooseLoginUI();
            aLoginUi.Show();
        }

        private void deleteCandidateButton_Click(object sender, EventArgs e)
        {
            if (deleteCandidateTextBox.Text != "")
            {
                aManageCandidate.DeleteCandidate = deleteCandidateTextBox.Text;
                CandidateManager aCandidateManager = new CandidateManager();
                bool confirmDeleteCandidate = aCandidateManager.DeleteCandidate(aManageCandidate);

                if (confirmDeleteCandidate)
                {
                    MessageBox.Show("Delete successfully");
                    deleteCandidateTextBox.Clear();
                    LoadCandidateGridview();
                }
                else
                {
                    MessageBox.Show("Can not be Deleted.\nError found while deleting the data.");
                }
            }
            else
            {
                MessageBox.Show("Empty field \nEnter Valid Candidate Name to Delete");
            }
        }

        private void systemOnButton_Click(object sender, EventArgs e)
        {
            string systemStatus = "on";
            bool systemStatsusMsg = aStatusManager.SaveSystemStatus(systemStatus);
            if (systemStatsusMsg)
            {
                MessageBox.Show("System is 'ON' now");
                systemOnButton.Enabled = false;
                systemOffButton.Enabled = true;
            }
            else
            {
                MessageBox.Show("Something is Wrong");
            }
        }

        private void systemOffButton_Click(object sender, EventArgs e)
        {
            string systemStatusMsg = "off";
            bool systemStatus = aStatusManager.SaveSystemStatus(systemStatusMsg);
            if (systemStatus)
            {
                MessageBox.Show("System is 'OFF' now");
                systemOnButton.Enabled = true;
                systemOffButton.Enabled = false;
            }
            else
            {
                MessageBox.Show("Something is Wrong");
            }
        }

        private void publishButton_Click(object sender, EventArgs e)
        {
            string publishStatusMsg = "published";
            bool publishStatus = aStatusManager.SavePublishingStatus(publishStatusMsg);
            if (publishStatus)
            {
                MessageBox.Show("Result is now published");
                publishButton.Enabled = false;
                withdrawButton.Enabled = true;
            }
            else
            {
                MessageBox.Show("Something is Wrong");
            }
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            string publishStatusMsg = "not published";
            bool publishStatus = aStatusManager.SavePublishingStatus(publishStatusMsg);
            if (publishStatus)
            {
                MessageBox.Show("Result is now withdrawed");
                publishButton.Enabled = true;
                withdrawButton.Enabled = false;
            }
            else
            {
                MessageBox.Show("Something is Wrong");
            }
        }
    }
}
