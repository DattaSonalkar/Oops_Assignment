using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Assignment
{
    public delegate void MyDelegate(int x,int y);
    class Multicast1
    {
        public void Add(int x,int y)
        {
            Console.WriteLine($"Add is:{x+y}");
        }

        public void Sub(int x, int y)
        {
            Console.WriteLine($"Sub is:{x - y}");
        }

        public void Mul(int x, int y)
        {
            Console.WriteLine($"Mul is:{x * y}");
        }
    }
    internal class Multicast_Delegate
    {
        static void Main(string[] args)
        {
                Multicast1 m1= new Multicast1();
                MyDelegate md=new MyDelegate(m1.Add);
                //md += m1.Add;
                md += m1.Sub;
                md += m1.Mul;
                md(64,16);
        }
    }
}
