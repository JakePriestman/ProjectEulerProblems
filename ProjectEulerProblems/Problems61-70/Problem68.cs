using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerProblems.Problems61_70
{
	//Finds the maximum concantinated 16 digit string in which using the numbers 1-10 in a Magic 5 gon ring.
	//Runs in 1924Ms
	class Problem68
	{
		public void Magic5GonRing()
		{
			int[][,] fiveGonRing = FiveGonList();

			List<List<string>> solutionSets = new List<List<string>>();
			List<string> solutionStrings = new List<string>();

			for (int i = 0; i < fiveGonRing.Length; i++)
			{
				if (isFiveComplete(fiveGonRing[i]) && isFiveUnique(fiveGonRing[i], solutionSets))
				{
					int total = fiveGonRing[i][0, 2] + fiveGonRing[i][1, 2] + fiveGonRing[i][2, 2];

					List<string> solution = ClockWiseFiveGon(fiveGonRing[i]);
					solutionSets.Add(solution);

					solutionStrings.Add(solution[0] + solution[1] + solution[2] + solution[3] + solution[4]);
					Console.WriteLine(total + ": " + solution.Aggregate((a,b) => a + "\t " + b));
				}
			}
			Console.WriteLine(solutionStrings.Max());
		} //Solves for 5 Gon Ring.

		public void Magic3GonRing()
		{
			int[][,] threeGonRing = ThreeGonList();
			List<List<string>> solutionSets = new List<List<string>>();
			List<string> solutionStrings = new List<string>();

			for(int i =0; i < threeGonRing.Length; i++)
			{
				if (isThreeComplete(threeGonRing[i]) && isThreeUnique(threeGonRing[i], solutionSets))
				{
					int total = threeGonRing[i][0, 2] + threeGonRing[i][1, 2] + threeGonRing[i][2, 2];
					List<string> solution = ClockWiseThreeGon(threeGonRing[i]);

					solutionSets.Add(solution);
					solutionStrings.Add(solution[0] + solution[1] + solution[2]);

					Console.WriteLine( total + ": " + solution[0] + "; " + solution[1] + "; " + solution[2]);
				}
			}

			Console.WriteLine(solutionStrings.Max());
		} //Solves for 3 Gon Ring.
		public int[][,] ThreeGonList()
		{
			List<string> perms = new List<string>();
			Problem24.Permute("123456", 0, 5, perms);

			int[][,] innerTriangles = new int[perms.Count()][,];

			for (int i = 0; i <perms.Count(); i++)
			{
				innerTriangles[i] = new int[3, 4];
				innerTriangles[i][0, 2] = perms[i][0] - '0';
				innerTriangles[i][1, 2] = perms[i][1] - '0';
				innerTriangles[i][2, 0] = perms[i][2] - '0';
				innerTriangles[i][2, 1] = perms[i][3] - '0';
				innerTriangles[i][2, 2] = perms[i][4] - '0';
				innerTriangles[i][2, 3] = perms[i][5] - '0';
			}
			return innerTriangles;
		}  //Creates List of all 3 gon possibilities
		public int[][,] FiveGonList()
		{
			List<string> perms = new List<string>();
			Problem24.Permute("0123456789", 0, 9, perms);

			int[][,] innerTriangles = new int[perms.Count()][,];

			for (int i = 0; i < perms.Count(); i++)
			{
				innerTriangles[i] = new int[4, 4];
				innerTriangles[i][1, 2] = (perms[i][0] - '0') + 1;
				innerTriangles[i][2, 2] = (perms[i][1] - '0') + 1;
				innerTriangles[i][3, 2] = (perms[i][2] - '0') + 1;
				innerTriangles[i][3, 1] = (perms[i][3] - '0') + 1;
				innerTriangles[i][2, 1] = (perms[i][4] - '0') + 1;
				innerTriangles[i][0, 2] = (perms[i][5] - '0') + 1;
				innerTriangles[i][1, 3] = (perms[i][6] - '0') + 1;
				innerTriangles[i][3, 3] = (perms[i][7] - '0') + 1;
				innerTriangles[i][3, 0] = (perms[i][8] - '0') + 1;
				innerTriangles[i][2, 0] = (perms[i][9] - '0') + 1;
			}
			return innerTriangles;
		} //Creates List of all 5 gon possibilities
		public bool isThreeComplete(int[,] magicNGonring)
		{
			int line1 = magicNGonring[0, 2] + magicNGonring[1, 2] + magicNGonring[2, 2];
			int line2 = magicNGonring[2, 0] + magicNGonring[2, 1] + magicNGonring[1, 2];
			int line3 = magicNGonring[2, 1] + magicNGonring[2, 2] + magicNGonring[2, 3];
			if (line1 == line2 && line2 == line3)
			{
				return true;
			}
			else { return false; }
		} //Checks if the 3 gon is a solution
		public bool isFiveComplete(int[,] magicNGonring)
		{
			int line1 = magicNGonring[0, 2] + magicNGonring[1, 2] + magicNGonring[2, 2];
			int line2 = magicNGonring[1, 3] + magicNGonring[2, 2] + magicNGonring[3, 2];
			int line3 = magicNGonring[3, 3] + magicNGonring[3, 2] + magicNGonring[3, 1];
			int line4 = magicNGonring[3, 0] + magicNGonring[3, 1] + magicNGonring[2, 1];
			int line5 = magicNGonring[2, 0] + magicNGonring[2, 1] + magicNGonring[1, 2];

			if (line1 == line2 && line2 == line3 && line3 == line4 && line4 == line5)
			{
				return true;
			}
			else { return false; }
		} //Checks if the 5 gon is a solution
		public bool isThreeUnique(int[,] magicNGonring, List<List<string>> solutions)
		{
			List<List<string>> list = solutions;
			string line1 = magicNGonring[0, 2].ToString() + magicNGonring[1, 2].ToString() + magicNGonring[2, 2].ToString();
			string line2 = magicNGonring[2, 0].ToString() + magicNGonring[2, 1].ToString() + magicNGonring[1, 2].ToString();
			string line3 = magicNGonring[2, 3].ToString() + magicNGonring[2, 2].ToString() + magicNGonring[2, 1].ToString();
			List<string> lines = new List<string>() {line1, line2, line3 };
			lines.Sort();

			foreach(var item in list)
			{
				item.Sort();
				if(lines.SequenceEqual(item))
				{
					return false;
				}
			}
			return true;

		} //Checks the solution hasnnt already been found in a different ocsilation. (3)
		public bool isFiveUnique(int[,] magicNGonring, List<List<string>> solutions)
		{
			List<List<string>> list = solutions;
			string line1 = magicNGonring[0, 2].ToString() + magicNGonring[1, 2].ToString() + magicNGonring[2, 2].ToString();
			string line2 = magicNGonring[1, 3].ToString() + magicNGonring[1, 2].ToString() + magicNGonring[2, 2].ToString();
			string line3 = magicNGonring[3, 3].ToString() + magicNGonring[3, 2].ToString() + magicNGonring[3, 1].ToString();
			string line4 = magicNGonring[3, 0].ToString() + magicNGonring[3, 1].ToString() + magicNGonring[2, 1].ToString();
			string line5 = magicNGonring[2, 0].ToString() + magicNGonring[2, 1].ToString() + magicNGonring[1, 2].ToString();
			List<string> lines = new List<string>() { line1, line2, line3, line4, line5};
			//lines.Sort();

			foreach (var item in list)
			{
				//item.Sort();
				if (lines.SequenceEqual(item))
				{
					return false;
				}
			}
			return true;

		} //Checks the solution hasnnt already been found in a different ocsilation. (5)

		public List<string> ClockWiseThreeGon(int[,] magicNGonRing)
		{
			int num = Math.Min(Math.Min(magicNGonRing[0, 2], magicNGonRing[2, 3]), magicNGonRing[2, 0]);

			if (magicNGonRing[0, 2] == num)
			{
				string string1 = magicNGonRing[0, 2].ToString() + magicNGonRing[1, 2].ToString() + magicNGonRing[2, 2].ToString();
				string string2 = magicNGonRing[2, 3].ToString() + magicNGonRing[2, 2].ToString() + magicNGonRing[2, 1].ToString();
				string string3 = magicNGonRing[2, 0].ToString() + magicNGonRing[2, 1].ToString() + magicNGonRing[1, 2].ToString();

				List<string> solution = new List<string>() { string1, string2, string3 };
				return solution;
			}
			else if (magicNGonRing[2, 3] == num)
			{
				string string1 = magicNGonRing[2, 3].ToString() + magicNGonRing[2, 2].ToString() + magicNGonRing[2, 1].ToString();
				string string2 = magicNGonRing[2, 0].ToString() + magicNGonRing[2, 1].ToString() + magicNGonRing[1, 2].ToString();
				string string3 = magicNGonRing[0, 2].ToString() + magicNGonRing[1, 2].ToString() + magicNGonRing[2, 2].ToString();
				List<string> solution = new List<string>() { string1, string2, string3 };
				return solution;
			}
			else if (magicNGonRing[2, 0] == num)
			{
				string string1 = magicNGonRing[2, 0].ToString() + magicNGonRing[2, 1].ToString() + magicNGonRing[1, 2].ToString();
				string string2 = magicNGonRing[0, 2].ToString() + magicNGonRing[1, 2].ToString() + magicNGonRing[2, 2].ToString();
				string string3 = magicNGonRing[2, 3].ToString() + magicNGonRing[2, 2].ToString() + magicNGonRing[2, 1].ToString();
				List<string> solution = new List<string>() { string1, string2, string3};
				return solution;
			}
			return null;
		} //Clockwise function for 3 gon to ensure starting with the smallest outer node and going clockwise.
		public List<string> ClockWiseFiveGon(int[,] magicNGonRing)
		{
			int num = Math.Min(Math.Min(Math.Min(Math.Min(magicNGonRing[0, 2], magicNGonRing[1, 3]), magicNGonRing[3, 3]), magicNGonRing[3, 0]), magicNGonRing[2, 0]);
			if(magicNGonRing[0, 2] == num)
			{
				string string1 = magicNGonRing[0, 2].ToString() + magicNGonRing[1, 2].ToString() + magicNGonRing[2, 2].ToString();
				string string2 = magicNGonRing[1, 3].ToString() + magicNGonRing[2, 2].ToString() + magicNGonRing[3, 2].ToString();
				string string3 = magicNGonRing[3, 3].ToString() + magicNGonRing[3, 2].ToString() + magicNGonRing[3, 1].ToString();
				string string4 = magicNGonRing[3, 0].ToString() + magicNGonRing[3, 1].ToString() + magicNGonRing[2, 1].ToString();
				string string5 = magicNGonRing[2, 0].ToString() + magicNGonRing[2, 1].ToString() + magicNGonRing[1, 2].ToString();

				List<string> solution = new List<string>() { string1, string2, string3, string4, string5 };
				return solution;
			}
			else if(magicNGonRing[1, 3] == num)
			{
				string string1 = magicNGonRing[1, 3].ToString() + magicNGonRing[2, 2].ToString() + magicNGonRing[3, 2].ToString();
				string string2 = magicNGonRing[3, 3].ToString() + magicNGonRing[3, 2].ToString() + magicNGonRing[3, 1].ToString();
				string string3 = magicNGonRing[3, 0].ToString() + magicNGonRing[3, 1].ToString() + magicNGonRing[2, 1].ToString();
				string string4 = magicNGonRing[2, 0].ToString() + magicNGonRing[2, 1].ToString() + magicNGonRing[1, 2].ToString();
				string string5 = magicNGonRing[0, 2].ToString() + magicNGonRing[1, 2].ToString() + magicNGonRing[2, 2].ToString();
				List<string> solution = new List<string>() { string1, string2, string3, string4, string5 };
				return solution;
			}
			else if(magicNGonRing[3, 3] == num)
			{
				string string1 = magicNGonRing[3, 3].ToString() + magicNGonRing[3, 2].ToString() + magicNGonRing[3, 1].ToString();
				string string2 = magicNGonRing[3, 0].ToString() + magicNGonRing[3, 1].ToString() + magicNGonRing[2, 1].ToString();
				string string3 = magicNGonRing[2, 0].ToString() + magicNGonRing[2, 1].ToString() + magicNGonRing[1, 2].ToString();
				string string4 = magicNGonRing[0, 2].ToString() + magicNGonRing[1, 2].ToString() + magicNGonRing[2, 2].ToString();
				string string5 = magicNGonRing[1, 3].ToString() + magicNGonRing[2, 2].ToString() + magicNGonRing[3, 2].ToString();
				List<string> solution = new List<string>() { string1, string2, string3, string4, string5 };
				return solution;
			}
			else if(magicNGonRing[3, 0] == num)
			{
				string string1 = magicNGonRing[3, 0].ToString() + magicNGonRing[3, 1].ToString() + magicNGonRing[2, 1].ToString();
				string string2 = magicNGonRing[2, 0].ToString() + magicNGonRing[2, 1].ToString() + magicNGonRing[1, 2].ToString();
				string string3 = magicNGonRing[0, 2].ToString() + magicNGonRing[1, 2].ToString() + magicNGonRing[2, 2].ToString();
				string string4 = magicNGonRing[1, 3].ToString() + magicNGonRing[2, 2].ToString() + magicNGonRing[3, 2].ToString();
				string string5 = magicNGonRing[3, 3].ToString() + magicNGonRing[3, 2].ToString() + magicNGonRing[3, 1].ToString();
				List<string> solution = new List<string>() { string1, string2, string3, string4, string5 };
				return solution;

			}
			else if(magicNGonRing[2, 0] == num )
			{
				string string1 = magicNGonRing[2, 0].ToString() + magicNGonRing[2, 1].ToString() + magicNGonRing[1, 2].ToString();
				string string2 = magicNGonRing[0, 2].ToString() + magicNGonRing[1, 2].ToString() + magicNGonRing[2, 2].ToString();
				string string3 = magicNGonRing[1, 3].ToString() + magicNGonRing[2, 2].ToString() + magicNGonRing[3, 2].ToString();
				string string4 = magicNGonRing[3, 3].ToString() + magicNGonRing[3, 2].ToString() + magicNGonRing[3, 1].ToString();
				string string5 = magicNGonRing[3, 0].ToString() + magicNGonRing[3, 1].ToString() + magicNGonRing[2, 1].ToString();
				List<string> solution = new List<string>() { string1, string2, string3, string4, string5 };
				return solution;
			}
			return null;
		} //Clockwise function for 5 gon to ensure starting with the smallest outer node and going clockwise.
	}
}
