namespace ProjectEulerProblems
{
    //Finds how many square roots for N <=10000 have an odd period. Eg, Root(13) = [3;(1,1,1,1,6)], period = 5.
    //Runs in around 32Ms.
    //Uses the algorithm from https://en.wikipedia.org/wiki/Periodic_continued_fraction.
    class Problem64
    {
        public void OddPeriodSquareRoots()
        {
            List<int> periods = new List<int>();
            int oddperiods =0;

            for(int i=1; i <=10000; i++) //Upper limit given is 10,000.
            {
                
                if(!isPerfectSquare(i))//checks if number is perfect square first.
                {
                    int period = 0;
                    List<int> ds = new List<int>() {1};
                    List<int> ms = new List<int>() {0};
                    List<int> aNumbers = new List<int>() {(int)(Math.Floor(Math.Sqrt(i)))};
                    int j=0;
                    while(aNumbers[j] != 2*aNumbers[0]) //period is found when a[j] = 2*a[0] or when (m[0] = m[j] && d[0] = d[j] && a[j] = a[0]) as states on web page.
                    {
                        aNumbers.Add(SquareRootExapnsion(i, aNumbers[j], ms[j], ds[j]).Item1);
                        ms.Add(SquareRootExapnsion(i, aNumbers[j], ms[j], ds[j]).Item2);
                        ds.Add(SquareRootExapnsion(i, aNumbers[j], ms[j], ds[j]).Item3);
                        j++;
                        period++;
                    }
                    periods.Add(period);
                    
                }
            }
            for(int i=0; i<periods.Count();i++)
            {
                if(periods[i] % 2 != 0) //Checks the odd periods.
                {
                    oddperiods++;
                }
            }
            Console.WriteLine(oddperiods);
        }


        public (int, int, int) SquareRootExapnsion(int S, int a, int m, int d) //Produces the integers in the continuous fraction expansion.
        {
            int m1 = (int)(d*a - m);
            int d1 = (S-(m1*m1)) / d;
            int a1 = (int)(Math.Floor((Math.Sqrt(S)+m1)/d1));
            return (a1,m1,d1);
            
        }

        public bool isPerfectSquare(int num) //Checks if number is perfect square.
        {
            double sqrt = Math.Sqrt(num);
            return Math.Sqrt(num) == (int)(sqrt);
        }
    }
}