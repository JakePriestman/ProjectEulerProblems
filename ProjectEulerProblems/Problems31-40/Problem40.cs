using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerProblems
{
    //Finds the digits 1,10,100,1000,10000,100000,1000000 and multiples them together from a number of the concantinated digits of the natural numbers starting at 1.
    //Runs in around 40Ms.
    public class Problem40
    {
        public static void ChampernownesConstant()//Just writes out the number we want.
        {
            Console.WriteLine(IrrationalDecimalFractionDigit(1) * IrrationalDecimalFractionDigit(10) * IrrationalDecimalFractionDigit(100)* IrrationalDecimalFractionDigit(1000)
                * IrrationalDecimalFractionDigit(10000)* IrrationalDecimalFractionDigit(100000)* IrrationalDecimalFractionDigit(1000000));
            

        }


        public static string IrrationalDecimalFraction(int lim)//Actually makes the irrational decimal fraction
        {
            string str = "0.";
            for(int i=1; i<=lim;i++)
            {
                str += Convert.ToString(i);
            }
            return str;
        }

        public static int IrrationalDecimalFractionDigit(int lim)//Gives the digit at limit index.
        {
            int strLength = 0;
            int digit = 0;
            for (int i = 1; i <= lim; i++)
            {
                string str = Convert.ToString(i);
                for(int j=0; j<str.Length;j++)
                {
                    strLength++;
                    if(strLength == lim)
                    {
                        digit = str[j] - '0';
                    }
                }
            }
            return digit;
        }
    }
}
