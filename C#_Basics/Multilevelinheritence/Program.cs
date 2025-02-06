using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Multilevelinheritence
{
    public class Branch
    {
        public int branchcode;

        public string branchname, branchaddress;

        //public Branch(int branchcd, string branchnm, string branchadrs)
        //{
        //    branchcode = branchcd;
        //    branchname = branchnm;
        //    branchaddress = branchadrs;
        //}

        public void GetDisplay()
        {
            Console.Write(branchcode + ",");
            Console.Write(branchname + ",");
            Console.Write(branchaddress + ",");
        }
    }
    public class Employee : Branch
    {
        public int employeeid, employeeage;
        public string employeename, employeeaddress;

        //public Employee(int empid, int empage, string empname, string empadr, int branchcd, string branchnm, string branchadrs)
        //{
        //    employeeaddress = empadr;
        //    employeeid = empid;
        //    employeeage = empage;
        //    employeename = empname;
        //    branchcode = branchcd;
        //    branchname = branchnm;
        //    branchaddress = branchadrs;
        //}

        public void GetDisplayEmployee()
        {
            Console.Write(employeeid+ ", ");
            Console.Write(employeeage + " ,");
            Console.Write(employeeaddress + ",");
            Console.Write(employeename + ",");
        }


    }

    public class Salary : Employee
    {
        double hrs, basical, dallow, grossSalary;
        public Salary( int empid, int empage, string empname, string empadr, double bas, int branchcd, string branchnm, string branchadrs) 
        {
            employeeaddress = empadr;
            employeeid = empid;
            employeeage = empage;
            employeename = empname;
            branchcode = branchcd;
            branchname = branchnm;
            branchaddress = branchadrs;
            basical = bas;
            
        }

        public void CalculateSalary()
        {
            hrs = .3 * basical;
            dallow = .4 * basical;
            grossSalary = hrs + dallow + basical;
        }

        public void GetCalculateSalry()
        {
            
            Console.Write(grossSalary + " ");
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Salary s = new Salary(1001,21,"preet","banglore",25000,57143, "HDFC","hoodi");
            //
            s.CalculateSalary();
            s.GetDisplayEmployee();
            s.GetDisplay();
            s.GetCalculateSalry();


            Console.ReadKey();
        }
    }

       
    
}
