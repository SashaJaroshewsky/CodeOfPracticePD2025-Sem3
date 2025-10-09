using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ3
{
    internal class Employee
    {
        public string Name { get; set; }

        public decimal Balance { get; private set; }

        public Employee(string name)
        {
            Name = name;
            Balance = 0;
        }

        public virtual void PaySalary(decimal money)
        {
            Balance += money;
        }

        public virtual void GetInfo()
        {
            Console.WriteLine("Працівник");
        }

    }
}
