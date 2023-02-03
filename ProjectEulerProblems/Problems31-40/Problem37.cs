using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerProblems
{
    //Finds the eleven numbers that are tuncatable from left-to-right and right-to-left.
    //Runs in around 1800Ms.
    public class Problem37
    {
        public static void TruncatablePrimes()
        {
            List<int> primeNumbers = Problem07.PrimeNumberList(1000000);
            List<int> truncatablePrimes = new List<int>();


            for(int i=4; i<primeNumbers.Count; i++)
            {
                TruncatablePrimeCheck(primeNumbers[i], primeNumbers, truncatablePrimes);
            }
            
            for(int i=0; i<truncatablePrimes.Count();i++)
            {
                Console.WriteLine(truncatablePrimes[i]);
            }

            Console.WriteLine(truncatablePrimes.Sum());
            

        }

        public static List<int> TruncatablePrimeCheck(int num, List<int> primeNumbers, List<int> truncatablePrimes)//Checks whether all the truncations of a number are prime.
        {
            List<int> truncationsLeft = new List<int>();
            List<int> truncationsRight = new List<int>();

            TruncateLeft(num, truncationsLeft);
            TruncateRight(num, truncationsRight);

            for (int j = 0; j < truncationsLeft.Count(); j++)
            {
                if (!primeNumbers.Contains(truncationsLeft[j]) || !primeNumbers.Contains(truncationsRight[j]))
                {
                    return truncatablePrimes;
                }
            }
            truncatablePrimes.Add(num);
            return truncatablePrimes;
        }

        public static List<int> TruncateLeft(int num, List<int> truncationsLeft)//Method to find all the truncations from the left.
        {
            string str = Convert.ToString(num);
            for(int i=1; i<str.Length; i++) //Starts from 1 because we are taking the original number from a prime number list.
            {
                truncationsLeft.Add(Convert.ToInt32(str.Substring(i)));
            }
            return truncationsLeft;
        }

        public static List<int> TruncateRight(int num, List<int> truncationsRight)//Method to find all the truncations from the right.
        {
            string str = Convert.ToString(num);
            for (int i = 1; i < str.Length; i++) //Starts from 1 because we are taking the original number from a prime number list.
            {
                truncationsRight.Add(Convert.ToInt32(str.Substring(0,str.Length-i)));
            }
            return truncationsRight;
        }
    }
}
