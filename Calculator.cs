using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Code
    {
        static void Main(string[] args)
        {
            int x, y, z;
            Console.Write("Enter the first number");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("1.Addition");
            Console.WriteLine("2.Subtraction");
            Console.WriteLine("3.Multiplication");
            Console.WriteLine("4.Division");
            Console.Write("Select the Operation to be Executed");
            z = Convert.ToInt32(Console.ReadLine());
            switch (z)
            {
                case 1:
                    Console.WriteLine(x+y);
                    break;
                case 2:
                    Console.WriteLine(x-y);
                    break;
                case 3:
                    Console.WriteLine(x*y);
                    break;
                case 4:
                    Console.WriteLine(x/y);
                    break;
                default:
                    Console.WriteLine("Invalid");
                    break;
            }
            Console.ReadLine();
        }
    }
}