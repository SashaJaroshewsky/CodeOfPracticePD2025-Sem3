using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lk2
{
    internal class Dog: Animal
    {
        public new void Speak()
        {
           // base.Speak(); // Виклик методу Speak з базового класу Animal
            Console.WriteLine("The dog barks.");
        }
    }
}
