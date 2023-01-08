using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ovrriding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog d = new Dog();
            d.voise();
            Console.ReadKey();
        }
    }
    public class Animal
    {
        public virtual void voise()
        {
            Console.WriteLine("Animal");
        }
    }
    public class Dog : Animal
    {
        public override void voise()
        {
            Console.WriteLine("Bark");
        }
    }
}
