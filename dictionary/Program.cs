using System;
using System.Collections.Generic;

namespace dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var yaya = new Dictionary<int, string>() { { 0, "a" }, { 1, "b" } };
            yaya[2] = "c";
            yaya[3] = "d";

            foreach (var item in yaya)
            {
                int key = item.Key;
                string value = item.Value;
                Console.WriteLine($"{key} {value}");
            }
        }
    }
}

