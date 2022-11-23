using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerProblems
{
    public class Problem67
    {
        public void MaximumPathSum2()
        {
            var lines = File.ReadAllLines(@"C:\Users\jakei\source\repos\ProjectEulerProblems\p067_triangle.txt");
            int[][] triangle = new int[100][];


            for (int i = 0; i < triangle.Length; i++)
            {
                triangle[i] = new int[i];
                triangle[i] = Triangle(lines[i], i+1);
            }

            try
            {
                int[] last = triangle[0];

                for (int i = 1; i < triangle.Length; i++)
                {
                    int[] current = new int[triangle[i].Length];

                    for(int j=0; j<current.Length; j++)
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
                    last = current;
                }
                Console.WriteLine(last.Max());
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public int[] Triangle(string lines_i, int row)
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
