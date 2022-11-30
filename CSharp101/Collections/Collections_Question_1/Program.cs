using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_Question_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Question - 1: Put the 20 positive integers entered from the keyboard into 2 separate lists as prime and non-prime.
                (Write using the ArrayList class.)

                * Block negative and non-numeric entries.
                * Print the elements of each array in ascending order.
                * Print the number of elements and the average of both arrays to the screen.
            */

            Console.WriteLine("Please enter 20 positive integers.");

            ArrayList primeNumbers = new ArrayList();
            ArrayList nonPrimeNumbers = new ArrayList();

            int counter = 0;
            while (counter < 20)
            {
                string inputStr = Console.ReadLine();
                int enteredNumber;
                if (Int32.TryParse(inputStr, out enteredNumber))
                {
                    if (enteredNumber > 0)
                    {
                        if (IsPrime(enteredNumber))
                            primeNumbers.Add(enteredNumber);
                        else
                            nonPrimeNumbers.Add(enteredNumber);
                    }
                    else Console.WriteLine("The number entered is invalid. Please enter a positive integer.");
                }
                else
                {
                    Console.WriteLine("The number entered is invalid. Please enter a positive integer.");
                }

                counter = primeNumbers.Count + nonPrimeNumbers.Count;
            }

            Console.WriteLine("Your prime numbers:");
            ReverseSortAndPrint(primeNumbers);
            Console.WriteLine("\n\nYour non-prime numbers:");
            ReverseSortAndPrint(nonPrimeNumbers);

            Console.ReadLine();
        }

        static bool IsPrime(int number)
        {
            if(number < 2) return false;

            int counter = 0;
            for (int i = 1; i <= number; i++)
            {
                if(number % i == 0) counter++;

                if (counter > 2) return false;
            }
            return true;
        }

        static void ReverseSortAndPrint(ArrayList arrayList)
        {
            arrayList.Sort();
            arrayList.Reverse();

            foreach (int item in arrayList)
            {
                Console.Write(" " + item.ToString());
            }
            Console.WriteLine("");
        }
    }
}
