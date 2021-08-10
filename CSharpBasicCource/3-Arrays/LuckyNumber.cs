using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace CSharpBasicCource._3_Arrays
{
    public class LuckyNumber
    {
        public static void ArrayHomeTaskPractice()
        {
            Console.WriteLine("Please enter 6 digits number");
            var entered_value = Console.ReadLine();
            bool isValid = Regex.IsMatch(entered_value, @"^\d{6}$");
            if (Regex.IsMatch(entered_value, @"^\d{6}$"))
            {
                Console.WriteLine("Cong! You enter 6 digits number!");
                
                string firstPart = entered_value.Substring(0, 3);//first part of enterd 6 digit number
                string secondPart = entered_value.Substring(3);//second part of enterd 6 digit number
                char[] arr = new char[firstPart.Length];
                int[] arr2 = new int[arr.Length];
               arr = entered_value.ToCharArray(0, 3);


                char[] second_arr = new char[secondPart.Length];
                int [] second_arr2 = new int[second_arr.Length];

                second_arr = entered_value.ToCharArray(3,3);

                // values to Sum first and second part on entered value
                int FirstSum = 0;
                int SecondSum = 0;

                for (int x = 0; x < 3; x++)
                {
                    
                    arr2[x] = Convert.ToInt32(arr[x].ToString());
                    FirstSum += arr2[x];// cals Sum of first part of entered 6 digit number
                    
                }
                //Console.WriteLine("Sum of First part of array: " + FirstSum);
                for (int y = 0; y < 3; y++)
                {

                    second_arr2[y] = Convert.ToInt32(second_arr[y].ToString());
                    SecondSum += second_arr2[y];// cals Sum of first part of entered 6 digit number

                }
                //Console.WriteLine("Sum of Second part of array: " + SecondSum);
                if (FirstSum == SecondSum)
                {
                    Console.WriteLine("Your number is lucky!");
                }
                else
                {
                    Console.WriteLine("Sorry! Try again, your number is not lucky!");
                }
            }
            else
            {
                Console.WriteLine("Oops! You enter not digits number or more that 6 number!");
            }


           //int[] arrayOfdigits = new int[6];
                    
           // for (int k = 0; k < 6; k++)
           // {
           //     Console.WriteLine("Please enter the {0} element of array", k);
           //     var entered_digit = Console.ReadLine();
           //     arrayOfdigits[k] = Convert.ToInt32(entered_digit);

           // }
          
           // Console.WriteLine("Your array contains the next values: " + string.Join(",",arrayOfdigits));
           // if (arrayOfdigits[0].GetType() == typeof(int))
           // {
           //     Console.WriteLine("Please enter the {0} element of array");
           // }


        }
        
    }
}
