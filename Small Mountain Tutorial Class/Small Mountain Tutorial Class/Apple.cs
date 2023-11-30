using System;
using System.Collections.Generic;
using System.Text;

namespace Small_Mountain_Tutorial_Class
{
    class Apple : Fruit
    {
        public Apple(string name) : base(name)
        {
            base.name = name;
        }

        public override string Say()
        {
            return "我是蘋果";
        }

    }
}
