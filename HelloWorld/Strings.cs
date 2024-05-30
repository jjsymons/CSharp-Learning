using System;

namespace Strings
{
    public class Strings()
	{
        static void HelloWorld()
        {
            Console.WriteLine("Hello World");
        }
        static void StringDataTypes()
        {
            string name = "Joe";
            char letter = 'J';
            Console.WriteLine(name);
            Console.WriteLine(letter);

            string numberString = "24";
            int convertedInt = Convert.ToInt32(numberString);
            Console.WriteLine(convertedInt);

            string longString = "50000000000";
            long convertedLong = Convert.ToInt64(longString);

            string floatString = "0.50000";
            float convertedFloat = Convert.ToSingle(floatString);

            string doubleString = "1.1415973";
            double convertedDouble = Convert.ToDouble(doubleString);

            string decimalString = "14.33";
            decimal convertedDecimal = Convert.ToDecimal(decimalString);


        }
    }
}
