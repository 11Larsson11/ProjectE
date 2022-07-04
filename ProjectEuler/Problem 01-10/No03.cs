using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class No03
    {

        public static void ProblemThree()
        {

            long testNr = 600851475143;

            for (int i = 2; i < testNr / 2; i++)
            {

                if (testNr % i == 0 && PrimeChecker(i) == true)
                {
                    testNr = (testNr / i);

                }

            }

            Console.WriteLine("Problem #3: The largest prime factor for 600851475143 is " + testNr);

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

