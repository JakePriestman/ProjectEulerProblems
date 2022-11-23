namespace ProjectEulerProblems
{
    //Find the max digit sum produced from number a^b such that a,b <100.
    //Runs in around 40 Ms
    class Problem56
    {
        public static void PowerfulDigitSum()
        {
            int result =0;
            for(int a=1; a<100; a++)
            {
                for(int b=1; b<100; b++)
                {
                    string str = Power(a,b);
                    int digitSum = 0;
                    for(int i=0; i<str.Length; i++)
                    {
                        digitSum += str[i]-'0';
                    }
                    if(digitSum > result)
                    {
                        result = digitSum;
                    }
                }
            }
            Console.WriteLine(result);
        }

        public static string Power(int a, int b)
        {
            System.Numerics.BigInteger num = a;

            for(int i=1; i<b; i++)
            {
                num *= a;
            }
            return num.ToString();
        }
    }
}