using System;
using System.ComponentModel;
using static System.Net.Mime.MediaTypeNames;

namespace w3resources_oefeningen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("Please enter the first number");
             int num1 = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Please enter the second number");
             int num2 = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Your results are");
             Console.WriteLine((num2) + (num1));
             Console.WriteLine((num2) - (num1));
             Console.WriteLine((num2) * (num1));
             Console.WriteLine((num2) / (num1));
             Console.WriteLine((num2) % (num1));*/
            /*oplossing w3
            
            Console.Write("Enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter another number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0} + {1} = {2}", num1, num2, num1 + num2);
            Console.WriteLine("{0} - {1} = {2}", num1, num2, num1 - num2);
            Console.WriteLine("{0} x {1} = {2}", num1, num2, num1 * num2);
            Console.WriteLine("{0} / {1} = {2}", num1, num2, num1 / num2);
            Console.WriteLine("{0} mod {1} = {2}", num1, num2, num1 % num2);*/

            //oefening 8

            /*Console.WriteLine("Enter a number");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your multiplication table is");
            int result1 = x * 1;
            Console.WriteLine($"{x}" + "x3=" + result1);
            int result2 = x * 2;
            Console.WriteLine($"{x}" + "x3=" + result2);
            int result3 = x * 3;
            Console.WriteLine($"{x}" + "x3=" + result3);
            int result4 = x * 4;
            Console.WriteLine($"{x}" + "x3=" + result4);
            int result5 = x * 5;
            Console.WriteLine($"{x}" + "x3=" + result5);
            int result6 = x * 6;
            Console.WriteLine($"{x}" + "x3=" + result6);
            int result7 = x * 7;
            Console.WriteLine($"{x}" + "x3=" + result7); ;
            int result8 = x * 8;
            Console.WriteLine($"{x}" + "x3=" + result8);
            int result9 = x * 9;
            Console.WriteLine($"{x}" + "x3=" + result9);
            int result10 = x * 10;
            Console.WriteLine($"{x}" + "x3=" + result10);
            helemaal ok */


            //9

            /*Console.WriteLine("Enter a number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter another number");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter another number");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter another number");
            int d = Convert.ToInt32(Console.ReadLine());
            int x = a + b + c + d;
            int y = 4; //hoe krijg ik hier de het aantal van ints van x
            int result = x / y;
            Console.WriteLine($"The average of your input is { result}");
            //Helemaal ok 
            */

            //10

            /*Console.WriteLine("Enter a number");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter another number");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter another number");
            double z = Convert.ToDouble(Console.ReadLine());
            double a = (x + y) * z;
            double b = (x*y) +(y*z);
            Console.WriteLine($"Result of specified numbers is {a} and {b}");
            //helemaal ok 
            */

            //11

            /* Console.WriteLine("What is your age");
             int a = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine($"You look older than {a}");
             //helemaal ok 
            */

            /*Console.WriteLine("Enter a number");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{number} {number} {number} {number}");
            Console.WriteLine($"{number}{number}{number}{number}");
            Console.WriteLine($"{number} {number} {number} {number}");
            Console.WriteLine($"{number}{number}{number}{number}");*/

            // Exception Handeling 1 

            /*Console.WriteLine("Enter a number");
            string a = Console.ReadLine();
            Console.WriteLine("Enter another number");
            string b = Console.ReadLine();
            double num1;
            double num2;

            if (!double.TryParse(a, out num1))
            {
                Console.WriteLine($"'{a}' "+"is not a number");
            }
            else if (!double.TryParse(b, out num2))
            {
                Console.WriteLine($"Your input '{b}' is not a number");
            }
            else if (num2==0)
            {
                Console.WriteLine($"Your input is 0 and we cannot divide by 0, you bellend");
            }
            else
            {
                double num3 = num1/num2;
                Console.WriteLine($"Your result is {num3}");
            }*/

            //Oefening2

            /*Console.WriteLine("Enter your number");
            string txt = Console.ReadLine() ?? "";

            if (!double.TryParse(txt, out double x))
            {
                Console.WriteLine($"Your input '{txt}' is invalid ya gobshite");
            }
            else if (!double.TryParse(txt, out double y) || (y < 0))
            {
                Console.WriteLine($"Your number is not an integer ya dingmush");
            }
            else
            {
                Console.WriteLine($"Your integer number is {txt}");
            }*/



            float Pi = 3.14f;
            Console.Write("Pi = ");
            Console.WriteLine(Pi);
            // Oef 2
            decimal getal = 2500.25M;
            Console.Write("getal = ");
            Console.WriteLine(getal);
            // Oef 3
            int maxInt = int.MaxValue;
            Console.Write("maxInt = ");
            Console.WriteLine(maxInt);
            Console.Write("maxInt + 1 = ");
            Console.WriteLine(++maxInt);
            // Oef 4
            ushort maxUShort = ushort.MaxValue;
            Console.Write("maxUShort = ");
            Console.WriteLine(++maxUShort);
            // Demo GIT
            int a = 1;
            Console.WriteLine(a++);


        }
    }
}
