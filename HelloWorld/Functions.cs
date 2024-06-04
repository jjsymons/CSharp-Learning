using System;
using System.Numerics;

namespace Functions
{
	public class Function
	{
		public static void FunctionsLessons()
		{
			/*
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
			*/
			int number = 0;
			Console.WriteLine("Please give your name");
			string name = Console.ReadLine();
			name = GetAge(name, out number);

			Console.WriteLine($"The name is {name} and they are {number}");

			refAssign(ref name);
        }
		/*
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
		*/

        // More serious functions
		// Allows a return, in this instance a string, and an out which is an int, previously declared in the main part of the code
		static string GetAge(string name, out int number)
		{
			if (name.ToLower().Equals("joe"))
			{
				number = 28;
			} else
			{
				number = 32;
			}
			return name;
			
		}
		// Ref and Out are similar, but out means the variable must be used, otherwise an Exception is raised
		// While ref doesn't, Out also means that the variable in the function is held in another part of the memory, ie, within a
		// Main function int num is at memory position 1, while in a called function, num is now at memory position 2.
		// Out does not have to be instantiated before calling, unlike ref
		static void refAssign(ref string name)
		{
			name = "Mike";
		}
    }/*
    public class Messages
	{
		public void Greeting()
		{
            Console.WriteLine("Hello");
        }
	}*/
}
