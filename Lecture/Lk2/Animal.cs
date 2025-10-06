using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lk2
{
    internal class Animal
    {
        protected string Name { get; set; }

        public Animal()
        {
            Console.WriteLine("Base class");
            Name = "Unknown";
        }

        public Animal(string name)
        {
            Console.WriteLine("Base class");
            Name = name;
        }

        public virtual void Speak()
        {
            Console.WriteLine("The animal makes a sound.");
        }
    }
}
