using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerProblems
{

    //Finds the maximum path through a triangle with 100 rows fromn the p067_triangle.txt
    //Runs in 8Ms.
    public class Problem67
    {
        public void MaximumPathSum2()
        {
            var lines = File.ReadAllLines(@"../../../../p067_triangle.txt"); //Reads the file.
            int[][] triangle = new int[100][]; //Intialise the rows.


            for (int i = 0; i < triangle.Length; i++) //Makes the whole triangle as an array of array of integers.
            {
                triangle[i] = new int[i];
                triangle[i] = Triangle(lines[i], i+1);
            }

            try
            {
                int[] last = triangle[0]; //Initialise

                for (int i = 1; i < triangle.Length; i++) //Loop through triangle matrix.
                {
                    int[] current = new int[triangle[i].Length]; //intialise the current array.
 
                    for(int j=0; j<current.Length; j++) //Loops through the row array and decides which number from last to add to current[j].
                    {
                        if (j == 0)
                        {
                            current[j] = triangle[i][j] + last[j];
                        }
                        if(j == triangle[i].Length-1)
                        {
                            current[j] = triangle[i][j] + last[j-1];
                        }
                        if(j > 0 && j< last.Length)
                        {
                            current[j] = triangle[i][j] + Math.Max(last[j-1], last[j]);
                        }
                     }
                    last = current; //Set last to the current array.
                }
                Console.WriteLine(last.Max()); //Print out the max of the last row, which contains the max path.
            }
            catch(Exception e) //Catch any errors.
            {
                Console.WriteLine(e);
            }
        }

        public int[] Triangle(string lines_i, int row) //Converts the read file into an array and returns it, produces a row for the trianle.
        {
            int[] triangle = new int[row];
            int i = 0;
            for(int j=0; j<lines_i.Length;j+=3)
            {
                triangle[i] = Convert.ToInt32(lines_i[j].ToString() + lines_i[j + 1].ToString());
                i++;
            }
            return triangle;
        }
    }
}
