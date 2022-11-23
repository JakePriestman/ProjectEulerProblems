using System.Numerics;
namespace ProjectEulerProblems
{
    class Problem66
    {
        public void DiophantineEquation()
        {
            int[] dlist = DlistGen(1000);
            List<BigInteger> xS = new List<BigInteger>();

            int result = 0;
            BigInteger pmax = 0;

            for(int i=0; i< dlist.Length; i++)
            {
                BigInteger m = 0;
                BigInteger d = 1;
                BigInteger a = (int)Math.Sqrt(dlist[i]);
                
                BigInteger numm1 = 1;
                BigInteger num = a;
                
                BigInteger denm1 = 0;
                BigInteger den = 1;
                
                while(num*num - dlist[i]*den*den != 1)
                {
                    m = d * a - m;
                    d = (dlist[i] - m * m) / d;
                    a = ((int)Math.Sqrt(dlist[i]) + m) / d;
                
                    BigInteger numm2 = numm1;
                    numm1 = num;
                    BigInteger denm2 = denm1;
                    denm1 = den;
                
                    num = a*numm1 + numm2;
                    den = a * denm1 + denm2;
                }
                
                xS.Add(num);
            }
           Console.WriteLine(dlist[xS.IndexOf(xS.Max())]);
        }

        public int[] DlistGen(int lim)
        {
            List<int> dlist = new List<int>();

            for(int i =2; i<=lim; i++)
            {
                if(!(Math.Sqrt(i) == (int)Math.Sqrt(i)))
                {
                    dlist.Add(i);
                }
            }
            return dlist.ToArray();
        }

    }

}