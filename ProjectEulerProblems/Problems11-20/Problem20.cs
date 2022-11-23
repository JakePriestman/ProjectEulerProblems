using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerProblems
{
    //Finds the sum of the digits of a given number factorial.
    //Runs in 16Ms.
    public static class Problem20
    {
        public static void FactorialDigitSum(int num)
        {
            System.Numerics.BigInteger numFactorial = Factorial(num);

            string numFacString = Convert.ToString(numFactorial);
            int sum = 0;

            for(int i=0; i< numFacString.Length;i++) //Summing the digits of the number.
            {
                sum += (numFacString[i]- '0');
            }

            Console.WriteLine(sum);
        }

        public static System.Numerics.BigInteger Factorial(int num)
        {
            System.Numerics.BigInteger numFactorial = num;
            if(num == 0)
            {
                numFactorial = 1;
                return numFactorial;
            }

            for (int i = num - 1; i > 0; i--)
            {
                numFactorial *= i;
            }

            return numFactorial;
        } //Method to find factorial of number.
    }
}
