using PZ3.ABC;
using PZ3.Employees;

namespace PZ3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager("Alice");
            Manager manager2 = new Manager("Eve");

            Intern intern = new Intern("Bob");
            Intern intern2 = new Intern("Charlie");

            Manager[] managers = { manager, manager2 };
            Intern[] interns = { intern, intern2 };

            Employee[] employees = {manager, manager2, intern, intern2};

            foreach (var emp in employees)
            {
                emp.GetInfo();
            }

            string message = "Hi!";

            SMSNotificatin sMSNotificatin = new SMSNotificatin();
            EmailNotification emailNotification = new EmailNotification();

            sMSNotificatin.Notify(message);
            emailNotification.Notify(message);

            Object obj = new Object();
            List<Object> objects = new List<Object>();
        }
    }
}
