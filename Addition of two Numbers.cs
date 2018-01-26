using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.WriteLine("Enter 1st No. > ");
            x=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd No. > ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Sum is > " + (x+y));
            Console.WriteLine("Sum of {0} & {1} is {2}",x,y,(x+y));
            Console.ReadLine();
        }
    }
}
