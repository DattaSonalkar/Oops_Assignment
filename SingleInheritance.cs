using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Oops_Assignment
{
   class Person
    {

        public string name;
        public int age;

        
    }

   class Student : Person
    {
        public Student(string n,int a)
        {
            name = n;
            age = a;
        }
        public void Display()
        {
            Console.WriteLine($"Name Is:{name}");
            Console.WriteLine($"Age Is:{age}");
        }

    }
    internal class SingleInheritance
    {
        static void Main(string[] args)
        {
            Student s=new Student("Datta",30);
            s.Display();
                
        }
    }
}
