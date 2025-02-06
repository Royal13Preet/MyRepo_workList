using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace calcidelegate
{
    public class Program
    {
        public int num1;
        public int num2;
        public void Cal()
        {
           
            Console.WriteLine("enter a number 1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter a number 2");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("1.Addition \n2.Substraction \n3.Multiplication \n4.Division \n");
            Console.WriteLine("Enter your choice:");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    add();
                    return;
                case 2:
                    sub();
                    break;
                case 3:
                    mul();
                    break;
                case 4:
                    div();
                    break;
                default:
                    Console.WriteLine("invalid input");
                    break;
            }
        }
        public void add()
        {
            Console.WriteLine("the addition");
            Console.WriteLine(num1 + num2);
        }
        public void sub()
        {
            Console.WriteLine("the substraction");
            Console.WriteLine(num2 - num1);
        }
        public void mul()
        {
            Console.WriteLine("the multiplication");
            Console.WriteLine(num1 * num2);
        }
        public void div()
        {
            Console.WriteLine("the division");
            Console.WriteLine(num1 / num2);
        }

    }
    public delegate void Dcal();
    
    public class test
    {
        static void Main(string[] args)
        {
            Program pg = new Program();
            Dcal obj = new Dcal(pg.Cal);
            obj();
            
        }

    }   

    
}
