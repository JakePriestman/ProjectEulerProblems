using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerProblems
{
    //Finds all the non-trivial fractions where for example 49/98 = 4/8 by bad simpification. 30/50 = 3/5 is trivial.
    //Runs in around 13Ms
    public class Problem33
    {
        public static void DigitCancellingFractions()
        {
            List<double> numerators = new List<double>();
            List<double> denominators = new List<double>();

            double numeratorProduct = 1;
            double denominatorProduct = 1;

            double simplifiedNumeratorProduct;
            double simplifiedDenominatorProduct;

            for (double n = 10; n < 100; n++)
            {
                for (double d = n + 1; d < 100; d++) //D is always bigger than n so that it is less than 1.
                {
                    string numerator = Convert.ToString(n);
                    string denominator = Convert.ToString(d);

                    //Checks the conditions for the fraction to be non-trivial and correct.
                    if (n / d == Convert.ToDouble(numerator[0] - '0') / Convert.ToDouble(denominator[1] - '0') && Convert.ToDouble(numerator[1] - '0') != Convert.ToDouble(denominator[1] - '0') && Convert.ToDouble(numerator[1] - '0') == Convert.ToDouble(denominator[0] - '0'))
                    {
                        numerators.Add(n);
                        denominators.Add(d);
                    }
                }
            }
            for (int i = 0; i < numerators.Count; i++) //Writes out the Four Non-trivial Fractions.
            {
                Console.WriteLine(numerators[i] + "/" + denominators[i]);
            }


            for (int i =0; i < numerators.Count; i++) //Multiplies fractions together.
            {
                numeratorProduct *= numerators[i];
                denominatorProduct *= denominators[i];
            }

            Console.WriteLine(numeratorProduct + "/" + denominatorProduct); //Product Fraction.

            simplifiedNumeratorProduct = numeratorProduct / GreatestCommonDivisor(numeratorProduct, denominatorProduct); //Simplified Numerator.
            simplifiedDenominatorProduct = denominatorProduct/GreatestCommonDivisor(numeratorProduct, denominatorProduct); //Simplified Denominator.

            Console.WriteLine(simplifiedNumeratorProduct + "/" +simplifiedDenominatorProduct);
        }

        public static double GreatestCommonDivisor(double n, double d)
        {
            while(n != d)
            {
                if (n > d)
                {
                    n = n - d;
                }
                else
                {
                    d = d - n;
                }
            }

            return n;

        } //Finds GCD of fraction.
    }
}
