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

namespace Terminal
{
    public partial class TerminalForTesting : Form
    {
        //SerialPort serilaPort1 = new SerialPort();
        ConnectionWoker ImitatorSer = new ConnectionWoker();
        ConnectionWoker DcuSer = new ConnectionWoker();
        DataPort ImitatorPortParam = new DataPort();
        DataPort DcuPortParam = new DataPort();
        TestPusher testPusher = new TestPusher();
        TestInterfaceData testInterfaceData = new TestInterfaceData();

        public List<TestCase> TestsCases;
        //public List<TestCase> TestsCases = new List<TestCase>();
        public TestsFileWorker ParseTest = new TestsFileWorker();



    public TerminalForTesting()
        {
            InitializeComponent();

            TestsCases = new List<TestCase>();

            SendDataToWork(testInterfaceData);
            testPusher.PrepareTestPusher(testInterfaceData);

            ImitatorSer.GetAvaiblePorts(comPortsCombo);
            DcuSer.GetAvaiblePorts(dcuComPortsCombo);

            testsPathLineTextBox.Text = ParseTest.GetWorkingPath();          

            ParseTest.pathline = testsPathLineTextBox.Text;

            ParseTest.GetAvailableTests(TestsCases, testsComboBox);

            ImitatorSer.StartRecive(true,readTextBox);
            DcuSer.StartRecive(true,dcuRichTextBox);
        }

        public void SendDataToWork(TestInterfaceData dataPusher)
        {
            dataPusher.Tests = TestsCases;
            dataPusher.TestEnd = label4;
            dataPusher.iMWorker = ImitatorSer;
            dataPusher.progressBar1 = progressBar1;
            dataPusher.testCommandsView = testsCommandsListBox;
            dataPusher.testsComboBox = testsComboBox;
            dataPusher.timeForWaitBox3 = timeForWaitBox3;
        }

        private void ConnectButtonClick(object sender, EventArgs e)
        {
            ImitatorPortParam.bandRateOfPOrt = textBox1.Text;
            ImitatorPortParam.nameOfPort = comPortsCombo.Text;
            ImitatorSer.ConnectSer(ImitatorPortParam);
            connectBtn.Enabled = false;
            closeBtn.Enabled = true;
            sendButton.Enabled = true;            
        }      

        private void CloseButtonClick(object sender, EventArgs e)
        {
            ImitatorSer.CloseSer(ImitatorPortParam);
            connectBtn.Enabled = true;
            closeBtn.Enabled = false;
            readTextBox.Clear();
            messageTextBox.Clear();
            sendButton.Enabled = false;
        }

        private void SendButtonClick(object sender, EventArgs e)
        {
            ImitatorSer.SendToSerialPort(messageTextBox.Text);
            messageTextBox.Clear();
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {          
            testsCommandsListBox.Items.Clear();
            if(TestsCases[testsComboBox.SelectedIndex].commands.ToArray()!=null)
                testsCommandsListBox.Items.AddRange(TestsCases[testsComboBox.SelectedIndex].commands.ToArray());
            testsCommandsListBox.SelectedIndex = 0;
            validateSignalsListBox.Items.Clear();
            if (TestsCases[testsComboBox.SelectedIndex].checkAsserts.Count!=0)
            {
                validateSignalsListBox.Items.AddRange(TestsCases[testsComboBox.SelectedIndex].checkAsserts.ToArray());
                validateSignalsListBox.SelectedIndex = 0;
            }
            label4.Visible = false;
            progressBar1.Value = 0;
        }

        private void LoadAllTestClick(object sender, EventArgs e)
        {
            testPusher.LoadAllTest();       
        }        

        private void SendOneCommandClick(object sender, EventArgs e)
        {         
            testPusher.SendComand(ImitatorSer);              
        }

        private void SaClick(object sender, EventArgs e)
        {
            ImitatorSer.SendToSerialPort("sa");
        }

        private void ViSendClick(object sender, EventArgs e)
        {
            ImitatorSer.SendToSerialPort("vi");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            readTextBox.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ImitatorSer.SendToSerialPort("reboot");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void DcuConnectClick(object sender, EventArgs e)
        {
            DcuPortParam.bandRateOfPOrt = textBox2.Text;
            DcuPortParam.nameOfPort = dcuComPortsCombo.Text;
            DcuSer.ConnectSer(DcuPortParam);
            closeDcuButton.Enabled = true;
            dcuSendButton.Enabled = true;
            connectDcuButton.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DcuSer.CloseSer(DcuPortParam);
            connectDcuButton.Enabled = true;
            closeDcuButton.Enabled = false;
            dcuRichTextBox.Clear();
            DcuTextBox.Clear();
            dcuSendButton.Enabled = false;
        }

        private void dcuSendButton_Click(object sender, EventArgs e)
        {
            DcuSer.SendToSerialPort(DcuTextBox.Text);
            DcuTextBox.Clear();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            DcuSer.SendToSerialPort("vi");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            DcuSer.SendToSerialPort("sa");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            DcuSer.SendToSerialPort("reboot");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AutoTest newForm = new AutoTest(this);
            if (newForm.ShowDialog(this) != DialogResult.OK)
                return;
            //newForm.Show();
        }
    }
}

