using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using VotingSystemSoftWithThreeTierArchitecture.DAL.DAO;

namespace VotingSystemSoftWithThreeTierArchitecture.DAL.Gateway
{
    class LoginGateway : BaseGateway
    {
        public LoginGateway()
        {
            aSqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["VSDB"].ConnectionString);
        }

        //public bool CheckLoginInfo(DAO.AdminLogin aAdminLogin)
        //{
        //    aSqlConnection.Open();
        //    string query = "SELECT * FROM t_login WHERE username = '"+aAdminLogin.Username+"' and password ='"+aAdminLogin.Password+"' ";
        //    SqlCommand aCommand = new SqlCommand(query, aSqlConnection);
        //    SqlDataReader aReader=aCommand.ExecuteReader();

        //    string username="";
        //    string password="";
        //    while (aReader.Read())
        //    {
        //        username=aReader["username"].ToString();
        //        password = aReader["password"].ToString();
        //    }
        //    aSqlConnection.Close();

        //    if (username == aAdminLogin.Username && password == aAdminLogin.Password)
        //    {
        //        return true;
        //    }
        //    return  false;

        //}

        //public VoterLogin CheckVoterLoginInfo(DAO.VoterLogin aVoterLogin)
        //{
        //    aSqlConnection.Open();
        //    string query = "SELECT * FROM t_voter WHERE voter_id = '" + aVoterLogin.VoterID + "' and voter_password ='" + aVoterLogin.VoterPassword + "' ";
        //    SqlCommand aCommand = new SqlCommand(query, aSqlConnection);
        //    SqlDataReader aReader = aCommand.ExecuteReader();

        //    while (aReader.Read())
        //    {
        //        voterID = aReader["voter_id"].ToString();
        //        voterPassword = aReader["voter_password"].ToString();
        //    }
        //    aSqlConnection.Close();

        //    if (voterID == aVoterLogin.VoterID && voterPassword == aVoterLogin.VoterPassword)
        //    {
        //        return true;
        //    }
        //    return false;
        //}

        //public bool CheckCandidateLoginInfo(DAO.CandidateLogin aCandidateLogin)
        //{
        //    aSqlConnection.Open();
        //    string query = "SELECT * FROM t_candidate WHERE candidate_name = '" + aCandidateLogin.CandidateName + "' and candidate_password ='" + aCandidateLogin.CandidatePassword+ "' ";
        //    SqlCommand aCommand = new SqlCommand(query, aSqlConnection);
        //    SqlDataReader aReader = aCommand.ExecuteReader();

        //    string candidateName = "";
        //    string candidatePassword = "";
        //    while (aReader.Read())
        //    {
        //        candidateName= aReader["candidate_name"].ToString();
        //        candidatePassword = aReader["candidate_password"].ToString();
        //    }
        //    aSqlConnection.Close();

        //    if (candidateName == aCandidateLogin.CandidateName&& candidatePassword == aCandidateLogin.CandidatePassword)
        //    {
        //        return true;
        //    }
        //    return false;
        //}

        public AdminLogin CheckLoginInfoTest(string username, string password)
        {
            aSqlConnection.Open();
            string query = "SELECT * FROM t_login WHERE username = '" + username + "' and password ='" + password + "' ";
            SqlCommand aCommand = new SqlCommand(query, aSqlConnection);
            SqlDataReader aReader = aCommand.ExecuteReader();

            AdminLogin aAdminLogin = new AdminLogin();
            while (aReader.Read())
            {
                aAdminLogin.Username = aReader["username"].ToString();
                aAdminLogin.Password = aReader["password"].ToString();
            }
            aReader.Close();
            aSqlConnection.Close();
            return aAdminLogin;

        }

        public VoterLogin CheckVoterLoginInfo(string voterID, string voterPassword)
        {
            aSqlConnection.Open();
            string query = "SELECT * FROM t_voter WHERE voter_id = '" + voterID + "' and voter_password ='" + voterPassword + "' ";
            SqlCommand aCommand = new SqlCommand(query, aSqlConnection);
            SqlDataReader aReader = aCommand.ExecuteReader();
            VoterLogin aVoterLogin = new VoterLogin();
            while (aReader.Read())
            {
                 aVoterLogin.VoterID= aReader["voter_id"].ToString();
                 aVoterLogin.VoterPassword= aReader["voter_password"].ToString();
            }
            aSqlConnection.Close();
            return aVoterLogin;
        }

        internal CandidateLogin CheckCandidateLoginInfo(string candidateName, string candidatePassword)
        {
            aSqlConnection.Open();
            string query = "SELECT * FROM t_candidate WHERE candidate_name = '" + candidateName + "' and candidate_password ='" + candidatePassword + "' ";
            SqlCommand aCommand = new SqlCommand(query, aSqlConnection);
            SqlDataReader aReader = aCommand.ExecuteReader();
            CandidateLogin aCandidateLogin = new CandidateLogin();
            
            while (aReader.Read())
            {
                aCandidateLogin.CandidateName = aReader["candidate_name"].ToString();
                aCandidateLogin.CandidatePassword = aReader["candidate_password"].ToString();
            }
            aSqlConnection.Close();
            return aCandidateLogin;
        }
    }
}
