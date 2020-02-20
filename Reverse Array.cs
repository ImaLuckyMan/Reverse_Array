using System;

namespace Reverse_Array
{
    class Reverse_Array
    {
        static void Main(string[] args)             // Enter point for the program
        {
            int[] given = { 1, 2, 3, 4 };           // Test numbers as given input
            Reversed(given);                        // Used to input array into method below
        }

        public static void Reversed(int[] input)    // Method to reverse the order of input
        {
            string output="";                       // Creates an empty place holder for the reversed input string
            int i;                                  // Standard int for loop Indices reference

            for (i=input.Length-1;i>=0;--i)         // for loop steps backward through input begining at end and working backwards
            {
                output += input[i];                 // adds the int at each index to the output string one at a time
            }
            Console.WriteLine(output);              // outputs the result to the screen

        }


    }
}
