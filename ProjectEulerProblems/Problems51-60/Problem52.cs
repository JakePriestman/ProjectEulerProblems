namespace ProjectEulerProblems
{
    //Finds first integar such that x2, x3, x4, x5, x6 all have the exact same digits.
    //Runs in around 59Ms.
    class Problem52
    {
        public static void PemutedMultiples()
        {
            bool notFound = true;
            int result=0;
            int i=1;

            while(notFound)
            {
                i++;
                if(MultiplesCheck(i,6))
                {
                    result = i;
                    notFound = false;
                }
            }
            Console.WriteLine(result);
        }

        public static bool MultiplesCheck(int num, int multiples)//Checks whether all the multiples up to a given number contain the same digits as the original given number.
        {
            for(int i= 2; i <= multiples; i++)
            {
                if(Problem32.SortString(Convert.ToString(i*num)) != Problem32.SortString(Convert.ToString(num)))
                {
                    return false;
                }
            }
            return true;
        }
    }
}