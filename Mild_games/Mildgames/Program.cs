using System;

namespace Mildgames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Mad lib game");
            Console.Write("Enter a Family Member: ");
            String FamilyMember = Console.ReadLine();
            Console.Write("Enter a Teacher Name: ");
            String TeacherName = Console.ReadLine();
            Console.Write("Enter a Noun: ");
            String Noun = Console.ReadLine();
            Console.Write("Enter a Clothing: ");
            String Clothing = Console.ReadLine();
            Console.Write("Enter Which type of drink u like: ");
            String Drink = Console.ReadLine();
            Console.Write("Enter a Sport: ");
            String Sport = Console.ReadLine();
            Console.Write("Enter a Sport ball(verb is in ing form: ");
            String Ball = Console.ReadLine();
            Console.Write("Enter a food: ");
            String Food = Console.ReadLine();
            Console.Write("Enter a food(adjective)");
            String Afood = Console.ReadLine();
            Console.WriteLine("Dogs are incredible! Dogs can be your \n best friend, your" + FamilyMember + " ," + TeacherName + " , and mission of other things\n They love to wag thier " +Noun+ ", and eat your " +Clothing+ ", and drink up all the " +Drink+ "They can be great at" +Sport+ " too. In fact, your dog is probably better than you at " +Ball+ " , and slum-dunking " +Food+ "! Be sure your dog gets plenty of water, pets, and " +Afood);
            Console.ReadKey();

        }


    }
}
