using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ReverseEntire
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///----reverse-----
            //string a = "My Name is X Y Z";
            //string rev = "";
            //for (int i = 0; i < a.Length; i++) 
            //{
            //    rev = a[i] + rev;
            //}
            //Console.WriteLine(rev);

            ///--fibonoccie---

            //int num = Convert.ToInt32(Console.ReadLine());
            //int[] fib = new int[num];
            //int a = 0;
            //int b = 1;
            //int res = 0;


            //for (int i = 0; i < num; i++)
            //{
            //    fib[i] = a;
            //    //Console.WriteLine(res);
            //   // Console.WriteLine();
            //    res = a + b;
            //    a = b;
            //    b = res;
            //}
            //for (int i = num - 1; i >= 0; i--)
            //{
            //    Console.WriteLine(fib[i]);
            //}

            //----Palindrome
            //string aa = Console.ReadLine();
            //string rev = "";
            //for (int i = 0; i < aa.Length; i++) 
            //{
            //    rev = rev + aa[i];
            //}
            //if(rev == aa)
            //{
            //    Console.WriteLine("palindrome");

            //}
            //else
            //{
            //    Console.WriteLine("not");
            //}

            //---Reverse the word
            //string rev = "Hi from Canada";
            //string[] aa = rev.Split(' ');
            //string result = "";
            //for (int i = aa.Length - 1; i >= 0; i--)
            //{
            //    result += aa[i];
            //    if (i > 0)
            //    {
            //        result += " ";
            //    }
            //}
            //Console.WriteLine(result);

            //--count the occurence
            //string aa = "Hello";
            //Dictionary<char,int> dic = new Dictionary<char,int>();

            //foreach(char c in aa)
            //{
            //    if (dic.ContainsKey(c))
            //    {
            //        dic[c]++;
            //    }
            //    else
            //    {
            //        dic[c] = 1;
            //    }
            //}
            //foreach (var c in dic) 
            //{
            //    Console.WriteLine(c);
            //}




            //removeduplicates
            //string duplicates = "Preethugowda";
            //string remove = "";
            //for(int i = 0; i<duplicates.Length; i++)
            //{
            //    if (!remove.Contains(duplicates[i]))
            //    {
            //        remove += duplicates[i];
            //    }
            //}
            //Console.WriteLine(remove);

            //Find all substring
            //string aa = "abcd";
            //for (int i = 0; i < aa.Length; i++)
            //{
            //    string sub = "";
            //    for (int j = i; j < aa.Length; j++)
            //    {
            //        sub += aa[j]; 
            //        Console.WriteLine(sub);
            //    }
            //}

            //Left Rotation
            //int size = Convert.ToInt32(Console.ReadLine());
            //int[] array = new int[] {1,2,3,4,5};
            //for (int i = 0; i <= size; i++) 
            //{
            //    int temp = array[size - 1];
            //    array[array.Length - 1] = array[i - 1];
            //    array[i-1] = temp;

            //}
            //foreach (int i in array) 
            //{
            //    Console.WriteLine(i);
            //}

            //int size = Convert.ToInt32(Console.ReadLine());
            //int[] array = new int[] { 1, 2, 3, 4, 5 };

            //size = size % array.Length; 
            //int[] rotatedArray = new int[array.Length];


            //for (int i = 0; i < array.Length; i++)
            //{
            //    int newIndex = (i + array.Length - size) % array.Length;
            //    rotatedArray[newIndex] = array[i];
            //}


            //foreach (int i in rotatedArray)
            //{
            //    Console.Write(i);
            //}


            //int[] array = new int[] { 1, 2, 3, 4, 5 };
            //int size = Convert.ToInt32(Console.ReadLine());
            //int temp;
            //for (int j = 0; j < size - 1; j++)
            //{
            //    temp = array[0];
            //    array[0] = array[j + 1];
            //    array[j + 1] = temp;
            //}
            //foreach (int num in array)
            //{
            //    Console.Write(num + " ");
            //}

            //int prime = Convert.ToInt32(Console.ReadLine());
            //int Count = 0;
            //for(int i = 1; i < prime/2; i++)
            //{
            //    if(prime % i == 0)
            //    {
            //        Count++;
            //    }
            //}
            //if (Count == 1) 
            //{
            //    Console.WriteLine("prime");
            //}
            //else
            //{
            //    Console.WriteLine("Not Prime");
            //}

            //sum of positive integer
            //int num = Convert.ToInt32(Console.ReadLine());
            //int sum = 0;
            //while (num > 0) 
            //{
            //    sum += num % 10;
            //    num /= 10;
            //}
            //Console.WriteLine(sum);


            //second biggest intege
            //int[] array = { 2, 3, 4, 2, 12, 23, 31, 21, 24 };
            //int big = array[0];
            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (array[i] > big)
            //    {
            //        big = array[i];
            //    }
            //}
            //int Secondbig = array[0];
            //for (int i = 0; i < array.Length; i++) 
            //{
            //    if(array[i] != big & array[i] > Secondbig)
            //    {
            //        Secondbig = array[i];
            //    }
            //}
            //Console.WriteLine("Second Biggest array" +Secondbig);


            //using one loop
            //int[] array = { 2, 3, 4, 2, 12, 24,23, 31, 21 };
            //int Max1 = int.MinValue;
            //int Max2 = int.MinValue;
            //int Max3 = int.MinValue;    

            //foreach (int i in array) 
            //{
            //    if (i > Max1)
            //    {
            //        Max3 = Max2;
            //        Max2 = Max1;
            //        Max1 = i;
            //    }
            //    else if (i >= Max2 && i != Max1)
            //    {
            //        Max3 = Max2;
            //        Max2 = i;

            //    }
            //    else if (i > Max3 && i != Max2) 
            //    {
            //        Max3 = i;
            //    }
            //}
            //Console.WriteLine(Max3);


            //Two dimensional array to one dimensinal array
            //int[,] array = { { 1, 2, 3 }, { 4, 5, 6 } };
            //int index = 0;
            //int width = array.GetLength(0);
            //int height = array.GetLength(1);
            //int[] single = new int[width * height];

            //for (int y = 0; y < height; y++)
            //{
            //    for (int x = 0; x < width; x++)
            //    {
            //        single[index] = array[x, y];
            //        Console.Write(single[index] + " ");
            //        index++;
            //    }
            //}


            //int[,] array1 = { { 2,4,5} ,{ 32,45,14},{ 34, 53, 23 } };
            //int index1 = 0;
            //int width1 = array1.GetLength(0);
            //int height1 = array1.GetLength(1);
            //int[] single1 = new int[width1 * height1];
            //for(int y = 0;y < height1; y++)
            //{
            //    for(int x = 0;x < width1; x++)
            //    {
            //        single1[index1] = array1[x, y];
            //        Console.Write(single1[index1] + " ");
            //        index1++;
            //    }
            //}



            //int? x = null;
            //int y = x ?? 2;
            //Console.WriteLine(y);


            int hours = Convert.ToInt32(Console.ReadLine());
            int mins = Convert.ToInt32(Console.ReadLine());
            double hourDegrees = (hours * 30) + (mins * 30.0 / 60);
            double minuteDegrees = mins * 6;
            double diff = Math.Abs(hourDegrees - minuteDegrees);
            if (diff > 180)
            {
                diff = 360 - diff;
            }
            Console.WriteLine("The angle between hour hand and minute hand is {0} degrees", diff);

            //multiplication matrix
            Console.WriteLine("Enter the row");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the column");
            int col = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[row];




















            //
            //----arraylist
            //ArrayList array = new ArrayList();
            //array.Add(2);
            //array.Add(3);
            //array.Add(4);
            //array.Add("ajshw");
            //array.Add(4);
            //array.Insert(0, "preet");
            //foreach (var i in array)
            //{
            //    Console.WriteLine(i);
            //}

            //---Hashtable
            //Hashtable ht = new Hashtable();
            //ht.Add("preet", 1);
            //ht.Add("sjskl", 2);
            //ht.Add(2, "efe");
            //ht.Add(3, 5);
            //ht.Add(4,null);
            //ht.Add("India", "Mumbai,Karnataka,Mysuru");
            //ht[3] = "hi";
            //foreach (DictionaryEntry i in ht)
            //{
            //    Console.WriteLine(i.Value + " : " + i.Key);
            //}

            //---Stack
            //Stack stack = new Stack();
            //stack.Push("jdlk");
            //stack.Push("khdihf");
            //stack.Push(9);
            //stack.Push(89);
            //stack.Pop();
            //stack.Pop();
            //Console.WriteLine(stack.Peek());   
            //foreach (var item in stack) 
            //{ 
            //    Console.WriteLine(item);
            //}


            //---Queue
            //Queue queue = new Queue();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //queue.Enqueue("dhkds");
            //queue.Enqueue("Khushi");
            //queue.Dequeue();
            //queue.Dequeue();
            //Console.WriteLine(queue.Count);
            //Console.WriteLine(queue.Peek());
            //foreach (var item in queue) 
            //{
            //    Console.WriteLine(item);
            //}

            //---SortedList
            //SortedList sort = new SortedList();
            //sort.Add(2, 43);
            ////sort.Add("efr", 232);
            //sort.Add(234, "gfrge");
            //sort.Add(43, "eeek");
            //sort.Add("cbnsbd", 4);
            //sort.Add("Adss", 2);
            //sort.Add("Eewe", 6);
            //sort.Add("njshue", 3);
            //sort.Add("Dprer", 5);
            //sort.Remove("Dprer");
            //foreach (DictionaryEntry item in sort) 
            //{
            //    Console.WriteLine(item.Key +" "+item.Value);
            //}


            //Generic Collections

            //List<string> stri = new List<string>();
            //stri.Add("Khushi");
            //stri.Add("Preet");
            //stri.Add("Navee");

            //foreach(string str in stri)
            //{
            //    Console.WriteLine(str);

            //}

            //Hashset
            //HashSet<string> set = new HashSet<string>();

            ////LinkedList
            //LinkedList<string> list = new LinkedList<string>();

            //

        }






    }
}




