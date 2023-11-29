using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Small_Mountain_Tutorial_Class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hi");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int number, zero;
            number = 20;

            MessageBox.Show("number = " + number);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int number;

            number = 40 + 8;
            number = 40 - 8;
            number = 40 * 8;
            number = 40 / 8;
            number = 40 % 8;

            number = (40 + 20) * 2 - 30 / 15;


            MessageBox.Show("number = " + number);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            int level = 40;

            if (level > 30)
            {
                MessageBox.Show("等級達到");
            }
            else
            {
                MessageBox.Show("等級太低");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int i = 1;
            string text = "";
            while (i <= 9)
            {
                text += "9 * " + i + "= " + 9 * i + "\r\n";
                i++;
            }

            for (int j = 1; j <= 9; j++)
            {
                text += "9 * " + j + "= " + 9 * j + "\r\n";
            }

            MessageBox.Show(text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int Count = (int)RowChooser.Value;
            string text = "";
            for (int i = 1; i <= Count; i++)
            {
                text += i + "=";
                for (int j = 1; j <= i; j++)
                {
                    text += "*";
                }
                text += "\r\n";

            }
            MessageBox.Show(text);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Student Jack = new Student(1, "牛逼阿換", 1);
            Jack.StudentID = 0;
            Jack.Name = "牛逼阿換";
            Jack.Grade = 6;
            MessageBox.Show(Jack.Say());
        }


        private void button8_Click(object sender, EventArgs e)
        {
            Student Jack = new Student(1, "牛逼阿換", 1);
            Jack.StudentID = 0;
            Jack.Name = "牛逼阿換";
            Jack.Grade = 6;
            MessageBox.Show(Jack.Say());
            Jack.UpGrade();
            MessageBox.Show(Jack.Say());
            MessageBox.Show(Jack.Talk(4, "Loli"));
            Student Loli = new Student(1, "牛逼阿換", 1);
            Loli.StudentID = 1;
            Loli.Name = "Loli";
            Loli.Grade = 1;
            MessageBox.Show(Jack.Talk(Loli.Grade, Loli.Name));
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int Geade = 1;
            Student Jack = new Student(1, "牛逼阿換", Geade);
            Student Loli = new Student(1, "Loli", Geade);
            Jack.UpGrade();
            MessageBox.Show(Jack.Say());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            int[] array1 = { 8, 12, 6, 14, 4, 16 };
            int T = 24;
            string Text = string.Join(",", TwoSumHashOnePass(array1, T)); ;
            MessageBox.Show(Text);
            //MessageBox.Show(""+TwoSum(array1, T));
        }

        public int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                        return new[] { i, j };
                }
            }


            return null;
        }

        public int[] TwoSumHashOnePass(int[] nums, int target)
        {

            Dictionary<int, int> HashTable = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                string Text = string.Join(",", HashTable); ;
                int half = target - nums[i];
                MessageBox.Show("目標：" + target + "當前數字：" + nums[i] + "目標減當前：" + half + "前後相加：" + (nums[i] + half).ToString() + "目前表已有" + Text);
                if (HashTable.ContainsKey(half))
                    return new int[] { HashTable[half], i };
                HashTable[nums[i]] = i;
            }
            return new int[] { };
        }
        public string tEST()
        {
            string Text = "";
            Dictionary<int, string> HashTable = new Dictionary<int, string>();
            HashTable.Add(0, "牛B");
            HashTable.Add(1, "阿換");
            HashTable.Add(2, "挖她路");

            return HashTable[0] + HashTable[1] + HashTable[2];
        }

        private void button11_Click(object sender, EventArgs e)
        {
            MessageBox.Show(tEST());
        }

        private void button12_Click(object sender, EventArgs e)
        {
            User U = new User("Jack", "123");
            string result = U.ComparePassword("12") ? "密碼正確" : "密碼錯誤";
            MessageBox.Show(result);
            MessageBox.Show(U.GetUserName());
            U.Hurt(25);
            MessageBox.Show("" + U.GetUserHP());
        }

        private void button13_Click(object sender, EventArgs e)
        {
            User U = new User("Jack", "123");
            MessageBox.Show("" + U.HP);
            U.HP = -10;
            MessageBox.Show("" + U.HP);
            MessageBox.Show("" + U.Money);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Villager V = new Villager("V1");
            Monster M = new Monster("M1");
            Monster M2 = new Monster("M2");
            MessageBox.Show("" + V.Talk());
            MessageBox.Show("" + V.GetHP());
            M.Attack(V);
            MessageBox.Show("" + V.GetHP());
            M.Attack(M2);
            MessageBox.Show("" + M2.GetHP());
        }

        private void button15_Click(object sender, EventArgs e)
        {
            int Power = 100;

            Random r = new Random();

            int Injured = r.Next(Power / 2, Power);

            MessageBox.Show("受到傷害：" + Injured);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Villager V = new Villager("V1");
            Monster M = new Monster("M1");

            MessageBox.Show(V.Touch(M));
            MessageBox.Show(V.Move());

            MessageBox.Show(M.Touch(V));
            MessageBox.Show(M.Move());
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Fruit F = new Fruit("水果");
            Fruit A = new Apple("蘋果");
            Fruit FO = new Orange();
            Orange OO = new Orange();

            MessageBox.Show("F：" + F.Say() + "\r\n" + "A：" + A.Say() + "\r\n" + "FO：" + FO.Say() + "\r\n" + "OO：" + OO.Say() + "\r\n" + "OO：" + OO.Say2());
        }

        private void button18_Click(object sender, EventArgs e)
        {
            int[,] A = new int[,] { { 5, 6 }, { 7, 8 } };
            int[,] B = new int[,] { { 1, 2 }, { 3, 4 } };
            int[,] result = Add(A,B);
            MessageBox.Show("矩陣相加" + " 00:" + result[0, 0] + " 01:" + result[0, 1] + " 10:" + result[1, 0] + " 11:" + result[1, 1]);
            result = Subtract(A, B);
            MessageBox.Show("矩陣相減" + " 00:" + result[0, 0] + " 01:" + result[0, 1] + " 10:" + result[1, 0] + " 11:" + result[1, 1]);
            result = Multiply(A, B);
            MessageBox.Show("矩陣相乘" + " 00:" + result[0, 0] + " 01:" + result[0, 1] + " 10:" + result[1, 0] + " 11:" + result[1, 1]);
        }
        private int[,] Add(int[,] a, int[,] b)
        {
            int[,] result = new int[2,2];
            for (int x = 0; x < a.GetLength(0); x++)
            {
                for (int y = 0; y < b.GetLength(1); y++)
                {
                    //MessageBox.Show("X" + x + "Y" + y);
                    result[x, y] = a[x, y] + b[x, y];
                }
            }
            return result;
        }

        private int[,] Subtract(int[,] a, int[,] b)
        {
            int[,] result = new int[2, 2];
            for (int x = 0; x < a.GetLength(0); x++)
            {
                for (int y = 0; y < b.GetLength(1); y++)
                {
                    //MessageBox.Show("X" + x + "Y" + y);
                    result[x, y] = a[x, y] - b[x, y];
                }
            }
            return result;
        }
        private int[,] Multiply(int[,] a, int[,] b)
        {
            int[,] result = new int[2, 2];
            for (int x = 0; x < a.GetLength(0); x++)
            {
                for (int y = 0; y < b.GetLength(1); y++)
                {
                    for (int z = 0; z < a.GetLength(1); z++)
                    {
                        result[x, y] += a[x, z] * b[z, y];
                    }
                }
            }
            return result;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            //pictureBox1.Image = Resources.Black.png;
        }

        //void TESTT(int[] nums)
        //{
        //    int[] Array = new Array[nums];
        //    int Sum = 0;
        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        Sum += nums[i]
        //        Array[i] = Sum
        //    }
        //}
    }
}
