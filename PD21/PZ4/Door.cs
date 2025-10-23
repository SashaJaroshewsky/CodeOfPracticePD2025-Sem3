using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ4
{
    internal class Door: ISwitchable, IDamageable
    {
        public int HP = 20;
        public bool IsOpened { get; private set; }
        public void Open()
        {
            IsOpened = true;
            Console.WriteLine("Door is opened.");
        }
        public void Close()
        {
            IsOpened = false;
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
