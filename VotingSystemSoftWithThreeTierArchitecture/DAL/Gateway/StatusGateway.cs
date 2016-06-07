using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingSystemSoftWithThreeTierArchitecture.DAL.Gateway
{
    class StatusGateway : BaseGateway
    {
        public StatusGateway()
        {
            aSqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["VSDB"].ConnectionString);
        }


        public bool UpdateStaus(string systemStatus)
        {
            aSqlConnection.Open();
            string query = "UPDATE t_status SET system_status = '" + systemStatus + "' WHERE id = '1'";
            SqlCommand command = new SqlCommand(query, aSqlConnection);
            int affectedRow = command.ExecuteNonQuery();
            aSqlConnection.Close();
            if (affectedRow > 0)
            {
                return true;
            }
            return false;
        }

        public bool UpdatePublishStaus(string publishStatus)
        {
            aSqlConnection.Open();
            string query = "UPDATE t_status SET  publishing_status = '" + publishStatus + "' WHERE id = '1'";
            SqlCommand command = new SqlCommand(query, aSqlConnection);
            int affectedRow = command.ExecuteNonQuery();
            aSqlConnection.Close();
            if (affectedRow > 0)
            {
                return true;
            }
            return false;
        }

        public string IfSystemIsOnorOff()
        {
            aSqlConnection.Open();
            string query = "SELECT system_status FROM t_status ";
            SqlCommand command = new SqlCommand(query, aSqlConnection);
            SqlDataReader aReader = command.ExecuteReader();
            string systemStatus = "";
            while (aReader.Read())
            {
                systemStatus = aReader["system_status"].ToString();
            }
            aSqlConnection.Close();
            return systemStatus;
            //if (systemStatus == "on")
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
        }

        public string IfResultIsPublishedorNot()
        {
            aSqlConnection.Open();
            string query = "SELECT publishing_status FROM t_status ";
            SqlCommand command = new SqlCommand(query, aSqlConnection);
            SqlDataReader aReader = command.ExecuteReader();
            string publishStatus = "";
            while (aReader.Read())
            {
                publishStatus = aReader["publishing_status"].ToString();
            }
            aSqlConnection.Close();
            return publishStatus;
            //if (publishiStatus == "published")
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
        }
    }
}
