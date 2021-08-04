using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasicCource._5_SimpleCalculator
{
    public class ConsoleCalculator
    {
        public static void Calculator()
        {
            Console.WriteLine("Please enter first value: ");
            var first_value = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please select operation:\n " +
                "'+' - Sum(a + b) " +
                "\n '-' - Subtract(a - b)" +
                "\n '*' - Multiply(a * b) " +
                "\n '/' - Divide (a / b) " );
            Console.Write("Your option? ");
            string operation = Console.ReadLine();
            Console.WriteLine("Please enter second value: ");
            var second_value = Convert.ToInt32(Console.ReadLine());
            int result;

            switch(operation)
            {
                case "+":
                    result = first_value + second_value;
                    break;
                case "-":
                    result = first_value - second_value;
                    break;
                case "*":
                    result = first_value * second_value;
                    break;
                case "/":
                    result = first_value / second_value;
                    break;
                
            }

            //if (operation == "+")
            //{
            //    result = first_value + second_value;
            //    Console.WriteLine(first_value + " + " + second_value + " = " + result);
            //    Console.ReadLine();
            //}
            //else if (operation == "-")
            //{
            //    if (first_value < second_value)
            //    {
            //        Console.WriteLine("You receive negative value!");
            //        result = first_value - second_value;
            //        Console.WriteLine(first_value + " - " + second_value + " = " + result);
            //        Console.ReadLine();
            //    }
            //    else
            //    {
            //        Console.WriteLine("You receive positive value!");
            //        result = first_value - second_value;
            //        Console.WriteLine(first_value + " - " + second_value + " = " + result);
            //        Console.ReadLine();
            //        result = first_value - second_value;
            //        Console.WriteLine(first_value + " - " + second_value + " = " + result);
            //        Console.ReadLine();
            //    }
            //}
            //else if (operation == "*")
            //{
            //    result = first_value * second_value;
            //    Console.WriteLine(first_value + " * " + second_value + " = " + result);
            //    Console.ReadLine();
            //}
            //else if(operation == "/")
            //{
            //    result = first_value / second_value;
            //    Console.WriteLine(first_value + " / " + second_value + " = " + result);
            //    Console.ReadLine();
            //}
        }

    }
}
