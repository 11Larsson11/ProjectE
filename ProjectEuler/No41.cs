using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class No41
    {
        public static void ProblemFourtyOne()
        {

            List<int> correctValues = new List<int>();

            for (int i = 1; i < 9000000; i++)
            {

                string b = i.ToString();
                List<char> charList = new List<char>();
                

                for (int j = 0; j < b.Length; j++)

                {
                    if (char.IsDigit(b[j]))
                    {
                        charList.Add(b[j]);
                    }
                    
                }

                if (charList.Count <= charList.Distinct().Count() && IsPrime(i) == true && NumSequence(i) == true)
                {
                    correctValues.Add(i);                  
                }

            }

            int max = correctValues.Max();

            Console.WriteLine("Problem 41: The max value is " + max);
            
        }

        public static bool IsPrime(int val)
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

        public static bool NumSequence(int val)
        {

            string num = val.ToString();

            int charCount = num.Length;

            foreach (char c in num)
            {

                int d = Convert.ToInt32(new string(c, 1));

                if (d > charCount | d == 0)
                {
                    return false;

                }

            }

            return true;

        }
    }
}
