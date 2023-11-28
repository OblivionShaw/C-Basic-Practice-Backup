using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Small_Mountain_Tutorial_Class2021
{
    public partial class Form1 : Form
    {
        BankUser Me ,Friend;
        public Form1()
        {
            InitializeComponent();
        }

        private void BorrowButton_Click(object sender, EventArgs e)
        {
                Me.BorrowMoney(Friend, 1000);
                UpdateMoney();
           
        }

        private void RepayButton_Click(object sender, EventArgs e)
        {
                Me.RepayMoney(Friend, 1000);
                UpdateMoney();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Me = new BankUser(User1Input.Text, 0);
            Friend = new BankUser(User2Input.Text, 5000);

            ConfigUserButton.Enabled = false;
            User1Input.Enabled = false;
            User2Input.Enabled = false;

            BorrowButton.Enabled = true;
            RepayButton.Enabled = true;

            User1NameText.Text = Me.Name;
            User2NameText.Text = Friend.Name;
            UpdateMoney();
            
        }

        private void UpdateMoney()
        {
            User1MoneyText.Text = "" + Me.Money;
            User2MoneyText.Text = "" + Friend.Money;
        }
    }
}
