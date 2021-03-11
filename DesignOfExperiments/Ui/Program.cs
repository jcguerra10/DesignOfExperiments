using System;
using System.Diagnostics;
using DesignOfExperiments.model;

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

        private static OrderingMethod om = new OrderingMethod();

        public static void Main(string[] args)
        {
            OrderingMethod om = new OrderingMethod();
            int[] s;
            int[] temp;

            Stopwatch sw = new Stopwatch();

            for (int i = 2; i < 6; i++)
            {
                s = generateArray((int) Math.Pow(10, i));

                Console.WriteLine("10^"+i+" InsertionSort");
                Console.WriteLine("InDesOrder");
                sw.Start();
                temp = om.insertionSort((int[]) s.Clone());
                sw.Stop();
                Console.Write("Time in seconds: ");
                Console.WriteLine((sw.Elapsed.TotalSeconds));
                Console.WriteLine();
                Console.WriteLine("InOrder");
                sw.Reset();
                sw.Start(); 
                temp = om.insertionSort((int[])temp.Clone());
                sw.Stop();
                Console.Write("Time in seconds: ");
                Console.WriteLine((sw.Elapsed.TotalSeconds));
                Console.WriteLine();
                Console.WriteLine("Reverse");
                Array.Reverse(temp);
                sw.Reset();
                sw.Start();
                temp = om.insertionSort((int[]) temp.Clone());
                sw.Stop();
                Console.Write("Time in seconds: ");
                Console.WriteLine((sw.Elapsed.TotalSeconds));
                Console.WriteLine();

                sw.Reset();

                Console.WriteLine("10^"+i+" SelectionSort");
                Console.WriteLine("InDesOrder");
                sw.Start();
                temp = om.selectionSort((int[]) s.Clone());
                sw.Stop();
                Console.Write("Time in seconds: ");
                Console.WriteLine((sw.Elapsed.TotalSeconds));
                Console.WriteLine();
                Console.WriteLine("InOrder");
                sw.Reset();
                sw.Start(); 
                temp = om.selectionSort((int[])temp.Clone());
                sw.Stop();
                Console.Write("Time in seconds: ");
                Console.WriteLine((sw.Elapsed.TotalSeconds));
                Console.WriteLine();
                Console.WriteLine("Reverse");
                Array.Reverse(temp);
                sw.Reset();
                sw.Start();
                temp = om.selectionSort((int[]) temp.Clone());
                sw.Stop();
                Console.Write("Time in seconds: ");
                Console.WriteLine((sw.Elapsed.TotalSeconds));
                Console.WriteLine();
            }
        }

        private static int[] generateArray(int n)
        {
            Random r = new Random();
            int[] gen = new int[n];
            for (int i = 0; i < n; i++)
            {
                gen[i] = r.Next(1, 1000000001);
            }

            return gen;
        }

        private static void printArray(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
            {
                Console.Write(arr[i] + " ");
            } 
            Console.Write("\n");
        }
    }
}