using System;
using System.Collections.Generic;
using System.Text;

namespace Small_Mountain_Tutorial_Class
{
    class Creature
    {
        protected int hp = 100;
        public string name;

        public virtual string Touch(Creature C)
        {
            return name + "摸了" + C.name;
        }

        public virtual string Move()
        {
            return name + "移動";
        }


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
