using System;

namespace ExceptionsLesson
{
	public class Exc
	{
		public static void ExcLessons()
		{
            /*
			// Example Exception
			Console.WriteLine("Give a number");
			int number = Convert.ToInt32(Console.ReadLine()); // Input = "Forty"
			*/                                                  // Outputs Exception Unhandled, code crashes and ends. If input was too large, (e.g a long)
                                                                // The code would also break as it couldn't be saved in a int.

            bool success = false;
			while (!success)
			{
				try
				{
					Console.WriteLine("Give a number");
					int number = Convert.ToInt32(Console.ReadLine());

					// Success becomes true if int number readline doesn't throw exception
					success = true;
				}
				catch (FormatException fe)
				{
					Console.WriteLine($"{fe}");
				}
				catch (OverflowException oe)
				{
                    Console.WriteLine($"{oe}");
                }
				catch (Exception e)
				{
                    Console.WriteLine($"{e}");
                }

			Console.WriteLine("Code still moves on and this will work");
			}
        }
	}
}
