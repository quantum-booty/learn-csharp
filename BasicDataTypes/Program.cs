using System;
using System.Collections.Generic;
using System.Numerics;

public class Program
{

    static void LocalVarDeclaration()
    {
        Console.WriteLine("=> Data Declarations:");
        int myInt = 0;

        string myString;
        myString = "This is my character data";

        bool b1 = true, b2 = false, b3 = b1;
        System.Boolean b4 = false;

        int myIntWithDefault = default;
        string myStringWithDefault = default;

        // calling a constructor without argument is the same as using the dafult keyword
        DateTime dt1 = new DateTime();
        DateTime dt2 = default;
        int myInt1 = new int();
        int myInt2 = default;
        // shortcut for this
        DateTime dt3 = new();
        int myInt3 = new();


        Console.WriteLine($"{myIntWithDefault}, {myStringWithDefault}");
        Console.WriteLine(dt1);
        Console.WriteLine(dt2);

        // int and double inherit from ValueType, exists on the stack and has built in methods
        Console.WriteLine(12.GetHashCode());
        Console.WriteLine(12.Equals(23));
        Console.WriteLine(12.ToString());
        Console.WriteLine(12.GetType());

        Console.WriteLine(int.MaxValue);
        Console.WriteLine(int.MinValue);
        Console.WriteLine(double.MaxValue);
        Console.WriteLine(double.MinValue);
        Console.WriteLine(double.Epsilon);
        Console.WriteLine(double.PositiveInfinity);
        Console.WriteLine(double.NegativeInfinity);

        // string parse
        Console.WriteLine(double.Parse("12"));
        double.TryParse("your mom gay", out double your_mom);
        Console.WriteLine(your_mom);

        // DateTime object
        var dt4 = new DateTime(2015, 10, 17);
        Console.WriteLine(dt4.Date);
        Console.WriteLine(dt4.DayOfWeek);
        Console.WriteLine(dt4.AddMonths(2));
        dt4.IsDaylightSavingTime();
        // timespan is akin to timedelta in python
        var ts = new TimeSpan(hours: 4, minutes: 30, seconds: 0); // can name the variables
        Console.WriteLine(ts);
        Console.WriteLine(dt4 - ts);
        Console.WriteLine(ts - new TimeSpan(0, 15, 0));

        Console.WriteLine("test".Equals("Test", StringComparison.CurrentCultureIgnoreCase));
        try
        {
            checked
            {
                short numb1 = 3000, numb2 = 30000;
                short answer = (short)Program.Add(numb1, numb2);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }
    static public int Add(int numb1, int numb2)
    {
        return numb1 + numb2;
    }

    static void IfElsePatternMatching()
    {
        Console.WriteLine("================ C# 9 If Else Pattern Matching Improvements ===============/n");
        object testItem1 = 123;
        Type t = typeof(string);
        char c = 'f';

        //Type patterns
        if (t is Type)
        {
            Console.WriteLine($"{t} is a Type");
        }
        //Relational, Conjuctive, and Disjunctive patterns
        if (c is >= 'a' and <= 'z' or >= 'A' and <= 'Z')
        {
            Console.WriteLine($"{c} is a character");
        };
        //Parenthesized patterns
        if (c is (>= 'a' and <= 'z') or (>= 'A' and <= 'Z') or '.' or ',')
        {
            Console.WriteLine($"{c} is a character or separator");
        };
        //Negative patterns
        if (testItem1 is not string)
        {
            Console.WriteLine($"{testItem1} is not a string");
        }
        if (testItem1 is not null)
        {
            Console.WriteLine($"{testItem1} is not null");
        }
        Console.WriteLine();
    }
    public static void SwitchExample()
    {
        string choice = Console.ReadLine();
        int i = int.TryParse(choice, out i) ? i : -1;
        Console.WriteLine(i);
        switch (i)
        {
            case 0:
                Console.WriteLine("i is 0");
                break;
            case 1:
                Console.WriteLine("i is 1");
                break;
            case 2:
                Console.WriteLine("i is 2");
                break;
            default:
                Console.WriteLine("i is not 0, 1, or 2");
                break;
        }
        Console.WriteLine();
    }

    public static void EnumSwitch()
    {
        DayOfWeek favday;
        try
        {
            // favday = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), Console.ReadLine());
            favday = Enum.Parse<DayOfWeek>(Console.ReadLine());
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            return;
        }
        switch (favday)
        {
            case DayOfWeek.Monday:
                Console.WriteLine("Monday");
                break;
            case DayOfWeek.Tuesday:
                Console.WriteLine("Tuesday");
                break;
            case DayOfWeek.Wednesday:
                Console.WriteLine("Wednesday");
                break;
            case DayOfWeek.Thursday:
                Console.WriteLine("Thursday");
                break;
            case DayOfWeek.Friday:
                Console.WriteLine("Friday");
                break;
            case DayOfWeek.Saturday:
            case DayOfWeek.Sunday:
                Console.WriteLine("It's the weekend!!");
                break;
            default:
                Console.WriteLine("Not a valid day of the week");
                break;
        }
    }
    public static void TypeSwitch()
    {
        object obj = 2;
        switch (obj)
        {
            case string s:
                Console.WriteLine($"{s} is a string");
                break;
            case int i:
                Console.WriteLine($"{i} is an int");
                break;
            case bool b:
                Console.WriteLine($"{b} is a bool");
                break;
            case null:
                Console.WriteLine($"{obj} is null");
                break;
            default:
                Console.WriteLine($"{obj} is unknown");
                break;
        }
    }

    public static void ExecutePatternMatchingSwitchWithWhen()
    {
        object langChoice = Console.ReadLine();
        var choice = int.TryParse(langChoice.ToString(), out int c) ? c : langChoice;
        switch (choice)
        {
            case int i when i == 2:
            case string s when s.Equals("C#", StringComparison.OrdinalIgnoreCase):
                Console.WriteLine("C#");
                break;
            case int i when i == 1:
            case string s when s.Equals("Python", StringComparison.OrdinalIgnoreCase):
                Console.WriteLine("Python");
                break;
            default:
                Console.WriteLine("Unknown");
                break;
        }
    }

    public static string ColorStringToHexClassic(string colorBand)
    {
        switch (colorBand)
        {
            case "Red":
                return "#FF0000";
            case "Orange":
                return "#FFA500";
            case "Yellow":
                return "#FFFF00";
            case "Green":
                return "#008000";
            case "Blue":
                return "#0000FF";
            case "Indigo":
                return "#4B0082";
            case "Violet":
                return "#EE82EE";
            default:
                return "Invalid color band";
        }
    }

    public static (string foo, string bar) ColorStringToHex(string colorBand)
    {
        return (colorBand, colorBand switch
        {
            "Red" => "#FF0000",
            "Orange" => "#FFA500",
            "Yellow" => "#FFFF00",
            "Green" => "#008000",
            "Blue" => "#0000FF",
            "Indigo" => "#4B0082",
            "Violet" => "#EE82EE",
            _ => "Invalid color band"
        });
    }

    public static string RockPaperScissors(string first, string second)
    {
        return (first, second) switch
        {
            ("Rock", "Paper") => "Paper covers Rock",
            ("Rock", "Scissors") => "Rock crushes Scissors",
            ("Paper", "Rock") => "Paper covers Rock",
            ("Paper", "Scissors") => "Scissors cuts Paper",
            ("Scissors", "Rock") => "Rock crushes Scissors",
            ("Scissors", "Paper") => "Scissors cuts Paper",
            _ => "Invalid input"
        };
    }


    static void Main(string[] args)
    {
        // LocalVarDeclaration();
        // IfElsePatternMatching();
        // SwitchExample();
        // EnumSwitch();
        // TypeSwitch();
        // ExecutePatternMatchingSwitchWithWhen();
        // Console.WriteLine(ColorStringToHexClassic("Red"));
        // var result = ColorStringToHex("Red");
        // Console.WriteLine(result);
        // Console.WriteLine(result.foo);
        // Console.WriteLine(result.bar);
        // Console.WriteLine(RockPaperScissors("Rock", "Paper"));
    }
}


