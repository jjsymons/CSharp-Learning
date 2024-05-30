using System;
using System.Data.SqlTypes;

namespace Format
{
    public class Formatting()
    {
        public static void Ternary()
        {
            Console.WriteLine("What is my favourite flavour of Ice Cream?");
            string guessFlavour = Console.ReadLine();

            bool favFlovour = guessFlavour == "Chocolate" ? true : false;
            Console.WriteLine(favFlovour);

            Console.WriteLine("What is your age?: ");
            int age = Convert.ToInt32(Console.ReadLine());

            string valid = age >= 1 && age <= 120 ? "Valid": "Invalid";

            Console.WriteLine(valid);
        }
        public static void NumberFormatting() 
        {
            int number = 1010;
            Console.WriteLine(string.Format("The two numbers given are {0} & {1}", number, 1001));

            double sum = 100 / 20D;
            // Hash removes trailing 0s
            Console.WriteLine("The sum of 100 divided by 33 is: {0:0.#}", sum);
            Console.WriteLine("The sum of 100 divided by 33 is: {0:0.0}", sum);
            Console.WriteLine("The sum of 100 divided by 33 is: {0:0.00}", sum);
            Console.WriteLine("The sum of 100 divided by 33 is: {0:0.000}", sum);

            double money = 112 / 67D;

            // Method to turn money var into currency.
            Console.WriteLine(money.ToString("C"));
            Console.WriteLine(money.ToString("C0")); // No dec places
            Console.WriteLine(money.ToString("C1")); // 1 dec places
            Console.WriteLine(money.ToString("C2")); // 2 dec places


        }
    }
}



