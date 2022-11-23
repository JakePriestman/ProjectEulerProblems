using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerProblems
{
    //Finds the largest prime under 1000000 which can be written as the most consecutive primes.
    //Runs in 70Ms.
    public class Problem50
    {
        public static void ConsecutivePrimeSum(int lim)
        {
            int numberofPrimes = 0;
            int result = 0;
            List<int> primeNumbers = Problem07.PrimeNumberList(lim);
            List<int> primeNumberSums = new List<int>() {0};

            for(int i = 0; i < primeNumbers.Count; i++)
            {
                primeNumberSums.Add(primeNumbers[i] + primeNumberSums[i]);
            }

            for(int i = numberofPrimes; i < primeNumberSums.Count(); i++)
            {
                for(int j = i-(numberofPrimes+1); j >= 0; j--)
                {
                    if(primeNumberSums[i] - primeNumberSums[j] > lim)
                    { break; }

                    if (primeNumbers.Contains(primeNumberSums[i] - primeNumberSums[j]))
                    {
                        numberofPrimes = i - j;
                        result = primeNumberSums[i] - primeNumberSums[j];
                    }
                }
            }
            Console.WriteLine(result);
            Console.WriteLine(numberofPrimes);
        }
    }
}
