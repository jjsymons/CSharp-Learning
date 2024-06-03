using System;

namespace Functions
{
	public class Function
	{
		public static void FunctionsLessons()
		{
			// Welcome Message is available as it's within the class and static
			WelcomeMessage();
			// GoodByeMessage(); Needs to be static to be called without instantiation

			// Function without Static, needs to be created
			Function Bye = new Function();

			Bye.GoodByeMessage();

			// .Greeting is not static and must be instantiated
			Messages firstVisit = new Messages();

			firstVisit.Greeting();

			// void means that nothing needs to be returned, and whatever was within the called code, is not accessible.

			int total = addNumbers();
            Console.WriteLine($"The numbers given added up to: {total}");
        }
		static int addNumbers()
		{
			bool success = false;
			int numOne = 0,
				numTwo = 0;

			while (!success) 
			{
				Console.WriteLine("Give me the first number");
				success = int.TryParse(Console.ReadLine(), out numOne);
			}
			success = false;
			while (!success)
			{
				Console.WriteLine("Give me the second number");
                success = int.TryParse(Console.ReadLine(), out numTwo);
            }

			return numOne + numTwo;
		}

        static void WelcomeMessage()
		{
            Console.WriteLine("Welcome to the site!");
        }
		public void GoodByeMessage()
		{
			Console.WriteLine("Goodbye!");
		}
	}
	public class Messages
	{
		public void Greeting()
		{
            Console.WriteLine("Hello");
        }
	}
}
