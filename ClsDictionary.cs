using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Assignment
{
    internal class ClsDictionary
    {
        static void Main(string[] args)
        {
                Dictionary<int,string> d = new Dictionary<int,string>();
            d.Add(101,"Datta");
            d.Add(102, "Raj");
            d.Add(103, "Vikas");
            d.Add(104, "Shyam");
            d.Add(105, "Anil");
            d.Add(106, "Raju");
            d.Add(107, "Ajit");
            d.Add(108, "Dipak");
            d.Add(109, "Ram");
            d.Add(110, "Sachin");
            foreach (KeyValuePair<int, string> kvp in d)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }

            d[4] = "Rutu";

            Console.WriteLine("Modified Values");
            foreach (KeyValuePair<int, string> kvp in d)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }

            d.Remove(6);

            Console.WriteLine("After Removing Element");
            foreach (KeyValuePair<int, string> kvp in d)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }


            var filteredElements = d.Where(kvp => kvp.Value.Contains("Modified"));

            
            Console.WriteLine("Filtered elements:");
            foreach (var kvp in filteredElements)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }


        }
    }
}
