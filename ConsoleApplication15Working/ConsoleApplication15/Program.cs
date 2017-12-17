using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography.X509Certificates;


namespace ConsoleApplication15
{
    

    public class CommandsWork
    {

        string [] Commands = new string[8] { "Close","ShowC" ,"DLFF", "PrintDLFF" ,"CalcAtom", "CalcMolec","td","calc" };
        private bool atomFlag = false;
        private bool molecFlag = false;

        Particle SomeBody = new Particle();
        

        public void Manager()
        {
            
            string Command = "Commad is wrong write again";          
            string InPutCommand =  Console.ReadLine();
            
         

            for (int i = 0; i < Commands.Length; i++)
            {
                if (InPutCommand == Commands[i])
                {
                    Command = InPutCommand;
                }               
            }            
            switch (Command)
            {
                case "Close":
                   Environment.Exit(0);
                    break;
                case "DLFF":
                    SomeBody.DownLoadDataFromFile();
                    SomeBody.ShowDownLoadData();
                    break;
                case "PrintDLFF":
                    SomeBody.ShowDownLoadData();
                    break;
                case "Commad is wrong write again":
                    Console.WriteLine(InPutCommand +" "+ Command);
                    break;
                case "ShowC":
                    foreach (string com in Commands)
                    {
                        Console.WriteLine(com);
                    }
                    break;
                case "CalcAtom":
                    atomFlag = true;
                    molecFlag = false;
                    Atom He = new Atom();                
                   
                    break;
                case "CalcMolec":
                    atomFlag = false;
                    molecFlag = true;
                    Molecule C = new Molecule();
                    C.DL();
                   
                    break;
                case "td":
                {
                    SomeBody.DL();
                }
                    break;

            }
        }
    }

    public class Particle
    {
        public double Totalenergy;

        public string[] DataParamsNames = new string[4] { "Massa", "PotEnergy", "KinEnergy", "Stepeny" };
        public static  double[] DataProgram = new double[4];

        public string[] DataFile;
        private string NameFile;
     //   public string[] nameParams;
        public List<string> nameParams = new List<string>();

        public static bool DLFF = false;

        public void DownLoadDataFromFile()
        {
            Console.WriteLine("Input the file name" + "\n");
            string NameFile = Console.ReadLine();
            string[] DataFile = File.ReadAllLines(NameFile);

            DLFF = true;
            for (int i = 0; i < (DataFile.Length - 1); i++)
            {
                for (int j = 0; j < DataParamsNames.Length; j++)
                {
                    if (DataFile[i] == DataParamsNames[j])
                        DataProgram[j] = Convert.ToDouble(DataFile[i + 1]);
                }
            }
            Console.WriteLine("DownLload is OK");
        }


        public void ShowDownLoadData()
        {
            for (int i = 0; i < DataProgram.Length; i++)
            {
                Console.WriteLine(DataParamsNames[i]+" "+DataProgram[i]);
            }
        }

        public virtual void DL()
        {
            Console.WriteLine("Input the file name" + "\n");                   
            NameFile = Console.ReadLine();
            DataFile = File.ReadAllLines(NameFile);
        }

        public virtual void CalcEnergy()
        {

        }
        public virtual void calc()
        {

        }

        public void PrintRelut(string result)
        {
            Console.WriteLine(result);
        }
    }

    public class Atom : Particle
    {
        public override void CalcEnergy()
        {
            base.CalcEnergy();
           // Totalenergy = KineticEnergy + PotetionalEnergy;
            Totalenergy = DataProgram[0] + DataProgram[1] + DataProgram[2] + DataProgram[3];
        }
    }

    public class Molecule : Particle
    {

        public override void DL()
        {           
            base.DL();
            string nowStr = DataFile[0];
            string[] split = nowStr.Split(new Char[] { ' ', ',', '.', ':' });
            int i = 0;
            foreach (string s in split)
            {             
                nameParams.Add(s);              
            }
            foreach (string s in nameParams)
            {
                Console.WriteLine(s);
            }
            string[] nameParamsAr = nameParams.ToArray();
            Console.WriteLine("DownLload is OK");

            Console.WriteLine(nameParamsAr.Length);
           
        }

        public override void CalcEnergy()
        {
            base.CalcEnergy();
            Totalenergy = DataProgram[0] + DataProgram[1] + DataProgram[2] + DataProgram[3];
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
                     
            string command;
            CommandsWork Application = new CommandsWork();
            do
            {
                Console.WriteLine("Input the command" + "\n Write the command ShowC for see all available comands");
                Application.Manager();             
                command = Console.ReadLine();
            } while (command != null && !command.Equals("Close"));

        }
    }
}
