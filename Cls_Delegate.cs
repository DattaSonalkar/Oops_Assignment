using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Assignment
{

    public delegate void Cls_Delegate(int a, int b);
    public delegate void Delegate_Substraction(int a, int b);
    class Cls_Delegate1
    {
        public void Addition(int a, int b)
        {
            Console.WriteLine("Addition is:" + (a + b));
        }

        public void Substraction(int a, int b)
        {
            Console.WriteLine($"Substraction is :{a - b}");
        }
    }

    class Cls_Delegate2
    { 

        static void Main()
        {
            //Delegate_Addition da = new Delegate_Addition(Display);
            Cls_Delegate1 cd = new Cls_Delegate1();
            Cls_Delegate cd1 = new Cls_Delegate(cd.Addition);
            cd1(10,12);

            Delegate_Substraction ds=new Delegate_Substraction(cd.Substraction);
            ds(53,43);
        }
        
    }
}
