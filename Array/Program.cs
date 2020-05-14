using System;
using Array;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            // Array
            //int[] userAge = { 21, 23, 35, 40, 52 }; // initializing array
            //Console.WriteLine(userAge[1]);

            int[] userAge = new int[5]; // declares and creates an array for storing 5 integers
            userAge = new[] { 21, 23, 35, 45, 52 }; // initializing array
            userAge[2] = userAge[2] + 10;   // added 10 to the third element of the array
            Console.WriteLine(userAge[2]);
            Console.WriteLine(userAge.Length);  // show the lenght of the array

            // Copy()
            int [] source = { 12, 1, 5, -2, 16, 14 };
            int [] dest = { 1, 2, 3, 4 };
            System.Array.Copy(source, dest, 4); // copies the elements of source array from index 0 to 3 into dest array

            Console.WriteLine("Printing array: ");
            for (int i = 0; i < dest.Length; i++)
            {
                Console.Write($"{dest[i]} ");
            }

            // Sort()
            int[] numbers = { 12, 1, 5, -2, 16, 14 };
            System.Array.Sort(numbers); // sorting elements in ascending order
            Console.WriteLine("\nSorting array {12, 1, 5, -2, 16, 14}:  ");
            for ( int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{numbers[i]} ");
            }


            // IndexOf()
            int[] digits = { 10, 30, 44, 21, 51, 21, 61, 24, 14 };
            int ans = System.Array.IndexOf(digits, 21); // search for the index of a given number inside an array
            Console.WriteLine($"\n{ans}");  
            Console.Read();


        }
    }
}
