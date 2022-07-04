using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class No06
    {
        public static void ProblemSix()
        {
            double firstValue = 0;
            double secondValue = 0;

            for (double i = 1; i <= 100; i++)
            {
                firstValue += Math.Pow(i, 2);
            }


            for (double i = 1; i <= 100; i++)
            {
                secondValue += i;
            }

            secondValue = Math.Pow(secondValue, 2);

            var answer = secondValue - firstValue;


            Console.WriteLine("Problem #6: The difference is " + answer);

        }
    }
}
