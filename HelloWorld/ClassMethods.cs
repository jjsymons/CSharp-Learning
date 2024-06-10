using System;

namespace ClassMethods
{
    class ClassMethodClass
    {
        class Person
        {
            private string fName;
            private string lName;
            private int age;

            public string ReturnDetails()
            {
                return $"User {fName} {lName} is {age} years old";
            }
            public Person(string fName, string lName, int age)
            {
                this.fName = fName;
                this.lName = lName;
                this.age = age;
            }
        }
        public static void programFunction()
        {
            Person person = new Person("Joe", "Symons", 28);
            Console.WriteLine(person.ReturnDetails());
            // Console.WriteLine(person.fName); doesn't work as now private fields
        }
    }
}

