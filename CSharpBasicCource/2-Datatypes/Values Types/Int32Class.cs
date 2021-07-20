using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasicCource._2_Datatypes.Values_Types
{
    public class Int32Class
    {
        public static void Int32Run()
        {
            Console.WriteLine("Maximum Value of In32 datatype: {0}", Int32.MaxValue);
            Console.WriteLine("Minimum Value of In32 datatype: {0}", Int32.MinValue);
            Console.WriteLine("Please enter int32 value a: ");
                var entered_v1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter int32 value b: ");
                var entered_v2 = Convert.ToInt32(Console.ReadLine());
                Int32 total3 = (entered_v1 * entered_v2);
                Console.WriteLine($"Int32 Total multiplication(a*b)= {total3}");


        }
    }
}
