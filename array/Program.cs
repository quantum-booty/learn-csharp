using System;
using System.Linq;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = i * i;
            }

            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }

            // an array is a reference type
            int[] b = a;
            a[0] = 42069;
            Console.WriteLine(b[0]);

            // multi-dimensional array
            int[] a1 = new int[10];
            int[,] a2 = new int[10, 5];
            int[,,] a3 = new int[10, 5, 2];

            a3[0, 0, 0] = 1;
            Console.WriteLine(a3[9, 4, 1]);

            // short hand for initialising array
            int[] c = new int[] { 1, 2, 3 };
            // or even shorter
            int[] d = { 1, 2, 3 };

            // array of array

        }
    }
}
