using System;
using CSharpBasicCource._0_FirstSteps;
using CSharpBasicCource._2_Datatypes.Values_Types;
using CSharpBasicCource._3_Arrays;
using CSharpBasicCource._3_Loops;

namespace CSharpBasicCource
{
    class Program
    {
        //private const string Question = "Hello! What is your name?"; // value that we don't want ot change - const
        //private const string Question2 = "How old are you?";
        //private const string Greating = "Hello ";

        //private static string Answer = "";
        //private static string Answer2 = "";
        public static void Main(string[] args)
        {
            Console.WriteLine("Hey! Please select what datatype you prefer: \n 1 - Bool;\n 2 - Char;\n 3 - Decimal;\n 4 - Double; \n 5 - Float; \n 6 - Int(32); \n 7 - Short(Int16); \n 8 - Long(int64) \n 9 - Array \n 10 - Loop \n 11 - Exit");
            bool exit = true;
            while (exit)
            {
                try
                {
                    var entered_value = Console.ReadLine();

                    switch (entered_value.ToString())
                    {
                        case "1":
                            BoolClass.BooleanRun();
                            break;
                        case "2":
                            CharClass.CharRun();
                            break;
                        case "3":
                            DecimalClass.DecimalRun();
                            break;
                        case "4":
                            DoubleClass.DoubleRun();
                            break;
                        case "5":
                            FloatClass.FloatRun();
                            break;
                        case "6":
                            Int32Class.Int32Run();
                            break;
                        case "7":
                            ShortClass.ShortRun();
                            break;
                        case "8":
                            LongClass.LongRun();
                            break;
                        case "9":
                            SingleArray.SingleArrayRun();
                            break;
                        case "10":
                            ForLoopPractice.LoopRun();
                            break;
                        case "11":
                            exit = false;
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("You enter wrong datatype!!!!");
                }


                Console.WriteLine("\nSelect another option");
            }
            


           
            //Console.ReadLine();

            //Console.WriteLine(Question);
            //Answer = Console.ReadLine();

            //Console.WriteLine(Question2);
            //Answer2 = Console.ReadLine();
            //int age = int.Parse(Answer2);
            //switch(age)
            //{
            //    case 6:
            //        Console.WriteLine(Greating + Answer + "Sorry but path is restricted");
            //        break;
            //    case 7 - 12:
            //        Console.WriteLine(Greating + Answer + "Please go. You have discount!");
            //        break;
            //    default:
            //        Console.WriteLine(Greating + Answer + "Please go amd enjoy!");
            //        break;
            //}

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
            //Console.WriteLine($"You are {Answer2}");

        }
    }
}
