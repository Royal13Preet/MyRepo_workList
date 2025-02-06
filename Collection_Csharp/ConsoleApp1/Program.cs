using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();

            // For adding the elements to the stack
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);

            //It displays topitem without removing

            //int top = (int)stack.Peek();
            //Console.WriteLine(top);

            ////It removes the topmost items

            //stack.Pop();
            //stack.Pop();

            ////It makes stack as empty

            //stack.Clear();

            //stack.Push(789);

            //// it tell us to the item is present or not
            //bool a = stack.Contains(1);
            //Console.WriteLine(a);

            // Clone the stack
            Stack clonedStack = (Stack)stack.Clone();

            // Display the original stack
            Console.WriteLine("Original Stack:");
            foreach (object item in stack)
            {
                Console.WriteLine(item);
            }

            // Display the cloned stack
            Console.WriteLine("Cloned Stack:");
            foreach (object item in clonedStack)
            {
                Console.WriteLine(item);
            }

            // Remove an item from the original stack
            stack.Pop();
            clonedStack.Pop();
            clonedStack.Pop();
            

            // Display the original and cloned stacks after popping
            Console.WriteLine("After popping from the original stack:");
            Console.WriteLine("Original Stack:");
            foreach (object item in stack)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Cloned Stack:");
            foreach (object item in clonedStack)
            {
                Console.WriteLine(item);
            }
            
            

                

               
        }
    }

}

