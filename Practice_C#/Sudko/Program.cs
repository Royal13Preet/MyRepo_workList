using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudko
{
    
        public class Program
        {
        public static void Main(string[] args)
            {
                int[,] arr = new int[9, 9];
                Random random = new Random();

                // Ensure each 3x3 grid has at least 2 random numbers
                for (int gridRow = 0; gridRow < 3; gridRow++)
                {
                    for (int gridCol = 0; gridCol < 3; gridCol++)
                    {
                        int count = 0;
                        while (count < 2)
                        {
                            int i = gridRow * 3 + random.Next(0, 3);
                            int j = gridCol * 3 + random.Next(0, 3);

                            if (arr[i, j] == 0)
                            {
                                int num;
                                do
                                {
                                    num = random.Next(1, 10); // Random number between 1 and 9
                                } while (!IsValid(arr, i, j, num));

                                arr[i, j] = num;
                                count++;
                            }
                        }
                    }
                }

                // Fill the remaining random numbers
                int totalRandomNumbers = 30;
                int placedNumbers = 2 * 9;
                while (placedNumbers < totalRandomNumbers)
                {
                    int i = random.Next(0, 9);
                    int j = random.Next(0, 9);

                    if (arr[i, j] == 0)
                    {
                        int num;
                        do
                        {
                            num = random.Next(1, 10); // Random number between 1 and 9
                        } while (!IsValid(arr, i, j, num));

                        arr[i, j] = num;
                        placedNumbers++;
                    }
                }

                // Print the array as a 3x3 grid
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        Console.Write(arr[i, j] + " ");
                        if ((j + 1) % 3 == 0 && j != arr.GetLength(1) - 1)
                        {
                            Console.Write("| ");
                        }
                    }
                    Console.WriteLine();

                    if ((i + 1) % 3 == 0 && i != arr.GetLength(0) - 1)
                    {
                        Console.WriteLine("---------------------");
                    }
                }
            }

            // Check if a number can be placed at arr[i, j] without violating Sudoku rules
            static bool IsValid(int[,] arr, int row, int col, int num)
            {
                // Check the row
                for (int j = 0; j < 9; j++)
                {
                    if (arr[row, j] == num)
                    {
                        return false;
                    }
                }

                // Check the column
                for (int i = 0; i < 9; i++)
                {
                    if (arr[i, col] == num)
                    {
                        return false;
                    }
                }

                return true;
            }
        }
    }

