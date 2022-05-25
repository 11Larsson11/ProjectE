using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class No4
    {
        public static void ProblemFour()
        {

            List<long> listOfProducts = new List<long>();


            for (int i = 100; i < 1000; i++)
            {
                for (int j = 100; j < 1000; j++)
                {

                    long checkPalindrom = i * j;

                    string checker = checkPalindrom.ToString();

                    if (Reverse(checker) == true)
                    {
                        listOfProducts.Add(checkPalindrom);

                    }
                }
            }

            Console.WriteLine("Problem #4: The largest palindrome of two three-digit numbers is " + listOfProducts.Max());


            static bool Reverse(string checker)
            {
                var checkerBackwards = new string(checker.ToCharArray().Reverse().ToArray());

                if (checker == checkerBackwards)
                {

                    return true;
                }

                return false;
            }
        }
    }
}
