using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Func<int, int> square = x => x * x;
            // Console.WriteLine(square(5));

            //Func<int, int> fact = x => {
            //     int result = 1;
            //     for (int i = 1; i <= x; i++)
            //     {
            //         result *= i;
            //     }
            //     return result;
            // };
            // Console.WriteLine(fact(5));

            List<int> a = new List<int>() { 67, 3, 36, 35 };
            //var list1 = a.FindAll(x => x % 2 == 0);
            //foreach (var x in list1) { 
            //    Console.WriteLine(x);

            //}
            //var list3 = a.Select(x => x * x);
            //foreach (var i in list3)
            //{
            //    Console.WriteLine(i);
            //}

            //var list4 = a.Find(x => (x % 3) == 0);
            //Console.WriteLine(list4);
            var list6 = a.FindIndex(x => (x%3) ==0);
            Console.WriteLine(list6);

        }



    }
}
