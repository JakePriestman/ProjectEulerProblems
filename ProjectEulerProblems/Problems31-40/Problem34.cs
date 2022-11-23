using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerProblems
{
    //Finds all numbers whose sum of the factorials of their digits is the number its self. eg 145 = 1! + 4! + 5!.
    //Runs in around 320 Ms.
    public class Problem34
    {
        public static void DigitFactorials()
        {
            List<int> numbers = new List<int>();

            for (int i = 3; i < 2540160; i++) //1! & 2! are trivial and not technically sums. 2540160 comes from the fact that 7 * 9! = 2540160 and 8*9! is also 7 digits long.
            {
                string numberString = Convert.ToString(i);
                int numFactorial = 0;
                for (int j = 0; j < numberString.Length; j++)
                {
                    numFactorial += Convert.ToInt32(Problem20.Factorial(numberString[j] - '0')); //Sums the factorials of the digits.
                }
                if (numFactorial == i) //Checks to see is the number is of the form.
                {
                    numbers.Add(i);
                }
            }
            for (int i = 0; i < numbers.Count(); i++) //Writes out all the numbers of the form.
            {
                Console.WriteLine(numbers[i]);
            }

            Console.WriteLine("The sum is "+numbers.Sum()); //Writes out the sum.
        }
    }
}
