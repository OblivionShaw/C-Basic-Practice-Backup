using System;
using System.Collections.Generic;
using System.Text;

namespace Small_Mountain_Tutorial_Class
{
    class Creature
    {
        private int hp = 100;

        public int GetHP()
        {
            return hp;
        }

        public void Injured(int InjuredPoint)
        {
            hp -= InjuredPoint;
        }
    }
}
