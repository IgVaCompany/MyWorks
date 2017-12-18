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

        string [] Commands = new string[8] { "Close","ShowC" ,"DLFF", "PDFF" ,"CalcAtom", "CalcMolec","td","calc" };
        private bool atomFlag = false;
        private bool molecFlag = false;

        Particle SomeBody = new Particle();
        Atom He = new Atom();
        Molecule CC = new Molecule();


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
                case "CalcAtom":
                    atomFlag = true;
                    molecFlag = false;  
                    He.DL();                 
                    break;
                case "CalcMolec":
                    atomFlag = false;
                    molecFlag = true;                  
                    CC.DL();
                    break;
                case "Close":
                   Environment.Exit(0);
                    break;
                case "DLFF":
                    SomeBody.DownLoadDataFromFile();                 
                    break;
                case "PDFF":
                    if (atomFlag && !molecFlag)
                        He.PrintDL();
                    else if(!atomFlag && molecFlag)
                        CC.PrintDataDL();
                    else
                        Console.WriteLine("DownLoad data please");
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
        List<double> config = new List<double>();
        List<double> jj = new List<double>();
        List<double> level = new List<double>();

        public override void DL()
        {
            base.DL();
            String valueName = DataFile[0];
            String[] valueNames = valueName.Split('\t', ' ', '-', '|');
            Console.WriteLine(valueNames.Length);

            foreach (var vals in valueNames)
            {
                Console.WriteLine(vals);
            }
            for (int i = 1; i < DataFile.Length; i++)
            {
                String value = DataFile[i];
                String[] vaslues = value.Split('\t', ' ', '-', '|','[',']');
                for (int j = 0; j < vaslues.Length; j++)
                {
                    switch (valueNames[j])
                    {
                        case "Configuration":
                            config.Add(Convert.ToDouble(vaslues[j]));
                            break;
                        case "J":
                            jj.Add(Convert.ToDouble(vaslues[j]));
                            break;
                        case "Level":
                            level.Add(Convert.ToDouble(vaslues[j]));
                            break;

                    }
                }
            }
        }

        public void PrintDL()
        {
            Console.Write("Configuration\t");
            foreach (var S in config)
            {
                Console.Write(S + " ");
            }
            Console.Write("\n" + "J\t");
            foreach (var S in jj)
            {
                Console.Write(S + " ");
            }
            Console.Write("\n" + "Level\t");
            foreach (var S in level)
            {
                Console.Write(S + " ");
            }
        }

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
            String[] valueNames = valueName.Split('\t', ' ');
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
                            alfaE.Add((Convert.ToDouble(vaslues[j]))*Math.Pow(10,2));
                            break;
                        case "dE":
                            dE.Add((Convert.ToDouble(vaslues[j]))*Math.Pow(10,6));
                            break;
                        case "bettaE":
                            bettaE.Add((Convert.ToDouble(vaslues[j]))*Math.Pow(10,6));
                            break;
                    }
                }              
            }                   
        }

        public void PrintDataDL()
        {
            Console.Write("te\t");
            foreach (var S in te)
            {
                Console.Write(S + " ");
            }
            Console.Write("\n" + "gi\t");
            foreach (var S in gi)
            {
                Console.Write(S + " ");
            }
            Console.Write("\n" + "omegaE\t");
            foreach (var S in omegaE)
            {
                Console.Write(S + " ");
            }
            Console.Write("\n" + "omegaExE\t");
            foreach (var S in omegaExE)
            {
                Console.Write(S + " ");
            }
            Console.Write("\n" + "bE\t");
            foreach (var S in bE)
            {
                Console.Write(S + " ");
            }
            Console.Write("\n" + "alfaE\t");
            foreach (var S in alfaE)
            {
                Console.Write(S + " ");
            }
            Console.Write("\n" + "dE\t");
            foreach (var S in dE)
            {
                Console.Write(S + " ");
            }
            Console.Write("\n" + "bettaE\t");
            foreach (var S in bettaE)
            {
                Console.Write(S + " ");
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
