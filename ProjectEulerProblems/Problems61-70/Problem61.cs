using System.Linq;

namespace ProjectEulerProblems
{
    class Problem61
    {
        public static void CyclicalFiguratenumbers()
        {
            int[][] numbersLists = new int[6][];
            int[] solution = new int[6];

            for(int i= 0; i<solution.Length; i++)
            {
                numbersLists[i] = GenerateNumberList(i);
            }

            for(int i=0; i<numbersLists[5].Length; i++)
            {
                solution[5] = numbersLists[5][i];
                if(FindNext(5,1, solution, numbersLists)) break;
            }
            for(int i=0; i<solution.Length; i++)
            {
                Console.Write(solution[i]+ ", ");
            }

            Console.WriteLine("\n");
            Console.WriteLine(solution.Sum());

		}
        public static bool FindNext(int last, int length, int[] solution, int[][] numbersLists) 
        {
            for (int i = 0; i < solution.Length; i++) 
            {
                if (solution[i] != 0) continue;                
                for (int j = 0; j < numbersLists[i].Length; j++) 
                {

                    bool unique = true;                                                       
                    for(int k = 0; k < solution.Length; k++)
                    {
                        if (numbersLists[i][j] == solution[k]) 
                        {
                            unique = false;
                            break;
                        }                                                
                    }
                                            
                    if ( unique && ((numbersLists[i][j] / 100) == (solution[last] % 100))) 
                    {                        
                        solution[i] = numbersLists[i][j];
                        if (length == 5) 
                        {
                            if (solution[5] / 100 == solution[i] % 100) return true;
                        }
                        if (FindNext(i, length + 1, solution, numbersLists)) return true;                        
                    }                    
                }
                solution[i] = 0;
            }            
            return false;                       
        }
        public static int[] GenerateNumberList(int type) //Generates a list of lists of all the 4 digit tri- oct numbers.
        {
            List<int> numbers = new List<int>();

            int n=0;
            int number =0;

            while(number < 10000)
            {
                n++;
                switch(type)
                {
                    case 0:
                    number = n*(n+1) / 2;
                    break;
                    case 1:
                    number = (n*n);
                    break;
                    case 2:
                    number = n*(3*n-1) / 2;
                    break;
                    case 3:
                    number = n*(2*n-1);
                    break;
                    case 4:
                    number = n*(5*n-3) / 2;
                    break;
                    case 5:
                    number = n*(3*n-2);
                    break;
                }
                if(number > 999 && number < 10000)
                {
                    numbers.Add(number);
                }
            }
            return numbers.ToArray();
            
        }
    }
}