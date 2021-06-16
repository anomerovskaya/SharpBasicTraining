using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasicCource
{
    public class TestClass
    {
        public static void HelloName(string name)
        {
            string value3 = "data from value3"; 

            Console.WriteLine("Hello " + "'" + value3 + "'");
            Console.WriteLine(Sum(2, 3));
            Console.ReadLine();
        }

        public static int  Sum(int value1, int value2)
        {
            return value1 + value2;
        }
    }
}
