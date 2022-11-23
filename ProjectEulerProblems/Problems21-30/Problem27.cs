using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerProblems
{
    //Returns the product of a and b that produce most primes from n^2+an+b for |a| <1000, |b| <=1000 and n>=0.
    //Runs in around 1900Ms.
     public static class Problem27
    {
        public static void QuadraticPrimes()
        {
            int aMax=0, bMax=0, nMax=0;
            List<int> primeNumbers = Problem07.PrimeNumberList(87400);
            

            for(int a = -999; a<1000; a++)
            {
                for(int b = -1000; b <= 1000; b++)
                {
                    int n = 0;
                    while(isPrime(Math.Abs(n*n + a*n + b), primeNumbers))
                    {
                        n++;
                    }
                    if(n > nMax) //Updates the max number of primes and a and b.
                    { 
                        aMax=a;
                        bMax=b;
                        nMax = n;
                    }
                }
            }

            Console.WriteLine("a = " +aMax);
            Console.WriteLine("b = "+bMax);
            Console.WriteLine("Number of Primes is "+nMax);
            Console.WriteLine("The Product is " + (aMax * bMax));
        }


        public static bool isPrime(int number,List<int> primeNumbers)//Checks a number is prime.
        {
            int i = 0;
            while (primeNumbers[i] <= number)
            {
                if (primeNumbers[i] == number)
                {
                    return true;
                }
                i++;
            }
            return false;
        }
    }
}
