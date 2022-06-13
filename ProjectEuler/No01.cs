using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class No01
    {

        public static void ProblemOne()
        {

            //Project Euler #1


            var list = new List<int>();

            //Checking which numbers between 1 and 1000 that are divisable with 3 or 5

            for (int i = 1; i < 1000; i++)
            {

                if ((i % 3 == 0) | (i % 5 == 0) == true)
                {
                    list.Add(i);
                }

            }

            Console.WriteLine("Project Euler");
            Console.WriteLine("Problem #1: The sum of all natural numbers below 1000, divisable with 3 & 5 are " + list.Sum());

        }
    }
}
