using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parameterized
{
    class Employee

    {
        int empsal, empid;
        string empname, empdepartment;

        public Employee(int sal, int id, string name, string department)
        {
            empsal = sal;
            empid = id;
            empname = name;
            empdepartment = department;
        }

        public void Display()
        {
            Console.WriteLine("emp id" + empid);
            Console.WriteLine("empsal" + empsal);
            Console.WriteLine("employee department" + empdepartment);
            Console.WriteLine("employee name" + empname);
        }

        class employee1
        {
            static void Main(string[] args)
            {
                Employee emp = new Employee(343532, 45, "preet", "c#");
                emp.Display();

            }

        }

    }
}
