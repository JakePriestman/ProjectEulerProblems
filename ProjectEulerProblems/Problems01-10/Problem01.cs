using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerProblems
{
    //Finds and lists all the multiples of 3 and 5 up to a given number and gives the sum. (1000)
    //Run time is O(n) as there is one for loop.
    //Runs in around 6Ms.
    public static class Problem01
    {

        public static void SumOfMultiples3or5(int lim)
        {
            List<int> multiplesof3 = new List<int>();
            List<int> multiplesof5 = new List<int>();
            List<int> multiplesof15 = new List<int>();


            Multiples(3, lim, multiplesof3); //Multiples of 3
            Multiples(5, lim, multiplesof5); // Multiples of 5
            Multiples(15, lim, multiplesof15); //Multiples of 15

            Console.WriteLine("\nThere are " + (multiplesof3.Count() + multiplesof5.Count() - multiplesof15.Count()) + " multiples of 3 or 5 below " + lim); // multiples of 3+5-multipels of 15 for duplicates.
            Console.WriteLine("The sum of the multiples is: " + (multiplesof3.Sum()+multiplesof5.Sum()-multiplesof15.Sum())); // multiples of 3+5-multipels of 15 for duplicates.

        }

        public static List<int> Multiples(int num1, int lim, List<int> Multiples) //Method for finding multiples of any given number upto a given limit.
        {
            for(int i=0; i<lim; i++)
            {
                if(i % num1 == 0)
                {
                    Multiples.Add(i);
                }
            }
            return Multiples;
        }
    }
}
