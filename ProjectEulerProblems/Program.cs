using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;



namespace ProjectEulerProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            
            new Problem67().MaximumPathSum2();

            

            watch.Stop();
            Console.WriteLine( "\n" + watch.ElapsedMilliseconds + " Ms");
        }
    }
}
