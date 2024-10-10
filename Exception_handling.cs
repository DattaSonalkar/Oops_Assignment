using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Assignment
{
    class Exception_handling
    {
        static void Main(string[] args)
        {
            int a=12, b=6, c=0;

            try
            {
                c = a + b;
                Console.WriteLine("Addition is:" + c);

                c = a - b;
                Console.WriteLine("Substraction is:" + c);

                c = a * b;
            }
            catch 
            {
                Console.WriteLine("Something went wrong");
            }
            Console.WriteLine("Multiplication is:"+c);

            //Dividebyzeroexception
            try
            {
                c = a / b;
                Console.WriteLine("Division is:" + c);
            }
            catch(DivideByZeroException de) 
            {
                Console.WriteLine(de.Message);
            }

            //FormatException
            try
            {
                string s = "abc123";
                int result = int.Parse(s);  
            }

            catch(FormatException fe) 
            {
                Console.WriteLine(fe.Message);
            }

            //OverflowException
            try
            {
                
                int max = int.MaxValue;
                int result = checked(max + 1);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.Read();
        }

    }
}
