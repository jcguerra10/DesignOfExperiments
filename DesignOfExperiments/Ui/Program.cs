using System;

namespace DesignOfExperiments
{
    internal class Program
    {
        private int[] inOrderArray1 = {1, 4, 5, 6};
        private int[] inOrderArray2 = {20, 70, 80, 140};

        private int[] inDesOrderArray1 = {6, 2, 1, 8, 0, 4, 7, 9, 5, 3};
        private int[] inDesOrderArray2 = {30, 28, 14, 23, 67, 10, 35, 24, 76, 54};

        private int[] invertedArray1 = {6, 5, 4, 1};
        private int[] invertedArray2 = {140, 80, 70, 20};
        
        public static void Main(string[] args)
        {
            int[] s = generateArray(12);
            foreach (var i in s)
            {
                Console.WriteLine(i);
            }
        }

        private static int[] generateArray(int n)
        {
            Random r = new Random();
            int[] gen = new int[n];
            for (int i = 0; i < n; i++)
            {
                gen[i] = r.Next(1, 100001);
            }

            return gen;
        }
    }
}