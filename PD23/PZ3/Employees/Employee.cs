using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ3.Employees
{
    internal class Employee
    {
        protected decimal Salary { get; private set; }
        public string Name { get; set; }

        public Employee(string name)
        {
            Name = name;
        }

        public virtual void PaySalary(decimal money)
        {
            Salary += money;
            // Example salary payment logic
        }

        public virtual void GetInfo()
        {
            Console.WriteLine("Працівник");
        }

        public virtual decimal GetSalary() { return Salary; }
    }
}
