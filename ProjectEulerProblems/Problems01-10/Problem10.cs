using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerProblems
{
    //Finds all primes up to a given number and returns the sum.
    //Runs in around 30Ms.
    public static class Problem10
    {
        public static void SumOfPrimes(int lim)
        {
            List<long> primeNumbers = Problem07.PrimeNumberList(lim).ConvertAll(i => (long)i); //Converts the return list of ints to longs to allow the summation.

            Console.WriteLine(primeNumbers.Sum());
        }
    }
}
