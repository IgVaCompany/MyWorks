using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Linq.Expressions;
using System.Security.Claims;
using System.Security.Cryptography.X509Certificates;


namespace ConsoleApplication15
{
    

    public class CommandsWork
    {

        private string[] Commands = new string[9]
        {"Close", "ShowC", "pf", "PDFF", "CalcAtom", "CalcMolec", "cl", "calc", "test"};
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
                case "cl":
                    atomFlag = false;
                    molecFlag = false;
                    He.Clear();
                    CC.Clear();
                    dlff = false;
                    break;  
                case "CalcAtom":
                    atomFlag = true;
                    molecFlag = false;
                    do
                    {
                        He.DL();
                    } while (!dlff);
                    He.NumLevels();
                    He.CalcEkin();                    
                    He.CalcZ();  
                    He.TotalCalc();  
                    He.HeatСapacity();              
                    break;
                case "CalcMolec":
                    atomFlag = false;
                    molecFlag = true;
                    do
                    {
                        CC.DL();                       
                    } while (!dlff);
                    CC.NumLevels();
                    CC.CalcEnergy();                   
                    CC.CalcEkin();
                    CC.TotalCalc();
                    CC.CalcZ();
                    CC.HeatСapacity();
                 //   CC.HeatСapacity();
                    break;
                case "Close":
                   Environment.Exit(0);
                    break;
                case "pf":
                    CC.ToFile();  
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

            }
        }
    }

    public class Particle
    {
        public string[] DataFile;
        private string NameFile;

        public List<double> gi = new List<double>();

        public const double h = 6.626070040e-34;
        public const double R = 1.38064852e-23;
        public const double vC = 3e+8;
        public const int temper = 300;
        public const double m = 1.661e-27;

        public double tEi_n;
        public double tEj_i;
        public double tEkin;
        public double tEn;
        public double tE;
        public double Z;
        public double Cv;

        public double mSum1;
        public double mSum2;

        public static int numOfLevels;
        
        public virtual void Clear()
        {
            tE = 0;
            tEi_n = 0;
            tEj_i = 0;
            tEkin = 0;
            tEn = 0;
            Z = 0;
            Cv = 0;
            gi.Clear();
            Console.WriteLine("Clear OK!");
        }

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

        public virtual void CalcEi_n() // VirationalEnergy
        {         

        }

        public virtual void CalcEj_i() // RotationalEnergy
        {
         
        }

        public virtual void CalcEkin() // Kinetick
        {
            tEkin = (3/2)*R*temper;           
        }

        public virtual void CalcEn() // Electronic
        {

        }

        public virtual void TotalCalc() // Total
        {
            Console.WriteLine("Total Energy: "+tE);
        }

        public virtual void CalcZ() // Statick Sum
        {
            Console.WriteLine("Statistic Sum: " + Z);
        }

        public virtual void HeatСapacity() //HeatСapacity
        {
                       
            Cv = (Particle.R/Particle.m)*(Math.Pow(Z, -1)*mSum1 + Math.Pow(Z, -1)*mSum2);
            Console.WriteLine("HeatСapacity: " + Cv);
        }

        public virtual void ToFile()
        {
            Console.WriteLine("OK");
        }

        public virtual void CalcEnergy()
        {
            
        }

        public  void WriteToFile(string nameFile, string namePrintVar, List<double> data)
        {
            try
            {
                string path =
               @"C:\Users\лш\Documents\GitHub\GAM\ConsoleApplication15Working\ConsoleApplication15\bin\Debug\" + nameFile;
                if (!File.Exists(path))
                {
                    // Create a file to write to.
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.WriteLine(namePrintVar);
                        int i = 1;
                        foreach (var s in data)
                        {
                            sw.WriteLine("Level " + i + " " + s);
                            i++;
                        }
                    }
                }
                else
                {
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.WriteLine(namePrintVar);
                        int i = 1;
                        foreach (var s in data)
                        {
                            sw.WriteLine("Level " + i + " " + s);
                            i++;
                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void WriteToFileEndData(string nameFile, string[] names, double[] data)
        {
            try
            {
                string path =
               @"C:\Users\лш\Documents\GitHub\GAM\ConsoleApplication15Working\ConsoleApplication15\bin\Debug\" + nameFile;
                if (!File.Exists(path))
                {
                    // Create a file to write to.
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.WriteLine(names);
                        int i = 0;
                        foreach (var s in data)
                        {
                            sw.WriteLine(names[i] + "\t" +  data[i]);
                            i++;
                        }
                    }
                }
                else
                {
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.WriteLine(names);
                        int i = 0;
                        foreach (var s in data)
                        {
                            sw.WriteLine(names[i] + data[i]);
                            i++;
                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }

    public class Atom : Particle
    {
        private string[] needDataForAtom = new string[2] { "J", "Level"};
        List<string> config = new List<string>();
        List<int> jj = new List<int>();
        List<double> level = new List<double>();
      //  List<double> g = new List<double>();

        List<string> dlData = new List<string>();
        List<double> En = new List<double>();

        public override void Clear()
        {
            base.Clear();
            config.Clear();
            jj.Clear();
            level.Clear();
        }

        public override void DL()
        {
            base.DL();
            String valueName = DataFile[0];
            String[] valueNames = valueName.Split(new char[] {'\t', ' ', '-', '|', '[', ']'},StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < valueNames.Length; i++)
            {
                for (int j = 0; j < needDataForAtom.Length; j++)
                {
                    if (valueNames[i] == needDataForAtom[j])
                    {
                        dlData.Add(needDataForAtom[j]);
                    }
                }
            }                         
                if (dlData.ToArray().Length == needDataForAtom.Length)
                {
                    for (int i = 1; i < DataFile.Length; i++)
                    {
                        String value = DataFile[i];
                        String[] vaslues = value.Split(new char[] { '\t', ' ', '-', '|', '[', ']' }, StringSplitOptions.RemoveEmptyEntries);
                        for (int j = 0; j < vaslues.Length; j++)
                        {
                            switch (valueNames[j])
                            {
                                case "J":
                                    jj.Add(Convert.ToInt16(vaslues[j]));
                                    break;
                                case "Level":
                                    level.Add(Convert.ToDouble(vaslues[j]));
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
                    foreach (var s in needDataForAtom)
                    {
                        Console.Write(s + " ");
                    }
                    Console.WriteLine("Input the file name" + "\n");
                }
            
           
        }

        public void PrintDL()
        {           
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

        public override void CalcEi_n()
        {
            base.CalcEi_n();
        }

        public override void CalcZ()
        {
            for (int i = 0; i < numOfLevels; i++)
            {
                try
                {
                    gi.Add(2 * jj.ToArray()[i] + 1);                    
                }
                catch (IndexOutOfRangeException)
                {
                  //  Console.WriteLine("Load more Data of Lelels & Calc Again");
                    break;
                }
                            
            }
            for (int i = 0; i < numOfLevels; i++)
            {
                try
                {
                    Z += gi.ToArray()[i] * Math.Exp((-level.ToArray()[i]) / (Particle.R * Particle.temper));
                }
                catch (IndexOutOfRangeException)
                {                  
                    Console.WriteLine("Load more Data of Lelels & Calc Again" + " Calc Only for: " + i);
                    break;
                }
            }
            base.CalcZ();
        }

        public override void CalcEn()
        {
            base.CalcEn();
            for (int i = 0; i < numOfLevels; i++)
            {
                try
                {
                    En.Add((1 / (Particle.m * Z)) * gi.ToArray()[i] * level.ToArray()[i] * Math.Exp(-level.ToArray()[i] / (Particle.R * Particle.temper)));
                    tEn += En.ToArray()[i];
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Load more Data of Lelels & Calc Again");
                    break;
                }              
            }
        }

        public override void TotalCalc()
        {           
            tE = tEkin + tEn;
            base.TotalCalc();
        }

        public override void HeatСapacity()
        {
            for (int i = 0; i < numOfLevels; i++)
            {
                mSum1 = Math.Pow((level.ToArray()[i] / (Particle.R * Particle.temper)), 2) * gi.ToArray()[i] *
                        Math.Exp(-level.ToArray()[i]/ (Particle.R * Particle.temper));
                mSum2 = Math.Pow((level.ToArray()[i] / (Particle.R * Particle.temper)), 1) * gi.ToArray()[i] *
                       Math.Exp(-level.ToArray()[i]/ (Particle.R * Particle.temper)) + 3 / 2;
            }
            base.HeatСapacity();                       
        }

        public override void ToFile()
        {
            base.ToFile();

        }
    }

    public class Molecule : Particle
    {
        private string[] needDataForMolec = new string[9] { "te", "gi", "omegaE", "omegaExE", "bE", "alfaE", "dE", "bettaE", "Ediss" };

        List<string> dlData =new List<string>();
        List<double> te = new List<double>();
        List<double> omegaE = new List<double>();
        List<double> omegaExE = new List<double>();
        List<double> bE = new List<double>();
        List<double> alfaE = new List<double>();
        List<double> dE = new List<double>();
        List<double> bettaE = new List<double>();
        List<double> Ediss = new List<double>();
        
        List<double> gn =new List<double>();
        List<double> gii =   new List<double>();
        List<double> gj = new List<double>();

        List<double> En = new List<double>();
        List<double> Ei = new List<double>();
        List<double> Ej_i = new List<double>();
        private bool first = false;
        private bool second = false; 

        public override void Clear()
        {
            base.Clear();
            dlData.Clear();
            te.Clear();
            omegaE.Clear();
            omegaExE.Clear();
            bE.Clear();
            alfaE.Clear();
            dE.Clear();
            bettaE.Clear();
            Ei.Clear();
            Ej_i.Clear();
        }

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
                                    te.Add(Convert.ToDouble(vaslues[j])*Particle.h*Particle.vC*100);
                                    break;
                                case "gi":
                                    gi.Add(Convert.ToDouble(vaslues[j]));
                                    break;
                                case "omegaE":
                                    omegaE.Add(Convert.ToDouble(vaslues[j])*100);
                                    break;
                                case "omegaExE":
                                    omegaExE.Add(Convert.ToDouble(vaslues[j])*100);
                                    break;
                                case "bE":
                                    bE.Add(Convert.ToDouble(vaslues[j])*100);//
                                    break;
                                case "alfaE":
                                    alfaE.Add((Convert.ToDouble(vaslues[j]))*100*);//
                                    break;
                                case "dE":
                                    dE.Add((Convert.ToDouble(vaslues[j])));//
                                    break;
                                case "bettaE":
                                    bettaE.Add((Convert.ToDouble(vaslues[j])));//
                                    break;
                                case "Ediss":    
                                    if  (Convert.ToDouble(vaslues[j])==0)
                                    Ediss.Add(Ediss.ToArray()[i-2]+ (Convert.ToDouble(vaslues[j])) * Particle.h * Particle.vC * 100);
                                    else                         
                                    Ediss.Add((Convert.ToDouble(vaslues[j])) * Particle.h * Particle.vC * 100);                              
                                break;
                        }
                        }
                    }
                  CommandsWork.dlff = true;
                  Console.WriteLine("DownLoad OK");
                    foreach (var s in Ediss)
                    {
                    Console.WriteLine(s);
                }
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

        public override void CalcEnergy()
        {
            base.CalcEnergy();
            for (int n = 0; n < numOfLevels; n++)
            {
                En.Add(Math.Abs(te.ToArray()[n]));
                tEn += En.ToArray()[n];
                gn.Add(Math.Abs(gi.ToArray()[n]));
                int i = 1;
                second = false;
                do
                {                    
                        Ei.Add(Math.Abs(Particle.h * Particle.vC * (omegaE.ToArray()[n] * (i + 0.5f) - omegaExE.ToArray()[n] * Math.Pow((i + 0.5f), 2))));
                        tEi_n += Ei.ToArray()[i-1];
                        gii.Add(1);
                       
                    int j = 1;           
                    do
                    {                   
                        double Bcn = bE.ToArray()[n] - alfaE.ToArray()[n] * (i + 0.5f);
                        double Dcn = dE.ToArray()[n] - bettaE.ToArray()[n] * (i + 0.5f);
                        double mEj_i = Math.Abs(Particle.h * Particle.vC * (Bcn * j * (j + 1) - Dcn * Math.Pow(j, 2) * Math.Pow((j + 1), 2)));
                        double sE = En.ToArray()[n] + Ei.ToArray()[i-1] + mEj_i;
                        Console.WriteLine(sE + " "+ Ediss[n]);
                        if (sE > Ediss[n] && !first)
                        {
                            first = true;
                            i++;
                        }
                        else if (sE > Ediss[n] && first)
                        {
                            second = true;
                        }
                        else
                        {
                            Ej_i.Add(mEj_i);
                            tEj_i += Ej_i.ToArray()[j - 1];
                            gj.Add(2*j+1);
                            j++;
                            first = false;

                        }                                        
                    } while (!first);
                } while (!second);
                
            }
            Console.WriteLine("En Total: "+ tEn + "\nEi Total: " + tEi_n + "\nEj Total: " + tEj_i );
            Console.WriteLine(Ej_i.ToArray().Length);
            Console.WriteLine(Ei.ToArray().Length);
            Console.WriteLine(En.ToArray().Length);
        }
      

        public override void CalcEkin()
        {
            base.CalcEkin();
            Console.WriteLine("Kinetic Energy Molec: " + tEkin);
        }

        public override void TotalCalc()
        {           
            tE = tEi_n + tEn + tEj_i + tEkin;
            base.TotalCalc();
        }

        public override void CalcZ()
        {           
            for (int i = 0; i < gn.ToArray().Length; i++)
            {
                for (int j = 0; j < gii.ToArray().Length; j++)
                {
                    for (int k = 0; k < gj.ToArray().Length; k++)
                    {
                        Z +=gn.ToArray()[i]*gii.ToArray()[j]*gj.ToArray()[k]*Math.Exp((-(En.ToArray()[i]+Ei.ToArray()[j]+Ej_i.ToArray()[k]))/(Particle.R*Particle.temper)); 
                      //  Console.WriteLine(j+": "+Z);                      
                    }
                }
            }
            Console.WriteLine(Z);
            base.CalcZ();
        }
      

        public override void HeatСapacity()
        {
            for (int i = 0; i < gn.ToArray().Length; i++)
            {
                for (int j = 0; j < gii.ToArray().Length; j++)
                {
                    for (int k = 0; k < gj.ToArray().Length; k++)
                    {
                        mSum1 += Math.Pow(((En.ToArray()[i] + Ei.ToArray()[j] + Ej_i.ToArray()[k]) / (Particle.R * Particle.temper)), 2) * gn.ToArray()[i] * gii.ToArray()[j] * gj.ToArray()[k] *
                       Math.Exp(-(En.ToArray()[i] + Ei.ToArray()[j] + Ej_i.ToArray()[k]) / (Particle.R * Particle.temper));
                        mSum2 += Math.Pow(((En.ToArray()[i] + Ei.ToArray()[j] + Ej_i.ToArray()[k]) / (Particle.R * Particle.temper)), 1) * gn.ToArray()[i] * gii.ToArray()[j] * gj.ToArray()[k] *
                       Math.Exp(-(En.ToArray()[i] + Ei.ToArray()[j] + Ej_i.ToArray()[k]) / (Particle.R * Particle.temper))+1.5f;
                    }
                }
               
            }
            base.HeatСapacity();
        }

        public override void ToFile()
        {
            base.ToFile();
            WriteToFile("EiMolec.txt", "Ei - VirationalEnergy : ", Ei);
            WriteToFile("Ej_iMolec.txt", "Ej_i - RotationalEnergy : ", Ej_i);
            WriteToFileEndData("EndData.txt", new string[4] { "tEi_n", "tEj_i", "tEkin", "tE" }, new double[4] { tEi_n, tEj_i, tEkin, tE });
            
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
