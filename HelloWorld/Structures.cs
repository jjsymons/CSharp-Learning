using System;
using System.Runtime.Versioning;

namespace Structures
{
	public class StructuresLesson 
	{
		struct Person
		{
			public string fName;
			//string lName;
			public int age;

			// Constructor
			public Person(string fName, int age)
			{
				this.fName = fName;
				this.age = age;
			}
		}
		public static void StructLesson()
		{
			Person person = new Person();
			person.fName = "Joe";
			//person.lName does not work because of the protection level
			person.age = 28;

            Console.WriteLine($"{person.fName} is {person.age}");

			Person person2 = ReturnPerson();
			Console.WriteLine("The second person is: ");
			Console.WriteLine($"{person2.fName} - {person2.age}");
        }
		static Person ReturnPerson()
		{
            Console.WriteLine("Enter a name: ");
			string name = Console.ReadLine();
			int ageGiven = 0;
			bool success = false;

			while (!success)
			{
                Console.WriteLine("Enter an age: ");
                success = int.TryParse(Console.ReadLine(), out ageGiven);
            }
			/* constructors allow for Classes to be used more easily, reducing lines of code
			Person person;
			person.fName = name;
			person.age = ageGiven;
			*/

            return new Person(name, ageGiven);
		}
	}
}
