/* File Name: Week6Project1
 * Programmer: Nasi Bode
 * Problem Statement: Write aprogram that will create a copy of an array. 
 * Overall Plan: 
 * 1. Print welcoming message to the screen
 * 2. Create an inital array of 10 items
 * 3. Create second array variable using the Length method to find the size of the original array
 * 4. Create a loop to read values of original array and place them in the new array
 * 5. Print the contents of both arrays to the screen
 * 
 */


using System;

namespace Week6Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            //print welcoming message to the screen
            Console.WriteLine("This program will copy an array!");

            //create an array of size 10 with int values
            int[] originalArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

            //print original Array
            Console.WriteLine("This is the original array");
            foreach (int i in originalArray)
            {
                Console.Write("{0} ", i);
            }

            //Create a copy array
            int[] copyArray = new int[originalArray.Length];

            //copy originalArray values to copyArray
            originalArray.CopyTo(copyArray, 0);


            //print the copyArray to the screen
            Console.WriteLine("\nThis is the copy array");
            foreach (int i in copyArray)
            {
                Console.Write("{0} ", i);
            }
        }
    }
}
