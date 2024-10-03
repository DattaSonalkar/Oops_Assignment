using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Oops_Assignment
{
    internal class ClsStack
    {
        static void Main(string[] args)
        {
                Stack s =new Stack();
                s.Push(1);
                s.Push(2);
                s.Push(3);
                s.Push(4);
                s.Push(5);
                Console.WriteLine("Stack Elements are:");
                foreach (var i in s) 
                Console.WriteLine(i);

                object se=s.Pop();
                Console.WriteLine("Stack Elements After removing are:");
                foreach (var i in s)
                Console.WriteLine(i);

                Console.Read();

        }

    }
}
