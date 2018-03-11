using System;
using System.Collections.Generic;

namespace ConsoleApplication15
{
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

        public override void HeatÑapacity()
        {
            for (int i = 0; i < numOfLevels; i++)
            {
                mSum1 = Math.Pow((level.ToArray()[i] / (Particle.R * Particle.temper)), 2) * gi.ToArray()[i] *
                        Math.Exp(-level.ToArray()[i]/ (Particle.R * Particle.temper));
                mSum2 = Math.Pow((level.ToArray()[i] / (Particle.R * Particle.temper)), 1) * gi.ToArray()[i] *
                        Math.Exp(-level.ToArray()[i]/ (Particle.R * Particle.temper)) + 3 / 2;
            }
            base.HeatÑapacity();                       
        }

        public override void ToFile()
        {
            base.ToFile();

        }
    }
}