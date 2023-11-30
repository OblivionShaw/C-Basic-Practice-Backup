using System;
using System.Collections.Generic;
using System.Text;

namespace Small_Mountain_Tutorial_Class
{
    class Fruit
    {
        protected string name;
        public Fruit(string name)
        {
            this.name = name;
        }

        public virtual string Say()
        {
            return "我是水果";
        }

        public string GetName()
        {
            return name;
        }

    }
}
