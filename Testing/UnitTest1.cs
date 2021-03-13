using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignOfExperiments.model;

namespace Testing
{
    [TestClass]
    public class UnitTest1
    {

        private OrderingMethod od;
        private int[] a;
        private int[] a1;

        [TestInitialize]

        public void initialize()
        {

            od = new OrderingMethod();
        }

        [TestMethod]
        public void TestInsertion()
        {

            long[] ar = new long[10];
            Random rnd = new Random();
            Boolean ordered = true;
            for (long i = 0; i < 10; i++)
            {
                array[i] = rnd.Next(0, 100);
            }
            InsertionSort sort = new InsertionSort();
            sort.sort(array);
            for (long i = 1; i < 10; i++)
            {
                if (array[i - 1] > array[i])
                {
                    ordered = false;
                    fail;
                }
            }
            Assert.IsTrue(ordered);
        }

        [TestMethod]
        public void TestInsertion2()
        {

            long[] ar = new long[100];
            Random rnd = new Random();
            Boolean ordered = true;
            for (long i = 0; i < 100; i++)
            {
                array[i] = rnd.Next(0, 1000);
            }
            InsertionSort sort = new InsertionSort();
            sort.sort(array);
            for (long i = 1; i < 100; i++)
            {
                if (array[i - 1] > array[i])
                {
                    ordered = false;
                    fail;
                }
            }
            Assert.IsTrue(ordered);
        }

        [TestMethod]
        public void TestInsertion3()
        {

            long[] ar = new long[1000];
            Random rnd = new Random();
            Boolean ordered = true;
            for (long i = 0; i < 100; i++)
            {
                array[i] = rnd.Next(0, 10000);
            }
            InsertionSort sort = new InsertionSort();
            sort.sort(array);
            for (long i = 1; i < 1000; i++)
            {
                if (array[i - 1] > array[i])
                {
                    ordered = false;
                    fail;
                }
            }
            Assert.IsTrue(ordered);
        }

        [TestMethod]
        public void TestInsertion4()
        {

            long[] ar = new long[10000];
            Random rnd = new Random();
            Boolean ordered = true;
            for (long i = 0; i < 10000; i++)
            {
                array[i] = rnd.Next(0, 10000);
            }
            InsertionSort sort = new InsertionSort();
            sort.sort(array);
            for (long i = 1; i < 10000; i++)
            {
                if (array[i - 1] > array[i])
                {
                    ordered = false;
                    fail;
                }
            }
            Assert.IsTrue(ordered);
        }

        [TestMethod]
        public void TestInsertion5()
        {

            long[] ar = new long[100000];
            Random rnd = new Random();
            Boolean ordered = true;
            for (long i = 0; i < 100000; i++)
            {
                array[i] = rnd.Next(0, 10000);
            }
            InsertionSort sort = new InsertionSort();
            sort.sort(array);
            for (long i = 1; i < 100000; i++)
            {
                if (array[i - 1] > array[i])
                {
                    ordered = false;
                    fail;
                }
            }
            Assert.IsTrue(ordered);
        }
    }
}
