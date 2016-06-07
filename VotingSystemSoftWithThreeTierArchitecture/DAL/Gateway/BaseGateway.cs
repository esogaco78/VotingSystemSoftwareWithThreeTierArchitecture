using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VotingSystemSoftWithThreeTierArchitecture.DAL.Gateway
{
    class BaseGateway
    {
        public SqlConnection aSqlConnection;
        public string ConfirmConnection()
        {
            aSqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["VSDB"].ConnectionString);
            if (aSqlConnection == null)
            {
                return  "Connection Error";
            }
            return  "Successfull";
        }
    }
}
