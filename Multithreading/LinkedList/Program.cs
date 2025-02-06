using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    LinkedList<int> ab = new LinkedList<int>();
            //    ab.AddFirst(78);
            //    ab.AddFirst(890);
            //    ab.AddFirst(70);
            //    ab.AddFirst(79);
            //    ab.AddLast(9);
            //    ab.AddLast(9);
            //    ab.AddFirst(907);
            //    ab.AddLast(86666);
            //    ab.Remove(78);
            //    ab.RemoveFirst();

            
            //    LinkedListNode<int> node = ab.Find(9);
            //    ab.AddBefore(node, 908);


            //    ab.AddBefore(node, 890);
            //    foreach (int i in ab)
            //    {
            //        Console.WriteLine(i);
            //    }

            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Insert(0, 9);

            foreach (int i in list)
            {
                Console.WriteLine(i);
            }

        }
    }
}
