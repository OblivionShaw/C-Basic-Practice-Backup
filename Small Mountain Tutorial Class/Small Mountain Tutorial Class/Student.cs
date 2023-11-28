using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Small_Mountain_Tutorial_Class
{
    class Student
    {
        //Property
        public int StudentID;
        public string Name;
        public int Grade;

        public int Score;
        public static int PassScore;



        //Method
        //public output型別  Method名稱(input型別 名稱)

        public Student(int SID, string N, int G) //Constructor 建構子
        {
            StudentID = SID;
            Name = N;
            Grade = G;
            //MessageBox.Show("學生爹死");
        }

        public string Say()
        {
            return "我叫" + Name + ",我是" + Grade+"年級的學生";
        }

        public void UpGrade()
        {
            Grade++;
        }

        public string Talk(int g , string n)
        {
            return Grade + "年級的" + Name + "對"+ g + "年級的" + n + "說hi";
        }
        public string Talk(Student S)
        {
            return Grade + "年級的" + Name + "對" + S.Grade + "年級的" + S.Name + "說hi";
        }

        public bool isPass()
        {
            return Score > PassScore ? true : false;
        }
    }
}
