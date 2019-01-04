using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathWorks.MATLAB.NET.Utility;
using MathWorks.MATLAB.NET.Arrays;
using Testdll;
using CalcFunction_v_0;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {


           // planeClass testClass = new planeClass();
            
            CalcFunctionClass calcFunctionClass = new CalcFunctionClass();

            MWNumericArray input = null;
            MWNumericArray velocityInsertion = null;
            MWNumericArray velocityRotation = null;
            MWNumericArray time = null;
            MWNumericArray input2 = null;
            MWNumericArray input3 = null;
            MWNumericArray input4 = null;
            MWNumericArray output = null;
            MWNumericArray output2 = null;
            
            MWNumericArray output3 = null;
            MWNumericArray output4 = null;
            MWNumericArray outputArray = null;
            MWNumericArray offset = null;
            MWNumericArray angleOffset = null;
            MWNumericArray x = null;
            MWNumericArray y = null;
            MWNumericArray z = null;
            MWNumericArray insL = null;
            MWNumericArray qtyCalcPoints = null;
            MWNumericArray checkTime = null;
            MWArray[] result = null;
            // var a = Convert.ToInt32(Console.ReadLine());

            // MWArray[] res = testClass.Testdll(a);

            input = 10;
            input2 = 10;
            input3 = 15;
            velocityInsertion = 0.03f;
            velocityRotation = 100f;
            DateTime info = new DateTime();
            int check = 0;
            double softWareTime = 0;
            //result = testClass.Testdll(6,input,input2,input3);

            do
            {
                var softWareTimeStep = (DateTime.Now.Millisecond) * 0.0001;
                softWareTime = softWareTime + softWareTimeStep;
                result = calcFunctionClass.CalcFunction_v_0(9, softWareTime, velocityInsertion,velocityRotation);
                offset = (MWNumericArray)result[0];
                angleOffset = (MWNumericArray)result[1];
                x = (MWNumericArray)result[2];
                y = (MWNumericArray)result[3];
                z = (MWNumericArray)result[4];
                insL = (MWNumericArray)result[5];
                qtyCalcPoints = (MWNumericArray)result[6];
                checkTime = (MWNumericArray)result[7];

                Console.WriteLine("offset:{0}\tangleOffset:{1}\tx:{2}\ty:{3}\tz:{4}" +
                                  "\tinsL:{5}\tqtyCalcPoints:{6}\tcheckTime:{7}\tsoftWareTime:{8}\tsoftWareTimeStep:{9}\n", 
                                  offset, angleOffset, x,y,z, insL, qtyCalcPoints, checkTime, softWareTime, softWareTimeStep);
                output2 = (MWNumericArray) result[8];
                check = output2.ToScalarInteger();
            } while (check == 0);
           



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

            //output4 = (MWNumericArray) result[3];
            //Console.WriteLine(output4 + "\n");

            //for (int i = 0; i < 10; i++)
            //{
            //    result = testClass.Testdll(6, input, input2, input3);

            //    output4 = (MWNumericArray)result[3];
            //    Console.WriteLine(output4 + "\n");
            //}
            //result = testClass.Testdll(6, input, input2, input3);

            //output4 = (MWNumericArray)result[3];
            //Console.WriteLine(output4 + "\n");

            Console.ReadLine();
        }
    }
}
