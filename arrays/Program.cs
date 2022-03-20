using System;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // array use default type values until asigned
            Console.WriteLine(default(int));
            var myArr = new int[5];
            foreach (var item in myArr)
            {
                Console.WriteLine(item);
            }

            // different ways of initializing arrays
            var arr1 = new[] { 1, 2, 3 };
            var arr2 = new int[] { 1, 2, 3 };
            int[] arr3 = { 1, 2, 3 };
            var arr4 = new int[3];
            arr4[0] = 1; arr4[1] = 2; arr4[2] = 3;

            // object arrays
            object[] arr5 = {10, false, new DateTime(1969, 3, 24), "Form & Void"};
            foreach (object item in arr5)
            {
                Console.WriteLine($"{item.GetType()} {item}");
            }

            // multidimensional arrays
            var arr6 = new int[2, 3];
            for (int i = 0; i < arr6.GetLength(0); i++)
            {
                for (int j = 0; j < arr6.GetLength(1); j++)
                {
                    arr6[i, j] = i * j;
                }
            }
            // print matrix
            for (int i = 0; i < arr6.GetLength(0); i++)
            {
                for (int j = 0; j < arr6.GetLength(1); j++)
                {
                    Console.Write($"{arr6[i, j]} ");
                }
                Console.WriteLine();
            }

            // jagged arrays (arrays of arrays)
            var jaggedArr = new int[3][];
            for (int i = 0; i < jaggedArr.Length; i++)
            {
                jaggedArr[i] = new int[i + 3];
            }
            // print jagged arrays
            for (int i = 0; i < jaggedArr.Length; i++)
            {
                for (int j = 0; j < jaggedArr[i].Length; j++)
                {
                    Console.Write($"{jaggedArr[i][j]} ");
                }
                Console.WriteLine();
            }

            // The reason we have Index and Range objects is that we could pass
            // them around as variables and parameters
            // range object
            var arr7 = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var range = new Range(0, 2);

            // range operator
            Range range1 = 0..2;
            Console.WriteLine(arr7[range1]);

            // or simply
            foreach (var item in arr7[0..2]) // range slicing is exclusive of the last index
            {
                Console.WriteLine(item);
            }

            // index object
            var idx = new Index(1, fromEnd: true);
            Console.WriteLine(arr7[idx]);

            // index object with range
            Index idx1 = 2;
            Index idx2 = 5;
            Range range2 = idx1..idx2;

            // relative to end of array
            // ^1 is the last element
            Console.WriteLine(arr7[^1]); // same as arr7[-1] in python
            // 0..^0 is the whole array
            foreach (var item in arr7[0..^0])
            {
                Console.WriteLine(item);
            }
        }
    }
}
