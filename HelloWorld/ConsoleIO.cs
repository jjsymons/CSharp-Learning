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
	}
}
