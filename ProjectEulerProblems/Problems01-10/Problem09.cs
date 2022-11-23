using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerProblems
{
    //Finds the Pythagorean triple that adds to 1000 and finds the product of the triplet.
    //Runs in around 350Ms.
    public static class Problem09
    {
        public static void SpecialPythagoreanTriplet()
        {
            int product=0;
            for(int c=3; c < 999; c++)
            {
                for(int b =2; b<c; b++)
                {
                    for(int a =1; a<b; a++)
                    {
                        if((a*a)+(b*b)==(c*c) && a+b+c==1000)
                        {
                            Console.WriteLine((a*a)+"+"+(b*b)+"="+(c*c));
                            Console.WriteLine(a+"+"+b+"+"+c+"= 1000");
                            product += a * b * c;
                            break;
                        }
                    }
                }
            }
            Console.WriteLine(product);
        }
    }
}
