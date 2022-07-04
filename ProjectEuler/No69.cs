using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class No69
    {

        public static double[] listOfValues = new double[1000000];
        public static void ProblemSixtynine()
        {

            for (double i = 1; i <= 1000000; i++)
            {
                RelPrimeChecker(i);
            }

            var (number, index) = listOfValues.Select((n, i) => (n, i)).Max();
            Console.WriteLine($"Problem 96: {index} has the highest divisor under 1 000 000 ({number}).");

        }


        //A less demanding solution needs to be found


        public static void RelPrimeChecker(double val)
        {


            List<double> listOfFactors = new List<double>();
            List<double> relativePrimes = new List<double>();


            for (double j = 1; j <= val; j++)
            {
                if (val % j == 0)
                {
                    listOfFactors.Add(j);    //Adds the factors of val to listOfFactors
                }

            }

            for (double j = 1;j <= val; j++)
            {
                List<double> tempFactors = new List<double>();


                for (double k = 1;k <= val; k++)
                {
                    if (j % k == 0)
                    {
                        tempFactors.Add(k); //Adds the factors to a temporary list
                    }


                }

                double factorCounter = 0;

                foreach (double k in tempFactors)
                {
                    if (listOfFactors.Contains(k))
                    {
                        factorCounter ++;
                    }

                    if (factorCounter > 1)
                    {
                        continue;
                    }


                }

                if (factorCounter == 1)
                {
                    relativePrimes.Add(j);
                }
            }

            int nVal = Convert.ToInt32(val);
            double divisor = Convert.ToDouble(relativePrimes.Count);
            double result = val / divisor;


            listOfValues[nVal] = result;


        }
    }
}
