using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasicCource._2_Datatypes.Values_Types
{
    public class CharClass
    {
        public static void CharRun()
        {
            //Char values
            char value_a = 'a';
            char value_b = 'b';
            char value_c = 'c';
            var sum = value_a + value_b;
            var sum2 = value_a + value_c;
            var sum3 = value_b + value_c;

            Console.WriteLine("Please select what ASCII element you want to sum: \n a(97+98); \n b(97+99) \n c(98+99)");
            var entered_data = Console.ReadLine();


            if (entered_data == "a")
            {
                Console.WriteLine($"97+98 = {sum}");
            }
            else if (entered_data == "b")
            {

                Console.WriteLine($"97+99 = {sum2}");
            }
            else
            {
                Console.WriteLine($"98+99 = {sum3}");
            }



        }
    }
}
