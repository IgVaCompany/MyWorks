namespace Terminal
{
    public class Command
    {
        public string chipComand;
        public string modelCommand;
        public string readyForSendCommand;



        public virtual string PrepareSendCommand(string data1, string data2, string data3)
        {
            return data1 + " " + data2;
        }


    }
}