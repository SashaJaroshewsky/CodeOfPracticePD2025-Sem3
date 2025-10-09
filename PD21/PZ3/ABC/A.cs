using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ3.ABC
{
    internal class A
    {
        protected int a;

        public A(int a)
        {
            this.a = a;
        }

        public virtual int GetInfo()
        {
            return a;
        }
    }
}
