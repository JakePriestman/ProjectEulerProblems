using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerProblems
{
    //Finds the two pentagonal numbers such that, p_k -p_j is minimised and p_k+p_j & p_k -p_j are also both pentagonal numbers.
    //Runs in around 3500 Ms. Could be quick by not generating the pentagonal list but thats alright.
    public class Problem44
    {
        public static void PentagonNumbers()
        {
            int pkMin = 0;
            int pjMin = 0;
            long dMin = 0;
            int jMin=0, kMin=0;

            List<int> pentagonalNumbers = new List<int>();
            PentagonalListGeneration(3000, pentagonalNumbers);

            for(int k =1; k<pentagonalNumbers.Count();k++)
            {
                for(int j=k-1; j>=0; j--)
                {
                    if(pentagonalNumbers.Contains(pentagonalNumbers[j] + pentagonalNumbers[k]) && k!=j && pentagonalNumbers.Contains(pentagonalNumbers[k] - pentagonalNumbers[j]))
                    {

                        dMin = pentagonalNumbers[k] - pentagonalNumbers[j];
                        pjMin = pentagonalNumbers[j];
                        pkMin = pentagonalNumbers[k];
                        jMin = j+1;
                        kMin = k+1;
                    }
                }
            }

            Console.WriteLine(pkMin + "-"+ pjMin + "=" + dMin);
            Console.WriteLine("k = "+kMin+","+ "j = "+jMin);

        }

        public static List<int> PentagonalListGeneration(int lim, List<int> pentagonalNumbers)
        {
            for(int i =1; i <= lim; i++)
            {
                pentagonalNumbers.Add(i * (3 * i - 1) / 2);
            }
            return pentagonalNumbers;
        }
    }
}
