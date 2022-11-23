using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerProblems
{
    //Finds the sum of all palindromic numbers in base 10 and 2 under 1000000. All are odd as numbers are not allowed to lead with a 0 in base 2.
    //Runs in 95Ms
    public class Problem36
    {
        public static void DoubleBasePalindromes()
        {
            List<int> doubleBasePalendromes = new List<int>();

            for(int i=1; i<1000000; i+=2)
            {
                string strBase10 = Convert.ToString(i);
                string strBase2 = Convert.ToString(i,2);
                if (Problem04.isPalindrome(strBase10) && Problem04.isPalindrome(strBase2))
                {
                    doubleBasePalendromes.Add(i);
                }
            }

            Console.WriteLine(doubleBasePalendromes.Sum());
        }
    }
}
