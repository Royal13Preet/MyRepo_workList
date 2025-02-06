using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace lambdaexample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = new List<int>() { 4, 5, 6, 3, 2, 89, 9 };
            // foreach (var i in list1)
            // {
            //     Console.WriteLine(i);
            // }

            //    Console.WriteLine($"Before TrimExcess:");
            //    Console.WriteLine($"Count: {list1.Count}");
            //    Console.WriteLine($"Capacity: {list1.Capacity}");

            //    // Call TrimExcess to optimize memory usage
            //    list1.TrimExcess();


          
            //    Console.WriteLine($"\nAfter TrimExcess:");
            //    Console.WriteLine($"Count: {list1.Count}");
            //    Console.WriteLine($"Capacity: {list1.Capacity}");

            //    // Add more elements to see if the capacity adjusts automatically
            //    list1.Add(6);
            //    list1.Add(7);


            //Console.WriteLine($"\nAfter Adding More Elements:");
            //    Console.WriteLine($"Count: {list1.Count}");
            //    Console.WriteLine($"Capacity: {list1.Capacity}");

            //    Console.ReadLine();

            // var list2 = list1.Select(x => x * x);
            // foreach (var i in list2)
            // {
            //     Console.WriteLine(i);
            // }

            // var list3 = list1.FindAll(x => (x % 2) == 0);

            // foreach (var i in list3)
            // {
            //     Console.WriteLine(i);
            // }

            // var list4 = list1.Find(x => (x % 3) == 0);
            //Console.WriteLine(list4);

            // var list5 = list1.FindLast(x => (x % 2) != 0);
            // Console.WriteLine(list5);

            //var list6 = list1.FindIndex(x => (x%3) !=0);
            //Console.WriteLine(list6);

            var list7 = list1.Exists(x => (x % 3) == 0);
            Console.WriteLine(list7);
            //var list8 = list1.Contains(x => x %3 == 0);
            //Console.WriteLine(list8);


            //var list9 = list1.FindLastIndex(x => x == 67);
            //        Console.WriteLine(list9);




            
    }
}


}
    
