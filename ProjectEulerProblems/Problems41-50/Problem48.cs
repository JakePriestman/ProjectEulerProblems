using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerProblems
{
    //Find the sum of the series 1 to 1000 raised to self powers. Gives also the last ten digits as requested.
    //Runs in around 30Ms.
    public class Problem48
    {
        public static void SelfPowers()
        {
            System.Numerics.BigInteger num = new System.Numerics.BigInteger(1);

            for(int i =2; i<=1000; i++)
            {
                num += BigInteger.Pow(i, i);
            }
            Console.WriteLine(num);

            string numString = Convert.ToString(num);

            Console.WriteLine(numString.Substring(numString.Length - 10));
        }
    }
}
