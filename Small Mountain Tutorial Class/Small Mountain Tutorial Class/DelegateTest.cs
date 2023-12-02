using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Small_Mountain_Tutorial_Class
{
    internal class DelegateTest
    {
        public delegate int Calcululate(int x , int y);
        public Calcululate myCalcululateMethod;


        public string DoCalcululate(int x, int y,Calcululate cal)
        {
            float result = cal(x, y);
            MessageBox.Show("cal:+" + x + y);
            return result.ToString();
        }

        public int Add(int x, int y)
        {
            MessageBox.Show("Add:+" + x + y);
            return x + y;
        }

        public int Multiply(int x, int y)
        {
            MessageBox.Show("Multiply:+" + x * y);
            return x * y;
        }
    }
}
