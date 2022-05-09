using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolemon
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
    }
}
