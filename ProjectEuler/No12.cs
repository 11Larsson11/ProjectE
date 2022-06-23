using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class No12
    {
        public static void ProblemTwelve()
        {
            long triangleSum = 0;

            for (long i = 1; i < 999999; i++)
            {

                triangleSum += i;

                List<long> triangleList = new List<long>();


                for (long j = 1; j <= triangleSum; j++)
                {

                    if (triangleSum % j == 0)
                    {
                        triangleList.Add(j);
                    }

                }


                if (triangleList.Count > 500)
                {
                    Console.WriteLine(triangleSum + " has over 500 divisors");
                    break;

                }

                triangleList.Clear();

            }
        }
    }
}
