﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerProblems
{
    public static class Problem31
    {
        //1p, 2p, 5p, 10p, 20p, 50p, £1, £2 How many ways are there to make £2
        //Runs in 6Ms.
        public static void CoinSums()
        {
            int target = 200;
            int ways = 0;

            for(int a=target; a>=0; a-=200)
            {
                for(int b=a; b>=0; b-=100)
                {
                    for(int c=b; c>=0; c-=50)
                    {
                        for(int d=c; d>=0; d-=20)
                        {
                            for(int e=d; e>=0; e-=10)
                            {
                                for(int f=e; f>=0; f-=5)
                                {
                                    for(int g=f; g>=0; g-=2)
                                    {
                                        ways++;
                                    }
                                }
                            }
                        }
                    }
                }
            }

            Console.WriteLine(ways);

        }
    }
}
