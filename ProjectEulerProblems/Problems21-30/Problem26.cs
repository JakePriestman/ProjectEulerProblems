using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerProblems
{
    //Finds the langest reciprocal cycle for 1/d such that d<1000.
    //Runs in around 5Ms.
    public static class Problem26
    {
        public static void ReciprocalCycles()
        {

            int sequenceLength = 0;

            for (int i = 1000; i > 1; i--)
            {
                if (sequenceLength >= i)
                {
                    break;
                }

                int[] foundRemainders = new int[i];
                int value = 1;
                int position = 0;

                while (foundRemainders[value] == 0 && value != 0)
                {
                    foundRemainders[value] = position;
                    value *= 10;
                    value %= i;
                    position++;
                }

                if (position - foundRemainders[value] > sequenceLength)
                {
                    sequenceLength = position - foundRemainders[value];
                }
            }

            Console.WriteLine(sequenceLength);

        }
    }
}
