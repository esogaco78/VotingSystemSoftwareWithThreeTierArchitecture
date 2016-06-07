using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotingSystemSoftWithThreeTierArchitecture.DAL.Gateway;

namespace VotingSystemSoftWithThreeTierArchitecture.BLL
{
    class StatusManager
    {
        StatusGateway aStatusGateway = new StatusGateway();
        public bool SaveSystemStatus(string systemStatus)
        {
            bool updateStatus = aStatusGateway.UpdateStaus(systemStatus);
            if (updateStatus)
            {
                return true;
            }
            return false;
        }

        public bool SavePublishingStatus(string publishStatus)
        {
            bool updatePublishStatus = aStatusGateway.UpdatePublishStaus(publishStatus);
            if (updatePublishStatus)
            {
                return true;
            }
            return false;
        }
        //----------------------------------------------//
        public bool CheckSystemStatus()
        {
            if (aStatusGateway.IfSystemIsOnorOff() == "on")
            {
                return true;
            }
                return false;
        }

        public bool CheckPublishStatus()
        {
            if (aStatusGateway.IfResultIsPublishedorNot()=="published")
            {
                return true;
            }
            return false;
        }
    }
}
