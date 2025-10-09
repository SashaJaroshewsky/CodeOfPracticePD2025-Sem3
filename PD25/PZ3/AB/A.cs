using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ3.AB
{
    internal class A
    {
        protected int a;

        public A(int a)
        {
            this.a = a;
        }

        public void GetInfo()
        {
            Console.WriteLine("Class A");
            Console.WriteLine(a);
        }
    }
}
