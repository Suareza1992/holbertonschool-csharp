using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Define vector v = (7, -3, -9)
        double[] v = { 7, -3, -9 };

        // Calculate the magnitude
        double magnitude = VectorMath.Magnitude(v);

        // Write the result to a text file
        string filePath = "magnitude.txt";
        File.WriteAllText(filePath, magnitude.ToString());

        // Output to console
        Console.WriteLine($"The magnitude of v is: {magnitude}");
        Console.WriteLine($"Result written to {filePath}");
    }
}

