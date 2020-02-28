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
            //do it..
            //json 추가 필요 

        }
        /// <summary>
        /// DB 연결에 필요한 정보 설정 하는 함수
        /// </summary>
        private void InitDBconnectInfor()
        {
            CConnectManager.DBConnector.Server = "localhost";
            CConnectManager.DBConnector.Database= "dbtest";
            CConnectManager.DBConnector.UserID ="JK";
            CConnectManager.DBConnector.Password = "ppap";
        }

        #endregion


        #region Event Methods


        #endregion
    }
}
