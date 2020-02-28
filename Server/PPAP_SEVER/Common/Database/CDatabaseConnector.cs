using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace PPAP_SEVER
{
    public class CDatabaseConnector : IDisposable
    {
        #region Member Variables

        private string m_sServer = string.Empty;
        private string m_sDatabase = string.Empty;
        private string m_sUId = string.Empty;
        private string m_sPassword = string.Empty;

        #endregion

        #region Public Properties

        public string Server
        {
            get { return m_sServer; }
            set { m_sServer = value; }
        }

        public string Database
        {
            get { return m_sDatabase; }
            set { m_sDatabase = value; }
        }

        public string UserID
        {
            get { return m_sUId; }
            set { m_sUId = value; }
        }

        public string Password
        {
            get { return m_sPassword; }
            set { m_sPassword = value; }
        }


        #endregion

        #region Initialize/Dispose

        public CDatabaseConnector()
        {

        }

        public void Dispose()
        {
            //connect release..
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// DB 연결
        /// </summary>
        public bool DBConnect()
        {
            bool bOk = false;
            string sConnectInfo = $"Server={m_sServer};Database={m_sDatabase};Uid={m_sUId};Pwd={m_sPassword};";
            MySqlConnection mssqlConnect = new MySqlConnection(sConnectInfo);

            if (mssqlConnect != null)
                bOk = true;

            return bOk;
        }

        #endregion

        #region Private Methods


        #endregion

        #region Event Methods


        #endregion
    }
}
