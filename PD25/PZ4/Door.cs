using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ4
{
    internal class Door: ISwitchable, IDamageable
    {
        public int HP { get; private set; } = 50;
        public bool IsOpen { get; private set; }
        public void Open()
        {
            IsOpen = true;
            Console.WriteLine("Door is opened.");
        }
        public void Close()
        {
            IsOpen = false;
            Console.WriteLine("Door is closed.");
        }

        public void On()
        {
            Open();
        }

        public void Off()
        {
            Close();
        }

        public void TakeDamage(int damage)
        {
            HP -= damage;
           
        }
    }
}
