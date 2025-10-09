using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ3
{
    internal class Notification
    {
        public virtual void Notify(string message)
        {
            Console.WriteLine($"Notification: {message}");
        }
    }
}
