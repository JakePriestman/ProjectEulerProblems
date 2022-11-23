namespace ProjectEulerProblems
{
    //Finds the sum of the digits of the numerator in the 100th continued fraction of e.
    //Runs in around 10Ms.
    class Problem65
    {
        public void ConvergentsOfe()
        {
            List<System.Numerics.BigInteger> numerators = new List<System.Numerics.BigInteger>() {2,3};
            int k=1;
            for(int i=2; i< 100; i++)
            {
                int fraction;
                if((i) % 3 == 2)
                {
                    fraction = 2*k;
                    k++;
                }
                else fraction = 1;

                numerators.Add(numerators[i-2] + (numerators[i-1]*fraction));
                
            }
            string str = Convert.ToString(numerators[99]);
            int sum =0;
            for(int i=0; i<str.Length; i++)
            {
                sum += str[i]-'0';
            }
            Console.WriteLine(sum);
            
        }
    }
}