using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerProblems
{
    public static class Problem07
    {
        //Gives the prime number located at a given index.
        //O(N)
        public static void PrimeN(int N)
        {
            List<int> primeNumbers = PrimeNumberList(20*N); //20*N is to ensure that the 10001st prime is in the list.


            Console.WriteLine("The " + N + "th prime number is:" + primeNumbers[N - 1]);
        }

        public static List<int> PrimeNumberList(int lim) //Produces a list of primes with lim indexs.
        {
            List<int> primeNumbers = new List<int>();

            bool[] isPrime = new bool[lim];

            for (int i = 0; i < isPrime.Length; i++) //Intialises the indexes in the list as true.
            {
                isPrime[i] = true;
            }

            for (int i = 2; (i * i) < lim; i++)
            {
                if (isPrime[i] == true)
                {
                    for (int j = i * i; j < lim; j += i) //Falses multiples of i.
                    {
                        isPrime[j] = false;
                    }

                }
            }

            for (int i = 2; i < lim; i++) //Add all i such that isprime[i] is true.
            {
                if (isPrime[i])
                {
                    primeNumbers.Add(i);
                }
            }

            return primeNumbers;
        } 
    }
}
