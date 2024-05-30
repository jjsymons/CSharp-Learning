using System;

namespace IfElseStatements
{
    public class IfElse
    {
        public static void Lesson()
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
        }
    }
}

