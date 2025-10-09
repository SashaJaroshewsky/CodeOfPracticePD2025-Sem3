using PZ3.AB;

namespace PZ3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            B b = new B(5);
            B b2 = new B(10);

            Manager manager = new Manager("Alice");
            Manager manager2 = new Manager("Bob");
            Intern intern = new Intern("Charlie");
            Intern intern2 = new Intern("Diana");

            //Manager[] managers = new Manager[] { manager, manager2 };
            //Intern[] interns = new Intern[] { intern, intern2 };

            Employee[] employees = new Employee[] { manager, manager2, intern, intern2 };


            
            foreach (var emp in employees)
            {
                emp.PaySalary(1000);
            }

            foreach (var emp in employees)
            {
                Console.Write($"Name: {emp.Name}, Balance: {emp.Balance} ");
                emp.GetInfo();
                
            }

        }
    }
}
