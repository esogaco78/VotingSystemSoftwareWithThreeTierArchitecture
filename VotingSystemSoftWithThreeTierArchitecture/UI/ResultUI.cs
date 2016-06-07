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
    public partial class ResultUI : Form
    {
        public ResultUI()
        {
            InitializeComponent();
        }

        private void ResultUI_Load(object sender, EventArgs e)
        {
            StatusManager aStatusManager = new StatusManager();
            if (aStatusManager.CheckPublishStatus())
            {
                CandidateManager aCandidateManager = new CandidateManager();

                winnerNameTextBox.Text = aCandidateManager.CheckWinner();
                

                List<ManageCandidate> candidateList = new List<ManageCandidate>();
                candidateList = aCandidateManager.LoadCandidateGridview();
                resultDataGridView.Rows.Clear();
                int SerialNumber = 1;
                foreach (var candidate in candidateList)
                {
                    resultDataGridView.Rows.Add(SerialNumber, candidate.CandidateName, candidate.NumberOfVote);
                    SerialNumber++;
                }
            }
            else
            {
                MessageBox.Show("Result is not published yet");
                
            }
        }

        private void ResultUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            ChooseLoginUI aLoginUi = new ChooseLoginUI();
            aLoginUi.Show();
        }

    }
}
