using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerProblems
{
    //Finds the 3 4 digit prims that are permutations of each other and are also prime and increasing in valeu and concantinate the string.
    //Runs in 204Ms.
    public class Problem49
    {
        public static void PrimePermutations()
        {
            List<int> primeNumbers = Problem07.PrimeNumberList(10000);
            string result= "";

            for(int i = 168; i<primeNumbers.Count();i++)
            {
                List<string> permutations = new List<string>();
                Problem24.Permute(Convert.ToString(primeNumbers[i]), 0, Convert.ToString(i).Length - 1, permutations);

                for (int j = i+1; j<primeNumbers.Count();j++)
                {
                    
                    int k = primeNumbers[j] + (primeNumbers[j] - primeNumbers[i]);
                    if (primeNumbers.Contains(k) && permutations.Contains(Convert.ToString(k)) && permutations.Contains(Convert.ToString(primeNumbers[j])))
                    {
                        result = Convert.ToString(primeNumbers[i]) + Convert.ToString(primeNumbers[j])+Convert.ToString(k);
                    }
                }
            }

            Console.WriteLine(result);
        }
    }
}
