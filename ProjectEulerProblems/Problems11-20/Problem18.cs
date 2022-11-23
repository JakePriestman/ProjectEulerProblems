﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerProblems
{
    /*Finds the maximum path through this triangle. Works by adding the max of the two options to the current element until
    we reach the top of the triagnle*/
    //Runs in around 6Ms.
    public class Problem18
    {

        public static void MaximumSumPath()
        {
            int[,] triangle =                { { 75,00,00,00,00,00,00,00,00,00,00,00,00,00,00},
                                               { 95,64,00,00,00,00,00,00,00,00,00,00,00,00,00},
                                               { 17,47,82,00,00,00,00,00,00,00,00,00,00,00,00},
                                               { 18,35,87,10,00,00,00,00,00,00,00,00,00,00,00},
                                               { 20,04,82,47,65,00,00,00,00,00,00,00,00,00,00},
                                               { 19,01,23,75,03,34,00,00,00,00,00,00,00,00,00},
                                               { 88,02,77,73,07,63,67,00,00,00,00,00,00,00,00},
                                               { 99,65,04,28,06,16,70,92,00,00,00,00,00,00,00},
                                               { 41,41,26,56,83,40,80,70,33,00,00,00,00,00,00},
                                               { 41,48,72,33,47,32,37,16,94,29,00,00,00,00,00},
                                               { 53,71,44,65,25,43,91,52,97,51,14,00,00,00,00},
                                               { 70,11,33,28,77,73,17,78,39,68,17,57,00,00,00},
                                               { 91,71,52,38,17,14,91,43,58,50,27,29,48,00,00},
                                               { 63,66,04,68,89,53,67,30,73,16,69,87,40,31,00},
                                               { 04,62,98,27,23,09,70,98,73,93,38,53,60,04,23} };

            for (int i = triangle.GetLength(0)-2; i >=0; i--)
            {
                for(int j=0; j<=i;j++)
                {
                    triangle[i,j] += Math.Max(triangle[i+1,j], triangle[i+1,j+1]);
                }
            }

            Console.WriteLine(triangle[0, 0]);
        }
    }
}
