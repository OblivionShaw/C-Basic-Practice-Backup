using System;
using System.Collections.Generic;
using System.Text;

namespace Small_Mountain_Tutorial_Class
{
    class User
    {
        private string UserName;
        private string Password;

        private int Count1, Count5, Count10;

        private int hp;
        public int HP
        {
            get { return hp; }
            set { hp = value < 0 ? hp = 0 : hp = value; }
            
        }
        public int Money
        {
            get { return Count1 + Count5*5 + Count10 * 10; }

        }



        public int GetUserHP()
        {
            return hp;
        }


        public void Hurt(int DecreaseHP)
        {
            hp = hp >= DecreaseHP ? hp -= DecreaseHP : hp = 0;

        }

        public User(string UserName , string UserPassword)
        {
            this.UserName = UserName;
            Password = UserPassword;
            hp = 50;
            Count1 = 1;
            Count5 = 1;
            Count10 = 1;
        }

        public bool ComparePassword(string TargetPassWord)
        {
            return Password == TargetPassWord ? true : false;
        }

        public void Reset()
        {
            Password = "";
        }

        public string GetUserName()
        {
            return UserName;
        }

    }
}
