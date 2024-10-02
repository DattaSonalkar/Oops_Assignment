using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Assignment
{
    internal class ClsArrayList
    {
        static void Main(string[] args)
        {
                ArrayList al = new ArrayList();
                al.Add(1);
            al.Add(2);
            al.Add(3);
            al.Add(4);
            al.Add(5);
            al.Add(6);
            al.Add(7);
            al.Add(8);
            al.Add(9);
            al.Add(10);

            foreach (int i in al)
            {
                Console.Write(i +" ");
            }

            al.Remove(3);
            Console.WriteLine();

            foreach (int i in al)
            {
                Console.Write( i + " ");
            }

            al.Reverse();
            Console.WriteLine();
            foreach (int i in al)
            {
                Console.Write(i + " ");
            }



            Console.Read();
        }
    }
}
