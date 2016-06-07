using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingSystemSoftWithThreeTierArchitecture.DAL.DAO
{
    class ManageVoter
    {
        public string VoterID { get; set; }
        public string VoterPassword { get; set; }
        public string VotingStatus { get; set; }
        public string DeleteVoter { get; set; }
    }
}
