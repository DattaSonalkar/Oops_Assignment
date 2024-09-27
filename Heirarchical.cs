using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Assignment
{

    class Shape1
    {
        public string color="";

        public void DisplayDetails()
        {
            
            Console.WriteLine(color);
        }
    }

    class Rectangle2:Shape1
    {
        public Rectangle2(string color)
        {
            this.color = color;
        }

    }

    class Circle2 : Shape1
    {
        public Circle2(string color)
        {
            this.color=color;
        }

    }
    internal class Heirarchical
    {
        static void Main(string[] args)
        {
            Circle2 c = new Circle2("Red");
            Console.WriteLine("Circle Color Is:");
            c.DisplayDetails();

            Rectangle2 r = new Rectangle2("pink");
            Console.WriteLine("Rectangle Color Is:");
            r.DisplayDetails();

        }
    }
}
