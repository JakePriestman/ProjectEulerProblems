using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerProblems
{
    //Finds and lists the prime factors of a given number. Then gives the largest. Given Numer is 600851475143.
    //Run time is O(n).
    //Runs in around 30Ms.
    public static class Problem03
    {
        public static void LargestPrimeFactor(long num)
        {
            List<int> primeFactors = PrimeFactors(num);

            for (int i = 0; i < primeFactors.Count; i++) //Writes out the prime factors.
            { Console.WriteLine(primeFactors[i]); }

            Console.WriteLine(primeFactors.Max()); //Prints the max prime factor.
        }

        public static List<int> PrimeFactors(long num) //Finds the prime factors upto a given number.
        {
            List<int> primeFactors = new List<int>();

            for (int i = 2; i <= num; i ++)
            {
               while (num % i == 0)
                {
                    num /= i;
                    if(!primeFactors.Contains(i))
                    {
                        primeFactors.Add(i);
                    }
                }
            }

            return primeFactors;
        }
    }
}
