using System;

namespace Functions
{
	public class Function
	{
		static void FunctionsLessons()
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
