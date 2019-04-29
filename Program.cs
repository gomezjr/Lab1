using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the Pig Latin Translator!");
            Console.WriteLine();

            Console.WriteLine("Please enter a word to be translated");
            string word1 = Console.ReadLine().ToLower();



            Console.WriteLine("Please enter what you want translated:");


            string pigLatin = "";
            string firstLetter;
            string restOfWord;
            string vowels = "aeiou";
            int letterPosition;

            foreach (string word in word1.Split())
            {

                firstLetter = word.Substring(0, 1);
                restOfWord = word.Substring(1, word.Length - 1);
                letterPosition = vowels.IndexOf(firstLetter);

                if (letterPosition == -1)

                {
                    pigLatin = restOfWord + firstLetter + "ay";
                }

                else

                {
                    pigLatin = word + "way";
                }
                Console.WriteLine(pigLatin);
                Console.ReadLine();
            }


        }
    }
}
