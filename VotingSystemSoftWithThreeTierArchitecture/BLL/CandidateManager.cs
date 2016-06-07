using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotingSystemSoftWithThreeTierArchitecture.DAL.Gateway;

namespace VotingSystemSoftWithThreeTierArchitecture.BLL
{
    class CandidateManager
    {
        CandidateGateway aCandidateGateway = new CandidateGateway();

        public bool SaveCandidate(DAL.DAO.ManageCandidate aManageCandidate)
        {
            if (aCandidateGateway.IsThisDataExist(aManageCandidate))
            {
                return false;
            }
            bool saveCandidate = aCandidateGateway.SaveNewCandidate(aManageCandidate);
            return saveCandidate;
        }

         public bool DeleteCandidate(DAL.DAO.ManageCandidate aManageCandidate)
        {
            bool deleteCandidate = aCandidateGateway.DeleteThisCandidate(aManageCandidate);
            return deleteCandidate;
        }

        public List<DAL.DAO.ManageCandidate> FillCombo()
        {
            return aCandidateGateway.FillComboBox();
        }

        public List<DAL.DAO.ManageCandidate> LoadCandidateGridview()
        {
            return aCandidateGateway.LoadGridView();
        }

        public string CheckWinner()
        {
            return aCandidateGateway.CheckTheWinner();
        }



        public string GetSymbol(System.Windows.Forms.TextBox candidateName)
        {
            return aCandidateGateway.GetThisCandidateSymbol(candidateName);

        }


    }
}
