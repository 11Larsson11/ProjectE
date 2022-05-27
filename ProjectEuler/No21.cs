using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class No21
    {
        public static void ProblemTwentyOne()
        {
            int firstSum = 0;
            int secondSum = 0;
            int sumOfAmicable = 0;

            for (int i = 1; i < 10000; i++)
            {
                
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0 && i != j)
                    {
                        firstSum += j;
                    }

                    if (i == j)
                    {
                        for (int k = 1; k < i; k++)
                        {
                            if (firstSum % k == 0 && firstSum != k)
                            {
                                secondSum += k;
                            }
                        }
                    }

                    if (i == secondSum && firstSum != secondSum)
                    {
                        sumOfAmicable += i;
                    }
                }

                secondSum = 0;
                firstSum = 0;

            }

            Console.WriteLine("The sum of all amicable numbers below 10000 is " + sumOfAmicable);

        }
    }
}
