using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace userdefines
{
    class student
    {
        int empid;
        long empsalary;

        public student()
        {
            empid = 10;
            empsalary = 2000;
        }

        public void display()
        {
            Console.WriteLine(empid);
            Console.WriteLine(empsalary);
        }
    }
    class stu
    {
        static void Main(string[] args)
        {
            student stud = new student();
            stud.display();
                
        }

    }
}
