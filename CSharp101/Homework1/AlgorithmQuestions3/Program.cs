using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmQuestions3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                In a console application, ask the user to enter a positive number (n).
                Then ask the user to enter n words.
                Print the words entered by the user from the end to the beginning to the console.
                
                Note: No exception checks have been made.
            */

            int n;
            Console.WriteLine("Write how many numbers you want to enter:");

            n = Convert.ToInt32(Console.ReadLine());

            string[] arr = new string[n];
            while (n > 0)
            {
                n--;
                arr[n] = Console.ReadLine();
                
            }

            arr.Reverse();
            Console.WriteLine("Words from last to first.");
            foreach (string item in arr)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
