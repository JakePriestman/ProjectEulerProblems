using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerProblems
{
    //Finds the amount of ttriangle words in words.txt
    //Runs in around 20Ms.
    public class Problem42
    {
        public static void CodedTriangleNumbers()
        {
            string[] wordsList = { };
            var lines = File.ReadAllLines(@"C:\Users\jakei\source\repos\ProjectEulerProblems\words.txt");

            List<string> trianglewords = new List<string>();
            List<int> triangleNumbers = TriangleNumberList(10000); 

            for (int i = 0; i < lines.Length; i++) //Sorts text file into array.
            {
                wordsList = lines[i].Split(',');
            }

            for(int i =0; i<wordsList.Length; i++)
            {
                if (triangleNumbers.Contains(Problem22.AlphabeticalValue(wordsList[i])))
                {
                    trianglewords.Add(wordsList[i]);
                }
            }

            Console.WriteLine(trianglewords.Count());

        }

        public static List<int> TriangleNumberList(int lim) //Produces a list of triangle numbers up to a given lim, lim being the index.
        {
            List<int> trianglesNumbers = new List<int>();

            for(int n=1; n<=lim; n++)
            {
                trianglesNumbers.Add((n*(n+1))/2);
            }
            return trianglesNumbers;
        }
    }
}
