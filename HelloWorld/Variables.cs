using System;

namespace Variables
{
    public class Vars()
    {
        public static void Variables()
        {
            /* Var should only be used for specific use cases when the variable name has obvious usage. 
             Variables for greeting or someones name could be Var because the type is inherent based on the name of the variable
            Score could be a long, decimal, Int etc, having to inspect the type would be slow while bug fixing */

            // Only a number can follow an int as it is strict.
            int age = 23;
            

            // Here a variable is given a number and so something becomes a Int32
            var something = 21;
            
            // letter becomes a Char
            var letter = 'A';

            // str becomes a String
            var str = "Hello";

            

            // Const

            /* Const is a keyword to indicate that a given variable should not/cannot be changed later in the program. For example, things like Pi, VAT, 
             Speed of Sound are measurements that cannot and shouldn't be changed. This makes sure that calculations are correct.

            In an event where a const has to change, it just needs to change at one point, for example, a version number of a software. But it 
            still should not be changeable within code
            */

            const string name = "Joe";

            const int vatUK = 20;

            const double percentVAT = vatUK / 100D;

            int priceOfGoods = 242;

            double priceAfterVAT = priceOfGoods * percentVAT;

            Console.WriteLine(priceAfterVAT);
        }
    }
}
