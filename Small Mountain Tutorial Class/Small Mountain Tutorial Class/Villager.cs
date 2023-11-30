using System;
using System.Collections.Generic;
using System.Text;

namespace Small_Mountain_Tutorial_Class
{
    class Villager : Creature , IAttackable, ITalkable
    {
        public Villager(string name)
        {
            this.name = name;
        }
        public string Talk()
        {
            return "hi";
        }

        public void Attack(Creature C)
        {
            C.Injured(10);
        }

        public string Talk(Creature C)
        {
            return "西捏" + C.GetName() + "花京院";
        }
    }
}
