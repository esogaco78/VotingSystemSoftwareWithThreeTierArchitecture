using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using VotingSystemSoftWithThreeTierArchitecture.DAL.Gateway;
using VotingSystemSoftWithThreeTierArchitecture.UI;

namespace VotingSystemSoftWithThreeTierArchitecture
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            BaseGateway aBaseGateway = new BaseGateway();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MessageBox.Show(aBaseGateway.ConfirmConnection());
            Application.Run(new ChooseLoginUI());   
        }
    }
}
