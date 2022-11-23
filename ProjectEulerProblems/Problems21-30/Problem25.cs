using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerProblems
{
    //Finds the first fibonacci number with 1000 digits and return the index.
    //Runs in around 50Ms.
    public static class Problem25
    {
        public static void FibonacciNumber1000Digits()
        {
            List<System.Numerics.BigInteger> fibonacciNumbers = new List<System.Numerics.BigInteger>() { 0,1};
            int index = 1;

            while (Convert.ToString(fibonacciNumbers[index]).Length < 1000) //Have not reused Problem02 because we need to use BigIntegars.
            {
                fibonacciNumbers.Add(fibonacciNumbers[index] + fibonacciNumbers[index - 1]);
                index++;
            }

            Console.WriteLine(fibonacciNumbers[index]);
            Console.WriteLine(index);

        }
    }
}
