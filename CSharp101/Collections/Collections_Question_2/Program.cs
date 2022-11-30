using System;

namespace Collections_Question_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Question - 2:
                Find the largest 3 and the smallest 3 of the 20 numbers entered from
            the keyboard and print them on the console.
                Take the average of both groups and print them to the console.
                Print the sum of the averages to the console. (Write using the Array class.)
            */

            Console.WriteLine("Please enter 20 positive integers.");

            int[] enteredNumbers = new int[20];

            int counter = 0;
            while (counter < 20)
            {
                string inputStr = Console.ReadLine();
                if (Int32.TryParse(inputStr, out int enteredNumber))
                {
                    if (enteredNumber > 0)
                    {
                        enteredNumbers[counter] = enteredNumber;
                        counter++;
                    }
                    else Console.WriteLine("The number entered is invalid. Please enter a positive integer.");
                }
                else
                {
                    Console.WriteLine("The number entered is invalid. Please enter a positive integer.");
                }

            }

            Array.Sort(enteredNumbers);

            PrintTheThreeBigNumbers(enteredNumbers);

            PrintTheThreeSmallNumbers(enteredNumbers);

            PrintSumsAndAveragesOfThreeBigAndSmallNumbers(enteredNumbers);

            Console.ReadLine();
        }

        static void PrintTheThreeBigNumbers(int[] arr)
        {
            Console.WriteLine("Big numbers:");
            for (int i = arr.Length -1; i >= arr.Length - 3; i--)
            {
                Console.Write(" " + arr[i]);
            }
            Console.WriteLine("\n******************\n");
        }

        static void PrintTheThreeSmallNumbers(int[] arr)
        {
            Console.WriteLine("Small numbers:");
            for (int i = 0; i < 3; i++)
            {
                Console.Write(" " + arr[i]);
            }
            Console.WriteLine("\n******************\n");
        }

        static void PrintSumsAndAveragesOfThreeBigAndSmallNumbers(int[] arr)
        {
            double smallNumsSum = arr[0] + arr[1] + arr[2];
            Console.WriteLine("Sum of small numbers: " + smallNumsSum + "\nAverage of small numbers: " + (smallNumsSum / 3));

            double bigNumsSum = arr[arr.Length-1] + arr[arr.Length - 2] + arr[arr.Length - 3];
            Console.WriteLine("Sum of big numbers: " + bigNumsSum + "\nAverage of big numbers: " + (bigNumsSum / 3));

            Console.WriteLine("Overall Average: " + ((smallNumsSum + bigNumsSum) / 2));
            Console.WriteLine("******************");
        }

    }
}
