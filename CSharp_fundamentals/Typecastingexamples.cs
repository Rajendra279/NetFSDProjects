using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_fundamentals
{
    class Typecastingexamples
    {
        static void Main(string[] args)
        {
            /*
            int num = 100;
            Console.WriteLine("number = " + num);
            double result = num * 0.5F;
            Console.WriteLine("result = " + result);
            Console.ReadKey();
            */

            /*
            int num1 = 100;
            int num2 = 200;
            int num3 = num1 + num2;
            Console.WriteLine("number one " + num1);
            Console.WriteLine("number two " + num2);
            Console.WriteLine("number three " + num3);
            Console.ReadKey();
            */

            byte num1 = 100;
            byte num2 = 200;
            byte num3 = (byte) (num1 + num2);//Explicit type casting
            int num4 = num1 + num2;//Implicit type casting
            Console.WriteLine("number one " + num1);
            Console.WriteLine("number two " + num2);
            Console.WriteLine("number three " + num3);
            Console.ReadKey();


        }
    }
}

