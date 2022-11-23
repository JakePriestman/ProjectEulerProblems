using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerProblems
{
    public static class Problem05
    {
        //Finds the smallest positive number that is divisible by all digits 1 through 20.
        //Time complexity is O(n).
        //Runs in around 900Ms
        public static void SmallestMultipleOf20through1()
        {
            int smalestMultiple = 0;
            int num = 1;
            while (smalestMultiple == 0)
            {
                num++;
                if (num % 20 == 0 && num % 19 == 0 && num % 18 == 0 && num % 17 == 0 && num % 16 == 0 && num % 15 == 0 && num % 14 == 0 && num % 13 == 0 && num % 12 == 0 && num % 11 == 0) //Dont need to check under 11 as this checks all the integars.
                {
                    smalestMultiple = num;

                }
            }

            Console.WriteLine(smalestMultiple);
        }
    }
}
