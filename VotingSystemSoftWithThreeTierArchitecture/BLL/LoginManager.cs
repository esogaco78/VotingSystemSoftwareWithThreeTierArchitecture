using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotingSystemSoftWithThreeTierArchitecture.DAL.DAO;
using VotingSystemSoftWithThreeTierArchitecture.DAL.Gateway;

namespace VotingSystemSoftWithThreeTierArchitecture.BLL
{
    class LoginManager
    {
        public bool GivePermitToLogin(DAL.DAO.AdminLogin aAdminLogin)
        {
            LoginGateway aLoginGateway = new LoginGateway();
            aLoginGateway.ConfirmConnection();

            AdminLogin bAdminLogin = aLoginGateway.CheckLoginInfoTest(aAdminLogin.Username, aAdminLogin.Password);
            if (bAdminLogin.Username == aAdminLogin.Username && bAdminLogin.Password == aAdminLogin.Password)
            {
                return true;
            }
            return false;

            //bool permitMessage = aLoginGateway.CheckLoginInfo(aAdminLogin);
            //return permitMessage;
        }

        public bool GivePermitToVoterToLogin(DAL.DAO.VoterLogin aVoterLogin)
        {
            LoginGateway aLoginGateway = new LoginGateway();
            aLoginGateway.ConfirmConnection();
            VoterLogin bVoterLogin = new VoterLogin();
            bVoterLogin = aLoginGateway.CheckVoterLoginInfo(aVoterLogin.VoterID, aVoterLogin.VoterPassword);

            if (bVoterLogin.VoterID == aVoterLogin.VoterID && bVoterLogin.VoterPassword == aVoterLogin.VoterPassword)
            {
                return true;
            }
            return false;

            //bool permitMessage = aLoginGateway.CheckVoterLoginInfo(aVoterLogin);
            //return permitMessage;
        }

        public bool GivePermitToCandidateToLogin(DAL.DAO.CandidateLogin aCandidateLogin)
        {
            LoginGateway aLoginGateway = new LoginGateway();
            aLoginGateway.ConfirmConnection();
            CandidateLogin bCandidateLogin = new CandidateLogin();
            bCandidateLogin = aLoginGateway.CheckCandidateLoginInfo(aCandidateLogin.CandidateName, aCandidateLogin.CandidatePassword);
            if (bCandidateLogin.CandidateName == aCandidateLogin.CandidateName && bCandidateLogin.CandidatePassword == aCandidateLogin.CandidatePassword)
            {
                return true;
            }
            return false;
            //bool permitMessage = aLoginGateway.CheckCandidateLoginInfo(aCandidateLogin);
            //return permitMessage;
        }
    }
}
