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

        SerialPort serilaPort1 = new SerialPort();
        static TestCase[] Tests;
    
        public TerminalForTesting()
        {
           
            InitializeComponent();        
            GetAvaiblePorts();
            GetAvailableTests();           
            serilaPort1.DataReceived += ReadData;
            // KeyDown += new KeyEventHandler();

        }

        void GetAvailableTests()
        {
            string[] items = Directory.GetFiles(testsPathLineTextBox.Text); // путь к папке
            Tests = new TestCase[items.Length];

            for (int i = 0; i < items.Length; i++)
            {
                Tests[i] = new TestCase();
                var name = items[i].ToString().Substring(items[i].ToString().LastIndexOf(@"\") + 1);
                Tests[i].testName = name.Remove(name.Length-4);
                testsComboBox.Items.Add(Tests[i].testName);  
                DownLoadTestsFromFile(testsPathLineTextBox.Text,i);
            }          
            if (testsComboBox.Items.Count > 0)
                testsComboBox.SelectedIndex = 0;
        }

        void DownLoadTestsFromFile(string path, int numOfTest)
        {
            
            var filePath = path + @"\" + Tests[numOfTest].testName + ".txt";           
            //Tests[numOfTest].Commands = new List<Command>();

            Tests[numOfTest].commands = new List<string>();       
            var file = File.ReadAllLines(filePath);
            for (int i = 0; i < file.Length; i++)
            {
                var data = file[i];
                if (data.Contains("sr") || data.Contains("rt") || data.Contains("sa"))
                    Tests[numOfTest].commands.Add(data);
            }
            Tests[numOfTest].qtyOfCommands = Tests[numOfTest].commands.Count;
        }

        void GetAvaiblePorts()
        {
            String[] ports = SerialPort.GetPortNames();
            comPortsCombo.Items.AddRange(ports);
            if (comPortsCombo.Items.Count > 0)
                comPortsCombo.SelectedIndex = 0;
        }       

        private void ConnectButtonClick(object sender, EventArgs e)
        {
            if (!serilaPort1.IsOpen)
            {
                serilaPort1.PortName = comPortsCombo.Text;
                serilaPort1.BaudRate = Convert.ToInt32(textBox1.Text);
                serilaPort1.Open();
    //            serilaPort1.RtsEnable = true;
                connectBtn.Enabled = false;
                closeBtn.Enabled = true;
                sendButton.Enabled = true;
            } 
        }

        void ReadData(object sender, SerialDataReceivedEventArgs e)
        {
            if (serilaPort1.IsOpen)
            {
                readTextBox.Invoke((ThreadStart) delegate()
                {
                    readTextBox.Text += serilaPort1.ReadExisting();
                    readTextBox.SelectionStart = readTextBox.Text.Length;
                    readTextBox.ScrollToCaret();
                    
                });
            }                       
        }

        private void CloseButtonClick(object sender, EventArgs e)
        {
            serilaPort1.Close();
            connectBtn.Enabled = true;
            closeBtn.Enabled = false;
            readTextBox.Clear();
            messageTextBox.Clear();
            sendButton.Enabled = false;
        }

        private void SendButtonClick(object sender, EventArgs e)
        {
            SendToSerialPort(messageTextBox.Text);
            messageTextBox.Clear();
        }

        void SendToSerialPort(string dataToSend)
        {
            if (serilaPort1.IsOpen)
            {
             var message = dataToSend + "\r\n";
             serilaPort1.Write(message);
            }
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {          
            testsCommandsListBox.Items.Clear();
            testsCommandsListBox.Items.AddRange(Tests[testsComboBox.SelectedIndex].commands.ToArray());
            testsCommandsListBox.SelectedIndex = 0;
            label4.Visible = false;
            progressBar1.Value = 0;
        }

        private void LoadAllTestClick(object sender, EventArgs e)
        {
            Thread loadTestThread = new Thread(new ThreadStart(LoadTest));
            loadTestThread.Start();          
        }

        void LoadTest()
        {           
            if (serilaPort1.IsOpen)
            {
             
                for (int i = 0; i < testsCommandsListBox.Items.Count; i++)
                {
                    SendComand();
                    testsComboBox.Invoke((ThreadStart) delegate()
                    {
                        var stepProcessBar = 100 / Tests[testsComboBox.SelectedIndex].qtyOfCommands;
                        var progBarValue=+Convert.ToInt32(stepProcessBar * (i + 1));
                        if ((100 - progBarValue) < 2)
                            progBarValue = 100;
                        progressBar1.Value = progBarValue;

                        if (progBarValue>99)
                            label4.Visible = true;
                    });                   
                    Thread.Sleep(Convert.ToInt32(timeForWaitBox3.Text));
                }
            }
            
        }
        void ChoseNextCommandInList()
        {
            testsCommandsListBox.Invoke((ThreadStart) delegate()
            {
                if (testsCommandsListBox.Items.Count > testsCommandsListBox.SelectedIndex + 1)
                    testsCommandsListBox.SelectedIndex++;
            });

        }

        void SendComand()
        {
            testsCommandsListBox.Invoke((ThreadStart)delegate ()
            {
                SendToSerialPort(Tests[testsComboBox.SelectedIndex].commands[testsCommandsListBox.SelectedIndex]);
                ChoseNextCommandInList();
            });
            
        }

        private void SendOneCommandClick(object sender, EventArgs e)
        {
            if (serilaPort1.IsOpen)
            {
                SendComand();
            }
                
        }

        private void SaClick(object sender, EventArgs e)
        {
            if (serilaPort1.IsOpen)
                SendToSerialPort("sa");

        }

        private void ViSendClick(object sender, EventArgs e)
        {
            if (serilaPort1.IsOpen)
                SendToSerialPort("vi");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            readTextBox.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (serilaPort1.IsOpen)
                SendToSerialPort("reboot");
        }
    }
}

