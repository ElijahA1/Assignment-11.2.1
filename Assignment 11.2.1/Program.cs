using System.Diagnostics;

namespace Assignment_11._2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] stockOptions = { 7, 1, 5, 3, 6, 4 };
            int[] badOption = { 5, 3, 1 };

            int biggestPayout = bestOption(stockOptions);
            int worstPayout = bestOption(badOption);

            Console.WriteLine(biggestPayout);
            Console.WriteLine(worstPayout);
            Console.ReadKey();
        }

        // Improved
        static int bestOption(int[] array)
        {
            int minPrice = int.MaxValue;
            int maxProfit = 0;

            foreach (int price in array)
            {
                if (price < minPrice)
                    minPrice = price;
                else
                {
                    int profit = price - minPrice;
                    if (profit > maxProfit)
                        maxProfit = profit;
                }
            }

            return maxProfit;

        }

        // Original
        //static int bestOption(int[] array)
        //{
        //    int maxProfit = 0, i, j;

        //    for (i = 0; i < array.Length - 1; i++)
        //    {
        //        for (j = i + 1; j < array.Length; j++)
        //        {
        //            if (array[i] >= array[j])
        //                continue;

        //            if (array[j] - array[i] > maxProfit)
        //                maxProfit = array[j] - array[i];
        //        }
        //    }
        //    return maxProfit;
        //}
    }
}
