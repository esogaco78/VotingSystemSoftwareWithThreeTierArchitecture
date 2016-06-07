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
    public partial class CandidateUI : Form
    {
        public CandidateUI(string candidateName)
        {
            InitializeComponent();
            candidateNameTextBox.Text = candidateName;
        }


        private void CandidateUI_Load(object sender, EventArgs e)
        {
            CandidateManager aCandidateManager = new CandidateManager();
            candidateSymbolTextBox.Text = aCandidateManager.GetSymbol(candidateNameTextBox);

            List<ManageCandidate> candidateList = new List<ManageCandidate>();
            candidateList = aCandidateManager.LoadCandidateGridview();
            candidateListDataGridView.Rows.Clear();
            int candidateSerialNumber = 1;
            foreach (var candidate in candidateList)
            {
                candidateListDataGridView.Rows.Add(candidateSerialNumber, candidate.CandidateName, candidate.CandidateSymbol);
                candidateSerialNumber++;
            }
        }

        private void CandidateUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            ChooseLoginUI aLoginUi = new ChooseLoginUI();
            aLoginUi.Show();
        }


    }
}
