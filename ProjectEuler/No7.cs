using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class No7
    {
        public static void ProblemSeven()
        {

            int primeCounter = 0;
            int soughtNr = 0;


            for (int i = 2; i < 1000000; i++)
            {
                if (PrimeChecker(i) == true)
                {
                    primeCounter++;
                }

                if (primeCounter == 10001)
                {
                    soughtNr = i;
                    break;
                }

            }

            Console.WriteLine("Problem #7: The sought number is " + soughtNr);
        }


        public static bool PrimeChecker(int val)
        {

            for (int j = 2; j < val; j++)
            {

                if (val % j == 0 && val != j)

                {
                    return false;
                }

            }

            return true;

        }
    }
}
