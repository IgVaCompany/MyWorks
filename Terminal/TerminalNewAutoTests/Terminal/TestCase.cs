using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Terminal
{
    public class TestCase
    {
        public string testCaseName;
        //public string command;
        public int qtyOfCommands;

        public List<string> commands;
        public int qtyCommandsRT;
       // public List<Command> Commands;

        public List<string> checkAsserts;

        public List<Test> Test; 

    }
}