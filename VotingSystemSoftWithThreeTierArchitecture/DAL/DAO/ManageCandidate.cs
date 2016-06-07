using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingSystemSoftWithThreeTierArchitecture.DAL.DAO
{
    class ManageCandidate
    {
        public string CandidateName { get; set; }
        public string CandidateSymbol { get; set; }
        public string CandidatePassword { get; set; }
        public int NumberOfVote { get; set; }
        public string DeleteCandidate { get; set; }
    }
}
