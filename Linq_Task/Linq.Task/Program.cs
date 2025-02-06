using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.Task
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string> { "Preet", "khushi", "pooja", "Navee", "Kavya" };
           
            // Adding single items
            list.Add("Abhi");

            // Adding multiple items using AddRange (use a collection like an array or another list)
            list.AddRange(new string[] { "sfhk", "sdgygf" });

            // Using All to check if all elements meet a condition
            bool allStartWithK = list.All(name => name.StartsWith("K"));
            Console.WriteLine("All names start with 'K': " + allStartWithK);

            // Using Any to check if any element meets a condition
            bool anyContainsY = list.Any(name => name.Contains("y"));
            Console.WriteLine("Any name contains 'y': " + anyContainsY);

            // Using Count to get the total number of elements
            int count = list.Count();
            Console.WriteLine("Total count: " + count);

            // Using Contains to check if a specific element exists
            bool containsSda = list.Contains("poo");
            Console.WriteLine("List contains 'poo': " + containsSda);

            // Using FindAll to filter elements based on a condition
            List<string> namesWithLength5 = list.FindAll(name => name.Length == 5);
            foreach (string name in namesWithLength5) 
            {
                Console.WriteLine(name);
            }
            list.InsertRange(2, new List<string> { "Added1", "Added2" });

            list.Clear();

            list.Sort();

            list.Reverse();


        }

    }
}
