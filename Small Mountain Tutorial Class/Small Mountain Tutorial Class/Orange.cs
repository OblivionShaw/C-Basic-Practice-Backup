using System;
using System.Collections.Generic;
using System.Text;

namespace Small_Mountain_Tutorial_Class
{
    class Orange : Fruit
    {
        public Orange() : base("橘子")
        {
        }

        public new string Say()
        {
            return "我是橘子";

        }

        public string Say2()
        {
            return base.Say();

        }


        
    }
}
