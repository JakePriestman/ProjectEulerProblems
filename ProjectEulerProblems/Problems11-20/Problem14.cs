using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerProblems
{
    //Finds the number that produces the longest collatz sequence under a given limit.
    //The actual task was to just compute the longest under 1,000,000.
    //Runs in 2044Ms.
    public static class Problem14
    {
        public static void LongestCollatzSequence(int lim)
        {

            int[] maxIterations= new int[2] {0,0};

            for (int i = 1; i < lim; i++)
            {
                long currentNumber = i;
                int iterations = 1;
                int startingNumber = i;

                while (currentNumber != 1 && currentNumber > 0) //Stops when sequence finishs at 1.
                {
                    if (currentNumber % 2 == 0) //n/2 for even numbers
                    {
                        currentNumber /= 2;
                        iterations++;
                    }
                    else // 3n+1 for odd numbers.
                    {
                        currentNumber = (3 * currentNumber) + 1;
                        iterations++;
                    }
                }

                if(iterations > maxIterations[1]) //update the newest longest sequence.
                {
                    maxIterations[1] = iterations;
                    maxIterations[0] = startingNumber;
                        
                }
            }
            Console.WriteLine("The longest Collatz Sequence under "+lim+" starts at "+maxIterations[0]+" and has " + maxIterations[1]+" terms.");
        }
    }
}
