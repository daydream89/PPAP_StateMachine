using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPAP_SEVER
{
    public partial class Form1 : Form
    {
        #region Member Variables

        private CDatabaseTask m_cDatabaseTask = CPPAPManager.DBConnector;
        private CJsonTask m_cJsonTask = CPPAPManager.JsonConnector;

        #endregion
        public Form1()
        {
            InitializeComponent();
            Initialize();
        }

        #region Public Properties


        #endregion


        #region Public Methods


        #endregion


        #region Private Methods

        /// <summary>
        /// 초기값 설정
        /// </summary>
        private void Initialize()
        {
            if (m_cDatabaseTask == null || m_cJsonTask == null)
                return;

            //DB 연결 테스트 데이터 
            initDBConnectInfo();
            DataSet Insert = m_cDatabaseTask.ExcuteMySqlQuery("INSERT INTO test(`temp1`, `temp2`) VALUES('양윤일', '바아아앙부');");
            //grdDB.DataSource = m_cDatabaseTask.ExcuteMySqlQuery("SELECT * FROM ppap.test;").Tables[0];
            //grvDB.UpdateCurrentRow();

            //json 연결 테스트 데이터 
            if (!m_cJsonTask.ReaderJsonFile("project.json"))
                return;

            if (!m_cJsonTask.WriteJsonFile(new TestData()))
                return;

        }

        /// <summary>
        /// DB 연결에 필요한 정보 설정 하는 함수
        /// </summary>
        private void initDBConnectInfo()
        {
            CPPAPManager.DBConnector.Server = "52.79.47.71";
            CPPAPManager.DBConnector.Database = "ppap";
            CPPAPManager.DBConnector.UserID = "ppap";
            CPPAPManager.DBConnector.Password = "sLK#e^";
        }

        #endregion


        #region Event Methods
        #endregion
    }
}
