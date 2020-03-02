using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace PPAP_SEVER
{
    public class CDatabaseTask : IDisposable
    {
        #region Member Variables

        private string m_sServer = string.Empty;
        private string m_sDatabase = string.Empty;
        private string m_sUId = string.Empty;
        private string m_sPassword = string.Empty;
        private MySqlConnection m_cMySql = null;

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

        public CDatabaseTask()
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
        public bool OpenConnect()
        {
            bool bOk = false;
            try
            {

                string sConnectInfo = $"Server={m_sServer};Database={m_sDatabase};Uid={m_sUId};Pwd={m_sPassword};";
                m_cMySql = new MySqlConnection(sConnectInfo);
                m_cMySql.Open();
                bOk = true;
            }
            catch (Exception ex)
            {
                ex.Data.Clear();
                bOk = false;
            }

            return bOk;
        }

        /// <summary>
        /// DB 연결 해제
        /// </summary>
        public bool ReleaseConnect()
        {
            bool bOk = false;
            try
            {
                m_cMySql.Close();
                bOk = true;
            }
            catch (Exception ex)
            {
                ex.Data.Clear();
                bOk = false;
            }

            return bOk;
        }

        public DataSet ExcuteMySqlQuery(string sCommand)
        {
            DataSet dt = new DataSet();
            string sUserQuery = sCommand;
            if (OpenConnect())
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = new MySqlCommand(sUserQuery, m_cMySql);
                adapter.Fill(dt);


                ReleaseConnect();

            }
            return dt;
        }

        #endregion

        #region Private Methods


        #endregion

        #region Event Methods


        #endregion
    }
}
