using System;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "Hello World";
            string anotherMessage = "";
            string myName = "Hello World, " + "my name is Herbert.";
            Console.WriteLine(myName);

            // .Lenght
            Console.WriteLine($"The String \"Hello World\" has {"Hello World".Length} characters.");

            // Substring()
            string newMessage = message.Substring(0, 5);  // substring is used to extract a substring from a longer string
            Console.WriteLine(newMessage);

            // Equals()
            string firstString = "This is Herbert";
            string secondString = "Hello";

            bool ans = firstString.Equals("This is Herbert"); // Equals() compares if two strings are identical
            bool ans2 = secondString.Equals(firstString);
            Console.WriteLine(ans);
            Console.WriteLine(ans2);

            // Split()
        }
    }
}
