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
    public class FileWorkerAutoTests : TestsFileWorkerBase
    {
        public override string GetWorkingPath()
        {
            return Application.StartupPath + @"\TestsCases";
        }

        public  void GetAvailableAutoTests(List<TestCase> TestsCases, ListBox testsCasesListBox)
        {
            string[] items = Directory.GetFiles(pathline); // путь к папке

            for (int i = 0; i < items.Length; i++)
            {
                TestsCases.Add(new TestCase());
                var name = items[i].ToString().Substring(items[i].ToString().LastIndexOf(@"\") + 1);
                TestsCases[i].testCaseName = name.Remove(name.Length - 4);
                //  testsComboBox.Items.Add(TestsCases[i].testCaseName);
                testsCasesListBox.Items.Add(TestsCases[i].testCaseName);
                testsCasesListBox.Enabled = false;
                //ShowTestFromTestCases(testCases);
                DownLoadTestsCommandsFromFile(pathline, i, TestsCases);
            }
            if (testsCasesListBox.Items.Count > 0)
                testsCasesListBox.SelectedIndex = 0;
        }

        public override void DownLoadTestsCommandsFromFile(string path, int numOfTestCase, List<TestCase> TestsCases)
        {
            var filePath = path + @"\" + TestsCases[numOfTestCase].testCaseName + ".txt";

            TestsCases[numOfTestCase].commands = new List<string>();
            TestsCases[numOfTestCase].checkAsserts = new List<string>();
            TestsCases[numOfTestCase].Test = new List<Test>();
            var file = File.ReadAllLines(filePath);
            for (int i = 0; i < file.Length; i++)
            {
                Test test = new Test(); 
                var data = file[i];
                if (data.Contains("tst"))
                {
                    i++;
                    test.testName = data;
                    TestsCases[numOfTestCase].Test.Add(test);
                    test.commandsToSerialPort = new List<string>();
                    for (int j = i; j < file.Length; j++)
                    {
                        data = file[j];                       
                        if (data.Contains("sr") || data.Contains("rt") || data.Contains("sa"))
                        {
                            test.commandsToSerialPort.Add(data);
                        }
                        else if (data.Contains("ch"))
                        {
                            test.validationSubSystem = data.Substring(3);
                        }
                        else if (data.Contains("tst"))
                        {
                            i = j;
                            break;
                        }
                        else
                        {
                            break;
                        }
                    }
                }                                      
            }
            TestsCases[numOfTestCase].qtyOfCommands = TestsCases[numOfTestCase].commands.Count;
        }        
    }
}