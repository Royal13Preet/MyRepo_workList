using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace HashTable1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            LinkedList<string> linkedList = new LinkedList<string>();
            linkedList.AddLast("One");
            linkedList.AddLast("Two");
            linkedList.AddLast("Three");
            linkedList.AddFirst("uhg");
            linkedList.AddLast("Four");
            linkedList.AddFirst("Five");
            linkedList.AddFirst("six");  //Added to first index
            Console.WriteLine("SortedDictionary Elements: ");
            foreach (var item in linkedList)
            {
                Console.WriteLine($"{item} ");
            }
            Console.ReadKey();

            //Hashtable obj = new Hashtable();
            //obj.Add(1, "df");
            //obj.Add(2, "fa");
            //obj.Add(6, "hf");
            //obj.Add(7, "eare");
            //obj.Add(457, "rwtgre");
            //obj.Add(3, "fej");
            //obj.Add(999, "srsr");
            //obj.Add(57, "eue");
            //obj.Add(65, "dthyt");
            //obj.Add(0, "dsg");
            //obj.Add(890, "7hr");

            //obj.Add("dfsaa", null);
            //Console.WriteLine(obj[334]);

            //foreach (DictionaryEntry e in obj)
            //{
            //    Console.WriteLine(e.Key + " " +e.Value);
            //}

        }
    }
}
