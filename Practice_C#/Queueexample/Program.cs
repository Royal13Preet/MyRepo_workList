using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queueexample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue Exam = new Queue();
          
            Exam.Enqueue(6);
            Exam.Enqueue(5);
            Exam.Enqueue(3);
            Exam.Enqueue(4);
            Exam.Enqueue(2);
            //Console.Write("hfjdkh",Exam.Dequeue());
            Console.Write("hfdh",Exam.Peek());

            foreach (var item in Exam) { 
                Console.WriteLine(item);
            
            }
        }
    }
}
