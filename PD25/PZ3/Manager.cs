using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ3
{
    internal class Manager: Employee
    {
        public Manager(string name) : base(name)
        {
        }

        public override void PaySalary(decimal money)
        {
            money *= 2;
            base.PaySalary(money);
        }

        public override void GetInfo()
        {
            Console.WriteLine("Менеджер");
        }

    }

}
