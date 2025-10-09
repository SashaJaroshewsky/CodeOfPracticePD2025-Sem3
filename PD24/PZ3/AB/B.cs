using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ3.AB
{
    internal sealed class B: A
    {
        public B(int a): base(a)
        {
        }

        public sealed override void GetInfo()
        {
            a = 5;
        }
    }
}
