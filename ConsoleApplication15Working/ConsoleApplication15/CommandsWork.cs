using System;

namespace ConsoleApplication15
{
    public class CommandsWork
    {

        private string[] Commands = new string[9]
        {"Close", "help", "pf", "PDFF", "CalcAtom", "CalcMolec", "cl", "calc", "test"};
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
                    He.HeatÑapacity();              
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
                    CC.CalcZ();
                    CC.TotalCalc();
                    CC.HeatÑapacity();
                    //   CC.HeatÑapacity();
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
                    foreach (string com in Commands)
                    {
                        Console.WriteLine(com);
                    }
                    break;                            

            }
        }
    }
}