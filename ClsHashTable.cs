using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Assignment
{
    internal class ClsHashTable
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("a", 1);
            ht.Add("b", 2);
            ht.Add("c", 3);
            ht.Add("d", 4);
            ht.Add("e", 5);

            foreach (DictionaryEntry d in ht)
            {
                Console.Write(d.Key+" ");
            }

            Console.WriteLine();
            ht.Remove("c");

            foreach (DictionaryEntry d in ht)
            {
                Console.Write(d.Key +" ");
            }

            Console.ReadLine();

        }
    }
}
