using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAP_SEVER
{
    public class CJsonTask : IDisposable
    {

        #region Member Variables
        private string m_sPort = string.Empty;

        #endregion

        #region Public Properties


        #endregion

        #region Initialize/Dispose

        public CJsonTask()
        {
            InitInstance();
        }

        public void Dispose()
        {
            //connect release..
        }

        #endregion

        #region Public Methods


        #endregion

        #region Private Methods

        private void InitInstance()
        {

        }

        #endregion

        #region Event Methods


        #endregion
    }
}
