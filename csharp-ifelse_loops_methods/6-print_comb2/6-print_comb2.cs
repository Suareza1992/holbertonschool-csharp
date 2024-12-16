using System;

class Program
{
    static void Main(string[] args)
    {
        for (int first = 0; first < 10; first++)
        {
            for (int second = first + 1; second < 10; second++)
            {
                if (first != 0 || second != 1)
                {
                    Console.Write(", ");
                }
                Console.Write($"{first}{second}");
            }
        }
        Console.WriteLine();
    }
}