using System;

namespace multilevel
{
    public class Branch
    {
        public int BranchCode;
        public string Branchname;


        public Branch()
        {
            Console.WriteLine("Enter the name of an Branchcode");
            BranchCode = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the name of an branch:");
            Branchname = Console.ReadLine();
        }
    }

    class Employee : Branch
    {
        public int EmployeeId;
        public string EmployeeName;
        public int EmployeeAge;
        public string EMployeeaddress;

        public Employee() : base()
        {
            Console.WriteLine("Enter the EmployeeId:");
            EmployeeId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the EmployeeName:");
            EmployeeName = Console.ReadLine();
            Console.WriteLine("Enter the EmployeeAge:");
            EmployeeAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a Employeeaddress");
            EMployeeaddress = Console.ReadLine();
        }

       
        public void Display()
        {
            Console.WriteLine (BranchCode);
            Console.WriteLine(Branchname);
            Console.WriteLine(EmployeeId);
            Console.WriteLine(EmployeeName);
            Console.WriteLine(EmployeeAge);
            Console.WriteLine(EMployeeaddress);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Employee b = new Employee();
            b.Display();
        }
    }
}
