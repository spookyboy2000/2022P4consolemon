using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolemonGame
{
    internal class Skill
    {
        private string name;
        private int damage;
        private int energyCost;

        internal Skill()
        {
            name = "firebreath";
            damage = 50;
            energyCost = 3;

        }

            internal void UseOn(Consolemon target, Consolemon caster)
            {
                caster.DepleteEnergy(energyCost);
                target.TakeDamage(damage);

            }
        internal Skill(int damage, string name, int energyCost)
        {
            this.damage = damage;
            this.name = name;
            this.energyCost = energyCost;
        }


    }
}
