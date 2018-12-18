using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Terminal
{
    public class Validater
    {
        private ConnectionWoker DCU;
        private string nameOfMessage = "ModuleSystemStatus1";
        private List<string> valueSignals;

        public void PrepareValidater(TestInterfaceData worker)
        {
            DCU = worker.DcuWorker;
        }

        public void SendComandToFromValidater()
        {
            DCU.SendToSerialPort("do");
        }


        public void CatchDataFromUart(RichTextBox resiverField, ListBox forMess, ListBox VaslidSignal,Label label)
        {
            List<string> data = new List<string>();
            resiverField.Invoke((ThreadStart) delegate()
            {
                data.AddRange(resiverField.Lines);
                if(resiverField.Lines.Length > 5000)
                    resiverField.Clear();
            });

            forMess.Invoke((ThreadStart) delegate { 
            forMess.Items.Clear();
               
            for (int i = data.Count-2; i > 0; i--)
            {
                if (data[i].Contains(nameOfMessage))
                {
                    forMess.Items.Add(data[i].ToString() + "\n\r");
                    for (int j = i+1; j < resiverField.Lines.Length - 1; j++)
                    {
                        if (data[j].Contains("SubSystem") || data[j].Contains("ModuleCommonStatus") ||
                            data[j].Contains("valid"))
                        {
                            forMess.Items.Add(data[j].ToString() + "\n\r");
                            var indexOf = VaslidSignal.SelectedItem.ToString().IndexOf("=");
                            var validateSignal = VaslidSignal.SelectedItem.ToString().Remove(indexOf);
                            var validateValueFromTest = VaslidSignal.SelectedItem.ToString().Substring(indexOf+1);
                            string validateValueFromBoard = "";
                            if (data[j].Contains(validateSignal))
                            {
                                forMess.SelectedIndex = forMess.Items.Count - 1;
                                int indexOfBoard = data[j].ToString().IndexOf("=");
                                validateValueFromBoard = data[j].Substring(indexOfBoard + 1);
                                validate(validateValueFromTest,validateValueFromBoard,label);
                            }
                                
                        }                                                     
                        else
                        {
                            break;
                        }
                    }                   
                    break;
                }
            }
            });
        }

        public void validate(string dataFromTestFile, string dataFromBoard, Label label)
        {
            if (dataFromTestFile == dataFromBoard)
            {
                label.Text = "Test passed";
                label.BackColor = Color.Green;
            }
            else
            {
                label.Text = "Test NOT passed";
                label.BackColor = Color.Red;
            }
                
        }


    }
}