using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerProblems
{
    //Find the sum of the diagonal numbers in a length by length spiral formed by moving to the right in a clockwise direction.
    // SumOfDiagonals(n) = 4*(2n+1)^2 -12n + SumOfDiagonals(n-1)
    //Runs in around 5Ms.
    public static class Problem28
    {
        public static void NumberSpiralDiagonals(int length)
        {
            int n = (length-1) / 2;

            int sum = 1;

            for(int i= 1; i<=n; i++)
            {
                sum += 4 * (((2 * i) + 1) * ((2 * i) + 1)) - 12 * i;
            }

            Console.WriteLine(sum);
        }
    }
}
