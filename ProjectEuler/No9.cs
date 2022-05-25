using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class No9
    {

        public static void ProblemNine()
        {

            int a = 0;
            int b = 0;
            int c = 0;

            bool foundCorrect = false;


            for (a = 0; a < 1000; a++)
            {
                for (b = 0; b < 1000; b++)
                {
                    c = 1000 - a - b;

                    if ((a < b) && (b < c) && ((a * a) + (b * b) == (c * c)))
                    {
                        foundCorrect = true;
                        break;
                    }

                }


                if (foundCorrect == true)
                {
                    break;
                }

            }

            var sum = a * b * c;

            Console.WriteLine("Problem #9: The product abc is " + sum);

        }
    }
}


