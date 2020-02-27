using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace PPAP_SEVER
{
    public static class CDatabaseConnector
    {
        #region Member Variables

        private static string m_sServer = string.Empty;
        private static string m_sDatabase = string.Empty;
        private static string m_sUser = string.Empty;
        private static string m_sPassword = string.Empty;

        #endregion

        #region Public Properties

        public static void Connect()
        {
            string sConnectInfo = string.Empty;
            MySqlConnection conn = new MySqlConnection(sConnectInfo);
        }
        #endregion

        #region Initialize/Dispose


        #endregion

        #region Public Methods

        #endregion

        #region Private Methods


        #endregion

        #region Event Methods

        #endregion

    }
}
