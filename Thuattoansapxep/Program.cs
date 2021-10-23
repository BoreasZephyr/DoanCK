using System;

namespace Thuattoansapxep
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 49, 42, 57, 86, 96, 82, 55, 6, 74, 34, 64, 7, 48, 11, 58, 21, 54, 21, 99, 81 };
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }

        }
        static void BubleSort(ref int[] a, int n)
        {
            bool swapped;
            do
            {
                swapped = false;
                n--;
                for (int i = 0; i < n; i++)
                {
                    if (a[i + 1] < a[i])
                    {
                        int t = a[i];
                        a[i] = a[i + 1];
                        a[i + 1] = t;
                        swapped = true;
                    }
                }
            }
            while (swapped);
        }
    }
}
