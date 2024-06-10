using System;

namespace Classes
{
    public class ClassLessons
    {
        public static void Cls()
        {
            Person person1 = new Person(); // Blank for empty constructor
            Person person2 = new Person("Joe"); // Blank
            Person person3 = new Person(21); // Age 
            Person person4 = new Person(name:"Joe", age:23); // Name, age
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
            return new Person(name, ageGiven);
        }
    }
    public class Person
    {
        public string name;
        public int age;


        // Overloads for taking multiple class constructors, so that if there is issues with the args given,
        // then the program won't error as default values will be used 
        public Person()// Blank
        {
            this.name = "";
            this.age = -1;
        }
        public Person(string name)
        {
            this.name = name;
            this.age= -1;
        }
        public Person(int age)
        {
            this.name = "";
            this.age = age;
        }
        public Person(string name, int age) 
        {
            this.name = name;
            this.age = age;
        }
    }
}

