using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasicCource._2_Datatypes.Values_Types
{
    public class FloatClass
    {
        public static void FloatRun()
        {
            Console.WriteLine("Maximum Value of Float datatype: {0}", float.MaxValue);
            Console.WriteLine("Minimum Value of Float datatype: {0}", float.MinValue);
            Console.WriteLine("Please enter float value a: ");
            var entered_data111 = Console.ReadLine();
            Console.WriteLine("Please enter Only float value b: ");
            var entered_data222 = Console.ReadLine();
            float a = float.Parse(entered_data111);
            float b = float.Parse(entered_data222);
            float total22 = a + b;
            Console.WriteLine($"Float Total sum(a+b)= {total22}");




        }
    }
}
