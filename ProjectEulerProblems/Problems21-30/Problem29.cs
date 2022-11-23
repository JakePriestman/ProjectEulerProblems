using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerProblems
{
    public static class Problem29
    {
        //Finds the number of distinct terms in a sequence of a^b for 2<=a,b<=100
        //Runs in around 50Ms.
        public static void DistinctPowers()
        {
            List<double> sequence = new List<double>();
            for(int a=2; a<=100; a++)
            {
                for(int b=2; b<=100;b++)
                {
                    if(!sequence.Contains(Math.Pow(a,b)))
                    {
                        sequence.Add(Math.Pow(a, b));
                    }
                }
            }

            Console.WriteLine(sequence.Count()); 
        }
    }
}
