using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ3.Employees
{
    internal class Intern : Employee
    {
        public Intern(string name) : base(name)
        {
        }
        public override void PaySalary(decimal money)
        {
            money *= 0.5m;
            base.PaySalary(money);
        }

    }
}
