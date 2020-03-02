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
    public partial class FrmMain : DevExpress.XtraEditors.XtraForm
    {
        #region Member Variables

        #endregion
        public FrmMain()
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
            if (CConnectManager.DBConnector == null || CConnectManager.JsonConnector == null)
                return;

            InitDBconnectInfor();


            DataSet Insert = CConnectManager.DBConnector.ExcuteMySqlQuery("INSERT INTO test(`temp1`, `temp2`) VALUES('양윤일', '바아아앙부');");
            grdDB.DataSource = CConnectManager.DBConnector.ExcuteMySqlQuery("SELECT * FROM ppap.test;").Tables[0];
            grvDB.UpdateCurrentRow();
            
            //do it..
            //json 추가 필요 

        }
        /// <summary>
        /// DB 연결에 필요한 정보 설정 하는 함수
        /// </summary>
        private void InitDBconnectInfor()
        {
            CConnectManager.DBConnector.Server = "52.79.47.71";
            CConnectManager.DBConnector.Database= "ppap";
            CConnectManager.DBConnector.UserID ="ppap";
            CConnectManager.DBConnector.Password = "sLK#e^";
        }

        #endregion


        #region Event Methods


        #endregion
    }
}
