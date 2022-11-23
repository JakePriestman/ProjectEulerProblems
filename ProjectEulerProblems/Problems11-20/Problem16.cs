using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ProjectEulerProblems
{
    //Finds the sum of the digits of 2 to the power of a given number.
    //Runs in 33Ms.
    public static class Problem16
    {
        public static void PowerDigitSum(int power)
        {
            System.Numerics.BigInteger num1 = new System.Numerics.BigInteger(2);
            
            for(int i=1; i<power;i++)
            {
                num1 *= 2;
            }
            

            string num = Convert.ToString(num1);
            long sum = 0;
            Console.WriteLine(num);

            for (int i=0; i<num.Length;i++)
            {
                sum += (num[i]-'0');
            }
            Console.WriteLine(sum);
            Console.WriteLine(num.Length);

        }
    }
}
