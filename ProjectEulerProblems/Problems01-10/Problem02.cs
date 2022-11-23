using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerProblems
{
    //Finds and gives the sum of fibonacci numbers up to a given number. Then sums the even given fibonacci numbers. (4000000)
    //Run time is O(n)
    //Runs in around 29Ms.
    public static class Problem02
    {
        public static void SumOfEvenFibonacciNumbers(int lim)
        {
            List<int> fibonacciNumbers = new List<int>() { 0, 1 };
            List<int> fibonacciEvenNumbers = new List<int>();

            FibonacciNumbers(lim, fibonacciNumbers);

            for(int i =0; i<fibonacciNumbers.Count();i++) 
            {
                Console.WriteLine(fibonacciNumbers[i]); //Writes of the fib numbers.

                if (fibonacciNumbers[i] % 2 == 0) //Finds the even fib numbers and adds them to the even list.
                {
                    fibonacciEvenNumbers.Add(fibonacciNumbers[i]);
                }
            }


            fibonacciNumbers.RemoveAt((fibonacciNumbers.Count - 1));

            Console.WriteLine("The sum of even fibonacci number is "+fibonacciEvenNumbers.Sum()); //Prints the sum of the even fib numbers.

        }

        public static List<int> FibonacciNumbers(int lim, List<int> fibonacciNumbers) //Method to find fibonacci numbers from an initial list of {0,1}.
        {
            for (int i = 1; i < lim; i++)
            {
                if (fibonacciNumbers[^1] < lim)
                {
                    fibonacciNumbers.Add(fibonacciNumbers[i] + fibonacciNumbers[i - 1]);
                }
            }
            fibonacciNumbers.RemoveAt((fibonacciNumbers.Count - 1)); //Removes the last number to keep it under the given limit.

            return fibonacciNumbers;

        }
    }
}
