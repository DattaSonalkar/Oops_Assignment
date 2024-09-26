using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Assignment
{
    abstract class Shape
    {
        public abstract double CalculateArea(double a, double b);

        public void Display()
        {
            Console.WriteLine("Types of Shape");
        }

    }

    class Rectangle1 : Shape
    {
        public override double CalculateArea(double a, double b)
        {
            return a * b;
        }
    }

    class Circle1 : Shape
    {
        public override double CalculateArea(double r ,double pi)
        {
            return 22 / 7 * r;
        }

    }

    class Tringle:Shape
    {
        public  override double CalculateArea(double a,double b)
        {
            return (1/2)*(a*b);
        }
    }

    class ClsShape
    {
        static void Main(string[] args)
        {
                Rectangle1 rect = new Rectangle1();
                rect.Display();
                double d1 = rect.CalculateArea(12,21);
                Console.WriteLine($"Rectangle Area is:{d1}");

                Circle1 circle = new Circle1();
                double d2 = rect.CalculateArea(22/7,15);
                Console.WriteLine($"Circle Area is:{d2}");

                Tringle tringle = new Tringle();
                double d3 = rect.CalculateArea(12, 7);
                Console.WriteLine($"Triangle Area is:{d3}");

                Console.ReadLine();

        }
    }
}