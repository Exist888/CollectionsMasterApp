using System;
using System.Collections.Generic;
using System.Globalization;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create ⬇⬇⬇

            #region Arrays
            //TODO: Create an integer Array of size 50
            int[] intArray1 = new int[50];  //will be 50 zeros until indexes are populated with specific numbers

            //TODO: Create a method to populate the number array with 50 random numbers that are between 0 and 50
            Populater(intArray1);
            
            Console.WriteLine("Here are 50 random numbers:");
            foreach (var num in intArray1)
            {
                Console.WriteLine(num);
            }

            //TODO: Print the first number of the array
            Console.WriteLine("Here is the first number from the array above:");
            Console.WriteLine(intArray1[0]);

            //TODO: Print the last number of the array
            Console.WriteLine("Here is the last number from the array above:");
            Console.WriteLine(intArray1[intArray1.Length-1]);

            Console.WriteLine("All Numbers Original");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(intArray1);
            Console.WriteLine("-------------------");

            //TODO: Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*  1) First way, using a custom method => Hint: Array._____(); 
                2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇)
            */

            Console.WriteLine("All Numbers Reversed:");

            Console.WriteLine("---------REVERSE CUSTOM------------");
            
            ReverseArray(intArray1);
            NumberPrinter(intArray1);

            Console.WriteLine("-------------------");

            //TODO: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");
            
            ThreeKiller(intArray1);
            NumberPrinter(intArray1);

            Console.WriteLine("-------------------");

            //TODO: Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");
            
            Array.Sort(intArray1);
            NumberPrinter(intArray1);

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //TODO: Create an integer List

            List<int> newIntList = new List<int>();

            //TODO: Print the capacity of the list to the console
            Console.WriteLine("New integer list capacity:");
            Console.WriteLine(newIntList.Capacity);

            //TODO: Populate the List with 50 random numbers between 0 and 50 you will need a method for this    
            Populater2(newIntList);
            
            //TODO: Print the new capacity
            Console.WriteLine("Populating integer list with random numbers, new capacity:");
            Console.WriteLine(newIntList.Capacity);
            
            Console.WriteLine("---------------------");

            //TODO: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            Console.WriteLine("What number will you search for in the number list?");

            var wasParsedSuccess = int.TryParse(Console.ReadLine(), out int searchNumber);
            NumberChecker(newIntList, searchNumber);

            while (!wasParsedSuccess)
            {
                Console.WriteLine("Invalid entry. Please type in a whole number (between 1 and 50).");
                wasParsedSuccess = int.TryParse(Console.ReadLine(), out searchNumber);
            }
            
            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            //NumberPrinter(newIntList);
            Console.WriteLine("-------------------");
            
            //TODO: Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");
            OddKiller(newIntList);
            NumberPrinter(newIntList);
            
            Console.WriteLine("------------------");

            //TODO: Sort the list then print results
            Console.WriteLine("Sorted Evens!!");
            newIntList.Sort();
            NumberPrinter(newIntList);
            
            Console.WriteLine("------------------");

            //TODO: Convert the list to an array and store that into a variable

            var newInstListToArray = newIntList.ToArray();

            //TODO: Clear the list

            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 3 == 0)
                {
                    numbers[i] = 0;
                }
            }
        }

        private static void OddKiller(List<int> numberList)
        {
            for (int i = numberList.Count- 1; i >= 0; i--)   //Note to self: variable name i also becomes a spot in the index
            {
                if (numberList[i] % 2 != 0)
                {
                    numberList.Remove(numberList[i]);
                    //i--;
                }
            }
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            if (numberList.Contains(searchNumber))
            {
                Console.WriteLine($"We have found {searchNumber}!");
            }
            else
            {
                Console.WriteLine($"We have not found {searchNumber}");
            }
            // foreach (var specificNum in numberList)
            // {
            //     if (specificNum == searchNumber)
            //     {
            //         Console.WriteLine($"We have found: {searchNumber}");
            //     }
            //     else
            //     {
            //         Console.WriteLine("Number not in list.");
            //     }
            // }
        }

        private static void Populater2(List<int> numberList)
        {
            Random rng = new Random();

            for (int i = 1; i <= 50; i++)
            {
                numberList.Add(rng.Next(0, 50));
            }
        }

        private static void Populater(int[] numbers)
        {
            Random rng = new Random();

            for (int i = 0; i <= numbers.Length - 1; i++)
            {
                numbers[i] = rng.Next(0, 50);
            }
        }        

        private static void ReverseArray(int[] array)
        {
            Array.Reverse(array);
        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
