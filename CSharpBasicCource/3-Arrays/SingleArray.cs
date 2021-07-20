using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasicCource._3_Arrays
{
    public class SingleArray
    {
        public static void SingleArrayRun()
        {
            int[] arrayOfIntegers = new int[5];
            arrayOfIntegers[0] = 5;
            arrayOfIntegers[1] = 8;
            arrayOfIntegers[3] = 10;
            Console.WriteLine("Length of our Int array is " + arrayOfIntegers.Length);

            string[] arrayOfStrings = new string[3] { "Name", "Surname", "Age" };
            //Console.WriteLine("The third element of stringArray it's: " + arrayOfStrings[2]);
            Console.WriteLine($"stringArray contains the next values: ");
            foreach (string i in arrayOfStrings)
            {
                Console.WriteLine(i);
            }

            //inialise array
            //int[] newArray = new int[20];
            //for (int a=0; a< newArray.Length; a++)
            //{
            //    newArray[a] = a;
            //    Console.WriteLine($"New array  elements {a} is equal to {a}");
            //}
        }
    }
}
