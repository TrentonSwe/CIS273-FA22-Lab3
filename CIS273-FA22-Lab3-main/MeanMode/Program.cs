using System;

namespace MeanMode
{
    public class Program
    {
        static void Main(string[] args)
        {

        }

        public static bool MeanMode(int[] array)
        {
            return computeMode(array) == computeAverage(array);
        }

        // TODO
        private static double computeAverage(int[] array)
        {
            int total = 0;
            foreach (int num in array)
            {
                total += num;
            }
            
            return total / array.Length;
        }

        // TODO
        private static double? computeMode(int[] array)
        {
            Dictionary<int, int> numCounts = new Dictionary<int, int>();

            foreach (int num in array)
            {
                if (!numCounts.ContainsKey(num))
                {
                    numCounts.Add(num, 1);
                }
                else
                {
                    numCounts[num] += 1;
                }
            }

            int maxCount = 0;

            foreach (int num in array)
            {
                if(numCounts[num] > maxCount)
                {
                    maxCount = numCounts[num];
                }
                else if (numCounts[num] == maxCount)
                {
                    return null;
                }
            }
            return maxCount;
        }
    }
}
