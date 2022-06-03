using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class No54
    {
        public static void ProblemFiftyFour()
        {

            string path = @"C:\Users\Richard\Downloads\p054_poker.txt";

            var lines = File.ReadAllLines(path).ToList();
            var numberOfLines = File.ReadLines(path).Count();
            string[,] hands = new string[numberOfLines, 10];

            int p1Wins = 0;
            int p2Wins = 0;


            for (int i = 0; i < numberOfLines; i++)
            {
                string[] first = lines[i].Split(' ');

                for (int j = 0; j < first.Length; j++)
                {
                    hands[i, j] = first[j];
                }

            }


            for (int i = 0; i < numberOfLines; i++)
            {
                string[] playerOne = new string[5];
                string[] p1Colors = new string[5];
                string[] playerTwo = new string[5];
                string[] p2Colors = new string[5];

                int oneLength = playerOne.Count();

                for (int j = 0; j < 5; j++)
                {

                    string input = new String(hands[i, j]).ToString();

                    string first = input.Substring(0, 1);
                    string last = input.Substring(input.Length - 1);

                    playerOne[j] = first;
                    p1Colors[j] = last;

                }

                for (int j = 5; j < 10; j++)
                {

                    string input = new String(hands[i, j]).ToString();

                    string first = input.Substring(0, 1);
                    string last = input.Substring(input.Length - 1);


                    playerTwo[j - 5] = first;
                    p2Colors[j - 5] = last;

                }

                var pOneScore = CountScore(playerOne, p1Colors);
                var pTwoScore = CountScore(playerTwo, p2Colors);


                if (pOneScore > pTwoScore)
                {
                    p1Wins++;
                }

                if (pOneScore < pTwoScore)
                {
                    p2Wins++;
                }

                if (pOneScore == pTwoScore)
                {
                    if (HighestCard(playerOne) > HighestCard(playerTwo))
                    {
                        p1Wins++;
                    }
                    if (HighestCard(playerOne) < HighestCard(playerTwo))
                    {
                        p2Wins++;
                    }

                }
            }

            Console.WriteLine("Problem 54: Player one wins " + p1Wins + " times.");

        }


        public static int CountScore(string[] pList, string[] pColors)
        {
            List<int> cardValues = new List<int>();
            int[] returnArray = new int[2];

            int score = 0;

            string[,] values = new string[13, 2] { {"2","2"},
                {"3","3"},
                {"4","4"},
                {"5","5"},
                {"6","6"},
                {"7","7"},
                {"8","8"},
                {"9","9"},
                {"T","10"},
                {"J","11"},
                {"Q","12"},
                {"K","13"},
                {"A","14"}
            };

            for (int i = 0; i < 13; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (values[i, 0] == pList[j])
                    {
                        cardValues.Add(Convert.ToInt32(values[i, 1]));
                    }
                }
            }

            if (cardValues.Distinct().Count() == 5) //No pairs
            {
                var high = cardValues.Max();
                score = high;
            }

            if (cardValues.Distinct().Count() == 4) //One pair
            {

                IEnumerable<int> duplicates = cardValues.GroupBy(x => x)
                                        .Where(g => g.Count() > 1)
                                        .Select(x => x.Key);

                var maxPair = duplicates.Max();

                score = maxPair + 13;

            }

            if (cardValues.Distinct().Count() == 3)     //Two pairs and three of a kind
            {

                IEnumerable<int> threeOfAKind = cardValues.GroupBy(x => x)
                    .Where(g => g.Count() > 2)
                    .Select(x => x.Key);


                if (threeOfAKind.Count() == 1)      //Three of a kind
                {
                    var maxThree = threeOfAKind.Max();

                    score = maxThree + 41;

                }

                else

                {
                    IEnumerable<int> twoPairs = cardValues.GroupBy(x => x)
        .Where(g => g.Count() > 1)
        .Select(x => x.Key);

                    var maxPair = twoPairs.Max();

                    score = maxPair + 27;

                }
            }

            if (cardValues.Min() + 4 == cardValues.Max() && cardValues.Distinct().Count() == 5) //Straight(stege)
            {
                var high = cardValues.Max() + 55;
                score = high;
            }

            if (pColors.Distinct().Count() == 1) //Flush, alla samma färg
            {
                var high = cardValues.Max() + 69;
                score = high;
            }

            if (cardValues.Distinct().Count() == 2) //Full house (kåk)
            {

                IEnumerable<int> fullHouseThree = cardValues.GroupBy(x => x)
    .Where(g => g.Count() > 2)
    .Select(x => x.Key);


                var maxThree = fullHouseThree.Max();

                score = maxThree + 83;
            }

            return score;

        }

        public static int HighestCard(string[] pList)
        {

            List<int> valueCard = new List<int>();

            string[,] values = new string[13, 2] { {"2","2"},
                {"3","3"},
                {"4","4"},
                {"5","5"},
                {"6","6"},
                {"7","7"},
                {"8","8"},
                {"9","9"},
                {"T","10"},
                {"J","11"},
                {"Q","12"},
                {"K","13"},
                {"A","14"}
            };

            for (int i = 0; i < 13; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (values[i, 0] == pList[j])
                    {
                        valueCard.Add(Convert.ToInt32(values[i, 1]));
                    }
                }
            }

            var highestCard = valueCard.Max();

            return highestCard;
        }
    }
}
