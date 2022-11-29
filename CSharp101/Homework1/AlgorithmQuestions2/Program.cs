using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmQuestions2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Homework:
                In a console application, ask the user to enter two positive numbers (n, m).
                Then ask the user to enter n positive numbers. From the numbers entered by the user.
                Print the numbers that are divisible by m to the console.

                Note: No exception checks have been made.
            */

            int n, m;
            Console.WriteLine("Write how many numbers you want to enter: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the multiplier: ");
            m = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Please enter the number: ");

                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("****************\nThe numbers you enter are divisible by the multiplier (" + m + ")");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % m == 0) Console.WriteLine(arr[i]);
            }

            Console.ReadLine();
        }
    }
}
