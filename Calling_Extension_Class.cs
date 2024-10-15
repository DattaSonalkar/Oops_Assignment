using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Assignment
{
    class Calling_Extension_Class
    {
        static void Main(string[] args)
        {
            Extension_Class_Old eco = new Extension_Class_Old();
            eco.Add();
            eco.Mul();
            eco.Sub();
            eco.Div(40,10);
            Console.Read();
        }
        

    }
}
