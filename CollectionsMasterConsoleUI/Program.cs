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
			int[] myArray = new int[50];
                    
            //TODO: Create a method to populate the number array with 50 random numbers that are between 0 and 50
			 Populater(myArray);
         
            //TODO: Print the first number of the array
			Console.WriteLine($"First element of random number array = {myArray[0]}");

            //TODO: Print the last number of the array
			Console.WriteLine($"Last element of random number array = {myArray[myArray.Length-1]}";          

            Console.WriteLine("All Numbers Original");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(myArray);
            Console.WriteLine("-------------------");

            //TODO: Reverse the contents of the array.
            //Do this 2 different ways
            /*  1) First way, using a custom method => Hint: Array._____(); 
                2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇)
                Then print BOTH reversed arrays to the console.
            */
	        Array.Sort(myArray); 

            Console.WriteLine("All Numbers Reversed:");

            Console.WriteLine("---------REVERSE CUSTOM------------");
	    // myArray.Reverse();
	       ReverseArray( myArray );
	        NumberPrinter( myArray );

            Console.WriteLine("-------------------");

            //TODO: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");
			ThreeKiller( myArray );
			 NumberPrinter( myArray );
            
            Console.WriteLine("-------------------");

            //TODO: Sort the array in order now
            /*      Hint: Array.____()      */
			 Array.Sort( myArray );
            Console.WriteLine("Sorted numbers:");
			NumberPrinter( myArray );
	      

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion
            int[] numbers = { 1, 2, 3, 4, 5 };
            ReverseArray(numbers);


	    // **********************************************************************************************
            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //TODO: Create an integer List
				var numbersList = new List<int>();
            
            //TODO: Print the capacity of the list to the console
			Console.WriteLine($"List capacity = numbersList.capacity");
            

            //TODO: Populate the List with 50 random numbers between 0 and 50 you will need a method for this  
			NumberPopulater( numbersList );          
            

            //TODO: Print the new capacity
            Console.WriteLine($"New list capacity = numbersList.capacity");

            Console.WriteLine("---------------------");

            //TODO: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            Console.WriteLine("What number will you search for in the number list?");
            string input1 = Console.ReadLine();
			 int searchNumber = int.Parse(input1);

            Console.WriteLine("-------------------");
            NumberChecker(numbersList, searchNumber);

            Console.WriteLine("All Numbers:");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            //NumberPrinter(numbersList);
            Console.WriteLine("-------------------");


            //TODO: Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");
			OddKiller( numbersList );
	    // NumberPrinter(numbersList);
            
            Console.WriteLine("------------------");

            //TODO: Sort the list then print results
			numbersList.Sort();
	
            Console.WriteLine("Sorted Evens!!");
            
            Console.WriteLine("------------------");

            //TODO: Convert the list to an array and store that into a variable
			myArray = numbersList.Array();
            
            //TODO: Clear the list
            numbersList.Clear();

	    Console.WriteLine($"new list capacity = {numbersList.capacity}");

            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {
		for ( i = 0; i < numbers.length-1; i++ ) {
			if ( numbers[i] % 3 == 0 ) {
				numbers[i] = 0;
			}
		}
        }

        private static void OddKiller(List<int> numberList)
        {
		numbersList.RemoveAll(n => n % 2 == 1);
	            
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
		foreach (int number in numberList)
		{
			if ( number == searchNumber ) {
				Console.WriteLine($"Your number {searchNumber} has been found.");
				break;
    			}
		}
	}
            

        private static void Populater(List<int> numberList)
        {
	    Random rng = new Random();

	    for ( i = 0; i < numberList.Count; i++ ) {

		    numberList.Add(rng.Next(0,51);
            }

        }

        private static void Populater(int[] numbers)
        {
            Random rng = new Random();

	    for ( int i = 0; i < numbers.length; i++ ) {
		numbers[i] = rng.Next(0,51);
	    }	   
        }        

        private static void ReverseArray(int[] array)
        {
	    int start = 0;
	    int end = array.length - 1;
	    int tmp;

	    while( start < end ) {
		tmp = array[start];
		array[start] = array[end];
		array[end] = tmp;

		start++;
		end--;
		
            //Array.Reverse(array);
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