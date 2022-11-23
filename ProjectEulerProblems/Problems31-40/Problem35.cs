using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerProblems
{
    //197 is a circular prime because 971 & 719 are also prime.
    //Finds out how many circular primes there are below a given value.
    //Runs in around 2700Ms
    public class Problem35
    {
        public static void CircularPrimes(int lim)
        {
            List<int> primeNumbers = Problem07.PrimeNumberList(lim);
            List<int> circularPrimes = new List<int>();

            for (int i = 0; i < primeNumbers.Count; i++)
            {
                CircularPrimeCheck(primeNumbers[i], primeNumbers, circularPrimes);
            }

            Console.WriteLine(circularPrimes.Count());
        }

        public static List<int> CircularPrimeCheck(int num, List<int> primeNumbers, List<int> circularPrimes) //Checks if a number is a circular prime.
        { 
            string numString = Convert.ToString(num);
            List<string> rotations = new List<string>();
            Rotate(numString, numString.Length - 1, rotations);

            for (int i = 0; i < rotations.Count(); i++)
            {
                if (!primeNumbers.Contains(Convert.ToInt32(rotations[i])))
                {
                    return circularPrimes;
                }
            }
            for (int i = 0; i < rotations.Count(); i++)
            {
                if (!circularPrimes.Contains(Convert.ToInt32(rotations[i])))
                {
                    circularPrimes.Add(Convert.ToInt32(rotations[i]));
                }
            }
            return circularPrimes;
        }

        public static void Rotate(string str, int y, List<string> rotations) //Finds all rotations of a given string.
        {
            
            rotations.Add(str);
            for(int i=0; i<y; i++)
            {
                rotations.Add(str.Substring(i+1)+str.Substring(0,i+1));
            }
            
        }

    }
}
