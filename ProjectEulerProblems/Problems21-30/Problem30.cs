using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerProblems
{
    public static class Problem30
    {
        //Finds all the numbers that can be written as a sum of the digits to ther power 5 and print the sum of those numbers.
        // Upper bound x*9^5 which gives an x digit number. So 9^5 = 59049, which is 5 digits and 5*9^5=29545 which is six, so 6*9^5=354294 which is still 6 so 355000 seems a reasonable upper bound.
        //Runs in around 90Ms.
        public static void DigitFifthPowers()
        {
            List<int> fifthPowerNumbers = new List<int>();

            for(int i =2; i <= 355000; i++)
            {
                string number = Convert.ToString(i);
                double powerNumber = DigitsPowerNumber(number, 5);

                if(powerNumber == i)
                {
                    fifthPowerNumbers.Add(i);
                }
            }

            Console.WriteLine(fifthPowerNumbers.Sum());
        }
        public static double DigitsPowerNumber(string number, int power)
        {
            double powerNumber = 0;
            for (int j = 0; j < number.Length; j++)
            {
                powerNumber += Math.Pow(number[j] - '0', power);
            }

            return powerNumber;
        }
    }
}
