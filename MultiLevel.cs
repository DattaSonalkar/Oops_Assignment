using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Assignment
{

    class Person1
    {
        public string Name;
        public string address;
    }

    class Teacher:Person1
    {
        public int id;
        public int salary;
    }

    class TeacherSalary:Teacher
    {
        int basic;
        int gross;

        public TeacherSalary(string name,string address,int id,int salary,int basic,int gross )
        {
            this.Name = name;
            this.address = address;
            this.id = id;
            this.salary = salary;
            this.basic = basic;
            this.gross = gross;
        }

        public void Display()
        {
            Console.WriteLine($"Name is:{Name}");
            Console.WriteLine($"Address is:{address}");
            Console.WriteLine($"Id is:{id}");
            Console.WriteLine($"salary is:{salary}");
            Console.WriteLine($"Basic is:{basic}");
            Console.WriteLine($"Gross is:{gross}");

        }
    }


    internal class MultiLevel
    {
        static void Main(string[] args)
        {
                TeacherSalary t=new TeacherSalary("Datta","Pune",102,30000,18000,16000);
                t.Display();
        }
    }
}
