using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Assignment
{
    public static class Extension_Class_New
    {
        public static void Sub(this Extension_Class_Old eco1)
        {
           int c = eco1.x - eco1.y;
            Console.WriteLine("Sub is:" + c);
        }

        public static void Mul(this Extension_Class_Old eco2)
        {
            
            Console.WriteLine("Mul is:" + eco2.x*eco2.y);
        }

        public static void Div(this Extension_Class_Old eco3, int a, int b)
        {
            int c = a / b;
            Console.WriteLine("Div is:" + c);
        }
    }
}
