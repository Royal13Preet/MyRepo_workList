using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace titilecase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter a string:");
            string value = Console.ReadLine();
            string[] words = value.Split(' ');
            string result = "";

            foreach (string word in words)
            {


                if (word.Length > 0)
                {
                        
                    char firstChar = word[0];
                    if (firstChar >= 'a' && firstChar <= 'z')
                    {
                        firstChar = (char)(firstChar - 32); 
                    }
                    result += firstChar;

                        
                    for (int i = 1; i < word.Length; i++)
                    {
                        char currentChar = word[i];
                        if (currentChar >= 'A' && currentChar <= 'Z')
                        {
                            currentChar = (char)(currentChar + 32); 
                        }
                        result += currentChar;
                    }

                    result += " "; 
                }
            }

                
             result = result.TrimEnd();

             Console.WriteLine("Title Case String: " + result);
            }
        }
    }
