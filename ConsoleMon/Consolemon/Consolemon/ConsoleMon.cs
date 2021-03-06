using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolemonGame
{
    internal class Consolemon
    {
        private string type;
        private int hp;
        private int defense;

        internal Consolemon()
        {
            type = "dragon";
            hp = 250;
            defense = 15;
        }
            internal void TakeDamage(int damage)
            {
                hp -= damage;
            }

            internal void DepleteEnergy(int energy)
            {
                energy -= energy;
            }
        
        
        internal Consolemon(int hp, string type, int defense)
        {
            this.hp = hp;
            this.type = type;
            this.defense = defense;
        }

        internal void Damage(int damage)
        {
            int damageAfterDefense = damage - defense;
            hp -= defense;
        }

        internal void SetHp(int hp)
        {
            this.hp = hp;
        }
    }
}
