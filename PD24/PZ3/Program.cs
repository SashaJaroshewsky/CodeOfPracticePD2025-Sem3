using PZ3.AB;
using PZ3.Employees;

namespace PZ3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            B b = new B(5);

            Manager manager = new Manager("Alisa");
            Manager manager1 = new Manager("Bob");
            Intern intern = new Intern("Charlie");
            Intern intern1 = new Intern("Diana");

            Manager[] managers = new Manager[] { manager, manager1 };
            Intern[] interns = new Intern[] { intern, intern1 };

            Employee[] employees = new Employee[] { manager, manager1, intern, intern1 };

            foreach (var emp in employees)
            {
                emp.PaySalary(1000);
                Console.WriteLine($"Name: {emp.Name}, Balance: {emp.Balance}");
            }
            Console.WriteLine("+++++++++++++++++++++++++++");

            string message = "Hello, this is a notification.";
            string message1 = "Hello, this is another notification.";

            Notification emailNotification = new EmailNotification();
            Notification smsNotification = new SMSNotification();

            emailNotification.Notify(message);
            smsNotification.Notify(message);
            emailNotification.Notify(message1);
            smsNotification.Notify(message1);



        }
    }
}
