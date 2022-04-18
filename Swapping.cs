using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swapping
{
    internal class Code
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 11;

            int temp = x;
            x = y;
            y = temp;
            Console.WriteLine("Swapped x Value " + x);
            Console.WriteLine("Swapped y Value " + y);
            Console.ReadLine();
        }    
    }
}