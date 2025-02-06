using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class Employee
    {
        private decimal balance;

        public decimal Balance
        {
            get
            { return balance; }
        }

        public  Employee(decimal intialBalance)
        {
            if (intialBalance < 0)
            {
                throw new ArgumentException("erorr: Intial balance cannot be negative");
            }

            balance = intialBalance;

        }
        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Deposit amount should be positive");
            }
            balance += amount;
        }

        public void withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("withdrwal should be positive");
            }

            if (balance - amount < 0)
            {
                throw new ArgumentException("Insuffient funds");
            }

            balance -= amount;
        }
    }

    public class Employee1
    {
        public static void Main(string[] args)
        {
            Employee e = new Employee(500);

            e.Deposit(100);

            Console.WriteLine(e.Balance);

            e.withdraw(100);
            Console.WriteLine(e.Balance);

            Console.Read();
            
        }
    }



}