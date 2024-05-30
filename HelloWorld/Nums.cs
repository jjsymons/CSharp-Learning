using System;

namespace Nums
{
    public class Numerical
    {
        public static void NumericDataTypes()
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
        public static void BooleanType()
        {
            bool male = true;
            bool female = false;

            Console.WriteLine(male);
            Console.WriteLine(female);
        }
        public static void Operators()
        {
            int age = 21;

            // Add
            age++;
            Console.WriteLine(age);

            age = age + 1;
            Console.WriteLine(age);

            age += 1;
            Console.WriteLine(age);

            // Minus
            age--;
            Console.WriteLine(age);

            age = age - 1;
            Console.WriteLine(age);

            age -= 1;
            Console.WriteLine(age);

            age = 20;
            age *= 10;
            Console.WriteLine(age);

            age = 20;
            age /= 3;
            Console.WriteLine(age);
            // Gives 6 as can't give decimal of 6.666..7

            double solution = 20;
            solution /= 3;
            Console.WriteLine(solution);

            // String operations

            string name = "Joe";
            name += " is here";

            Console.WriteLine(name);

            // name -= " is here". will not work

            char l = 'J';
            l += 'o';

            Console.WriteLine(l);
            // Cannot add letters to char, will add values to work out the number represented by their ascii
            // Therefore this output is 1

            int i = 0;

            Console.WriteLine(i++);
            // Output = 0, compiler is being told to add 1 after. 

            Console.WriteLine(i);
            // output = 1

            Console.WriteLine(++i);
            // output 2, as ++ occurs before
        }

        public static void Modulas()
        {
            int numOne = 10;
            int numTwo = 3;

            int divided = numOne / numTwo;
            Console.WriteLine(divided);
            // Gives 3, as can't have a float in a int

            int div = numOne % numTwo;
            Console.WriteLine(div);
        }
    }
}

