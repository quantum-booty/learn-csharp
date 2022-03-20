using System;

namespace FunWithMethods
{
    class Program
    {
        static int Add(int x, int y)
        {
            int ans = x + y;
            x = 10000;
            y = 88888;
            return ans;
        }

        static void AddUsingOutParam(int x, int y, out int ans)
        {
            ans = x + y;
        }

        static void SwapStrings(ref string s1, ref string s2)
        {
            string tempStr = s1;
            s1 = s2;
            s2 = tempStr;
        }

        static int AddReadOnly(in int x, in int y)
        {
            return x + y;
        }

        static double CalculateAverage(params double[] values)
        {
            Console.WriteLine($"You sent me {values.Length} doubles.");
            double sum = 0;
            if (values.Length == 0)
            {
                return sum;
            }
            for (int i = 0; i < values.Length; i++)
            {
                sum += values[i];
            }
            return sum / values.Length;
        }

        static int AddWithDefault(int x, int y = 10)
        {
            return x + y;
        }

        static void DisplayFancyMessage(ConsoleColor textColor, ConsoleColor backgroundColor, string message)
        {
            ConsoleColor oldTextColor = Console.ForegroundColor;
            ConsoleColor oldBackgroundColor = Console.BackgroundColor;
            Console.ForegroundColor = textColor;
            Console.BackgroundColor = backgroundColor;
            Console.WriteLine(message);
            Console.ForegroundColor = oldTextColor;
            Console.BackgroundColor = oldBackgroundColor;
        }

        static void Main(string[] args)
        {

            // passing by values, i.e. copied by default 
            int x = 9, y = 10;
            Console.WriteLine($"Before call: x={x}, y={y}");
            Add(x, y);
            Console.WriteLine($"After call: x={x}, y={y}");

            // out modifier
            AddUsingOutParam(x, y, out int ans);
            Console.WriteLine(ans);

            // discard out parameters
            AddUsingOutParam(x, y, out _);

            // ref modifier
            string str1 = "Flip";
            string str2 = "Flop";
            Console.WriteLine($"Before: str1={str1}, str2={str2}");
            SwapStrings(ref str1, ref str2);
            Console.WriteLine($"After: str1={str1}, str2={str2}");

            // in modifier
            // pass a variable by reference but make it read only
            // useful when you don't want to copy a large object due to memory concerns
            AddReadOnly(x, y);

            // params modifier
            // allows you to pass a variable number identically typed parameters
            CalculateAverage(4.0, 3.0, 2.0, 1.0); // can pass in numbers delimited by commas
            CalculateAverage(new double[] { 4.0, 3.2, 5.7 }); // can pass in array
            CalculateAverage(); // can pass in nothing

            // optional parameters
            AddWithDefault(9);
            AddWithDefault(9, 100);

            // named arguments
            DisplayFancyMessage(textColor: ConsoleColor.DarkRed, backgroundColor: ConsoleColor.Yellow, "Hello!");
        }
    }
}
