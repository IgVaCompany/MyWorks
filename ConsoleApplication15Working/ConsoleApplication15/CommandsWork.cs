using System;
using System.Runtime.Remoting.Messaging;

namespace ConsoleApplication15
{
    public class CommandsWork
    {
        

        private string[] Commands = new string[9]
        {"Close", "help", "pf", "PDFF", "CalcAtom", "CalcMolec", "cl", "calc", "test"};
        private string[] CommandsShow = new string[9]
       {"Close - close the application", "help - show commands in window", "pf", "PDFF", "CalcAtom - Calc data for atom", "CalcMolec - Calc data for molec", "cl - clear data in memory", "calc", "test"};
        public static bool atomFlag = false;
        public static bool molecFlag = false;
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
                    Particle.numLines = 0;
                    dlff = false;
                    break;  
                case "CalcAtom":
                    atomFlag = true;
                    molecFlag = false;
                    do
                    {
                        He.DL();
                    } while (!dlff);
                    Console.WriteLine(Particle.numLines);
                    He.NumLevels();

                    if (Particle.numOfLevels >Particle.numLines)
                        Particle.numOfLevels = Particle.numLines;

                    He.CalcEkin();                    
                    He.CalcZ();  
                    He.TotalCalc();  
                    He.Heat—apacity();
                    Console.WriteLine("Calc made for " + Particle.numOfLevels + " levels");
                    break;
                case "CalcMolec":
                    atomFlag = false;
                    molecFlag = true;
                    do
                    {
                        CC.DL();                       
                    } while (!dlff);
                    Console.WriteLine(Particle.numLines);
                    CC.PrintDataDL();
                    CC.NumLevels();
                    if (Particle.numOfLevels > Particle.numLines)
                        Particle.numOfLevels = Particle.numLines;

                    CC.CalcEnergy();                   
                    CC.CalcEkin();                   
                    CC.CalcZ();
                    CC.TotalCalc();
                    CC.Heat—apacity();
                    Console.WriteLine("Calc made for " + Particle.numOfLevels + " levels");
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
                case "help":
                    foreach (string com in CommandsShow)
                    {
                        Console.WriteLine(com);
                    }
                    break;                            

            }
        }
    }
}