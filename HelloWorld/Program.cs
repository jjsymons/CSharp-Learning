using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            StringDataTypes();
        }
        static void HelloWorld()
        {
            Console.WriteLine("Hello World");
        }
        static void NumericDataTypes()
        {
            // Methods to declare
            int x = 10;
            int y = 20;
            int z = 40;

            int a, b, c;
            int h = 10, j = 20, k = 30;

            int s = 20,
                t = 40,
                u = 80;

            // Numeric Types
            int age = 28;
            Console.WriteLine(age);
            int ageMinus = -12;
            Console.WriteLine(ageMinus);

            long bigNum = 900000; // Note that the number here wants to be a int32. You must specify the long type in the inception
            Console.WriteLine(bigNum);

            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);

            long realLong = 900000L;
            Console.WriteLine(realLong);
            long realLongMinus = -900000L;
            Console.WriteLine(realLongMinus);

            Console.WriteLine(long.MaxValue);
            Console.WriteLine(long.MinValue);

            double doubleNum = 55.3D;
            Console.WriteLine(doubleNum);
            Console.WriteLine(double.MaxValue);
            Console.WriteLine(double.MinValue);

            float floatNum = 1.0000000004F;
            Console.WriteLine(floatNum);
            Console.WriteLine(float.MaxValue);
            Console.WriteLine(float.MinValue);

            decimal decNum = 12.88M;
            Console.WriteLine(decNum);
            Console.WriteLine(decimal.MaxValue);
            Console.WriteLine(decimal.MinValue);
        }
        static void StringDataTypes()
        {
            string name = "Joe";
            char letter = 'J';
            Console.WriteLine(name);
            Console.WriteLine(letter);

            String ageString = "28"; 
            int convertedAge = Convert.ToInt32(ageString);
            Console.WriteLine(convertedAge);
        }


    }
}
