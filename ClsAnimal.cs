using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Assignment
{
    class Animal
    {
        public virtual void Draw()
        {
            Console.WriteLine("Drawing a shape");
        }
    }

    class Circle : Animal
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a Circle");

        }
    }

    class Rectangle : Animal
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a Rectangle");
        }
        

    }
    
    internal class ClsAnimal
    {
        static void Main(string[] args)
        {
            Animal ani=new Animal();
            ani.Draw();

            Circle cir=new Circle();
            cir.Draw();

            Rectangle rect=new Rectangle();
            rect.Draw();

            Console.Read();

        }
    }
}
