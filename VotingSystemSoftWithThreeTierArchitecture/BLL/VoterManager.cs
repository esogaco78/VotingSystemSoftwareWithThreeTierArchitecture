using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotingSystemSoftWithThreeTierArchitecture.DAL.Gateway;

namespace VotingSystemSoftWithThreeTierArchitecture.BLL
{
    class VoterManager
    {
        VoterGateway aVoterGateway = new VoterGateway();
        public bool SaveVoter(DAL.DAO.ManageVoter aManageVoter)
        {
            if (aVoterGateway.IsThisDataExist(aManageVoter))
            {
                return false;
            }
            bool saveVoterMsg = aVoterGateway.SaveNewVoter(aManageVoter);
            return saveVoterMsg;
        }



        public bool DeleteVoter(DAL.DAO.ManageVoter aManageVoter)
        {
                bool deleteVoter = aVoterGateway.DeleteThisVoter(aManageVoter);
                return deleteVoter;
        }



        public bool CheckVoterVoteStatus(string voterID)
        {
            if (aVoterGateway.IsThisVoterGiveVote(voterID))
            {
                return true;
            }
            return false;
        }

        public List<DAL.DAO.ManageVoter> LoadVoterGridview()
        {
            return aVoterGateway.LoadGridview();
        }
    }
}
