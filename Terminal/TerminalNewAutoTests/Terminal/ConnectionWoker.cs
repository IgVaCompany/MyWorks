using System;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;

namespace Terminal
{
    public class ConnectionWoker
    {
        
        public SerialPort serilaPort1 = new SerialPort();      
        private RichTextBox placeToDataFromUart;

        public void GetAvaiblePorts(ComboBox comPortsCombo)
        {
            String[] ports = SerialPort.GetPortNames();
            comPortsCombo.Items.AddRange(ports);
            if (comPortsCombo.Items.Count > 0)
                comPortsCombo.SelectedIndex = 0;
        }

        public void SendToSerialPort(string dataToSend)
        {
                var message = dataToSend + "\r\n";
                serilaPort1.Write(message);
        }

        public void ConnectSer(DataPort portParam)
        {
            serilaPort1.PortName = portParam.nameOfPort;
            serilaPort1.BaudRate = Convert.ToInt32(portParam.bandRateOfPOrt);
            serilaPort1.Open();
        }

        public void CloseSer(DataPort portParam)
        {
            serilaPort1.Close();
        }

        public string ReadFromSerial()
        {
            return serilaPort1.ReadExisting();
        }

        public void StartRecive(bool flagToStart,RichTextBox data)
        {
            if (flagToStart)
            {
                Thread startReciceDatotFromSerial = new Thread(new ThreadStart(Subscribe));
                startReciceDatotFromSerial.Start();
                placeToDataFromUart = data;
            }
            
        }

        public void Subscribe()
        {
            serilaPort1.DataReceived += ReadData;
        }

        public void ReadData(object sender, SerialDataReceivedEventArgs e)
        {
            placeToDataFromUart.Invoke((ThreadStart) delegate()
            {
                placeToDataFromUart.Text += serilaPort1.ReadExisting().ToString();
                placeToDataFromUart.SelectionStart = placeToDataFromUart.Text.Length;
                placeToDataFromUart.ScrollToCaret();
            });

        }

    }
}