using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMtransaction
{
    public class Program
    {
        static void Main(string[] args)
        {
            int amount = 10000, deposit, withdraw;
            int choice = 0;
            int pin = 0;
            
            Console.WriteLine("Enter your Pin Number");
            pin = Convert.ToInt32(Console.ReadLine());
            
            while (true)
            {
               
                Console.WriteLine("-----ATM transaction------");
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Balance");
                Console.WriteLine("4. Quit\n");
                Console.WriteLine("----------***-----------");
                Console.WriteLine("Enter your choice");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                   
                    case 1:
                        Console.WriteLine("Enter the amount of deposit");
                        deposit = Convert.ToInt32(Console.ReadLine());
                        amount = amount + deposit;
                        Console.WriteLine("your amount is deposited succesfully");

                        break;
                    case 2:
                        Console.WriteLine("enter the amount of withdraw");
                        withdraw = Convert.ToInt32(Console.ReadLine());
                        if (withdraw % 100 != 0)
                        {
                            Console.WriteLine("please enter the amount in multiples of 100");

                        }
                        else if (withdraw > amount)
                        {
                            Console.WriteLine("Insuffiesent balance");
                        }
                        
                        else
                        {
                            amount = amount - withdraw;
                            Console.WriteLine("please collect your cash\n ");
                        }
                        break;
                    case 3:
                        Console.WriteLine("The Balance is" + amount);
                        break;
                    case 4:
                        Console.WriteLine("Thank you for using our ATM.");
                        return;
                    
                    
                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                    


                   
                }
               
            }

           

        }
       
    }
}