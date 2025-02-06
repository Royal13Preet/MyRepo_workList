using System;


namespace guessing_game
{
    internal class Program
    {
        static void Main(string[] args)

        {

            string Secretword = "Mandya";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 5;
            bool outofguess = false;
            string hint = "Hint: The word starts with '" + Secretword[0] + "'";


            while (guess != Secretword && !outofguess)
            {
                if (guessCount<guessLimit)
                {
                    if (guessCount == 0)
                    {
                        Console.WriteLine("Hint is the Place");
                    }
                    if (guessCount == 1)
                    {
                        Console.WriteLine(hint);
                    }
                    else if (guessCount == 2)
                    {
                        Console.WriteLine("Hint: the length of the word '" +Secretword.Length+ "'");
                    }
                    else if (guessCount == 3)
                    {
                        Console.WriteLine("Hint: the last letter of the word is '" + Secretword[Secretword.Length-1] + "'");
                    }
                    Console.Write("Enter a guessword: ");
                    guess = Console.ReadLine();
                    guessCount++;
                } else
                {
                    outofguess = true;
                }
            }
            if (outofguess)
            {
                Console.WriteLine("you loss");
            }
            else
            {
                Console.WriteLine("you win");
            }
        }
    }
}