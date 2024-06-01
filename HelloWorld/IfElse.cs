using System;

namespace IfElseStatementsAndSwitches
{
    public class IfElse
    {
        public static void LessonIfElse()
        {
            // == > < >= <= !=
            Console.WriteLine("What's your age");
            string ageInput = Console.ReadLine();

            int age = Convert.ToInt32(ageInput);

            if (age != 28)
            {
                if (age <= 10 && age >= 0)
                {
                    Console.WriteLine("You are a kid");
                }
                else if (age > 120 || age < 0)
                {
                    Console.WriteLine("ERROR");
                }
                else if (age < 18 && age > 10)
                {
                    Console.WriteLine("You are a teen");
                }
                else
                {
                    Console.WriteLine("You are an adult");
                }
            }
            else
            {
                Console.WriteLine("That's my age!");
            }


            // You can also use functions in if blocks:

            string password = "1234567";

            if (!password.Equals("1234567"))
                {
                    Console.WriteLine("Incorrect");
                }
            else
                {
                    Console.WriteLine("Sucessful Login");
                }


        }
        public static void LessonSwitch()
        {
            Console.WriteLine("What day of the week is it?");
            int day = Convert.ToInt32(Console.ReadLine());

            switch (day)
            {
                case 1: Console.WriteLine("Mon");
                    break;
                case 2:
                    Console.WriteLine("Tue");
                    break;
                case 3:
                    Console.WriteLine("Wed");
                    break;
                case 4:
                    Console.WriteLine("Thu");
                    break;
                case 5:
                    Console.WriteLine("Fri");
                    break;
                case 6:
                    Console.WriteLine("Sat");
                    break;
                case 7:
                    Console.WriteLine("Sun");
                    break;
                default: Console.WriteLine("Invalid day given");
                    break;
            }
        }
    }
}

