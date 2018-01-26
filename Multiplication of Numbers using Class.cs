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
            Multiplication d = new Multiplication();
            d.input();
        }
    }

    class Multiplication
    {
        public void input() {
            Console.WriteLine("Enter 1st No. > ");
            float x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd No. > ");
            float y = Convert.ToInt32(Console.ReadLine());
            multiply(x, y);

        }

        void multiply(float a,float b) {
            float z = a * b;
            output(z);
        }

        void output(float a) {
            Console.WriteLine("Product is > "+ a);
            Console.ReadLine();
        }
        

    }
}
