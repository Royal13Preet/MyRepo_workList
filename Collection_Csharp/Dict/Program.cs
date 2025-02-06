using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dict
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            var vegetab = new Dictionary<string, int>();


            vegetab.Add("potato", 8);
            vegetab.Add("onion", 9);
            vegetab.Add("garlic", 80);
            vegetab.Add("dhskh", 9);

            //vegetab["potato"] = 1;
            //var gen = new Dictionary<string, int>(vegetab);

            foreach (var item in vegetab)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }

            //var vegetab1 = new Dictionary<string, int>();

            //vegetab1.Add("potato", 8);
            //vegetab1.Add("onion", 9);
            //vegetab1.Add("garlic", 80);

            //bool gf = vegetab.Equals(vegetab1);
            //Console.WriteLine(gf);


            //Console.WriteLine("get type" + vegetab.GetType());
            //Console.WriteLine("get code" + vegetab.GetHashCode());

            //Console.WriteLine(vegetab.ContainsKey("potato"));
            //Console.WriteLine(vegetab.ContainsValue(8));




            //Console.WriteLine();


            //foreach (var entry in vegetab) 
            //{ 
            //    Console.WriteLine(entry.Key+ " " +entry.Value);
            //}

            //var list1 = vegetab.ToList();
            //foreach (var item in list1)
            //{
            //    Console.WriteLine(item.Key + " " + item.Value);
            //}

         

            Console.ReadLine();


        }
    }
}
