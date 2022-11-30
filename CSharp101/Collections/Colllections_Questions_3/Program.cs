using System;
using System.Collections.Generic;
using System.Linq;

namespace Colllections_Questions_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Question - 3:
                Write a program that stores the vowels in a sentence entered from
            the keyboard in an array and sorts the elements of the array.
            */

            Console.WriteLine("Please enter a sentence.");
            string sentence = Console.ReadLine().ToLower();

            char[] turkishWovels = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };

            List<char> chars= new List<char>();
            foreach (char item in sentence)
            {
                if (turkishWovels.Contains(item) && !chars.Contains(item))
                {
                    chars.Add(item);
                }
            }

            chars.Sort();
            Console.WriteLine("The vowels in the sentence you entered:");
            foreach (var item in chars)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
