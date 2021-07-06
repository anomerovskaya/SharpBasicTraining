using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasicCource._2_Datatypes.Values_Types
{
    public class DecimalClass
    {
        public static void DecimalRun()
        {
            Console.WriteLine("Maximum Value of Decimal datatype: {0}", decimal.MaxValue);
            Console.WriteLine("Minimum Value of Decimal datatype: {0}", decimal.MinValue);

            Console.WriteLine("Please enter Only decimal value a: ");
            var entered_data1 = Convert.ToDecimal( Console.ReadLine());
            Console.WriteLine("Please enter Only decimal value b: ");
            var entered_data2 = Convert.ToDecimal(Console.ReadLine());
            decimal total = (entered_data1 + entered_data2);
            Console.WriteLine($"Decimal Total sum(a+b)= {total}");

        }
    }
}

