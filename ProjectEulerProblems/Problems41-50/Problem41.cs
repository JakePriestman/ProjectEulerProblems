using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerProblems
{
    //Finds the largest prime number which is also pandigital.
    //Runs in around 500Ms.
    public class Problem41
    {
        public static void PandigitalPrimeMax()
        {
            List<int> primeNumbers = Problem07.PrimeNumberList(10000000);
            List<int> pandigitalPrimes = new List<int>();

            for(int i=0; i<primeNumbers.Count();i++)
            {
                if (Problem32.SortString(PandigitalString(primeNumbers[i])) == Problem32.SortString(Convert.ToString(primeNumbers[i])))
                {
                    pandigitalPrimes.Add(primeNumbers[i]);
                }
            }

            Console.WriteLine(pandigitalPrimes.Max());
        }

        public static string PandigitalString(int num)
        {
            int numLength = Convert.ToString(num).Length;
            string str = "";

            for(int i=1; i<=numLength; i++)
            {
                str += Convert.ToString(i);
            }
            return str;
        }
    }
}
