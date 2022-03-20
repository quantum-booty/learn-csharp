using System;

Point myPoint;
myPoint.X = 349;
myPoint.Y = 76;
myPoint.Increment();
myPoint.Decrement();
myPoint.Display();

// alternative syntax -> calling the constructor
Point myPoint1 = new Point(); // uses default constructor, the default values of int is 0
Point myPoint2 = new Point(349, 76); // call the custom constructor

myPoint1.Display();
myPoint2.Display();

ReadOnlyPoint myReadOnlyPoint = new ReadOnlyPoint(349, 76);
myReadOnlyPoint.Display();

struct Point
{
    // Fields of the structure.
    public int X;
    public int Y;

    // A custom constructor.
    public Point(int XPos, int YPos)
    {
        X = XPos;
        Y = YPos;
    }

    public void Increment()
    { X++; Y++; }

    public void Decrement()
    { X--; Y--; }

    public void Display()
    {
        Console.WriteLine("X = {0}, Y = {1}", X, Y);
    }
}


// can make a struct readonly
readonly struct ReadOnlyPoint
{
    // Fields of the structure.
    public readonly int X; // can make a member readonly
    public readonly int Y;

    // A custom constructor.
    public ReadOnlyPoint(int XPos, int YPos)
    {
        X = XPos;
        Y = YPos;
    }

    public void Display()
    {
        Console.WriteLine("X = {0}, Y = {1}", X, Y);
    }
}


