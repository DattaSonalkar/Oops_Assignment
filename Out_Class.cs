using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Assignment
{
    internal class Out_Class
    {
        public static void Initilize_Values(int a,string s,out int rollno,out string name)
        {
            rollno = a;
            name = s;
        }
        static void Main(string[] args)
        {
            int a = 10;
            string s = "Datta";
            int rollno;
            string name;
            Initilize_Values(a,s,out rollno,out name);
            Console.WriteLine($"Rollno is:{rollno}");
            Console.WriteLine($"Name is:{name}");

        }
    }
}
