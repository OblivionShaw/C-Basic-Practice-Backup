using System;
using System.Collections.Generic;
using System.Text;

namespace Small_Mountain_Tutorial_Class
{
    class Slime : AbstractMonster
    {
        protected override string Attack()
        {
            return "黏液攻擊";
        }
    }
}
