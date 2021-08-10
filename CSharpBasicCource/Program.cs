using System;
using CSharpBasicCource._0_FirstSteps;
using CSharpBasicCource._2_Datatypes.Values_Types;
using CSharpBasicCource._3_Arrays;
using CSharpBasicCource._3_Loops;
using CSharpBasicCource._4_Loops;
using CSharpBasicCource._5_SimpleCalculator;

namespace CSharpBasicCource
{
    class Program
    {
        //private const string Question = "Hello! What is your name?"; // value that we don't want ot change - const
        //private const string Question2 = "How old are you?";
        //private const string Greating = "Hello ";

        //private static string Answer = "";
        //private static string Answer2 = "";
        private const string NotIntMessage = "Answer should be an Integer";
        public static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Hey! Please select what lesson you would like to choose: \n " +
                "1- Introduction C#;" +
                "\n 2 - Data Types;" +
                "\n 3 - Arrays;" +
                "\n 4 - Loop;" +
                "\n 5 - Simple Calculator" +
                "\n 6 - Exit");
            bool exit = true;
            while (exit)
            {
                try
                {
                    var entered_value = Console.ReadLine();

                    switch (entered_value.ToString())
                    {
                        case "1":
                            Console.Clear();
                            Console.WriteLine("Start of C# basic training");
                            IntroductionToCSharp.BasicCsharpRun();
                            int sum = IntroductionToCSharp.Sum(5, 20);
                            Console.WriteLine(sum);
                            break;
                        case "2":
                            Console.Clear();
                            Console.WriteLine("Data types");
                            Console.WriteLine("The following data types available:\n\n 1 - Reference types\n2 - Value Types.\n");
                            Console.WriteLine("Please select DataType:");
                            var answer2 = Console.ReadLine();
                            bool selected_value = int.TryParse(answer2, out var dataTypeNumber);

                            if(!selected_value)
                            {
                                Console.WriteLine(NotIntMessage);
                            }
                            else 
                            {
                                switch(dataTypeNumber)
                                {
                                    case 1:
                                        Console.WriteLine("No methods available");
                                        break;
                                    case 2:
                                        Console.Clear();
                                        Console.WriteLine("Please select what datatype you prefer: " +
                                            "\n 1 - Bool;" +
                                            "\n 2 - Char;" +
                                            "\n 3 - Decimal;" +
                                            "\n 4 - Double; " +
                                            "\n 5 - Float; " +
                                            "\n 6 - Int(32); " +
                                            "\n 7 - Short(Int16); " +
                                            "\n 8 - Long(int64) " +
                                            "\n 9 - Array " +
                                            "\n 10 - Loop " +
                                            "\n 11 - Exit");
                                        var answer3 = Console.ReadLine();
                                        bool selected_value2 = int.TryParse(answer3, out var valueTypeNumber);
                                        if(!selected_value2)
                                        {
                                            Console.WriteLine(NotIntMessage);
                                        }
                                        else
                                        {
                                            switch(valueTypeNumber)
                                            {
                                                case 1:
                                                    BoolClass.BooleanRun();
                                                    break;
                                                case 2:
                                                    CharClass.CharRun();
                                                    break;
                                                case 3:
                                                    DecimalClass.DecimalRun();
                                                    break;
                                                case 4:
                                                    DoubleClass.DoubleRun();
                                                    break;
                                                case 5:
                                                    FloatClass.FloatRun();
                                                    break;
                                                case 6:
                                                    Int32Class.Int32Run();
                                                    break;
                                                case 7:
                                                    ShortClass.ShortRun();
                                                    break;
                                                case 8:
                                                    LongClass.LongRun();
                                                    break;
                                                case 9:
                                                    SingleArray.SingleArrayRun();
                                                    break;
                                                case 10:
                                                    ForLoopPractice.LoopRun();
                                                    break;
                                                default:
                                                    Console.WriteLine(NotIntMessage);
                                                    break;
                                            }
                                        }
                                        break;

                                }
                            }
                            break;
                        case "3":
                            Console.Clear();
                            Console.WriteLine("Arrays");
                            Console.WriteLine("What exercise of Arrays you would like: " +
                                "\n 1 - View SingleArray " +
                                 "\n 2 - Verify Lucky Number " +
                                 "\n 3 - Exit");
                            var answer4 = Console.ReadLine();
                            bool selected_value3 = int.TryParse(answer4, out var ArrayExercise);
                            if (!selected_value3)
                            {
                                Console.WriteLine(NotIntMessage);
                            }
                            else 
                            {
                                switch(ArrayExercise)
                                {
                                    case 1:
                                        SingleArray.SingleArrayRun();
                                        break;
                                    case 2:
                                        LuckyNumber.ArrayHomeTaskPractice();
                                        break;
                                    default:
                                        Console.WriteLine(NotIntMessage);
                                        break;

                                }
                            }
                            
                            break;
                        case "4":
                            Console.Clear();
                            Console.WriteLine("Loops");
                            Console.WriteLine("What exercise of Loop you would like: " +
                                "\n 1 - Creation random array and view revers version of array" +
                                 "\n 2 - View Movies from Australia " +
                                 "\n 3 - Exit");
                            var answer5 = Console.ReadLine();
                            var selected_value4 = int.TryParse(answer5, out var LoopExercise);
                            if (!selected_value4)
                            {
                                Console.WriteLine(NotIntMessage);
                            }
                            else
                            {
                                switch (LoopExercise)
                                {
                                    case 1:
                                        ForLoopPractice.LoopRun();
                                        break;
                                    case 2:
                                        MovieFromAustralia.RunGetMoviesFromAustralia();
                                        break;
                                    default:
                                        Console.WriteLine(NotIntMessage);
                                        break;

                                }
                            }
                            
                            
                            break;
                        case "5":
                            Console.Clear();
                            Console.WriteLine("Simple Calculator");
                            ConsoleCalculator.Calculator();
                            break;
                        case "6":
                            exit = false;
                            break;

                    }
                }
                catch (Exception ex)
                {
                    //Console.WriteLine("You enter wrong datatype!!!!");
                }


               
                //Console.WriteLine("Hey! Please select what datatype you prefer: \n 1 - Bool;\n 2 - Char;\n 3 - Decimal;\n 4 - Double; \n 5 - Float; \n 6 - Int(32); \n 7 - Short(Int16); \n 8 - Long(int64) \n 9 - Array \n 10 - Loop \n 11 - Exit");
                //bool exit = true;
                //while (exit)
                //{
                //    try
                //    {
                //        var entered_value = Console.ReadLine();

                //        switch (entered_value.ToString())
                //        {
                //            case "1":
                //                BoolClass.BooleanRun();
                //                break;
                //            case "2":
                //                CharClass.CharRun();
                //                break;
                //            case "3":
                //                DecimalClass.DecimalRun();
                //                break;
                //            case "4":
                //                DoubleClass.DoubleRun();
                //                break;
                //            case "5":
                //                FloatClass.FloatRun();
                //                break;
                //            case "6":
                //                Int32Class.Int32Run();
                //                break;
                //            case "7":
                //                ShortClass.ShortRun();
                //                break;
                //            case "8":
                //                LongClass.LongRun();
                //                break;
                //            case "9":
                //                SingleArray.SingleArrayRun();
                //                break;
                //            case "10":
                //                ForLoopPractice.LoopRun();
                //                break;
                //            case "11":
                //                exit = false;
                //                break;
                //        }
                //    }
                //    catch (Exception ex)
                //    {
                //        Console.WriteLine("You enter wrong datatype!!!!");
                //    }


                //    Console.WriteLine("\nSelect another option");
            }
            


           
            //Console.ReadLine();

            //
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
