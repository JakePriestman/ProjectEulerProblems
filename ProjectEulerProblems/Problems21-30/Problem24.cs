using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerProblems
{
    //Finds the permutations of a string and then sorts them into lexicographic order and then prints the 1 millionth element.
    //Runs in around 9500Ms.
    public static class Problem24
    {
        public static void LexicographicPermutations(string str)
        {
            
            List<string> permutations = new List<string>();
            
            Permute(str, 0, str.Length - 1, permutations);

            permutations.Sort();

            //Console.WriteLine(permutations[999999]);
            Console.WriteLine(permutations.Count());

        }

        public static List<string> Permute(string str, int x, int y, List<string> permutations)//Gets all permutations of given string.
        {

            if (x == y)
            {
                permutations.Add(str);
            }

            else
            {
                for (int i = x; i <= y; i++)
                {
                    str = Swap(str, x, i);
                    Permute(str, x + 1, y, permutations);
                    str = Swap(str, x, i);

                }
            }
            return permutations;
        }

        public static string Swap(string a, int i, int j)//Swaps numbers in string.
        {
            if(i == j)
            { return a; }

            char temp;
            char[] charArray = a.ToCharArray();
            temp = charArray[i];
            charArray[i] = charArray[j];
            charArray[j] = temp;
            string s = new string(charArray);
            return s;

        }
    }
}
