using System;
using System.Collections.Generic;
using System.Text;

namespace Small_Mountain_Tutorial_Class
{
    class Player : Creature , IAttackable , ITalkable
    {
        public void Attack(Creature C)
        {
            C.Injured(30);
        }

        public string Talk(Creature C)
        {
            return "看來必須制裁" + C.GetName();
        }

    }
}
