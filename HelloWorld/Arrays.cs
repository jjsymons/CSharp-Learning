using System;

namespace Arrays
{ 
	public class ArrayLessons
	{
		public static void Arrays()
		{
			/*int num1 = 10, 
				num2 = 20, 
				num3 = 40;
			int total = num1 + num2 + num3;

			int[] numbers = new int[3];

			numbers[0] = num1;
			numbers[1] = num2;
			numbers[2] = num3;

            Console.WriteLine($"{num1} {num2} {num3}");

			Console.WriteLine($"{numbers[0]} {numbers[1]} {numbers[2]}");

			for (int i = 0; i < numbers.Length; i++)
			{
				Console.WriteLine(numbers[i]);
			}

			foreach (int num in numbers)
			{
				Console.WriteLine(num);
			}
			// Another way to create a array
			*/

			int[] newArray = new int[]
			{
				11,12,13,14,15,16,17,18,19,1,2,3,4,5,6,7,8,9,10
			};

			// in order to sort an array we can use the following

			string test = " ";
			test = test.Replace(" ", ""); // Returns the string replacing " " with ""

			//Array.Sort(newArray); // Void return so you do not need newArray 

			/*foreach (int num in newArray)
			{
                Console.Write($"{num} ");
            }

			Array.Reverse(newArray);

			Array.Clear(newArray, 3, 7);

            foreach (int num in newArray)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine(""); */

			Console.WriteLine("Write a number to search for between 1 and 20");

			string number = Console.ReadLine();

			bool success = int.TryParse(number, out int intNumber);

			if (success)
			{
                int position = -1;
                position = Array.IndexOf(newArray, intNumber);
                if (position == -1)
                {
                    Console.WriteLine("Not found");
                }
                else
                {
                    Console.WriteLine($"Found {number} at {position}");
                }
            }
			else
			{
                Console.WriteLine($"Sorry, you input '{number}', which is not an integer");
            }


			
		}
	}
}
