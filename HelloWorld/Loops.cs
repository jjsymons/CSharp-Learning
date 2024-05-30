using System;
using System.ComponentModel;

namespace Loops
{
    public class Loop
    {
        public static void ForLoop()
        {
            for (int i = 10; i > 0; i-=2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Give me a number to count up to");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= number; i++)
            {
                Console.WriteLine(i);
            }

        }
        public static void WhileLoops()
        {
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine("Hello");
                i++;
            }


            while (true)
            {
                Console.WriteLine("Please guess a number between 1-10: ");
                int number = Convert.ToInt32(Console.ReadLine());

                if (number == 8)
                {
                    Console.WriteLine("Correct!");
                    break;
                } else if (number > 10 || number < 1) {
                    Console.WriteLine("Number is lower than 1 or higher than 10, please try again");
                } else
                {
                    Console.WriteLine("Incorrect, try again");
                }

            }
        }
        public static void DoWhileLoops()
        {
            int guess;
            Console.WriteLine("Please give me the first number: ");
            int numA = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please give me the second number: ");
            int numB = Convert.ToInt32(Console.ReadLine());

            int answer = numA * numB;

            do
            {
                Console.WriteLine("Enter Guess: ");
                guess = Convert.ToInt32(Console.ReadLine());

                if (guess != answer)
                {
                    Console.WriteLine("Incorrect");
                } else
                {
                    Console.WriteLine("Well Done");
                }

            } while (answer != guess);
        }
    }
}


