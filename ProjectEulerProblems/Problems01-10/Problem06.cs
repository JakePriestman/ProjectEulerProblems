using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerProblems
{
    //Finds the difference between the sqaure of the sum and the sum of the sqaures of a given natural number.(100)
    //O(n)
    //Runs in around 6Ms.
    public static class Problem06
    {
        public static void SumSquaredifference(int lim) //Method to find the difference between the sum of the squares and the square of the sum.
        {
            long squareOfTheSum = SquareOfTheSum(lim);
            long sumOfTheSquares = SumOfTheSquares(lim);

            

            Console.WriteLine("The Square of the Sum is: " + squareOfTheSum + " and the Sum of the Squares is: " + sumOfTheSquares);
            Console.WriteLine("The difference is: " + (squareOfTheSum - sumOfTheSquares));



        }

        public static long SquareOfTheSum(int lim) //Method to find the square of the sum to a given number.
        {
            long squareOfTheSum = 0;

            for (int i = 1; i <= lim; i++)
            {
                squareOfTheSum += i;
            }
            squareOfTheSum = (squareOfTheSum * squareOfTheSum);

            return squareOfTheSum;
        }
        public static long SumOfTheSquares(int lim) //Method to find the sum of the squares to a given number.
        {
            long sumOfTheSquare = 0;
            for (int i = 1; i <= lim; i++)
            {
                sumOfTheSquare += (i * i);
            }
            return sumOfTheSquare;
        }

    }
}
