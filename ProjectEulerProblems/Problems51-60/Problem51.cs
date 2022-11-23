using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerProblems
{
    //Finds the smallest prime such that replacing part of the number with the same digit, is part of an eight prime family.
    //Runs in around 92Ms.
    public class Problem51
    {
        public static void PrimeDigitReplacements()
        {
            List<int> primeNumbers = Problem07.PrimeNumberList(1000000);
            int result = int.MaxValue;

            int[][] fiveDigitPattern = get5DigitPattern();
            int[][] sixDigitPattern = get6DigitPattern();

            for(int i=11; i<1000;i+=2)
            {
                if(i % 5 == 0) continue; //Number must end in 1,3,7,9

                    int[][] patterns = (i<100) ?
                        fiveDigitPattern : sixDigitPattern;

                
                    for(int j=0; j<patterns.GetLength(0); j++)
                    {
                        for(int k=0; k<=2; k++)
                        {
                            if(patterns[j][0] ==0 && k==0) continue; //check first digit is not a 0.
                                int[] pattern = FillPattern(patterns[j], i);
                                int candidate = GenerateNumber(k, pattern);

                                if(candidate < result && primeNumbers.Contains(candidate) && PrimeNumberAmount(k, pattern, primeNumbers) == 8)
                                {
                                    result = candidate;
                                }
                                    break;
                        }
                    }
            }
            Console.WriteLine(result);

        }

        public static int PrimeNumberAmount(int repeatingNumber, int[] pattern, List<int> primeNumbers) //Check how many primes can be produced from the patter and repeating number.
        {
            int familySize = 1;

            for(int i = repeatingNumber+1; i<10; i++)
            {
                if(primeNumbers.Contains(GenerateNumber(i, pattern)))
                {
                    familySize++;
                }
            }
            return familySize;
        }


        private static int GenerateNumber(int repNumber, int[] filledpattern)//Generates a number from the filled pattern.
        {
            int temp = 0;
            for(int i=0; i<filledpattern.Length;i++)
            {
                temp = temp* 10;
                temp += (filledpattern[i] == -1) ?
                    repNumber : filledpattern[i];
            }
            return temp;
        }
        private static int[] FillPattern(int[] pattern, int num) //Fills the pattern with non repeating digits.
        {
            int[] filledpattern = new int[pattern.Length];
            int temp = num;
            for(int i=filledpattern.Length-1; i>=0; i--)
            {
                if(pattern[i] == 1)
                {
                    filledpattern[i] = temp % 10;
                    temp /= 10;
                }
                else
                {
                    filledpattern[i] = -1;
                }
            }
            return filledpattern;
        }

        private static int[][] get5DigitPattern()//Possible 5 digit patterns
        {
            int[][] patterns = new int[4][];

            patterns[0] = new int[] {1,0,0,0,1};
            patterns[1] = new int[] {0,1,0,0,1};
            patterns[2] = new int[] {0,0,1,0,1};
            patterns[3] = new int[] {0,0,0,1,1};

            return patterns;
        }
        private static int[][] get6DigitPattern()//Possible 6 digit patterns
        {
            int[][] patterns = new int[10][];

            patterns[0] = new int[] {1,1,0,0,0,1};
            patterns[1] = new int[] {1,0,1,0,0,1};
            patterns[2] = new int[] {1,0,0,1,0,1};
            patterns[3] = new int[] {1,0,0,0,1,1};
            patterns[4] = new int[] {0,1,1,0,0,1};
            patterns[5] = new int[] {0,1,0,1,0,1};
            patterns[6] = new int[] {0,1,0,0,1,1};
            patterns[7] = new int[] {0,0,1,1,0,1};
            patterns[8] = new int[] {0,0,1,0,1,1};
            patterns[9] = new int[] {0,0,0,1,1,1};

            return patterns;
        }
    }
}
