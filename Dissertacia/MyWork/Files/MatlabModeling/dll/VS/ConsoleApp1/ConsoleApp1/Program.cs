using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathWorks.MATLAB.NET.Utility;
using MathWorks.MATLAB.NET.Arrays;
using Testdll;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {


            planeClass testClass = new planeClass();

            MWNumericArray input = null;
            MWNumericArray input2 = null;
            MWNumericArray input3 = null;
            MWNumericArray input4 = null;
            MWNumericArray output = null;
            MWNumericArray output2 = null;
            MWNumericArray output3 = null;
            MWNumericArray output4 = null;
            MWNumericArray outputArray = null;
            MWArray[] result = null;
            // var a = Convert.ToInt32(Console.ReadLine());

            // MWArray[] res = testClass.Testdll(a);

            input = 10;
            input2 = 10;
            input3 = 15; 
            result = testClass.Testdll(6,input,input2,input3);


            //output = (MWNumericArray) result[0];
            //output2 = (MWNumericArray) result[1];
            //output3 = (MWNumericArray) result[2];

            //Console.WriteLine(output + "\n");
            //Console.WriteLine(output2 + "\n");
            //Console.WriteLine(output3 + "\n");


            //Console.WriteLine((MWNumericArray)result[3] + "\n");


            //outputArray = (MWNumericArray) result[4];
            //Console.WriteLine(outputArray +"\n");

            //var stringarr = outputArray.ToString();
            //var stringarr1 = outputArray.ToArray();

            //Console.WriteLine( stringarr1.GetValue(0,0) + "\n");
            //Console.WriteLine( stringarr1.GetValue(0,1) + "\n");
            //Console.WriteLine( stringarr1.GetValue(0,2) + "\n");

            output4 = (MWNumericArray) result[3];
            Console.WriteLine(output4 + "\n");

            for (int i = 0; i < 10; i++)
            {
                result = testClass.Testdll(6, input, input2, input3);

                output4 = (MWNumericArray)result[3];
                Console.WriteLine(output4 + "\n");
            }
            result = testClass.Testdll(6, input, input2, input3);

            output4 = (MWNumericArray)result[3];
            Console.WriteLine(output4 + "\n");

            Console.ReadLine();
        }
    }
}
