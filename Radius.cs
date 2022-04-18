using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radius
{
    internal class Program
{
    static void Main(string[] args)
    {
        float pi = 3.14f;
        Console.Write("enter the radius value");
        float r = Convert.ToSingle(Console.ReadLine());
        float sol = 2 * pi * r;
        Console.WriteLine(sol);
        Console.ReadLine();
    }
}
}