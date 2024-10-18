using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Assignment
{
    internal class Ref_Class
    {
        public static void Increment_Value(ref int a)
        {
            a++;
        }

        static void Main(string[] args)
        {
            int a = 10;
            Console.WriteLine($"Vale Before Increment:{a}");
            Increment_Value(ref a);
            Console.WriteLine($"Value after increment:{a}");
            Console.Read();
            
        }

    }
}
