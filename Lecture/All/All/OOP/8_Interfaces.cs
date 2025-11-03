using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All.OOP
{
    /// <summary>
    /// 8. Interfaces — Інтерфейси
    /// 
    /// ТЕОРІЯ:
    /// Інтерфейс — це контракт, який визначає, які методи/властивості має реалізувати клас.
    /// 
    /// ОСОБЛИВОСТІ:
    /// - Не містить реалізації (тільки сигнатури)
    /// - Клас може реалізовувати кілька інтерфейсів
    /// 
    /// СИНТАКСИС:
    /// interface IName { ... }
    /// class MyClass : IName { ... }
    /// </summary>
    public class Interfaces
    {
        public interface IMovable
        {
            void Move();
        }

        public interface IAttackable
        {
            void Attack();
        }

        public class Player : IMovable, IAttackable
        {
            public void Move()
            {
                Console.WriteLine("Гравець рухається вперед 🎮");
            }

            public void Attack()
            {
                Console.WriteLine("Гравець атакує мечем ⚔️");
            }
        }

        public class Enemy : IMovable
        {
            public void Move()
            {
                Console.WriteLine("Ворог пересувається до гравця 👾");
            }
        }

        public static void DemonstrateInterfaces()
        {
            Console.WriteLine("=== ІНТЕРФЕЙСИ ===\n");

            IMovable player = new Player();
            IAttackable attacker = new Player();
            IMovable enemy = new Enemy();

            player.Move();
            attacker.Attack();
            enemy.Move();
        }
    }

}
