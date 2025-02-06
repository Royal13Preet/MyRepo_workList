using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ArrayList1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ArrayList obj = new ArrayList();

            //// For inserting
            //obj.Add(1);
            //obj.Add(2);
            //obj.Add(67);
            //obj.Add(3);
            //obj.Add(8);
            //obj[3] = 78;
            //var dict = new Dictionary<int, String>();
            //dict.Add(1, "first");
            //dict.Add(1, "second");

            //foreach (char x in dict[1])
            //{
            //    Console.WriteLine(x);
            //}

            var items = new List<KeyValuePair<int, String>>();
            items.Add(new KeyValuePair<int, String>(1, "first"));
            items.Add(new KeyValuePair<int, String>(1, "second"));
            var lookup = items.ToLookup(kvp => kvp.Key, kvp => kvp.Value);

            foreach (string x in lookup[1])
            {
                Console.WriteLine(x);
            }


            ////// for removing the element

            ////obj.Remove(2);

            ////// for removing index element

            ////obj.RemoveAt(2);

            ////// for inserting element based on index

            ////obj.Insert(1,45);

            //////for elemnts is there are not

            ////bool a = obj.Contains(1);
            ////Console.WriteLine(a);

            //////for counting the element

            ////int a1 = obj.Count;
            ////Console.WriteLine("count"+a1);

            //////for clearing the entire list

            ////obj.Clear();

            //////for reversing the entire list

            ////obj.Reverse();

            //////for sorting an array ascending order

            ////obj.Sort();

            //////for finding the index of the element

            ////int aa = obj.IndexOf(67);
            ////Console.WriteLine(aa);

            //foreach (int i in obj)
            //{ 

            //    Console.WriteLine(i);

            //}
        }
    }
}
