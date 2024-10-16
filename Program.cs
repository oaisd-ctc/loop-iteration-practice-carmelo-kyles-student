using System;
using System.Formats.Asn1;

public static class program
{
    public static void Main(string[] args)
    {
        Write1ThroughN_While(-1);
        Write1ThroughN_While(5);
        Write1ThroughN_While(0);

        Write1ThroughN_For(-1);
        Write1ThroughN_For(5);
        Write1ThroughN_For(0);

        WriteNThrough1_While(-1);
        WriteNThrough1_While(5);
        WriteNThrough1_While(0);

        WriteNThrough1_For(-1);
        WriteNThrough1_For(5);
        WriteNThrough1_For(0);

        WriteEvensThrough100();

        FindSum(5);
        FindSum(1);
        FindSum(-3);
        FindSum(100);

        FindSumOfEvenNumbers(10);
        FindSumOfEvenNumbers(-5);
        FindSumOfEvenNumbers(2);
        FindSumOfEvenNumbers(0);
        FindSumOfEvenNumbers(1);
        FindSumOfEvenNumbers(25);
        FindSumOfEvenNumbers(-25);

        FindSumOfOddNumbers(10);
        FindSumOfOddNumbers(-5);
        FindSumOfOddNumbers(1);
        FindSumOfOddNumbers(2);
        FindSumOfOddNumbers(25);
        FindSumOfOddNumbers(-25);

        OutputRightTriangle(4);
        OutputRightTriangle(6);
        OutputRightTriangle(-4);
        OutputRightTriangle(-6);
        OutputRightTriangle(0);


    }

    public static void Write1ThroughN_While(int n)
    {
        Console.WriteLine("Write1ThroughN_While");
        if ((n >= 0))
        {
            OutOfRangeMessage(n);
        }
        int i = 1;
        while (i < n)
        {
            Console.WriteLine(i);
            i++;

        }
    }
    public static void Write1ThroughN_For(int n)
    {
        if ((n >= 0))
        {
            OutOfRangeMessage(n);
        }
        Console.WriteLine("Write1ThroughN_For");

        for (int i = 1; i < n; i++)
        {
            Console.WriteLine(i);
        }
    }
    public static void WriteNThrough1_While(int n)
    {
        if ((n >= 0))
        {
            OutOfRangeMessage(n);
        }
        Console.WriteLine("WriteNThrough1_While");

        int i = n;
        while (i > 0)
        {
            Console.WriteLine(i);
            i--;

        }
    }
    public static void WriteNThrough1_For(int n)
    {
        if ((n >= 0))
        {
            OutOfRangeMessage(n);
        }
        Console.WriteLine("WriteNThrough1_For");
        for (int i = n; i > 0; i--)
        {
            Console.WriteLine(i);
        }
    }
    public static void WriteEvensThrough100()
    {
        for (int i = 0; i < 102; i = i + 2)
        {
            Console.WriteLine(i);
        }
    }
    public static void FindSum(int n)
    {
        int sum = 0;
        if (n == 0)
        {
            sum = 0;
            Console.WriteLine("0");
        }
        else if (n > 1)
        {
            // Sum from 1 to n
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }

        }
        else if (n <= 1)
        {
            // Sum from n to 1
            for (int i = n; i <= 1; i++)
            {
                sum += i;
            }
        }
        Console.WriteLine(sum);

    }
    public static void FindSumOfEvenNumbers(int n)
    {
        int sum = 0;
        if (n == 0)
        {
            sum = 0;
            Console.WriteLine("0");
        }
        else if (n > 1)
        {
            // Sum from 1 to n
            for (int i = 0; i <= n; i = i + 2)
            {
                sum += i;
            }

        }
        else if (n <= 1)
        {
            // Sum from n to 1
            for (int i = n; i <= 0; i = i + 2)
            {
                sum += i;
            }
        }
        Console.WriteLine(sum);
    }
    public static void FindSumOfOddNumbers(int n)
    {
        int sum = 0;
        if (n == 0)
        {
            sum = 0;
            Console.WriteLine("0");
        }
        else if (n > 1)
        {
            // Sum from 1 to n
            for (int i = 1; i <= n; i++)
            {
                if ((i % 2) != 0)
                {

                    sum += i;
                }
            }

        }
        else if (n <= 1)
        {
            // Sum from n to 1
            for (int i = n; i <= 1; i++)
            {
                if ((i % 2) != 0)
                {

                    sum += i;
                }
            }
        }
        Console.WriteLine(sum);
    }
    public static void OutputRightTriangle(int n)
    {
        if ((n == 0))
        {
            OutOfRangeMessage(n);
        }

        else if (n > 0)
        {
            // Print triangle from 1 to n
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine(); // Blank line between triangles

            // Print triangle from n to 1
            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }

    public static void OutOfRangeMessage(int n)
    {

        Console.WriteLine(n + " is out of range");
    }











}