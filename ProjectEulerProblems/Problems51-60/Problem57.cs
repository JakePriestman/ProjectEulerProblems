namespace ProjectEulerProblems
{
    //Finds how many of the expansions of root 2 under one thoudsand have a numerator with more digits than the denominator.
    // Runs in around 197Ms. Can be shortened by not making a list of previous numerators and denominators.
    class Problem57
    {
        public static void SquareRootConvergence()
        {
            int count =0;
            for(int i=0; i<1000; i++)
            {
                if(Convert.ToString(SquareRootConvergenceFraction(i).Item1).Length > Convert.ToString(SquareRootConvergenceFraction(i).Item2).Length)
                {
                    count++;
                }
            }
            Console.WriteLine(count);

        }


        public static (System.Numerics.BigInteger, System.Numerics.BigInteger) SquareRootConvergenceFraction( int iterations)
        {
            List<System.Numerics.BigInteger> num = new List<System.Numerics.BigInteger>() {3};
            List<System.Numerics.BigInteger> den = new List<System.Numerics.BigInteger>() {2};

            for(int i=1; i<=iterations; i++)
            {
                num.Add(2*(den[i-1]) + num[i-1]);
                den.Add(num[i-1] + den[i-1]);
            }

            return (num[iterations], den[iterations]);
        }
    }
}