namespace ProjectEulerProblems
{
    //Finds the 5 primes in which any two concantinated is prime and the sum is the lowest.
    class Problem60
    {
        public static void PrimePairSets()
        {
            List<int> primes = Problem07.PrimeNumberList(30000);
            int result = int.MaxValue;

 
            HashSet<int>[] pairs = new HashSet<int>[primes.Count()];
    
            for (int a = 1; a < primes.Count(); a++) { if (primes[a] * 5 >= result) break;
            if (pairs[a] == null) pairs[a] = MakePairs(a, primes);
            for (int b = a + 1; b < primes.Count(); b++) { if (primes[a] + primes[b] * 4 >= result) break;
                if (!pairs[a].Contains(primes[b])) continue;
                if (pairs[b] == null) pairs[b] = MakePairs(b, primes);
        
                for (int c = b + 1; c < primes.Count(); c++) { if (primes[a] + primes[b] + primes[c] * 3 >= result) break;
                    if (!pairs[a].Contains(primes[c]) ||
                    !pairs[b].Contains(primes[c])) continue;
                    if (pairs[c] == null) pairs[c] = MakePairs(c, primes);
        
                    for (int d = c + 1; d < primes.Count(); d++) { if (primes[a] + primes[b] + primes[c] + primes[d] * 2 >= result) break;
                        if (!pairs[a].Contains(primes[d]) ||
                        !pairs[b].Contains(primes[d]) ||
                        !pairs[c].Contains(primes[d])) continue;
                        if (pairs[d] == null) pairs[d] = MakePairs(d, primes);
        
                        for (int e = d + 1; e < primes.Count(); e++) { if (primes[a] + primes[b] + primes[c] + primes[d] + primes[e] >= result) break;
                            if (!pairs[a].Contains(primes[e]) ||
                            !pairs[b].Contains(primes[e]) ||
                            !pairs[c].Contains(primes[e]) ||
                            !pairs[d].Contains(primes[e])) continue;
        
                            if (result > primes[a] + primes[b] + primes[c] + primes[d] + primes[e])
                                result = primes[a] + primes[b] + primes[c] + primes[d] + primes[e];
        
                            Console.WriteLine("{0} + {1} + {2} + {3} + {4} = {5}", primes[a], primes[b], primes[c], primes[d], primes[e], result);
                            break;
                            }   
                        }
                    }
                }
            }
        }
        public static HashSet<int> MakePairs(int a, List<int> primes) {
        HashSet<int> pairs = new HashSet<int>();
        for (int b = a + 1; b < primes.Count(); b++) {
            if (Problem58.isPrime(Convert.ToInt64(Convert.ToString(primes[a]) + Convert.ToString(primes[b]))) && Problem58.isPrime(Convert.ToInt64(Convert.ToString(primes[b]) + Convert.ToString(primes[a]))))
                pairs.Add(primes[b]);
            }
        return pairs;
        }
    }   
}
