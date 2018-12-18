using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Terminal
{
    public class TestsFileWorkerBase
    {        
       public string pathline; // путь к папке

        public virtual string GetWorkingPath()
        {
            return "";
        }
       public virtual void GetAvailableTests(List<TestCase> TestsCases, ComboBox testsComboBox)
        {
            
        }
        public  virtual void DownLoadTestsCommandsFromFile(string path, int numOfTestCase,List<TestCase> TestsCases)
        {

          
        }
    }

}