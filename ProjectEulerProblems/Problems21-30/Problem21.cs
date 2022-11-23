using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerProblems
{
    //Finds the sum of all the Amicable numbers up to a certain limit.
    //Runs in around 120Ms.
    public static class Problem21
    {
        public static void AmicableNumbersSum(int lim)
        {
            int amicableNumbersSum = 0;
            for(int i=2; i <= lim; i++)
            {
                if (i == SumofDivisors(SumofDivisors(i)) && i != SumofDivisors(i))
                {
                    amicableNumbersSum += i;
                }
            }
            Console.WriteLine(amicableNumbersSum);
        }

        public static int SumofDivisors(int num) //Finds the sum of the divisors of a given number.
        {
            int sum = 1;
            for(int i=2; i * i <= num; i++)
            {
                if(num%i ==0)
                {
                    sum += (i + (num/i));
                }
            }

            return sum;
        }
    }
}
