using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerProblems
{
    //Find the value of p <=1000 such that a,b,c are pythagorian and a+b+c=p are maximised.
    //Runs in around 5Ms.
    public class Problem39
    {
        public static void IntegarRightTriangles()
        {
            int pMax = 0;
            int countMax = 0;

            for(int p=2; p<=1000; p+=2)
            {
                int count = 0;
                for (int a = 2; a < (p / 3); a++)
                {
                    if (p * (p - 2 * a) % (2 * (p - a)) == 0) //Rearranged for an expression for b.
                    {
                        count++;
                    }
                }
                if (count > countMax)
                {
                    countMax = count;
                    pMax = p;
                }


            }






            Console.WriteLine(pMax);
        }
    }
}
