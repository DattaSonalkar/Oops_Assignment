using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Assignment
{
    internal class Calculator
    {
        public void Cal(int a, int b)
        {
            Console.WriteLine($"Addition is:{ a+b}");
        }
        public void Cal(double a, int b)
        {
            Console.WriteLine($"Multiplication is:{a * b}");
        }
        public void Cal(float a, int b)
        {
            Console.WriteLine($"Division is:{a / b}");
        }
        public void Cal(int a, float b)
        {
            Console.WriteLine($"Substraction is:{a - b}");
        }
    }
    class Clscalculator
    {
        static void Main(string[] args)
        {
            Calculator cal1 = new Calculator();
            cal1.Cal(12,10);
            cal1.Cal(1233d,10);
            cal1.Cal(10.5F,3);
            cal1.Cal(47,12.5F);

        }
    }
}
