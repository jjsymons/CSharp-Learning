using System;

namespace Arrays
{ 
	public class ArrayLessons
	{
		public static void Arrays()
		{
			int num1 = 10, 
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
        }
	}
}
