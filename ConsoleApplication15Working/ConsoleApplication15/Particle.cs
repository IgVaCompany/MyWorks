using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApplication15
{
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

        public virtual void Heat—apacity() //Heat—apacity
        {
                       
            Cv = (Particle.R/Particle.m)*(Math.Pow(Z, -1)*mSum1 + Math.Pow(Z, -1)*mSum2);
            Console.WriteLine("Heat—apacity: " + Cv);
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
                    @"C:\Users\Î¯\Documents\GitHub\GAM\ConsoleApplication15Working\ConsoleApplication15\bin\Debug\" + nameFile;
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
                    @"C:\Users\Î¯\Documents\GitHub\GAM\ConsoleApplication15Working\ConsoleApplication15\bin\Debug\" + nameFile;
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
}