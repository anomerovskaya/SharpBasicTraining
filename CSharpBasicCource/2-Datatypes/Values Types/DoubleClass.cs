using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasicCource._2_Datatypes.Values_Types
{
    public class DoubleClass
    {
        public static void DoubleRun()
        {
            Console.WriteLine("Maximum Value of Double datatype: {0}", double.MaxValue);
            Console.WriteLine("Minimum Value of Double datatype: {0}", double.MinValue);

            Console.WriteLine("Please enter double value a: ");
            var entered_data11 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter Only double value b: ");
            var entered_data22 = Convert.ToDouble(Console.ReadLine());
            Double total2 = (entered_data11 * entered_data22);
            Console.WriteLine($"Double Total multiplication(a*b)= {total2}");


        }
    }
}
