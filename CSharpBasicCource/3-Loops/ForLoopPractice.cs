using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasicCource._3_Loops
{
    public class ForLoopPractice
    {
        public static void LoopRun()
        {
            
            int Min = 0;
            int Max = 99;
            int[] test2 = new int[20]; //declaration Array
            int[] reverseArray = new int[test2.Length]; // Reversed Array
           
            Random randNum = new Random(); // Randow generator of numbers
            Console.WriteLine("What kind of Array you prefer? 1-Real/ 2- Reverse / 3- go away ");
            bool go_away = true;
            while (go_away)
            {
                var entered_data = Console.ReadLine();
                switch (entered_data.ToString())
                {
                    case "1":


                        for (int f = 0; f < test2.Length; f++)
                        {
                            test2[f] = randNum.Next(Min, Max);
                            Console.WriteLine($"Real Array {f} contains the next element: {test2[f]}");
                        }
                        break;

                    case "2":


                        for (int i = 0; i < test2.Length - 1; i++)
                        {
                            test2[i] = randNum.Next(Min, Max);
                            reverseArray[i] = test2[test2.Length - i - 1];
                            Console.WriteLine($"Reverse Random Array {i} contains the next element: {reverseArray[i]}");
                        }
                        break;
                    case "3":
                        go_away = false;
                        break;

                }
                Console.WriteLine("\nSelect another Array type");

            }
        }

           

                  
    }
}
