using System;
using System.Collections.Generic;
using System.Text;

namespace Small_Mountain_Tutorial_Class
{
    class Monster : Creature
    {
        int hp = 100;
        public Monster(string name)
        {
            hp = 50;
            this.hp = 50;
            base.hp = 50;
            this.name = name;
        }
        public void Attack(Creature C)
        {
            C.Injured(10);
        }
        public override string Touch(Creature C)
        {
            return name + "不能摸" + C.name;
        }

        public override string Move()
        {
            return name + "跳走";
        }
    }


}
