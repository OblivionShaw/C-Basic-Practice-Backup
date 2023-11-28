using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Small_Mountain_Tutorial_Class9
{
    public partial class Form1 : Form
    {
        int Count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Count = 0;
            UpdateTimesLable();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Count++;
            UpdateTimesLable();
        }

        void UpdateTimesLable()
        {
            timesLable.Text = "已經按了 " + Count + " 下";
        }
    }
}
