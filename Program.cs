using System;

public class MathOperations
{
    public int Sum(int a, int b)
    {
        return a + b;
    }

    public string Sum(short a, short b)
    {
        return a.ToString() + b.ToString();
    }

    public int Max(int a, int b)
    {
        if (a > b)
        {
            return a;
        }
        return b;
    }

    public int Max(int a, int b, int c)
    {
        return this.Max(this.Max(a, b), c);
    }

    public int Max(int a, int b, int c, int d)
    {
        return this.Max(this.Max(a, b, c), d);
    }
}

class Program
{
    static void Main()
    {
        MathOperations m = new MathOperations();

        Console.WriteLine(m.Sum(12, 5));

        short x = 12;
        short y = 5;
        Console.WriteLine(m.Sum(x, y));

        Console.WriteLine(m.Max(3, 7));
        Console.WriteLine(m.Max(3, 7, 5));
        Console.WriteLine(m.Max(3, 7, 5, 9));
    }
}
