using System;

namespace ConsoleIO
{
	public class CIO
	{
		public static void IO()
		{
            Console.WriteLine("Hello what's your name?");
			string name = Console.ReadLine();
            Console.WriteLine(name);

			Console.WriteLine("What's your age?");
			string age = Console.ReadLine();
			Console.WriteLine("Your name is " + name + " and your age is " + age);

            //However when dealing with inputs we might need a integer. Console.ReadLine() converts to string
            
			// solution
            Console.WriteLine("What did you get on the test?");
			string testScoreInput = Console.ReadLine();
			int testScore = Convert.ToInt32(testScoreInput);
        }
		public static void IOTryParse()
		{
			Console.WriteLine("Enter a number: ");
			string numInput = Console.ReadLine(); // What happens if a string number is not given?
			//int number = Convert.ToInt32(numInput); // Code fails here and any code below is not processed.
			int number = 0;

			// Solution

			//int.TryParse(numInput, out number); // Takes the input from ReadLine, tries to parse as an int, if successful outputs value in 'number'
        

			// However if user gives value the same as the initial variable of number 0, it might appear the program failed, even though the program worked
			// To avoid incorrectly exiting the program a bool should be used to test if the TryParse was successful


			bool success = int.TryParse(numInput, out number);

			if (success)
			{
				Console.WriteLine(number);
			} else
			{
				Console.WriteLine("Failed");
            }



        }
	}
}
