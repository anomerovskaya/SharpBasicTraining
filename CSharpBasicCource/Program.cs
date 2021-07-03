using System;
using CSharpBasicCource._0_FirstSteps;

namespace CSharpBasicCource
{
    class Program
    {
        private const string Question = "Hello! What is your name?"; // value that we don't want ot change - const
        private const string Question2 = "How old are you?";
        private const string Greating = "Hello ";

        private static string Answer = "";
        private static string Answer2 = "";
        public static void Main(string[] args)
        {
            Console.WriteLine(Question);
            Answer = Console.ReadLine();
        
            Console.WriteLine(Question2);
            Answer2 = Console.ReadLine();
            int age = int.Parse(Answer2);
            switch(age)
            {
                case 6:
                    Console.WriteLine(Greating + Answer + "Sorry but path is restricted");
                    break;
                case 7 - 12:
                    Console.WriteLine(Greating + Answer + "Please go. You have discount!");
                    break;
                default:
                    Console.WriteLine(Greating + Answer + "Please go amd enjoy!");
                    break;
            }

            //if(age < 7 && age > 0)
            //{
            //    Console.WriteLine(Greating + Answer + "Sorry but path is restricted");
            //}
            //else if(age<12)
            //{
            //    Console.WriteLine(Greating + Answer + "Please go. You have discount!");
            //}
            //else
            //{
            //    Console.WriteLine(Greating + Answer + "Please go amd enjoy!");
            //}
            Console.WriteLine($"You are {Answer2}");
            Console.ReadLine();
        }
    }
}
