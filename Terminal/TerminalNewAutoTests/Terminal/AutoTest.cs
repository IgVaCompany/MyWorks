using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Spreadsheet;


namespace Terminal
{
    public partial class AutoTest : Form
    {
        private TerminalForTesting mMainForm;



        public AutoTest(TerminalForTesting mainForm)
        {
            InitializeComponent();
            mMainForm = mainForm;

            pathLineAutoTextBox.Text = mainForm.ParseAutoTests.GetWorkingPath();
            SendDataToInterface();
            mainForm.ParseAutoTests.pathline = pathLineAutoTextBox.Text;
            mainForm.SubSystemCheker.PrepareValidater(mainForm.testInterfaceData);

           // TerminalForTesting mainForm = (TerminalForTesting)this.Owner;
            var testsCases = mainForm.TestsCasesAuto;
            mainForm.ParseAutoTests.GetAvailableAutoTests(testsCases,listBox1TestCases);          
                     
            
        }

        public void SendDataToInterface()
        {
            mMainForm.testInterfaceData.TestCaseForAutoTests = listBox1TestCases;
            mMainForm.testInterfaceData.TestForAutoTests = listBox1Tests;
            mMainForm.testInterfaceData.CommandForAutoTests = listBox1Command;
            mMainForm.testInterfaceData.ValidParam = listBox2ValidParam;


            listBox1Command.Enabled = false;
            listBox1TestCases.Enabled = false;
            listBox1Tests.Enabled = false;
            listBox2ValidParam.Enabled = false;

        }

        private void AutoTest_Load(object sender, EventArgs e)
        {

        }

        private void listBox1TestCases_SelectedIndexChanged(object sender, EventArgs e)
        {
            RebildAllListBoxes();
        }

        public void RebildAllListBoxes()
        {
            listBox1Tests.Items.Clear();
            for (int i = 0; i < mMainForm.TestsCasesAuto[listBox1TestCases.SelectedIndex].Test.Count; i++)
            {
                listBox1Tests.Items.Add(mMainForm.TestsCasesAuto[listBox1TestCases.SelectedIndex].Test[i].testName);
            }
            listBox1Tests.SelectedIndex = 0;
            RebildComAndChe();
        }

        public void RebildComAndChe()
        {
            listBox1Command.Items.Clear();
            listBox2ValidParam.Items.Clear();
            listBox1Command.Items.AddRange(mMainForm.TestsCasesAuto[listBox1TestCases.SelectedIndex]
                .Test[listBox1Tests.SelectedIndex].commandsToSerialPort.ToArray());
            listBox2ValidParam.Items.Add(mMainForm.TestsCasesAuto[listBox1TestCases.SelectedIndex].Test[listBox1Tests.SelectedIndex].validationSubSystem);
            listBox1Command.SelectedIndex= 0;
            listBox2ValidParam.SelectedIndex =0;
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            mMainForm.testPusher.StartSend = true;
            button1StartButton.Enabled = false;
            button1StopButton.Enabled = true;
            SendDataToInterface();
            mMainForm.testPusher.PrepareTestPusher(mMainForm.testInterfaceData);
            mMainForm.testPusher.AutoTestStart();
            AutoTestStartValidate();
            //mMainForm.XmlWorking = new xmlWorking();
            mMainForm.XmlWorking.CreateFile("TestReport","TestReport");
            mMainForm.XmlWorking.document.Save();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            mMainForm.testPusher.StartSend = false;
            button1StartButton.Enabled = true;
            button1StopButton.Enabled = false;
            mMainForm.testPusher.StopAutoTest();
            loadAutoTestThreadValidate.Abort();
            mMainForm.XmlWorking.document.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            listBox1Command.Enabled = true;
            listBox1TestCases.Enabled = true;
            listBox1Tests.Enabled = true;
            listBox2ValidParam.Enabled = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            listBox1Command.Enabled = false;
            listBox1TestCases.Enabled = false;
            listBox1Tests.Enabled = false;
            listBox2ValidParam.Enabled = false;
        }

        private void listBox1Tests_SelectedIndexChanged(object sender, EventArgs e)
        {
            RebildComAndChe();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            SendRequest("sub");
        }


        private Thread loadAutoTestThreadValidate;

        public void AutoTestStartValidate()
        {
            loadAutoTestThreadValidate = new Thread(new ThreadStart(CheckFromBoard));
            loadAutoTestThreadValidate.Start();
        }

        private void CheckFromBoard()
        {
            string currentCommand = "";
            string beforeCommand = "";

            while (mMainForm.testPusher.StartSend)
            {
               
                int index = 0;
                listBox1Command.Invoke((ThreadStart) delegate
                {
                    currentCommand = listBox1Command.SelectedItem.ToString();
                    index = listBox1Command.SelectedIndex - 1;
                });

                //if (index > 0 && listBox1Command.Items[index].ToString().Contains("rt"))
                if (currentCommand.Contains("sa") && beforeCommand.Contains("rt"))
                {
                    SendRequest("ci");
                    Thread.Sleep(500);
                    SendRequest("sub");
                    //Thread.Sleep(1000);
                }
                beforeCommand = currentCommand;
            }
                      
        }

        private void SendRequest(string command)
        {
            if (command == "sub")
            {
                mMainForm.SubSystemCheker.SendComandToFromValidater();
                mMainForm.SubSystemCheker.CatchDataFromUartForSubSustem(mMainForm.dcuRichTextBox, listBox1, listBox2ValidParam, label1);
            } else if (command == "ci")
            {
                mMainForm.SubSystemCheker.SendCommandToCheckCAN();
                mMainForm.SubSystemCheker.CatchDataFromUartForCANStatu(mMainForm.dcuRichTextBox);
            }
            else
            {
                return;
            }
           
        }

        
    }
}
