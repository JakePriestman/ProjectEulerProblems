using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerProblems
{
    public class Problem47
    {
        //Finds the first 4 consecutive integars that have 4 prime factors.
        //Runs in around 14s.
        public static void DistinctPrimeFactors()
        {
            bool notFound = true;
            int i =600;
            int result = 0;

            while(notFound)
            {
                i++;
                if(Problem03.PrimeFactors(i).Count() == 4 && Problem03.PrimeFactors(i+1).Count() == 4 &&
                    Problem03.PrimeFactors(i+2).Count() == 4 && Problem03.PrimeFactors(i+3).Count() == 4)
                {
                    result = i;
                    notFound = false;
                }
            }
            Console.WriteLine(result+","+ (result+1)+","+(result+2)+","+(result+3));
        }
    }
}
