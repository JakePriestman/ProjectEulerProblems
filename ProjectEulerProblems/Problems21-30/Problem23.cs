using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerProblems
{

    //Finds the sum of all numbers, that cannot be expressed as a sum of two abudant numbers, up to 28123
    //Runs in around 180Ms.
    public static class Problem23
    {
        public static void NonAbudantNumbersSum()
        {
            List<int> abundantNumbers = new List<int>();
            bool[] canBeWrittenAsSum = new bool[28124];
            int sum = 0;



            for(int i=1; i<= 28123; i++)
            {
                if(SumofProperDivisors(i) > i) //Check if number is abundant.
                {
                    abundantNumbers.Add(i);
                }
            }

            for(int i=0; i<abundantNumbers.Count; i++)
            {
                for(int j=i; j<abundantNumbers.Count; j++)
                {
                    if (abundantNumbers[i] + abundantNumbers[j] <= 28123) //Checks if number can be written as a sum of two abundant numbers.
                    {
                        canBeWrittenAsSum[abundantNumbers[i] + abundantNumbers[j]] = true;
                    }
                    else
                    { 
                        break; 
                    }
                }
            }
            for(int i=1; i <= 28123; i++)
            {
                if (!canBeWrittenAsSum[i]) //Add the number to the sum if it cant be written as a sum of two abundant numbers.
                { 
                    sum += i; 
                }
            }
            Console.WriteLine(sum);

            
        }

        public static int SumofProperDivisors(int num) //Method to find the sum of the proper divisors of a given number.
        {
            int sum = 1;
            for (int i = 2; i * i <= num; i++)
            {
                if (num % i == 0)
                {
                    sum += (i + (num / i));
                }
                
            }

            if (Math.Ceiling(Math.Sqrt(num))*Math.Ceiling(Math.Sqrt(num)) == num)
            { sum -= (int)Math.Ceiling(Math.Sqrt(num)); } 
            return sum;
            
        }
    }
}
