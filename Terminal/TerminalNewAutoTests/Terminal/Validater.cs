using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Spreadsheet;
using Color = System.Drawing.Color;

namespace Terminal
{
    public class Validater
    {
        private ConnectionWoker DCU;
        private xmlWorking mXmlWorking;
        private string nameOfMessage = "ModuleSystemStatus";
        private List<string> valueSignals;

       

        CANStatus CAN_1 = new CANStatus();
        CANStatus CAN_2 = new CANStatus();

        private ListBox mTestCases;
        private ListBox mTests;
        private ListBox mCommands;
        private ListBox mNeedValue;

        public void PrepareValidater(TestInterfaceData worker)
        {
            DCU = worker.DcuWorker;
            mXmlWorking = worker.XmlWorking;
            mTestCases = worker.TestCaseForAutoTests;
            mTests = worker.TestForAutoTests;
            mNeedValue = worker.ValidParam;
            mCommands = worker.CommandForAutoTests;
        }

        public void SendComandToFromValidater()
        {
           // Thread.Sleep(1000);
            DCU.SendToSerialPort("do");
           Thread.Sleep(500);

        }

        public void SendCommandToCheckCAN()
        {
           // Thread.Sleep(1000);
            DCU.SendToSerialPort("ci");
            Thread.Sleep(500);

        }

        public void readFromRichTextBox(RichTextBox list, List<string> daList)
        {
            list.Invoke((ThreadStart)delegate ()
            {
                
                daList.AddRange(list.Lines);               
                if (list.Lines.Length > 5000)
                    list.Clear();
            });
        }

        public void CatchDataFromUartForCANStatu(RichTextBox resiverField)
        {
            List<string> data = new List<string>();
            readFromRichTextBox(resiverField, data);

            string[] canInfo = new string[12];
            for (int i = data.Count - 2; i > 0; i--)
            {
                if (data[i].Contains("CAN2"))
                {
                    canInfo = data[i].Split(new[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                    ParseDataToCanStatusObj(CAN_2,canInfo);
                    
                }

                if (data[i].Contains("CAN1"))
                {
                    canInfo = data[i].Split(new[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                    ParseDataToCanStatusObj(CAN_1,canInfo);
                }

            }

        }

        public void ParseDataToCanStatusObj(CANStatus CAN, string[] data)
        {
            if (data.Length > 10)
            {
                CAN.nameOfCAN = data[0];
                CAN.TX_msg_cnt.Add(data[1]);
                CAN.RX_msg_cnt.Add(data[2]);
                CAN.Error_Count.Add(data[3]);
                CAN.Lost_RX_q.Add(data[4]);
                CAN.Lost_RX_o.Add(data[5]);
                CAN.Lost_TX_q.Add(data[6]);
                CAN.RX_queue.Add(data[7]);
                CAN.TX_queue.Add(data[8]);
                CAN.B_O.Add(data[9]);
                CAN.UsedRX.Add(data[10]);
                CAN.UsedTX.Add(data[11]);
            }
           
        }



        public void CatchDataFromUartForSubSustem(RichTextBox resiverField, ListBox forMess, ListBox VaslidSignal,Label label)
        {
            List<string> data = new List<string>();
            readFromRichTextBox(resiverField,data);
            

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
        private static int numOfRow = 3;
    
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
            WriteDataToLog(numOfRow,label.Text,dataFromTestFile,dataFromBoard);
            numOfRow++;
        }

        
        public void WriteDataToLog(int numOfRow, string resultOfTest, string dataFromFile, string dataFromBoard)
        {
                     
            Row row = new Row() { RowIndex = Convert.ToUInt32(numOfRow) };
            mXmlWorking.sheetData.Append(row);
            mXmlWorking.InsertCell(row, 1, DateTime.Now.TimeOfDay.ToString(), CellValues.String, 5);
            mXmlWorking.InsertCell(row, 2, mTestCases.SelectedItem.ToString() , CellValues.String, 5);
            mXmlWorking.InsertCell(row, 3, mTests.SelectedItem.ToString() , CellValues.String, 5);
            mXmlWorking.InsertCell(row, 3, mCommands.Items[mCommands.SelectedIndex-1].ToString() , CellValues.String, 5);

            if (resultOfTest == "Test passed")
                mXmlWorking.InsertCell(row, 5, resultOfTest, CellValues.String, 5);
            else
                mXmlWorking.InsertCell(row, 5, resultOfTest , CellValues.String, 2);

            mXmlWorking.InsertCell(row, 6, dataFromFile, CellValues.String, 5);
            mXmlWorking.InsertCell(row, 7, dataFromBoard, CellValues.String, 5);

            mXmlWorking.InsertCell(row, 8, CAN_1.nameOfCAN, CellValues.String, 5);
            mXmlWorking.InsertCell(row, 9, CAN_1.TX_msg_cnt.ToArray()[CAN_1.TX_msg_cnt.Count-1], CellValues.String, 5);
            mXmlWorking.InsertCell(row, 10, CAN_1.RX_msg_cnt.ToArray()[CAN_1.RX_msg_cnt.Count-1], CellValues.String, 5);
            mXmlWorking.InsertCell(row, 11, CAN_1.Error_Count.ToArray()[CAN_1.Error_Count.Count-1], CellValues.String, 5);
            mXmlWorking.InsertCell(row, 12, CAN_1.Lost_RX_q.ToArray()[CAN_1.Lost_RX_q.Count-1], CellValues.String, 5);
            mXmlWorking.InsertCell(row, 13, CAN_1.Lost_RX_o.ToArray()[CAN_1.Lost_RX_o.Count-1], CellValues.String, 5);
            mXmlWorking.InsertCell(row, 14, CAN_1.Lost_TX_q.ToArray()[CAN_1.Lost_TX_q.Count-1], CellValues.String, 5);
            mXmlWorking.InsertCell(row, 15, CAN_1.RX_queue.ToArray()[CAN_1.RX_queue.Count-1], CellValues.String, 5);
            mXmlWorking.InsertCell(row, 16, CAN_1.TX_queue.ToArray()[CAN_1.TX_queue.Count-1], CellValues.String, 5);
            mXmlWorking.InsertCell(row, 17, CAN_1.B_O.ToArray()[CAN_1.B_O.Count-1], CellValues.String, 5);
            mXmlWorking.InsertCell(row, 18, CAN_1.UsedRX.ToArray()[CAN_1.UsedRX.Count-1], CellValues.String, 5);
            mXmlWorking.InsertCell(row, 19, CAN_1.UsedTX.ToArray()[CAN_1.UsedTX.Count-1], CellValues.String, 5);

            mXmlWorking.document.Save();           
        }

    }
}