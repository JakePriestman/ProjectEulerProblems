using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerProblems
{
    /*Reads text file of names and then imports to array, Alphabetically sorts then and adds up the values
    based on the alphabetical value and position in the alphabetically sorted list.*/
    //Runs in around 30Ms.
    public static class Problem22
    {
        public static void NameScoresSum()
        {
            int sum = 0;
            string[] namesList = {};
            var lines = File.ReadAllLines(@"../../../../names.txt");

            for(int i=0; i < lines.Length; i++) //Sorts text file into array.
            {
                namesList = lines[i].Split(',');
            }
            
            Array.Sort(namesList, (x, y) => String.Compare(x, y)); //Sorts names into alphabetical order.

            for (int i=0; i<namesList.Length; i++) //Sums all the name scores and prints the total.
            {
                sum += AlphabeticalValue(namesList[i]) * (i + 1);
            }
            Console.WriteLine(sum);
        }

        public static int AlphabeticalValue(string name)//Method that returns the alphabetical value of a given name.
        {
            int value = 0;
            char[] alphabet = new char[26] { 'A', 'B' , 'C' , 'D' , 'E' , 'F' , 'G' , 'H' ,'I', 'J' , 'K' , 'L' , 'M' ,
                                             'N' , 'O' , 'P' , 'Q' , 'R' , 'S' , 'T' , 'U' , 'V' , 'W' , 'X' , 'Y' , 'Z'};

            for(int i = 0; i < name.Length; i++)
            {
                for(int j=0; j < alphabet.Length; j++)
                {
                    if (name[i] == alphabet[j])
                    {
                        value += (j + 1);
                    }
                }
            }
            return value;
        }
    }
}
