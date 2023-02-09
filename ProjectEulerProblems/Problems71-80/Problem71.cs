using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerProblems.Problems71_80
{
	class Problem71
	{
		public void OrderedFractions()
		{
			int num = 3;
			int den = 0;
			for(int i = 1000000; i>1; i--)
			{
				if(i % 7 == 0)
				{
					den = i;
					break;
				}
			}
			int multiplier = den / 7;

			Console.WriteLine(ReducedProperFraction((num*multiplier)-1, den).Item1 + " " + ReducedProperFraction((num * multiplier) -1, den).Item2);
		}


		public (int, int) ReducedProperFraction(int num, int den)
		{
			int num1 = num;
			int den1 = den;
			int max = num > den ? num : den;

			for(int i = max-1; i > 1; i--)
			{
				if(num1 % i == 0 && den1 % i == 0)
				{
					num1 /= i;
					den1 /= i;
				}
			}
			return (num1, den1);
		} //Finds the reduced proper fraction of a given numerator and denominator.
	}
}
