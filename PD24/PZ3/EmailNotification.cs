using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ3
{
    internal class EmailNotification: Notification
    {
        public override void Notify(string message)
        {
            Console.WriteLine($"Email Notification : {message}");
        }

    }
}
