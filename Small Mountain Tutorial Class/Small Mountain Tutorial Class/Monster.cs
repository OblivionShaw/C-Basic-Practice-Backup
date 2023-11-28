using System;
using System.Collections.Generic;
using System.Text;

namespace Small_Mountain_Tutorial_Class
{
    class Monster : Creature
    {
        public void Attack(Creature C)
        {
            C.Injured(10);
        }
    }
}
