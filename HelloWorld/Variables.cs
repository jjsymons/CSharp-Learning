using System;

namespace Variables
{
    public class Vars()
    {
        static void Variables()
        {
            // Only a number can follow an int as it is strict.
            int age = 23;
            

            // Here a variable is given a number and so something becomes a Int32
            var something = 21;
            
            // letter becomes a Char
            var letter = 'A';

            // str becomes a String
            var str = "Hello";

            /* Var should only be used for specific use cases when the variable name has obvious usage. 
             Variables for greeting or someones name could be Var because the type is inherent based on the name of the variable
            Score could be a long, decimal, Int etc, having to inspect the type would be slow while bug fixing */
        }
    }
}
