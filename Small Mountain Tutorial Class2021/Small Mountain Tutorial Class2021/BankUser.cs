using System;
using System.Collections.Generic;
using System.Text;

namespace Small_Mountain_Tutorial_Class2021
{
    class BankUser
    {
        //Property
        public string Name;
        public int Money;
        //Method
        //public output型別  Method名稱(input型別 名稱)
        public BankUser(string Name, int Money) //Constructor 建構子
        {
            this.Name = Name;
            this.Money = Money;
        }
        public void BorrowMoney(BankUser OtherUser, int Money)
        {
            if (OtherUser.Money >= Money)
            {
                OtherUser.Money -= Money;
                this.Money += Money;
            }
           
        }

        public void RepayMoney(BankUser OtherUser, int Money)
        {
            if (this.Money >= Money)
            {
                OtherUser.Money += Money;
                this.Money -= Money;
            }
               
        }
    }
}
