using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignOfExperiments.model
{
    class OrderingMethod
    {
        public int[] insertionSort(int[] arr)    //Metodo de ordenamiento por insercion.
        {
            int n = arr.Length;
            for (int i = 1; i < n; ++i)
            {
                int first = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j] > first)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = first;
            }

            return arr;
        }

        public int[] selectionSort(int[] arr)    //Metodo de ordenamiento por seleccion.
        {
            int n = arr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[min])
                        min = j;
                }
                int temp = arr[min];
                arr[min] = arr[i];
                arr[i] = temp;
            }

            return arr;
        }
    }
}
