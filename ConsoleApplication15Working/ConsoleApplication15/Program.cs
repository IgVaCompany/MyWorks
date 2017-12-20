using System;
using System.Collections.Generic;
using System.Globalization;
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
        public static bool dlff = false;

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
                    do
                    {
                        He.DL();
                    } while (!dlff);
                                      
                    break;
                case "CalcMolec":
                    atomFlag = false;
                    molecFlag = true;
                    do
                    {
                        CC.DL();                       
                    } while (!dlff);
                    CC.NumLevels();
                    CC.CalcEi_n();
                    CC.CalcEj_i();
                    CC.CalcEkin();
                    CC.TotalCalc();
                    break;
                case "Close":
                   Environment.Exit(0);
                    break;
                case "DLFF":
                                  
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

        public string[] DataFile;
        private string NameFile; 
        
        public const double h = 6.626070040e-34;
        public const double R = 1.38064852e-23;
        public const double vC = 299792458;
        public const int temper = 300;

        public double tEkin;
        public double tE;
        public static int numOfLevels;

        public virtual void DL()
        {
            again: 
            try
            {
                Console.WriteLine("Input the file name" + "\n");
                NameFile = Console.ReadLine();
                DataFile = File.ReadAllLines(NameFile);
            }
            catch (Exception)
            {
                goto again;
                throw;
            }                   
        }

        public virtual int NumLevels()
        {
            if (numOfLevels == 0) ;
            {
                Console.WriteLine("Put level numbers");
                numOfLevels = Convert.ToInt32(Console.ReadLine());
            }
            return(numOfLevels);
        }

        public virtual void CalcEi_n()
        {         

        }
        public virtual void CalcEj_i()
        {
         
        }

        public virtual void CalcEkin()
        {
            tEkin = (3/2)*R*temper;           
        }

        public virtual void CalcEn()
        {

        }

        public virtual void TotalCalc()
        {
            Console.WriteLine("Total Energy");
            Console.WriteLine(tE);
        }

        public void PrintRelut(string result)
        {
            Console.WriteLine(result);
        }
    }

    public class Atom : Particle
    {
        private string[] needDataForAtom = new string[3] { "Configuration", "J", "Level"};
        List<string> config = new List<string>();
        List<int> jj = new List<int>();
        List<double> level = new List<double>();

        public override void DL()
        {
            base.DL();
            String valueName = DataFile[0];
            String[] valueNames = valueName.Split(new char[] {'\t', ' ', '-', '|', '[', ']'},StringSplitOptions.RemoveEmptyEntries);

            foreach (var vals in valueNames)
            {
                Console.WriteLine(vals);
            }
            for (int i = 1; i < DataFile.Length; i++)
            {
                String value = DataFile[i];
                String[] vaslues = value.Split(new char[] { '\t', ' ', '-', '|', '[', ']' }, StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < vaslues.Length; j++)
                {
                    switch (valueNames[j])
                    {
                        case "Configuration":
                            config.Add(vaslues[j]);
                            break;
                        case "J":
                            jj.Add(Convert.ToInt16(vaslues[j]));
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

        public override void CalcEn()
        {
            base.CalcEn();

        }

        public override void CalcEi_n()
        {
            base.CalcEi_n();
        }
    }

    public class Molecule : Particle
    {
        private string[] needDataForMolec = new string[8] { "te", "gi", "omegaE", "omegaExE", "bE", "alfaE", "dE", "bettaE" };
        List<string> dlData =new List<string>();
        List<double> te = new List<double>();
        List<double> gi = new List<double>();
        List<double> omegaE = new List<double>();
        List<double> omegaExE = new List<double>();
        List<double> bE = new List<double>();
        List<double> alfaE = new List<double>();
        List<double> dE = new List<double>();
        List<double> bettaE = new List<double>();

        public double tEi_n;
        public double tEj_i;
        List<double> Ei = new List<double>();
        List<double> Ej_i = new List<double>();
       

        public override void DL()
        {           
            base.DL();
            String valueName = DataFile[0];
            String[] valueNames = valueName.Split('\t', ' ');           
                for (int i = 0; i < valueNames.Length; i++)
                {
                    for (int j = 0; j < needDataForMolec.Length; j++)
                    {
                        if (valueNames[i] == needDataForMolec[j])
                        {
                            dlData.Add(needDataForMolec[j]);
                        }
                    }
                }
                if (dlData.ToArray().Length == needDataForMolec.Length)
                {
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
                                    alfaE.Add((Convert.ToDouble(vaslues[j]))*Math.Pow(10, 2));
                                    break;
                                case "dE":
                                    dE.Add((Convert.ToDouble(vaslues[j]))*Math.Pow(10, 6));
                                    break;
                                case "bettaE":
                                    bettaE.Add((Convert.ToDouble(vaslues[j]))*Math.Pow(10, 6));
                                    break;
                            }
                        }
                    }
                  CommandsWork.dlff = true;
                  Console.WriteLine("DownLoad OK");
            }
                else
                {
                    Console.WriteLine("Data is not correct" + "\nDownLoad please");
                    foreach (var s in needDataForMolec)
                    {
                        Console.Write(s + " ");
                    }
                    Console.WriteLine("Input the file name" + "\n");

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

        public override void CalcEi_n()
        {
            base.CalcEi_n();
            for (int i = 0; i < numOfLevels; i++)
            {
                try
                {
                    Ei.Add(Particle.h * Particle.vC * (omegaE.ToArray()[i] * (i + 0.5f) - omegaExE.ToArray()[i] * Math.Pow((i + 0.5f), 2)));
                    tEi_n += Ei.ToArray()[i];
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Load more Data of Lelels & Calc Again");
                    //throw;
                    break;
                }               
            }
            Console.WriteLine("Total Ei: "+ tEi_n);
            int f = 1;
            foreach (var s in Ei)
            {
                Console.WriteLine(f+" "+s);
                f++;
            }            
           
        }
        public override void CalcEj_i()
        {
            base.CalcEj_i();
            for (int i = 0; i < numOfLevels; i++)
            {
                try
                {
                    double Bcn = bE.ToArray()[i] - alfaE.ToArray()[i] * (i + 0.5f);
                    double Dcn = dE.ToArray()[i] - bettaE.ToArray()[i] * (i + 0.5f);
                    Ej_i.Add(Particle.h * Particle.R * (Bcn * i * (i + 1) - Dcn * Math.Pow(i, 2) * Math.Pow((i + 1), 2)));
                    tEj_i += Ej_i.ToArray()[i];
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Load more Data of Lelels & Calc Again");
                    //throw;
                    break;
                }
               
            }
            Console.WriteLine("Total Eji: " + tEj_i);
            int f = 1;
            foreach (var s in Ej_i)
            {
                Console.WriteLine(f + " " + s);
                f++;
            }
        }

        public override void CalcEkin()
        {
            base.CalcEkin();
            Console.WriteLine("Kinetic Energy Molec: " + tEkin);
        }

        public override void TotalCalc()
        {           
            tE = tEi_n + tEj_i + tEkin;
            base.TotalCalc();
        }
    }
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
                Console.WriteLine("Input the command" + "\n Write the command ShowC for see all available comands");
                Application.Manager();             
                command = Console.ReadLine();
            } while (command != null && !command.Equals("Close"));

        }
    }
}
