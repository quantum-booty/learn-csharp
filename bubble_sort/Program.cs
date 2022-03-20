using System;
using System.Collections.Generic;
using System.Linq;

namespace Yaya
{
    class Program
    {
        public static void exchange(int[] data, int m, int n)
        {
            int temp = data[m];
            data[m] = data[n];
            data[n] = temp;
        }

        public static void IntArrayBubbleSort(int[] data)
        {
            int N = data.Length;

            for (int j = N - 1; j > 0; j--)
            {
                for (int i = 0; i < j; i++)
                {
                    if (data[i] > data[i + 1])
                    {
                        exchange(data, i, i + 1);
                    }
                }
            }
        }

        public static int[] RandomIntegersArray(int min, int max, int length)
        {
            Random random = new Random();
            int[] data = new int[length];
            for (int i = 0; i < length; i++)
            {
                data[i] = random.Next(min, max);
            }
            return data;
        }

        static void Main(string[] args)
        {
            int[] data2 = RandomIntegersArray(min: 0, max: 10000, length: 10000);
            Console.WriteLine(data2.Sum());
            Console.WriteLine(data2.Max());
            IntArrayBubbleSort(data2);
            foreach (int i in data2)
            {
                Console.Write(i + " ");
            }
        }
    }
}
