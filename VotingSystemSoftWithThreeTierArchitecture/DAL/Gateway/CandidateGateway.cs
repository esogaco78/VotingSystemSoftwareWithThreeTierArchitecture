using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotingSystemSoftWithThreeTierArchitecture.BLL;
using VotingSystemSoftWithThreeTierArchitecture.DAL.DAO;

namespace VotingSystemSoftWithThreeTierArchitecture.DAL.Gateway
{
    class CandidateGateway : BaseGateway
    {
        public CandidateGateway()
        {
            aSqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["VSDB"].ConnectionString);
        }
        public bool IsThisDataExist(ManageCandidate aManageCandidate)
        {
            aSqlConnection.Open();
            string selectQuery = "SELECT * FROM t_candidate where candidate_name = '" + aManageCandidate.CandidateName + "'";
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

        public bool SaveNewCandidate(ManageCandidate aManageCandidate)
        {
            aSqlConnection.Open();
            string query = " INSERT INTO t_candidate (candidate_name , candidate_password, candidate_symbol, number_of_vote) VALUES ('" +
                           aManageCandidate.CandidateName + "' , '" + aManageCandidate.CandidatePassword + "' ,'" + aManageCandidate.CandidateSymbol + "', '0') ";
            SqlCommand aCommand = new SqlCommand(query, aSqlConnection);
            int affectedRow = aCommand.ExecuteNonQuery();
            aSqlConnection.Close();
            if (affectedRow > 0)
            {
                return true;
            }
            return false;
        }


        public bool DeleteThisCandidate(ManageCandidate aManageCandidate)
        {
            aSqlConnection.Open();
            string query = "DELETE FROM t_candidate WHERE candidate_name = '" + aManageCandidate.DeleteCandidate + "'";
            SqlCommand aCommand = new SqlCommand(query, aSqlConnection);
            int affectedRow = aCommand.ExecuteNonQuery();
            if (affectedRow > 0)
            {
                return true;
            }
            return false;
        }

        public bool CastThisVote(string candidateName)
        {
            aSqlConnection.Open();
            string query = "UPDATE t_candidate SET number_of_vote+='1' WHERE candidate_name = '" + candidateName + "'";
            SqlCommand command = new SqlCommand(query, aSqlConnection);
            int affectedRow = command.ExecuteNonQuery();
            aSqlConnection.Close();
            if (affectedRow > 0)
            {
                return true;
            }
            return false;
        }

        public List<DAL.DAO.ManageCandidate> FillComboBox()
        {
            aSqlConnection.Open();
            string query = "SELECT * FROM t_candidate";
            SqlCommand command = new SqlCommand(query, aSqlConnection);
            SqlDataReader aReader = command.ExecuteReader();
            List<ManageCandidate> candidatesList = new List<ManageCandidate>();
            while (aReader.Read())
            {
                ManageCandidate aCandidate = new ManageCandidate();
                aCandidate.CandidateSymbol = aReader["candidate_symbol"].ToString();
                candidatesList.Add(aCandidate);

            }
            aSqlConnection.Close();

            return candidatesList;
        }

        public List<ManageCandidate> LoadGridView()
        {
            aSqlConnection.Open();
            string query = "SELECT * FROM t_candidate";
            SqlCommand command = new SqlCommand(query, aSqlConnection);
            SqlDataReader aReader = command.ExecuteReader();
            List<ManageCandidate> candidatesList = new List<ManageCandidate>();
            while (aReader.Read())
            {
                ManageCandidate aCandidate = new ManageCandidate();
                aCandidate.CandidateName = aReader["candidate_name"].ToString();
                aCandidate.CandidateSymbol = aReader["candidate_symbol"].ToString();
                aCandidate.CandidatePassword = aReader["candidate_password"].ToString();
                aCandidate.NumberOfVote = (int)aReader["number_of_vote"];
                candidatesList.Add(aCandidate);

            }
            aSqlConnection.Close();

            return candidatesList;
        }

        public string CheckTheWinner()
        {
            aSqlConnection.Open();
            string query = ("select candidate_name from t_candidate where number_of_vote=(select max(number_of_vote) from t_candidate)");
            SqlCommand command = new SqlCommand(query, aSqlConnection);
            SqlDataReader aReader;
            aReader = command.ExecuteReader();
            string winner = "";
            while (aReader.Read())
            {
               winner= aReader["candidate_name"].ToString();
            }
            aSqlConnection.Close();
            return winner;
        }

        public string GetThisCandidateSymbol(System.Windows.Forms.TextBox candidateName)
        {
            aSqlConnection.Open();
            string query ="SELECT candidate_symbol FROM t_candidate WHERE candidate_name='"+candidateName+"'";
            SqlCommand command = new SqlCommand(query, aSqlConnection);
            SqlDataReader aReader;
            aReader = command.ExecuteReader();
            string symbol = "";
            while (aReader.Read())
            {
                symbol = aReader["candidate_symbol"].ToString();
            }
            aSqlConnection.Close();
            return symbol;
        }
    }
}
