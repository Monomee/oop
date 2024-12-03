using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMethod
{
    public class Student
    {
        private int rollno;
        private string name;
        private static string college = "BBDIT";

        public Student(int r, string n)
        {
            rollno = r;
            name = n;
        }


        public static void Change()
        {
            college = "CODEGYM";
        }

        public void Display()
        {
            Console.WriteLine(rollno + " " + name + " " + college);
        }
    }
}
