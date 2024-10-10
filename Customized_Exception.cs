using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Oops_Assignment
{
    class Negetive_Number_Exception:Exception
    {
        public Negetive_Number_Exception(string msg): base("Negative numbers are not allowed.")
        {
        }
    }
    internal class Customized_Exception
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Enter Any No:");
                int num = Convert.ToInt32(Console.ReadLine());
                if (num < 0)
                {
                    throw new Negetive_Number_Exception($"Error: {num} is a negative number.");
                }
                else
                {
                    Console.WriteLine($"{num} is a valid positive number.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

        }
    }
}
