using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerProblems
{
    //Finds the number of sundays in the 20th century that lie on the first of a month.
    //Runs in 5Ms.
    public static class Problem19
    {
        public static void CountingSundays()
        {
            int sundays = 0;
            for(int year=1901; year<2001;year++)
            { 
               for(int month = 1; month<=12; month++)
                {
                    if(new DateTime(year,month,1).DayOfWeek == DayOfWeek.Sunday)
                    {
                        sundays += 1;
                    }
                }
            }
            Console.WriteLine(sundays);
        }
    }
}
