namespace ProjectEulerProblems
{
    //Finds the first side length such that the number of diagonal primes / the number of diagonal numbers < 0.1
    //Runs in around 195 Ms.
    class Problem58
    {
        public static void SpiralPrimes()
        {
            
            int i =0;
            int length = 1;
            int diagonalsTotal = 1;
            double numOfPrimes = 0;
            bool notFound = true;

            while(notFound)
            {
                i++;
                length +=2;
                diagonalsTotal += 4;

                if(isPrime(((2*i+1) * (2*i+1))-6*i))
                {
                    numOfPrimes++;
                }
                if(isPrime(((2*i+1) * (2*i+1))-4*i))
                {
                    numOfPrimes++;
                }
                if(isPrime(((2*i+1) * (2*i+1))-2*i))
                {
                    numOfPrimes++;
                }

                if(numOfPrimes / Convert.ToDouble(diagonalsTotal) < 0.10)
                {
                    notFound = false;
                }
            }
            /*for(int j=0; j<primeDiagonals.Count(); j++)
            {
                Console.WriteLine(primeDiagonals[j]);
            }*/

            Console.WriteLine(numOfPrimes);
            Console.WriteLine(diagonalsTotal);
            Console.WriteLine(length);
        }

        public static bool isPrime(long n) {
            if (n <= 1) return false;
            if (n == 2) return true;
            if (n % 2 == 0) return false;
            if (n < 9) return true;
            if (n % 3 == 0) return false;
            
            long counter = 5;            
            while ((counter * counter) <= n) {
                if (n % counter == 0) return false;
                if (n % (counter + 2) == 0) return false;
                counter += 6;
            }

            return true;
        }
    }
}