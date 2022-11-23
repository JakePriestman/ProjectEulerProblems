using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerProblems
{

    //Finds all the multiplications of the form a x b = c sush that a,b and c contain 1-9 exactly once.
    //Then returns the sum of all the products.
    //Runs in around 330 Ms
    public static class Problem32
    {
        public static void PandigitalProducts()
        {
            List<int> multiplicands = new List<int>();
            List<int> multipliers = new List<int>();
            List<int> products = new List<int>();

            for(int a = 1; a < 98; a++) //Only 1 digit x 4 digit and 2 digit x 3 digit makes 9 digits in total with the product, so we can limit the search space as such.
            {
                for(int b = 123; b < 9876; b++)
                {
                    string numberString = SortString(Convert.ToString(a) + Convert.ToString(b) + Convert.ToString(a*b)); //Sorts the concantinated string 
                    if (numberString == "123456789" && !products.Contains(a*b))
                    {
                        multiplicands.Add(a);
                        multipliers.Add(b);
                        products.Add(a*b);
                    }
                }
            }
            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine(multiplicands[i] + "x" + multipliers[i] + "=" + products[i]);
            }

            Console.WriteLine("The Sum of the Products is " +products.Sum());
        }

        

        public static string SortString(string input)
        {
            char[] characters = input.ToArray();
            Array.Sort(characters);
            return new string(characters);
        }
    }
}
