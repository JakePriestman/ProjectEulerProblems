using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerProblems
{
    //Finds the largest palindromic number as a product of 3 digidt numbers
    //Run time is O(n^2) I think
    //Runs in around 36Ms.
    public static class Problem04
    {
        public static void LargestPalindromicNumberAsAProductOf3DigitNumbers()
        {
            List<int> palindromicNumbers = new List<int>();

            for (int i = 100; i <= 999; i++)
            {
                for (int j = 100; j <= 999; j++)
                {
                    string product = Convert.ToString(i * j);
                    if(isPalindrome(product) && !palindromicNumbers.Contains(i*j)) //Checks product is palindromic and isnt in the list already.
                    {
                        palindromicNumbers.Add(i * j);
                    }
                }
            }
            Console.WriteLine(palindromicNumbers.Max()); //Prints the largest.
        }

        public static bool isPalindrome(string str) //Method to check if number is a palindrome.
        {
            for (int n = 0; n < str.Length; n++)
            {
                if (str[n] != str[str.Length - n - 1])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
