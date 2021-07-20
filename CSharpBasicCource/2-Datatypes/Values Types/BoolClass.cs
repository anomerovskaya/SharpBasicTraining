using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasicCource._2_Datatypes.Values_Types
{
    public class BoolClass
    {
        public static void BooleanRun()
        {
            //Bool value
            bool value_false = false;
            bool value_true = true;
            Console.WriteLine("Please select option: T or F");
            var entered_data = Console.ReadLine();
            
           
            if (entered_data.ToUpper() == "T")
            {
                Console.WriteLine($"You entered: {value_true}");
            }
            else if(entered_data.ToUpper() == "F")
            {
                
                Console.WriteLine($"Man, You selected: {value_false}");
            }
           

            
        }
    }
}
 