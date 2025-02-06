using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primerange
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //int prime = Convert.ToInt32(Console.ReadLine());
            
            int i,j;
            for(i= 0; i <= 100; i++)
            {
                int count = 0;
                for ( j = 1; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                    }
                    
                }
                if (count == 1)
                {
                    Console.WriteLine(i);
                }


            }
            


        }
    }
}
