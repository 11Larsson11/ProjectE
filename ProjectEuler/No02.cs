using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class No02
    {
        public static void ProblemTwo()
        {

            var numList = new List<int>();
            var evenNumbers = new List<int>();

            for (int i = 0; i < (i + 1); i++)
            {

                if (Fibonacci(i) > 4000000)
                {
                    break;
                }

                else
                {
                    numList.Add(Fibonacci(i));
                }
            }

            foreach (int i in numList)
            {
                if (i % 2 == 0)
                {
                    evenNumbers.Add(i);
                }

            }

            var sum = evenNumbers.Sum();

            Console.WriteLine("Problem #2: The sum of even Fibonacci numbers below 4 000 000 is: " + sum);

        }


        public static int Fibonacci(int num)
        {

            int a = 1;
            int b = 2;

            for (int i = 0; i < num; i++)
            {
                int c = a;
                a = b;
                b = a + c;
            }

            return a;

        }
    }
}


