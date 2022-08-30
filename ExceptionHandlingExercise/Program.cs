using System;
using System.Collections.Generic;
using System.IO;

namespace ExceptionHandlingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // -----------------------------------------------------------------------------
            // First create an char[], it must contain 6 numbers and 3 letters - name it arr
            // Create a list called numbers that will hold integers
            // Create an string variable with an empty string initializer - name it str

            // using a foreach loop, attempt to parse the elements in your char[] with int.Parse()
            // and Exceptions will be thrown 
            // Below we will set this up 
            // ------------------------------------------------------------------------------
            char[] lettsNums = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', '1', '2', '3' };
            List<int> nums = new List<int>();
            var str = "";
            //foreach (var item in lettsNums)
            //{
            //    int.Parse(item);
            //}


            //TODO START HERE:
            foreach (var item in lettsNums)
            {
                try
                {
                    int var1 = int.Parse(item.ToString());
                    nums.Add(var1);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Unable to Parse '{item}'"); 
                }
            }
            // Make a foreach loop to iterate through your character array

            // Now create a try catch


            // Inside your try block
            // set your string variable to each array element in your char[] to .ToString()
            // Now, using int.Parse, parse your string variable and store in an int variable
            // Then add each int to your list

            // catch your Exception:
            // in the scope of your catch you can use the following, 

            //Console.WriteLine($"Unable to Parse '{character}'"); //character will be the name of each item in your collection



            foreach (var num in nums)
            {
                Console.WriteLine(num);
            }
        }
    }
}
