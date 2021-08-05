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
            double first_value = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please select operation:\n " +
                "'+' - Sum(a + b) " +
                "\n '-' - Subtract(a - b)" +
                "\n '*' - Multiply(a * b) " +
                "\n '/' - Divide (a / b) " );
            Console.Write("Your option? ");
            string operation = Console.ReadLine();
            Console.WriteLine("Please enter second value: ");
            double second_value = Convert.ToDouble(Console.ReadLine());
            double result;



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
                default:
                    result = 0;
                    break;
                
            }
            Console.WriteLine($"Result of operation is: {result}");


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
