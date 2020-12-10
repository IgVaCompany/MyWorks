namespace Terminal
{
    public class SetRegistry: Command
    {
        public string parametrValue;

        public override string PrepareSendCommand(string data1, string data2, string data3)
        {
            return data1 + " " + data2 + " " + data3;
        }
    }
}