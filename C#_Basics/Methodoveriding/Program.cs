using System;
using System.Security.Cryptography.X509Certificates;
namespace Methodoveriding
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }

        public double Salary;

        public virtual double CalculateSalaryBonus(double Salary)
        {
            return 50000;
        }
    }

    public class Developer : Employee
    {
        
        public override double CalculateSalaryBonus(double salary)
        {
            double basesal = base.CalculateSalaryBonus(Salary);
            double calculatesal = Salary * 0.20;
            if (calculatesal <= basesal)
            {
                return basesal;
            }
            else
            {
                return calculatesal;
            }
        }
    }

    public class Manager : Employee
    {
       
        public override double CalculateSalaryBonus(double Salary)
        {
            
            double basesal = base.CalculateSalaryBonus(Salary);
            double calculatesal = Salary * 0.25;
            if (calculatesal <= basesal)
            {
                return basesal;
            }
            else
            {
                return calculatesal;
            }
        }

    }
    public class Admin : Employee
    {
        public override double CalculateSalaryBonus(double salary)
        {
            return 50000;
        }
    }
  
    class main
    {
        public static void Main(string[] args)
        {
            Employee emp = new Developer
            {
                Id = 101,
                Name = "preet",
                Designation = "Developer",
                Salary = 289000
            };

            Employee emp1 = new Manager
            {
                Id = 102,
                Name = "khushi",
                Designation = "Manager",
                Salary = 978790
            };
            Employee emp2 = new Admin
            {

                Id = 102,
                Name = "khus",
                Designation = "Admin",
                Salary = 50000
            };
        
            double bonus = emp.CalculateSalaryBonus(emp1.Salary);
            Console.WriteLine(emp1.CalculateSalaryBonus(emp1.Salary));
            Console.WriteLine(bonus);
            Console.WriteLine(emp2.CalculateSalaryBonus(emp2.Salary));
            Console.ReadKey();
            
        }
    }
   
}