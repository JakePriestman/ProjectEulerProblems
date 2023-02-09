using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;
using ProjectEulerProblems.Problems61_70;
using System.Collections;
using ProjectEulerProblems.Problems71_80;

namespace ProjectEulerProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            new Problem71().OrderedFractions();


			watch.Stop();
            Console.WriteLine( "\n" + watch.ElapsedMilliseconds + " Ms");
        }


	}
}
 