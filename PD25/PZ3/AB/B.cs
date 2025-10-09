using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ3.AB
{
    internal class B: A
    {
        public B(int b): base(b)
        {
        }

        public new void GetInfo()
        {
            Console.WriteLine("Class B");
            Console.WriteLine(a);
        }
    }


}
