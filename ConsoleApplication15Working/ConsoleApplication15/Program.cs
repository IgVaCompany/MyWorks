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
      // public string[] nameParams;
      //  public List<string> nameParams = new List<string>();

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
        List<double> te = new List<double>();
        List<double> gi = new List<double>();
        List<double> omegaE = new List<double>();
        List<double> omegaExE = new List<double>();
        List<double> bE = new List<double>();
        List<double> alfaE = new List<double>();
        List<double> dE = new List<double>();
        List<double> bettaE = new List<double>();


        public override void DL()
        {           
            base.DL();
            String valueName = DataFile[0];
            String[] valueNames = valueName.Split('\t');                
            Console.WriteLine(valueNames.Length);
            for (int i = 1; i < DataFile.Length; i++)
            {
                String value = DataFile[i];
                String[] vaslues = value.Split('\t');                
                for (int j = 0; j < vaslues.Length; j++)
                {
                    switch (valueNames[j])
                    {
                        case "te":
                            te.Add(Convert.ToDouble(vaslues[j]));
                            break;
                        case "gi":
                            gi.Add(Convert.ToDouble(vaslues[j]));
                            break;
                        case "omegaE":
                            omegaE.Add(Convert.ToDouble(vaslues[j]));
                            break;
                        case "omegaExE":
                            omegaExE.Add(Convert.ToDouble(vaslues[j]));
                            break;
                        case "bE":
                            bE.Add(Convert.ToDouble(vaslues[j]));
                            break;
                        case "alfaE":
                            alfaE.Add((Convert.ToDouble(vaslues[j]))*(10^2));
                            break;
                        case "dE":
                            dE.Add((Convert.ToDouble(vaslues[j]))*(10^6));
                            break;
                        case "bettaE":
                            bettaE.Add((Convert.ToDouble(vaslues[j]))*(10^6));
                            break;
                    }
                }              
            }
            
            Console.WriteLine(valueNames.ToString());

            for (int i = 0; i < DataFile.Length-1; i++)
            {
                switch (valueNames[i])
                {
                    case "te":
                        Console.WriteLine(te.ToArray()[i]);
                        break;
                    //case "gi":
                    //    gi.Add(Convert.ToDouble(valueNames[i]));
                    //    break;
                    //case "omegaE":
                    //    omegaE.Add(Convert.ToDouble(valueNames[i]));
                    //    break;
                    //case "omegaExE":
                    //    omegaExE.Add(Convert.ToDouble(valueNames[i]));
                    //    break;
                    //case "bE":
                    //    bE.Add(Convert.ToDouble(valueNames[i]));
                    //    break;
                    //case "alfaE":
                    //    alfaE.Add(Convert.ToDouble(valueNames[i]));
                    //    break;
                    //case "dE":
                    //    dE.Add(Convert.ToDouble(valueNames[i]));
                    //    break;
                    //case "bettaE":
                    //    bettaE.Add(Convert.ToDouble(valueNames[i]));
                    //    break;
                }
            }


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
