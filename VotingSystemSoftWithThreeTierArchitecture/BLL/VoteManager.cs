using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotingSystemSoftWithThreeTierArchitecture.DAL.Gateway;

namespace VotingSystemSoftWithThreeTierArchitecture.BLL
{
    class VoteManager
    {
        public bool UpdateVoterVoteStatus(string voterID)
        {
            VoterGateway aVoterGateway = new VoterGateway();
            bool voteStatus=aVoterGateway.UpdateThisVoterVoteStatus(voterID);
            return voteStatus;
        }

        public bool CastVote(string candidateName)
        {
            CandidateGateway aCandidateGateway = new CandidateGateway();
            bool castVoteStatus = aCandidateGateway.CastThisVote(candidateName);
            return castVoteStatus;
        }
    }
}
