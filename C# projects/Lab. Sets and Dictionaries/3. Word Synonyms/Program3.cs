using System;
using System.Linq;
using System.Collections.Generic;

namespace _3._Word_Synonyms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();
            for (int i = 0; i < count; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                // If word is in dict add a synonym
                if (dictionary.ContainsKey(word))
                {
                    dictionary[word].Add(synonym);
                }
                else // If the word is NOT in dict add it to the dictionary
                {
                    List<string> synonimsOfCurrentWord = new List<string>();
                    synonimsOfCurrentWord.Add(synonym);
                    dictionary.Add(word, synonimsOfCurrentWord);
                }


            }

            // Print result

            // Variant 1
            //foreach (KeyValuePair<string, List<string>> pair in dictionary)
            //{
            //  Console.WriteLine($"{pair.Key} - {string.Join(", ", pair.Value)}");
            //}

            // Variant 2
            foreach (string word in dictionary.Keys)
            {
                Console.WriteLine($"{word} - {string.Join(", ", dictionary[word])}");
            }
        }
    }
}
