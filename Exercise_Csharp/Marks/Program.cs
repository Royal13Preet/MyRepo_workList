using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marks
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int rollnum;
            int m1, m2,m3;
            string name;
            Console.WriteLine("Enter a Roll Number");
            rollnum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter your name");
            name = Console.ReadLine();
            Console.WriteLine("Enter your subject 1 marks ");
            
            m1 = Convert.ToInt32(Console.ReadLine());
            if(m1 > 100)
            {
                Console.WriteLine("Give a valid marks it should be below hundred");
                m1 = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Enter your subject 2 marks ");
           
            m2 = Convert.ToInt32(Console.ReadLine());
            if (m2 > 100)
            {
                Console.WriteLine("Give a valid marks it should be below hundred");
                m2 = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Enter your subject 3 marks ");
            m3 = Convert.ToInt32(Console.ReadLine());
            if (m3 > 100)
            {
                Console.WriteLine("Give a valid marks it should be below hundred");
                m3 = Convert.ToInt32(Console.ReadLine());
            }
            int total = m1 + m2 + m3;
            float p = total / 3.0f;

            Console.WriteLine("The total marks :" + total);
            Console.WriteLine("the total percentage is :" +p);
            if (p > 35 && p < 50)
            {
                Console.WriteLine("the grad is C");
            }
            else if (p > 50 && p < 75)
            {
                Console.WriteLine("the grade is B");

            }
            else if (p > 75 && p < 90)
            {
                Console.WriteLine("the grade is A");
            }
            else if (p > 90 && p < 100)
            {
                Console.WriteLine("The grade is A+");
            }
            else
            {
                Console.WriteLine("you fail");
            }

        }
    }
}
