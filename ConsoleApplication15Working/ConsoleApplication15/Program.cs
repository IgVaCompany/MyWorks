using System;
using System.Dynamic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using System.Security.Claims;
using System.Security.Cryptography.X509Certificates;


namespace ConsoleApplication15
{
    class Program
    {
        static void Main(string[] args)
        {
            int with = 150;
            int hegith = 40;
            Console.SetWindowSize(with, hegith);     
            string command;
            CommandsWork Application = new CommandsWork();
            do
            {
                Console.WriteLine("Input the command" + "\n Write the command 'help' for see all available commands");
                Application.Manager();             
                command = Console.ReadLine();
            } while (command != null && !command.Equals("Close"));

        }
    }
}
