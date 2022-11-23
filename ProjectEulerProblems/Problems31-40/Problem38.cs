using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerProblems
{
    //Finds the largest padigital number formed by multipling x by the numbers 1,2,...,n n>1 and concatinating the results. for example 192x1=192, 192x2=384, 192x3=576, when concantinated gives 19238576 which is pandigital.
    //Runs in 10Ms.
    public class Problem38
    {
        public static void PandigitalMultiples()
        {
            List<int> pandigitalMultiples = new List<int>();

            for(int i = 9876; i>=9123;i--) //Search space is limited to these numbers to yeild a 9 digit result.
            {
                if(Problem32.SortString(Convert.ToString(i)+Convert.ToString(2*i))== "123456789") //n is an element of {1,2}, otherwise we would have a number larger than 9 digits.
                {
                    pandigitalMultiples.Add(100002 * i); // this is the integar multiplecation yeilding the concantination of the strings.
                }
            }
            Console.WriteLine(pandigitalMultiples.Max());
        }
    }
}
