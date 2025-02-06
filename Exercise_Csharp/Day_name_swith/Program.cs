using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_name_swith
{
    internal class Program
    {
        

            static void Main(string[] args)
            {

                Console.WriteLine(GetDay(Convert.ToInt32(Console.ReadLine())));
                Console.ReadKey();
            }

            static string GetDay(int DayNum)
            {
                string dayName;
                switch (DayNum)
                {
                    case 0:
                        dayName = "sunday";
                        break;
                    case 1:
                        dayName = "Monday";
                        break;
                    case 3:
                        dayName = "Tuesday";
                        break;
                    case 4:
                        dayName = "Wednesday";
                        break;
                    case 5:
                        dayName = "Thursday";
                        break;
                    case 6:
                        dayName = "Friday";
                        break;
                    case 7:
                        dayName = "Saturday";
                        break;
                    default:
                        dayName = "Invalid input";
                        break;
                }
                return dayName;
            }
        
    }
}
