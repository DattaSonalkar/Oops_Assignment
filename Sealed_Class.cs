using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Assignment
{
    class Sealed_Class1
    {
        public void Display1()
        {
            Console.WriteLine("This is Base class");
        }
    }

    sealed class Sealed_Class2:Sealed_Class1
    {
        public void Display2()
        {
            Console.WriteLine("This is derived class with Sealed");
        }

    }
    class Sealed_Class
    {
        static void Main(string[] args)
        {
            Sealed_Class2 sc = new Sealed_Class2();
            sc.Display1();
            sc.Display2();
        }
    }
}
