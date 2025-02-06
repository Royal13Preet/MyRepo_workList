using System;

namespace Enumdays
{
    enum days
    {
        Monday,
        Tuesday,
        Wednesday = 90,
        thursday,
        Friday,
        Saturday = 90,
        sunday
    }


    internal class Program
    {
        static void Main(string[] args)
        {

            foreach (days day in Enum.GetValues(typeof(days)))
            {
                Console.WriteLine($"{day} = {(int)day}");
            }




            Console.ReadLine();

        }
    }

}








