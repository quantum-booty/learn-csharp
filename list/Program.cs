using System;
using System.Collections.Generic;

namespace list
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var mylist = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine(mylist);
            Console.WriteLine(mylist.BinarySearch(3));
            Console.WriteLine(mylist.Capacity); // the capacity increases by 2^n
            // mylist.Contains
            // Console.WriteLine();
            mylist.ForEach(Console.WriteLine);
        }
    }
}
