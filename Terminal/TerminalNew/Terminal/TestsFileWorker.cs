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
    public class TestsFileWorker
    {        
       public string pathline; // путь к папке

        public string GetWorkingPath()
        {
            return Application.StartupPath + @"\TestsCases";
        }
       public void GetAvailableTests(List<TestCase> TestsCases, ComboBox testsComboBox)
        {
            string[] items = Directory.GetFiles(pathline); // путь к папке

            for (int i = 0; i < items.Length; i++)
            {
                TestsCases.Add(new TestCase());
                var name = items[i].ToString().Substring(items[i].ToString().LastIndexOf(@"\") + 1);
                TestsCases[i].testCaseName = name.Remove(name.Length - 4);
                testsComboBox.Items.Add(TestsCases[i].testCaseName);
                DownLoadTestsCommandsFromFile(pathline, i, TestsCases);
            }
            if (testsComboBox.Items.Count > 0)
                testsComboBox.SelectedIndex = 0;
        }
        public  void DownLoadTestsCommandsFromFile(string path, int numOfTestCase,List<TestCase> TestsCases)
        {

            var filePath = path + @"\" + TestsCases[numOfTestCase].testCaseName + ".txt";

            TestsCases[numOfTestCase].commands = new List<string>();
            TestsCases[numOfTestCase].checkAsserts = new List<string>();
            TestsCases[numOfTestCase].Test = new List<Test>();
            var file = File.ReadAllLines(filePath);
            for (int i = 0; i < file.Length; i++)
            {
                var data = file[i];
                if (data.Contains("rt"))
                {
                    Test test = new Test();
                    test.testName = data.Substring(3);
                    test.validationSubSystem = "1";
                    test.commandToSerialPort = data;
                    TestsCases[numOfTestCase].Test.Add(test);
                    TestsCases[numOfTestCase].qtyCommandsRT++;
                }
                if (data.Contains("sr") || data.Contains("rt") || data.Contains("sa"))
                    TestsCases[numOfTestCase].commands.Add(data);
                else if (data.Contains("ch"))
                    TestsCases[numOfTestCase].checkAsserts.Add(data);
                else
                {
                    
                }
            }
            TestsCases[numOfTestCase].qtyOfCommands = TestsCases[numOfTestCase].commands.Count;
        }

        public void DownLoadTest(List<TestCase> Tests)
        {
           
        }
    }

}