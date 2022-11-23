namespace ProjectEulerProblems
{
    //Finds how many number below 10000 are lychrel numbers.
    //Runs in around 36 Ms
    class Problem55
    {
        public static void LychrelNumbers()
        {
            List<int> lychrelNumbers = new List<int>();
            for(int i=10; i<10000; i++)
            {
                if(isLychrel(i))
                {
                    lychrelNumbers.Add(i);
                }
            }
            Console.WriteLine(lychrelNumbers.Count());
        }

        public static bool isLychrel(int num) //Checks a number is Lychrel
        {
            System.Numerics.BigInteger testNum = num;
            for(int i=0; i<50; i++)
            {
                testNum += ReverseNumber(testNum);
                if(Problem04.isPalindrome(Convert.ToString(testNum)))
                {
                    return false;
                }
            }
            return true;

        }
        public static  System.Numerics.BigInteger ReverseNumber(System.Numerics.BigInteger num) //Reverses Number.
        {
            string str = Convert.ToString(num);
            string str1 = "";
            for(int i=str.Length-1; i>=0; i--)
            {
                str1 += str[i];
            }
            return System.Numerics.BigInteger.Parse(str1);
        }
    }
}