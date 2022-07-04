using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class No10
    {

        public static void ProblemTen()
        {
            long primeSum = 0;


            for (long i = 2; i < 2000000; i++)
            {
                if (PrimeChecker(i) == true)
                {
                    primeSum += i;
                }
            }

            Console.WriteLine("The sum of all prime numbers below two million is " + primeSum);

        }

        public static bool PrimeChecker(long val)
        {
            for (long j = 2; j < val; j++)
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
