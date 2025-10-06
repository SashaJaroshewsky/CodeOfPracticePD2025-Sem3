using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lk2
{
    internal class Cat : Animal
    {
        public Cat()
        {
            Console.WriteLine("Derived class");
        }

        public Cat(string name) : base(name)
        {
            Console.WriteLine("Derived class");
        }
        public override void Speak()
        {
            //base.Speak(); // Виклик методу Speak з базового класу Animal
            Console.WriteLine("The cat meows.");
        }
    }
}
