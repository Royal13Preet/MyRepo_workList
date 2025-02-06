using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringmethods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //int a = Console.Read();
            //Console.WriteLine(a);

            Console.ReadKey();
            string built = "I lovCCe IceCream";
            int index = built.LastIndexOf("C");  //It prints last index of the word
            Console.WriteLine(index);


            //string name = "Csharp";
            //string strFormat = String.Format("{0} Hello ", name); //It returns the argument what we passed
            //Console.WriteLine(strFormat); 


            //string firstname = "Heloo everyone";
            //string[] split = firstname.Split(new char[] { 'e' });
            //Console.WriteLine(split[0]);
            //Console.WriteLine(split[1]);
            //Console.WriteLine(split[2]);

            //string myString = "apple,banana,orange";
            //string[] fruits = myString.Split(',');
            //Console.WriteLine(fruits[0]);

            //string text = "C# is fun";
            //Console.WriteLine(text.Substring(6, 2)); //it prints the substring of the txt

            //string str1 = "C#";
            //string str2 = "Program";
            //int result = String.Compare(str1, str2); //comparing the value give the result in boolean
            //Console.WriteLine(result);


            //string str = "Programming is fun"; 
            //string res = str.Replace("Programming", "C#"); //replace the word by different word
            //Console.WriteLine(res);

            //string str1 = "i am good at coding";
            //bool check = str1.Contains("Good"); //It checks in the sentence that word is there or not
            //Console.WriteLine(check);


            //string[] text = { "C#", "Java", "C++" };
            //string resa = String.Join(",", text);  //It join by some functions
            //Console.WriteLine(resa);

            //string str0 = "Preethu";
            //string str1 = "gowda";
            //string result = String.Concat(str0 , str1); //It adds the two value
            //Console.WriteLine(result);

            //string txt = " This is the function ";
            //string s1 = txt.Trim();
            //Console.WriteLine("hi" +s1);  //It remove last and first spaces form the sentence


            //string str = "Dairy Milk";
            //int result = str.IndexOf("cream");
            //Console.WriteLine(result);  //It find the index of word

            //string str = "Kit KAt";
            //string result = str.Remove(2);
            //Console.WriteLine(result);    //It removes the the given index to full

            //string str = "chocolate";
            //string result = str.ToUpper();  //It capitalize the word
            //Console.WriteLine(result);

            //string str = "chOcoAAAlate";
            //string result = str.ToLower();
            //Console.WriteLine(result);   //It smalarize the word

            //string text = "Giridhara software pvt";
            //bool result = text.EndsWith("cream");
            //Console.WriteLine(result);    //It checks the last word is true or false

            //string str = "Life is too short";
            //bool result = str.StartsWith("Ice");    //It checks the first word is true or false

            //string str = "Confidence";
            //string result = str.PadLeft(14);          
            //Console.WriteLine(result);


            //char pad = '^';
            //string str = "Icecream";
            //string result = str.PadRight(15, pad);
            //Console.WriteLine(result);

            //string myString = "Hello, World!";
            //int length = myString.Length;
            //Console.WriteLine(length);

            //string s1 = "Hello C#";
            //string s2 = s1.Normalize();
            //Console.WriteLine(s2);  //It dispalyed the same string but binary representation is in unicode

            //int number = 42;
            //string text = "Hello, World!";
            //double decimalValue = 3.14;
            //Console.WriteLine(number.GetType());    
            //Console.WriteLine(text.GetType());     
            //Console.WriteLine(decimalValue.GetType()); 

            //string name = "ge";
            //int hashCode = name.GetHashCode();
            //Console.WriteLine(hashCode);

            //int firstname = 899;
            //TypeCode typeCode = Convert.GetTypeCode(firstname);
            //Console.WriteLine(typeCode);

            //string firstname = "Khushi";
            //Console.WriteLine(firstname.Insert(0, "Hello ")); 

            //string ch1 = "5fds7gr5";
            //bool result = Char.IsDigit(ch1, 4);
            //Console.WriteLine(result);

            //char ch1 = ' ';
            //bool result1 = Char.IsWhiteSpace(ch1);
            //Console.WriteLine(result1);

            //char ch1 = '\n';
            //bool result1 = Char.IsWhiteSpace(ch1);
            //Console.WriteLine(result1);

            //char ch1 = '-';
            //bool result1 = Char.IsWhiteSpace(ch1);
            //Console.WriteLine(result1);

            //char ch1 = '5';
            //bool result = Char.IsNumber(ch1);
            //Console.WriteLine(result);


            //char ch2 = 'c';
            //bool result = Char.IsNumber(ch2);
            //Console.WriteLine(result);




            Console.ReadLine();
        }
    }
}
