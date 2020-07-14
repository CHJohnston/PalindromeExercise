using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string str) 
        {   
            //Assign the return value
            bool isAPalindrome = false;            
             
            //Convert the string to lower case
            var word1 = str.ToLower();
            
            //Reverse the string and output the ansewer to a new string
            string word2 = new string(word1.Reverse().ToArray()); 
            
            //Compare the two strings to see if they match
            if (word1 == word2) 
            {
                isAPalindrome = true;
            }
            return isAPalindrome;
        }
    }
}
