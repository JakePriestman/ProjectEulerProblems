using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerProblems
{
    public class Problem45
    {
        //Finds the next triangular number after 40755 which is also hex and pent. But all trangular number with i odd are hex so just need to check pentagonal numbers.
        // runs in around 5Ms.
        public static void TriangularPentagonalHexagonalNumber()
        {
            bool notFound = true;
            int i = 143;

            while(notFound)
            {
                i++;
                long n = i * (2*i - 1);

                if(isPentagonal(n))
                {
                    Console.WriteLine(n);
                    notFound = false;

                }
                
            }
        }

        public static bool isTriangular(long num)
        {
            double triTest = (Math.Sqrt(8*num +1)-1.0)/2.0;
            return triTest == ((int)triTest);
        }
        public static bool isPentagonal(long num)
        {
            double penTest = (Math.Sqrt(24 * num + 1) + 1.0) / 6.0;
            return penTest == ((int)penTest);
        }
        public static bool isHexagonal(long num)
        {
            double hexTest = (Math.Sqrt(8 * num + 1) + 1.0) / 4.0;
            return hexTest == ((int)hexTest);
        }
    }
}
