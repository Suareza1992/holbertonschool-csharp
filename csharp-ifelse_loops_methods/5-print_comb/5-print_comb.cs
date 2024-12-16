using System;

class Program
{
    static void Main(string[] args)
    {
        for (int number = 0; number < 100; number++)
        {
            if (number < 99)
            {
                System.Console.Write($"{number:D2}, ");
            }
            else
            {
                System.Console.Write($"{number:D2}\n");
            
            }
        }
        
    }
}