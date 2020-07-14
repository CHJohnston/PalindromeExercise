using System;
using System.Linq;

namespace PalindromeExercise
{
    class Program
    {
        static void Main(string[] args)
        {   //The following was used test the IsAPalindrome logic
            string str = "level";
            var word1 = str.ToLower();
            //var word2 = word1.Reverse().ToArray();
            string word2 = new string(word1.Reverse().ToArray());
            Console.WriteLine($"{word1}  {word2}");
        }
    }
}
