using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trycatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Format exception
            try
            {
                Console.Write("Enter a number: ");
                int number = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }

            //IndexOutException
            int[] arr = { 6, 8, 64, 3, 9, 2 };
            try
            {
                for (int i = 0; i <= arr.Length; i++)
                    Console.WriteLine(arr[i]);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);

            }
            //DividedByZeroException
            try
            {
                Console.WriteLine("enter the number");
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                int result = a / b;
                int[] ar = { 1, 2, 3, 4, 5 };
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Divided by zero is not possible");

            }

            //NullReference
            try
            {
                string str = null;
                Console.WriteLine(str.Length);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            ////overflowexceptoion

            //try
            //{
            //    int largeValue = int.MaxValue;
            //    largeValue = largeValue + 78;
            //    Console.WriteLine(largeValue);
            //}
            //catch (OverflowException ex)
            //{
            //    Console.WriteLine("Error: " + ex.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("we are in final block");
            //}

        }
    }
}