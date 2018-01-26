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
            int[] a = new int[5];
            // int[] b = new int[5] { 1, 2, 3, 4, 5 }; //for self declaration
            for (int i = 0; i < 5; i++) {
                Console.WriteLine("Enter Value " + (i+1) + " > ");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach (int b in a) {
                Console.WriteLine("Value "+b+" is > ");
                Console.WriteLine(b);
            }
            Console.ReadLine();

        }
    }
}
