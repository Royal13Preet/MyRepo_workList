using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sealedclass
{
    public class Employee
    {
        public int Eid, Eage;
        public string Ename, Eaddress;
        public virtual void GetEmployeeData()
        {

            Console.Write("Enter Employee ID:");
            Eid = int.Parse(Console.ReadLine());
            Console.Write("Enter Employee Name:");
            Ename = Console.ReadLine();
            Console.Write("Enter Employee Address:");
            Eaddress = Console.ReadLine();
            Console.Write("Enter Employee Age:");
            Eage = int.Parse(Console.ReadLine());
        }

        public virtual void DisplayEmployeeData()
        {
            Console.WriteLine("Emplpyee Details Are:");
            Console.WriteLine("Employee ID: " + Eid);
            Console.WriteLine("Employee Name: " + Ename);
            Console.WriteLine("Employee Address: " + Eaddress);
            Console.WriteLine("Employee Age: " + Eage);
        }
    }

    public sealed class Manager : Employee
    {
        double Bonus, Salary;
        public override void GetEmployeeData()
        {
            Console.WriteLine("Enter Manager Details:");
            Console.Write("Enter Manager ID:");
            Eid = int.Parse(Console.ReadLine());
            Console.Write("Enter Manager Name:");
            Ename = Console.ReadLine();
            Console.Write("Enter Manager Salary:");
            Salary = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Manager Bonus:");
            Bonus = double.Parse(Console.ReadLine());
        }
        public override void DisplayEmployeeData()
        {
            Console.WriteLine("Manager Details Are:");
            Console.WriteLine("Manager ID: " + Eid);
            Console.WriteLine("Manager Name: " + Ename);
            Console.WriteLine("Manager Salary: " + Salary);
            Console.WriteLine("Manager Bonus: " + Bonus);
        }
    }


    //public class Manager1 : Manager
    //{
    //}

    class Program
    {
        static void Main(string[] args)
        {
            Manager obj = new Manager();
            obj.GetEmployeeData();
            obj.DisplayEmployeeData();
            Console.ReadKey();
        }
    }
}
