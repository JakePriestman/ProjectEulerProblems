namespace ProjectEulerProblems
{
    //Finds the smallest cube such that 5 of its permutations are also cube.
    //Runs in 16s
    class Problem62
    {
        public static void CubicPermutations()
        {
            List<string> cubes = new List<string>();
            
            for(int i=0; i< 10000; i++)
            {
                cubes.Add(Cube(i));
            }

            for(int i=0; i<cubes.Count();i++)
            {
                int count =1;
                for(int j=i+1; j<cubes.Count(); j++)
                {

                    if(Problem32.SortString(cubes[i]) == Problem32.SortString(cubes[j]))
                    {
                        count++;
                        
                    }
                }
                if(count == 5)
                {
                    Console.WriteLine(Math.Cbrt(Convert.ToDouble(cubes[i])));
                    break;
                }
                

            }
            
            
            
        }
        public static bool isCubic(long num) //checks number is a cube.
        {
            double cubeRoot = Math.Cbrt(num);
            return cubeRoot == ((int)cubeRoot);
        }


        public static string Cube(int num)
        {
            System.Numerics.BigInteger cube = num;
            for(int i=1; i<3; i++)
            {
                cube *=num;
            }
            return Convert.ToString(cube);
        }
    }
}