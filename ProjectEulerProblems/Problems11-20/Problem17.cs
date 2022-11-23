using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerProblems
{
    //Returns the sum of the letters of all numbers up to 1000.
    //Runs in around 5Ms.
    public static class Problem17
    {
        public static void NumberLetterCounts()
        {
            int sum=0;
            for(int i = 0; i<10; i++)
            {
                for(int j =0; j<10;j++)
                {
                    for(int k=0; k<10;k++)
                    {
                        sum += Hundreds(i, j, k);
                    }
                }

            }
            sum += 11; //For the number 1000
            Console.WriteLine(sum);
            
            
        }

         
        public static int Units(int i)//Returns the number of letters for units.
        {
            switch(i)
            {
                case 0:
                    break;
                case 1:
                    return 3;
                case 2:
                    return 3;
                case 3:
                    return 5;
                case 4:
                    return 4;
                case 5:
                    return 4;
                case 6:
                    return 3;
                case 7:
                    return 5;
                case 8:
                    return 5;
                case 9:
                    return 4;
            }
            return 0;
        }

        public static int Tens(int j, int i)//Returns the number of letters for the tens.
        {
            switch(j)
            {
                case 0:
                    return Units(i);
                case 1:
                    switch(i)
                    {
                        case 0:
                            return 3;
                        case 1:
                            return 6;
                        case 2:
                            return 6;
                        case 3:
                            return 8;
                        case 4:
                            return 8;
                        case 5:
                            return 7;
                        case 6:
                            return 7;
                        case 7:
                            return 9;
                        case 8:
                            return 8;
                        case 9:
                            return 8;
                    };
                    break;
                case 2:
                    return Units(i) + 6;
                case 3:
                    return Units(i) + 6;
                case 4:
                    return Units(i) + 5;
                case 5:
                    return Units(i) + 5;
                case 6:
                    return Units(i) + 5;
                case 7:
                    return Units(i) + 7;
                case 8:
                    return Units(i) + 6;
                case 9:
                    return Units(i) + 6;
            }
            return 0;

        }

        public static int Hundreds(int k, int j, int i)//Returns the number of letters for the Hundreds.
        {
            switch(k)
            {
                case 0:
                    return Tens(j, i);
                case 1:
                    if (i == 0 && j == 0)
                    { return 10; }
                    else
                    { return Tens(j, i) + 13; }
                case 2:
                    if (i == 0 && j == 0)
                    { return 10; }
                    else
                    { return Tens(j, i) + 13; }
                case 3:
                    if (i == 0 && j == 0)
                    { return 12; }
                    else
                    { return Tens(j, i) + 15; }
                case 4:
                    if (i == 0 && j == 0)
                    { return 11; }
                    else
                    { return Tens(j, i) + 14; }
                case 5:
                    if (i == 0 && j == 0)
                    { return 11; }
                    else
                    { return Tens(j, i) + 14; }
                case 6:
                    if (i == 0 && j == 0)
                    { return 10; }
                    else
                    { return Tens(j, i) + 13; }
                case 7:
                    if (i == 0 && j == 0)
                    { return 12; }
                    else
                    { return Tens(j, i) + 15; }
                case 8:
                    if (i == 0 && j == 0)
                    { return 12; }
                    else
                    { return Tens(j, i) + 15; }
                case 9:
                    if (i == 0 && j == 0)
                    { return 11; }
                    else
                    { return Tens(j, i) + 14; }
            }
            return 0;
        }
    }
}
