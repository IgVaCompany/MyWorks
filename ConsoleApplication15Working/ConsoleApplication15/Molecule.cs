using System;
using System.Collections.Generic;

namespace ConsoleApplication15
{
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
                                alfaE.Add((Convert.ToDouble(vaslues[j]))*100);//
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
                //foreach (var s in Ediss)
                //{
                //    Console.WriteLine(s);
                //}
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
                Console.Write("\n" + S + " ");
            }
            Console.Write("\n" + "\n" + "gi\t");
            foreach (var S in gi)
            {
                Console.Write("\n" + S + " ");
            }
            Console.Write("\n" + "\n" + "omegaE\t");
            foreach (var S in omegaE)
            {
                Console.Write("\n" + S + " ");
            }
            Console.Write("\n" + "\n" + "omegaExE\t");
            foreach (var S in omegaExE)
            {
                Console.Write("\n" + S + " ");
            }
            Console.Write("\n" + "\n" + "bE\t");
            foreach (var S in bE)
            {
                Console.Write("\n" + S + " ");
            }
            Console.Write("\n" + "\n" + "alfaE\t");
            foreach (var S in alfaE)
            {
                Console.Write("\n" + S + " ");
            }
            Console.Write("\n" + "\n" + "dE\t");
            foreach (var S in dE)
            {
                Console.Write("\n" + S + " ");
            }
            Console.Write("\n" + "\n" + "bettaE\t");
            foreach (var S in bettaE)
            {
                Console.Write("\n" + S + " ");
            }
            Console.Write("\n" + "\n" + "EDiss\t");
            foreach (var S in Ediss)
            {
                Console.Write("\n" + S + " ");
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
                int i = 0;
                second = false;
                first = false;
                do
                {                    
                    Ei.Add(Math.Abs(Particle.h * Particle.vC * (omegaE.ToArray()[n] * (i + 0.5f) - omegaExE.ToArray()[n] * Math.Pow((i + 0.5f), 2))));
                    tEi_n += Ei.ToArray()[i];
                    double Bcn = bE.ToArray()[n] - alfaE.ToArray()[n] * (i + 0.5f);
                    double Dcn = dE.ToArray()[n] - bettaE.ToArray()[n] * (i + 0.5f);
                    gii.Add(1);
                       
                    int j = 0;           
                    do
                    {                                         
                        double mEj_i = Math.Abs(Particle.h * Particle.vC * (Bcn * j * (j + 1) - Dcn * Math.Pow(j, 2) * Math.Pow((j + 1), 2)));
                        double sE = En.ToArray()[n] + Ei.ToArray()[i] + mEj_i;
                        Console.WriteLine(sE + " "+ Ediss[n]);
                        if (sE > Ediss[n] && !first)
                        {
                            first = true;
                            i++;
                        }
                        else if (sE > Ediss[n] && first)
                        {
                            second = true;
                            first = true;
                        }
                        else
                        {
                            Ej_i.Add(mEj_i);
                            tEj_i += Ej_i.ToArray()[j];
                            gj.Add(2*j+1);
                            j++;
                            first = false;

                        }                                        
                    } while (!first);
                } while (!second);
                
            }
            Console.WriteLine("En Total: "+ tEn + "\nEi Total: " + tEi_n + "\nEj Total: " + tEj_i );
        
            Console.WriteLine("EKin"+tEkin);

            Console.WriteLine(Ej_i.ToArray().Length);
            Console.WriteLine(Ei.ToArray().Length);
            Console.WriteLine(En.ToArray().Length);
            Console.WriteLine(gj.ToArray().Length);

        }


        public override void CalcEkin()
        {
            base.CalcEkin();
            Console.WriteLine("Kinetic Energy Molec: " + tEkin);
        }

        public override void TotalCalc()
        {
            double T = 0.0f;
            for (int i = 0; i < gn.ToArray().Length; i++)
            {
                for (int j = 0; j < gii.ToArray().Length; j++)
                {
                    for (int k = 0; k < gj.ToArray().Length; k++)
                    {
                        T += (1 / (Particle.m * Z)) * gn.ToArray()[i] * 1 * (2 * k + 1) * (En.ToArray()[i] + Ei.ToArray()[j] + Ej_i.ToArray()[k]) * Math.Exp((-(En.ToArray()[i] + Ei.ToArray()[j] + Ej_i.ToArray()[k])) / (Particle.R * Particle.temper));                      
                        //  Console.WriteLine(j+": "+Z);                      
                    }
                }
            }

            tE = T+tEkin;
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
                        Z += gn.ToArray()[i] *1 * (2*k+1)* Math.Exp(-(En.ToArray()[i] + Ei.ToArray()[j] + Ej_i.ToArray()[k]) / (Particle.R * Particle.temper));
                        //  Console.WriteLine(j+": "+Z);                      
                    }
                }
            }
            Console.WriteLine(Z);
            base.CalcZ();
        }
      

        public override void HeatÑapacity()
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
            base.HeatÑapacity();
        }

        public override void ToFile()
        {
            base.ToFile();
            WriteToFile("EiMolec.txt", "Ei - VirationalEnergy : ", Ei);
            WriteToFile("Ej_iMolec.txt", "Ej_i - RotationalEnergy : ", Ej_i);
            WriteToFileEndData("EndData.txt", new string[4] { "tEi_n", "tEj_i", "tEkin", "tE" }, new double[4] { tEi_n, tEj_i, tEkin, tE });
            
        }
    }
}