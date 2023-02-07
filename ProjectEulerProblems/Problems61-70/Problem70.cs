using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerProblems.Problems61_70
{
	//Finds the value of n such that the totient function of n is a permutation of n and it produces the smallest n/phi(n) under 10^7.
	// Runs in 6000Ms
	class Problem70
	{
		public void TotientPermuatation()
		{
			double result = int.MaxValue;
			double n = int.MaxValue;
			double phiN = int.MaxValue;
			List<int> primes = Problem07.PrimeNumberList(100000000);

			List<int> semiPrimes = SemiPrimeList(10000000,primes);
			semiPrimes.Sort();


			for (int i = semiPrimes.Count() - 1; i >= 0; i--)
			{
				if (isPermutation(semiPrimes[i], TotientFunction(semiPrimes[i], primes)))
				{
					if(result > (double)semiPrimes[i] / (double)TotientFunction(semiPrimes[i], primes))
					{
						n = (double)semiPrimes[i];
						phiN = (double)TotientFunction(semiPrimes[i], primes);
						result = (double)semiPrimes[i] / (double)TotientFunction(semiPrimes[i], primes);
					}
					
				}
			}
			Console.WriteLine(n + "\t" + phiN + "=" + result);

		} //Gives the answer.

		public int TotientFunction(int n, List<int> primes)
		{
			int result = n;


				List<int> primeFactors = Problem03.PrimeFactors(n);
				foreach (int i in primeFactors)
				{
					if (result >= i)
					{

						result -= result / i;
					}
					else { break; }
				}
			return result;
		} //Calculates Totient Function of n.

		public bool isPermutation(long n, long perm)
		{
			if(n.ToString().Length != perm.ToString().Length)
			{
				return false;
			}
			string str = perm.ToString();
			string str1 = n.ToString();
			char[] chars = new char[str.Length];
			char[] chars1 = new char[str1.Length];
			for (int i =0; i <str.Length; i++)
			{
				chars[i] = str[i];
				chars1[i] = str1[i];
			}

			return chars.OrderBy(x => x).SequenceEqual(chars1.OrderBy(x => x));
		} //Checks if its a permutation.

		public List<int> SemiPrimeList(int lim, List<int> primes)
		{
			List<int> semiPrimes = new List<int>();

			foreach(int i in primes)
			{
				for(int j = i; j<primes.Count(); j++)
				{	
					if(i*j > lim || i*j < 5000000)
					{
						break;
					}
					else
					{
						if (!semiPrimes.Contains(i * j))
						{
							semiPrimes.Add(i * j);
						}
					}
				}
			}
			return semiPrimes;
		} //Creates a list of semiprimes above 5000000.

	}
}
