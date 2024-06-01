using System;

namespace Strings
{
    public class StringsLessons()
    {
        public static void HelloWorld()
        {
            Console.WriteLine("Hello World");
        }
        public static void StringDataTypes()
        {
            string name = "Joe";
            char letter = 'J';
            Console.WriteLine(name);
            Console.WriteLine(letter);

            string numberString = "24";
            int convertedInt = Convert.ToInt32(numberString);
            Console.WriteLine(convertedInt);

            string longString = "50000000000";
            long convertedLong = Convert.ToInt64(longString);

            string floatString = "0.50000";
            float convertedFloat = Convert.ToSingle(floatString);

            string doubleString = "1.1415973";
            double convertedDouble = Convert.ToDouble(doubleString);

            string decimalString = "14.33";
            decimal convertedDecimal = Convert.ToDecimal(decimalString);


        }
        public static void StringLitterals()
        {
            string fname = "Joe",
                lName = "Symons";

            double scoreOnTest = 100 / 44D;
            Console.WriteLine(scoreOnTest);

            // Using $ as string interpolation, makes formatting better. 
            Console.WriteLine($"{fname} {lName} is a pretty cool guy. He scored a {scoreOnTest:0.0#} on the big test", scoreOnTest);

            // Escape Charecter \, \t \" etc 
            // Console.WriteLine("She said "Hello, How are you ? ""); This fails as the speech marks make She said the only part in quotes
            //      and Hello, How are you? outside the quotes.

            // Solution

            Console.WriteLine("She Said \"Hello How are you?\"");
            string path = "C:\\Users\\joejs\\Documents\\Code\\C#\\HelloWorld"; // This escapes \ so when fed into code appears as 
            // C:\Users\joejs\ etc

            // String Verbatim

            string newPath = @"C:\Users\joejs\Documents\Code\C#\HelloWorld"; // This is used verbatim, no escape chars needed
            Console.WriteLine(newPath);

            // However, it does have some quirks

            string sentence = @"He said ""What's up fellow kids?"""; // You have to use two " in order to quote.
            Console.WriteLine(sentence);
            string newSentence = "Cb is not a 'real' programming language"; // ' are fine when used within a "" or with @"..."
            Console.WriteLine(newSentence);

            // if you need to use a escape char for something where you are using @ then you can do it via the following

            string finalSentence = @"I was like ""OMG""" + "\n\t" + @"Lucy asked ""What did he say?!""" + "\n" + @"""I really shouldn't say""";
            Console.WriteLine(finalSentence);

            // String concat

            string concat = string.Concat(newSentence, " Says who? Says ", fname, " ",lName);
            Console.WriteLine(concat);
        }
        public static void StringIterationLoop()
        {
            string message = "Hi";
            // message = char[] = ['H', 'i'] this is an array

            // to write out part of the sentence you can use []

            Console.WriteLine(message[0]); // H
            Console.WriteLine(message[1]); // i
            //Console.WriteLine(message[2]); // ERROR out of length, how can this be avoided?

            // Solution

            for (int i = 0; i < message.Length; i++) 
            {
                Console.WriteLine(message[i]);
            }
        }
        public static void StringIfNotNull()
        {
            Console.WriteLine("Enter your name");
            //string name = Console.ReadLine();
            string name = null; // Example shows that Equals fails here, because you are calling a method on a null object. Crashes program.

            // Methods to check if anything was entered
            if (name != "")
            {
                Console.WriteLine("1");
            }
            //if (!name.Equals(""))
            //{
                //Console.WriteLine("2");
            //}
            // Issue with the above methods is that if the answer is null, program still executes.

            // Solution

            if (!string.IsNullOrEmpty(name))
            {
                Console.WriteLine("3");
            }
        }
    }
}
