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
            mainForm.ParseAutoTests.pathline = pathLineAutoTextBox.Text;

           // TerminalForTesting mainForm = (TerminalForTesting)this.Owner;
            var testsCases = mainForm.TestsCasesAuto;
            mainForm.ParseAutoTests.GetAvailableAutoTests(testsCases,listBox1TestCases);          
                     
            SendDataToInterface();
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
            mMainForm.XmlWorking.CreateFile("TestReport","TestReport");

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            mMainForm.testPusher.StartSend = false;
            button1StartButton.Enabled = true;
            button1StopButton.Enabled = false;
            mMainForm.testPusher.StopAutoTest();
            loadAutoTestThreadValidate.Abort();
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
            SendRequest();
        }


        private Thread loadAutoTestThreadValidate;

        public void AutoTestStartValidate()
        {
            loadAutoTestThreadValidate = new Thread(new ThreadStart(CheckFromBoard));
            loadAutoTestThreadValidate.Start();
        }

        private void CheckFromBoard()
        {
            while (mMainForm.testPusher.StartSend)
            {
                int index = 0;
                listBox1Command.Invoke((ThreadStart) delegate
                {
                    index = listBox1Command.SelectedIndex - 1;
                });
                
                if (index >0 && listBox1Command.Items[index].ToString().Contains("rt"))
                {
                    SendRequest();
                    Thread.Sleep(1000);
                }
                
            }
                      
        }

        private void SendRequest()
        {
            mMainForm.SubSystemCheker.SendComandToFromValidater();
            mMainForm.SubSystemCheker.CatchDataFromUart(mMainForm.dcuRichTextBox, listBox1, listBox2ValidParam, label1);
        }

    }
}
