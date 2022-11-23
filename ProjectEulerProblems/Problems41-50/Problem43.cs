using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerProblems
{
    //Finds all the numbers that are 0-9 pandigital and prime divisible such is stated in the prime divisible function. Then sums them.
    // Runds in arounf 1500Ms.

    public class Problem43
    {
        public static void SubStringDivisibility()
        {
            List<long> pandigitalPrimeDivisibleNumbers = new List<long>();
            List<string> permutations = new List<string>();
            Problem24.Permute("0123456789", 0, 9, permutations);

            for (int i = 0; i < permutations.Count(); i++)
            {
                if (SubStringPrimeDivisbility(permutations[i]) && permutations[i][0] != '0')
                {
                    pandigitalPrimeDivisibleNumbers.Add(Convert.ToInt64(permutations[i]));
                }
            }

            for(int i=0; i<pandigitalPrimeDivisibleNumbers.Count();i++)
            {
                Console.WriteLine(pandigitalPrimeDivisibleNumbers[i]);
            }

            Console.WriteLine("The sum of these numbers is " + pandigitalPrimeDivisibleNumbers.Sum());
        }

        public static bool SubStringPrimeDivisbility(string str)
        {
            if(Convert.ToInt32(str.Substring(1,3)) % 2 ==0 && Convert.ToInt32(str.Substring(2, 3)) % 3 == 0 && Convert.ToInt32(str.Substring(3, 3)) % 5 == 0 &&
                Convert.ToInt32(str.Substring(4, 3)) % 7 == 0 && Convert.ToInt32(str.Substring(5, 3)) % 11 == 0 && Convert.ToInt32(str.Substring(6, 3)) % 13 == 0 &&
                Convert.ToInt32(str.Substring(7, 3)) % 17 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
