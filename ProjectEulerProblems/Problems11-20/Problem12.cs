using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerProblems
{
    //Finds the first trianlge number to have over 500 divisors.
    //Runs in aroun 900Ms.
    public static class Problem12
    {
        public static void HighlyDivisibleTriangleNumber(int divisors)
        {
            long i = 1;
            long j = 2;
            bool isUnder500 = true;
            while(isUnder500)
            {
                if (NumberOfDivisors(i) <= divisors)
                {
                    i += j;
                    j++;
                }
                if(NumberOfDivisors(i) > divisors)
                { isUnder500 = false;}

            }
            Console.WriteLine(i);


        }

        private static int NumberOfDivisors(long num)//Gives the numer of divisors of a number.
        {
            int divisors = 0;

            for(long i=1; i*i<=num; i++)
            {
                if(num%i==0)
                {
                    divisors+=2;
                }
            }
            return divisors;

        }
    }

}
