using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerProblems
{
    //Finds the smallest odd composite number that cannot be written as a sum of a prime and twice a square. Eg 15 = 7 + 2*2^2.
    //Runs in around 124Ms.
    public class Problem46
    {
        public static void GolbachsOtherConjecture()
        {
            List<int> primeNumbers = Problem07.PrimeNumberList(10000);
            bool notFound = true;
            int i = 3;
            int result=0;

            while(notFound)
            {
                i++;
                if(!primeNumbers.Contains(i) && i % 2 !=0 && !ConjectureCheck(i, primeNumbers))
                {
                    result = i;
                    notFound = false;
                }
            }

            Console.WriteLine(result);

        }

        public static bool ConjectureCheck(int num, List<int> primeNumbers)
        {
            for (int k = 1; k < num; k++)
            {
                for (int j = 0; j < primeNumbers.Count(); j++)
                {
                    if(num == primeNumbers[j] + 2*(k*k))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
