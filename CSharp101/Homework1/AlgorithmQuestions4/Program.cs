using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmQuestions4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                In a console application, ask the user to type a sentence.
                Print the total number of words and letters in the sentence to the console.
            */

            Console.WriteLine("Please enter a sentence.");
            string sentence = Console.ReadLine();

            string[] words = sentence.Split(' ');

            sentence = sentence.Replace(" ", "");
            Console.WriteLine("The sentence you entered consists of " + words.Length + " word(s) and " + sentence.Length + " characters excluding spaces.");

            Console.ReadLine();
        }
    }
}
