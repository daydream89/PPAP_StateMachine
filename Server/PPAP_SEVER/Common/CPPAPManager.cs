using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPAP_SEVER
{
    public static class CPPAPManager
    {
        #region Member Variables

        public static CDatabaseTask DBConnector = new CDatabaseTask();
        public static CJsonTask JsonConnector = new CJsonTask();

        #endregion

        #region Public Properties
        public static DialogResult ShowPopup(IWin32Window owner, string sMessage, MessageBoxButtons emButtons, MessageBoxIcon emIcon)
        {
            return MessageBox.Show(sMessage, "PPAP", emButtons, emIcon);
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
