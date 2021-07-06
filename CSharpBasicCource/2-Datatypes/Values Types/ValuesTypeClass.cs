using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasicCource._2_Datatypes.Values_Types
{
    public class ValuesTypeClass
    {
        public static void Run()
        {
            

            //Char values
            char value_a = 'a';
            char value_b = 'b';
            char value_c = 'c';
            var sum = value_a + value_b + value_c;
            Console.WriteLine("Char result: "+ sum);

            //Double values
            decimal value_aa = 15.99M;
            decimal value_bb = 45.88M;
            int total = (int)(value_aa + value_bb);
            Console.WriteLine("Decimal result: " + total);

            //Float values
            float value_aaa = 5.01F;
            float value_bbb = 98.66F;
            float result = value_aaa + value_bbb;
            Console.WriteLine("Float result: " + result);

            //Int32 values
            Int32 value_d = 888;
            Int32 value_f = 666;
            Int32 total_i32 = value_d + value_f;
            Console.WriteLine("Int32 result: " + total_i32);
        }
    }
}
