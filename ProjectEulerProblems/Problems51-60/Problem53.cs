namespace ProjectEulerProblems
{
    //Finds the amount of 1<=n<=100 such that nCr is greater than 1000000 for r<=n. Not necessarily distinct values of n. Answer = 4075.
    //Runs in around 35Ms.
    class Problem53
    {
        public static void CombinatoricSelections()
        {
            int count =0;

            for(int n = 1; n<=100; n++)
            {
                for(int r = 0; r<=n; r++)
                {
                    if(Problem53.Combinations(n,r) > 1000000)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);

            
        }

        public static System.Numerics.BigInteger Combinations(int num, int r)
        {
            return Problem20.Factorial(num) / (Problem20.Factorial(num-(num-r))*Problem20.Factorial(num-r));

        }
    }
}
