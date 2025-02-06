using System;


namespace calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, welcome to the calculator program!");
            Console.WriteLine("Please enter your first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter your second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What type of operation you like do!");
            Console.WriteLine("Please enter: a for addition, s for subrtraction, m for multiplication, press any other key for division");
            string output = Console.ReadLine();
            int result;
            if (output == "a")
            {
                result = num1 + num2;
                
            }
            else if (output == "s")
            {
                result = num1 - num2;
            } 
            else if(output == "m")
            {
                result = num1 * num2;

            }
            else
            {
                result = num1 / num2;
            }
            Console.WriteLine("the result is" + result);
            Console.WriteLine("Thank you!!");
            Console.ReadKey();
        }
    }
}
