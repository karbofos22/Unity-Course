using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_5
{
    internal class Enemy
    {
        public string Name { get; set; }
        public int Hp { get; set; }

        public int TakeDamage(int damageAmount)
        {
             return Hp-=damageAmount;
        }
    }
}
