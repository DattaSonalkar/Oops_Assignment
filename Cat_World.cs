using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Assignment
{
    public static class cls_Static
    {
        public static int NumberOfCats { get; private set; } = 0;
        public static int TotalCatNaps { get; private set; } = 0;

       public static void AddCat()
        { 
            NumberOfCats++;
            Console.WriteLine($"A new cat joined Total cats: {NumberOfCats}");
        }

        public static void AddCatNaps(int naps)
        {
            TotalCatNaps += naps;
            Console.WriteLine($"Added {naps} naps. Total naps: {TotalCatNaps}");
        }

    }
    internal class Cat_World
    {
        static void Main(string[] args)
        {
            cls_Static.AddCat();
            cls_Static.AddCat();

            cls_Static.AddCatNaps(5);
            cls_Static.AddCatNaps(3);

        }
    }
}
