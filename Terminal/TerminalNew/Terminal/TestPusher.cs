using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace Terminal
{
    public class TestPusher
    {
        private ListBox testCommandsView;
        private List<TestCase> Tests;
        private ComboBox testsComboBox;
        private ProgressBar progressBar1;
        private TextBox timeForWaitBox3;
        private Label testEnd;
        private ConnectionWoker iMworker;

        public void PrepareTestPusher(TestInterfaceData interfaceData)
        {
            testCommandsView = interfaceData.testCommandsView;
            Tests = interfaceData.Tests;
            testsComboBox = interfaceData.testsComboBox;
            progressBar1 = interfaceData.progressBar1;
            timeForWaitBox3 = interfaceData.timeForWaitBox3;
            testEnd = interfaceData.TestEnd;
            iMworker = interfaceData.iMWorker;
        }

        public void LoadAllTest()
        {
            Thread loadTestThread = new Thread(new ThreadStart(LoadTest));
            loadTestThread.Start();
        }

        void LoadTest()
        {
            for (int i = 0; i < testCommandsView.Items.Count; i++)
            {
                SendComand(iMworker);
                testCommandsView.Invoke((ThreadStart) delegate()
                {
                    var stepProcessBar = 100 / Tests[testsComboBox.SelectedIndex].qtyOfCommands;
                    var progBarValue = +Convert.ToInt32(stepProcessBar * (i + 1));
                    if ((100 - progBarValue) < 2)
                        progBarValue = 100;
                    progressBar1.Value = progBarValue;

                    if (progBarValue > 99)
                        testEnd.Visible = true;
                });
                Thread.Sleep(Convert.ToInt32(timeForWaitBox3.Text));
            }

        }
        void ChoseNextCommandInList()
        {
            testCommandsView.Invoke((ThreadStart)delegate ()
            {
                if (testCommandsView.Items.Count > testCommandsView.SelectedIndex + 1)
                    testCommandsView.SelectedIndex++;
            });

        }

       public void SendComand(ConnectionWoker worker)
        {
            testCommandsView.Invoke((ThreadStart)delegate ()
            {
                worker.SendToSerialPort(Tests[testsComboBox.SelectedIndex].commands[testCommandsView.SelectedIndex]);
                ChoseNextCommandInList();
            });

        }
    }
}