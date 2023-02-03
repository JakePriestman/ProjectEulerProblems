using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerProblems.Problems61_70
{
	class Problem69
	{
		public void TotientMaximum(int lim)
		{
			int n = 1;
			List<List<int>> factors = new List<List<int>>();
			List<int> primes = new List<int>() { 2,3,5,7,11,13,17,19,21,23,29,31};

			for(int i =0; i<primes.Count(); i++)
			{
				if (primes[i]*n > lim)
				{
					break;
				}
				else 
				{
					n *= primes[i];
				}
			}


			Console.WriteLine("The max n/phi(n) for n <= {2} occurs when n = {0}, n/phi(n) = {1}",n , 510510.0/92160.0, lim);
		}
	}
}
