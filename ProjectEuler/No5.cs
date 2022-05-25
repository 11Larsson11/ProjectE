using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    internal class No5
    {
        public static void ProblemFive()
        {
            int trueChecker = 0;
            long trueValue = 0;
            bool correctValue = false;

            while (correctValue == false)
            {


                for (long i = 1; i < 332792560; i++)
                {

                    for (int j = 1; j <= 20; j++)
                    {

                        if (i % j == 0)
                        {
                            trueChecker++;
                        }

                        if (j == 20 && trueChecker != 20)
                        {
                            trueChecker = 0;
                            break;
                        }

                        if (j == 20 && trueChecker == 20)
                        {
                            trueValue = i;
                            correctValue = true;
                            Console.WriteLine("Problem #5: The smallest multiple is " + trueValue);
                            break;
                        }


                    }
                }
            }
        }
    }
}
