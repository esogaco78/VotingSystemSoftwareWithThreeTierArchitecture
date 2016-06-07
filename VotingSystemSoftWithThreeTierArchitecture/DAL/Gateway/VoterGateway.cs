using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotingSystemSoftWithThreeTierArchitecture.DAL.DAO;

namespace VotingSystemSoftWithThreeTierArchitecture.DAL.Gateway
{


    class VoterGateway : BaseGateway
    {
        public VoterGateway()
        {
            aSqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["VSDB"].ConnectionString);
        }

        public bool IsThisDataExist(ManageVoter aManageVoter)
        {
            aSqlConnection.Open();
            string selectQuery = "SELECT * FROM t_voter where voter_id = '" + aManageVoter.VoterID + "'";
            SqlCommand aSqlCommand = new SqlCommand(selectQuery, aSqlConnection);
            SqlDataReader aReader = aSqlCommand.ExecuteReader();

            while (aReader.Read())
            {
                aSqlConnection.Close();
                return true;
            }
            aSqlConnection.Close();
            return false;
        }

        public bool SaveNewVoter(ManageVoter aManageVoter)
        {
            aSqlConnection.Open();
            string query = " INSERT INTO t_voter (voter_id , voter_password, voting_status) VALUES ('" +
                           aManageVoter.VoterID + "' , '" + aManageVoter.VoterPassword + "' , 'not voted') ";
            SqlCommand aCommand = new SqlCommand(query, aSqlConnection);
            int affectedRow = aCommand.ExecuteNonQuery();
            aSqlConnection.Close();
            if (affectedRow > 0)
            {
                return true;
            }
            return false;
        }

        public bool DeleteThisVoter(ManageVoter aManageVoter)
        {
            aSqlConnection.Open();
            string query = "DELETE FROM t_voter WHERE voter_id = '" + aManageVoter.DeleteVoter + "'";
            SqlCommand aCommand = new SqlCommand(query, aSqlConnection);
            int affectedRow = aCommand.ExecuteNonQuery();
            aSqlConnection.Close();
            if (affectedRow > 0)
            {
                return true;
            }
            return false;
        }

        public bool UpdateThisVoterVoteStatus(string voterID)
        {
            aSqlConnection.Open();
            string query = "UPDATE t_voter SET voting_status ='voted' WHERE voter_id = '" + voterID + "'";
            SqlCommand command = new SqlCommand(query, aSqlConnection);
            int affectedRow = command.ExecuteNonQuery();
            aSqlConnection.Close();
            if (affectedRow > 0)
            {
                return true;
            }
            return false;

        }

        public bool IsThisVoterGiveVote(string voterID)
        {
            aSqlConnection.Open();
            string selectQuery = "SELECT * FROM t_voter where voter_id = '" + voterID + "'";
            SqlCommand aSqlCommand = new SqlCommand(selectQuery, aSqlConnection);
            SqlDataReader aReader = aSqlCommand.ExecuteReader();

            string status = "";
            while (aReader.Read())
            {
                status = aReader["voting_status"].ToString();
            }
            aSqlConnection.Close();
            if (status == "voted")
            {
                return true;
            }
                return false;
        }

        public List<ManageVoter> LoadGridview()
        {
            aSqlConnection.Open();
            string query = "SELECT * FROM t_voter";
            SqlCommand command = new SqlCommand(query, aSqlConnection);
            SqlDataReader aReader = command.ExecuteReader();
            List<ManageVoter> voterList = new List<ManageVoter>();
            while (aReader.Read())
            {
                ManageVoter aVoter = new ManageVoter();
                aVoter.VoterID = aReader["voter_id"].ToString();
                aVoter.VoterPassword= aReader["voter_password"].ToString();
                aVoter.VotingStatus= aReader["voting_status"].ToString();
                voterList.Add(aVoter);

            }
            aSqlConnection.Close();

            return voterList;
        }
    }
}
