using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static StringAssignments.Pg;

namespace StringAssignments
{
    public class Student
    {
        public event DisplayMessage Pass;
        public event DisplayMessage Fail;



        public void AcceptMarks(int marks)
        {
            if (marks >= 40)
            {
                Pass();
            }
            else
            {
                Fail();
            }
        }


        static void PassMsg()
        {
            Console.WriteLine("Congratulations ! You are pass with good score");
        }

        static void FailMsg()
        {
            Console.WriteLine("OOPs ! You are Fail");
        }

        static void Main(string[] args)
        {
            Student stud = new Student();
            stud.Pass += new DisplayMessage(PassMsg);
            stud.Fail += new DisplayMessage(FailMsg);

            stud.AcceptMarks(30);

        }

    }

    public class Pg
        {

        public delegate void DisplayMessage();
        
    }
}
