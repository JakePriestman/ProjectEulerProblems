using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerProblems
{
    public static class Problem15
    {
        //Finds the number of paths in a grid of given size.
        //Runs in 6Ms.
        public static void LatticePaths(int gridSize)
        {
            long[,] grid = new long[gridSize+1, gridSize+1];

            for(int i=0; i<gridSize;i++)
            {
                grid[i, gridSize] = 1;
                grid[gridSize,i] = 1;
            }

            for(int i=gridSize-1; i>=0;i--)
            {
                for(int j=gridSize-1; j>=0;j--)
                {
                    grid[i, j] = grid[i + 1, j] + grid[i, j + 1];
                }
            }
            Console.WriteLine(grid[0,0]);
        }
    }
}
