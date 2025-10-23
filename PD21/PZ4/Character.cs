using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ4
{
    internal abstract class Character: IDamageable
    {
        private int _health;
        private int _attackPower;

        public int Health => _health;
        public int AttackPower => _attackPower;
        public Character(int health, int attackPower)
        {
            _health = health;
            _attackPower = attackPower;
        }
        public void Attack(IDamageable target)
        {
            target.TakeDamage(_attackPower);
        }

        public virtual void TakeDamage(int damage)
        {
            _health -= damage;
            if (_health < 0) _health = 0;
            if (_health <= 0)
            {
                Die();
            }
        }

        protected abstract void Die();

    }
}
