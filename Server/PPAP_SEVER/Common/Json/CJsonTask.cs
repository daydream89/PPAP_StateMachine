using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace PPAP_SEVER
{
    public class TestData
    {
        public string key { get; set; }
        public string id{ get; set; }
        public string pw { get; set; }
        public string info { get; set; }
    }

    public class CJsonTask : IDisposable
    {
        #region Member Variables

        private string m_sJsonPath = @"..\..\..\..\Client\StateMachineClient\";

        #endregion

        #region Public Properties


        #endregion

        #region Initialize/Dispose

        public CJsonTask()
        {
           
        }

        public void Dispose()
        {
            //connect release..
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Json 파일 읽기
        /// </summary>
        public bool ReaderJsonFile(string sJsonFile)
        {
            bool bOk = false; 
            try
            {
                m_sJsonPath += sJsonFile;
                using (StreamReader reader = new StreamReader(m_sJsonPath))
                {
                    string json = reader.ReadToEnd();
                    object item = JsonConvert.DeserializeObject<object>(json);
                }
                bOk = true;
            }
            catch (Exception ex)
            {
                ex.Data.Clear();
                return false;
            }

            return bOk;
        }

        /// <summary>
        /// Json 파일 저장
        /// </summary>
        public bool WriteJsonFile(TestData sJsonFile)
        {
            //경로 지정해서 저장 하는거 필요 
            bool bOk = false;
            try
            {
                string jsonString = JsonConvert.SerializeObject(sJsonFile);
                File.WriteAllText(@"TestData001.json", jsonString);
                System.Diagnostics.Debug.WriteLine(jsonString);
                bOk = true;
            }
            catch (Exception ex)
            {
                ex.Data.Clear();
                return false;
            }
            return bOk;
        }


        public void DoTest()
        {
            ////클라 담당자가 만들어둔 json 정보 가져오기
            //ProjectJson testJson = new ProjectJson
            //{
            //    engine = "cocos-creator-js",
            //    packages = "packages",
            //    version = "2.3.0",
            //    id = "e691cce8-a306-459a-91ed-ec29e576861e"
            //};

            //string jsonString = JsonConvert.SerializeObject(testJson);
            //File.WriteAllText(@"TestData001.json", jsonString);
            //System.Diagnostics.Debug.WriteLine(jsonString);

          
            //string sPath = @"D:\99.etc\C#\PPAP\PPAP_StateMachine\Client\StateMachineClient\project.json";
            //// string json = File.ReadAllText(sPath);
            //using (StreamReader reader = new StreamReader(sPath))
            //{
            //    string json = reader.ReadToEnd();
            //    ProjectJson item = JsonConvert.DeserializeObject<ProjectJson>(json);
            //}
        }

        #endregion

        #region Private Methods


        #endregion

        #region Event Methods


        #endregion
    }
}
