using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextStatsLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            //call TextStats
            TextStats(" I’ve missed more than 9000 shots in my career. I’ve lost almost 300 games. 26 times I’ve been trusted to take the game winning shot and missed. I’ve failed over and over and over again in my life. And that is why I succeed. –Michael Jordan");
            Console.ReadKey();
        }
        static void TextStats(string input)
        {
            //made a list to pull words out of
            List<string> list = input.Split(' ').ToList();
            //use .Length to find num of characters in string
            Console.WriteLine("Number of characters: " + input.Length);
            //use .Count to find num of words in list
            Console.WriteLine("Number of words: " + list.Count);
            //to find the vowels seach for any instance of aeiou using .Where and changing x to a string the to lower case the see if it contains the vowel
            //then use the count to get the number of vowels
            Console.WriteLine("Number of Vowels: " + input.Where(x => x.ToString().ToLower().Contains("aeiou")).Count());
            //the same as vowels but with consonants
            Console.WriteLine("Number of Consonants: " + input.Where(x => x.ToString().ToLower().Contains("qwrtypsdfghjklzxcvbnm")).Count());
            //same as vowels and consonats but with special characters
            Console.WriteLine("Number of Special Characters: " + input.Where(x => x.ToString().Contains(",.?/!():")).Count());
            //find the longest word with orderbydescending
            Console.WriteLine("Longest Word: " + list.OrderByDescending(x => x.Length).First());
            //find the shortest word
            Console.WriteLine("Shortest Word: " + list.OrderBy(x => x.Length).Skip(1).Take(2).First());
        }
    }
}
