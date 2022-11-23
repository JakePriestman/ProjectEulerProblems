namespace ProjectEulerProblems
{
    //Finds how many n-digit positive integers are nth powers. Eg, 16807 = 7^5.
    //Runs in around 5Ms.
    class Problem63
    {

        public void PowerfulDigitCounts()
        {

            int count =0;
            for(int i=1; i<25; i++)
            {
                for(int j=1; j<10;j++) //Must be 1-9.
                {
                    if(Power(j,i).ToString().Length == i)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }

        public System.Numerics.BigInteger Power(int num, int pow) //Gives number to certain power.
        {
            System.Numerics.BigInteger number = num;
            for(int i=1; i<pow; i++)
            {
                number *= num;
            }
            return number;
        }
    }
}