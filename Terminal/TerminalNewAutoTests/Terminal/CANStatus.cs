using System.Collections.Generic;

namespace Terminal
{
    public class CANStatus
    {
        public string nameOfCAN;
        public List<string> TX_msg_cnt = new List<string>();
        public List<string> RX_msg_cnt = new List<string>();
        public List<string> Error_Count = new List<string>();
        public List<string> Lost_RX_q = new List<string>();
        public List<string> Lost_RX_o = new List<string>();
        public List<string> Lost_TX_q = new List<string>();
        public List<string> RX_queue = new List<string>();
        public List<string> TX_queue = new List<string>();
        public List<string> B_O = new List<string>();
        public List<string> UsedRX = new List<string>();
        public List<string> UsedTX = new List<string>();
    }
}