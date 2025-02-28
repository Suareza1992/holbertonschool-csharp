using System;

class Program
{
    static void Main()
    {
        // Test case 1: Multiply a 2D vector
        double[] vector1 = { 2, 4 };
        double scalar1 = 3;
        double[] result = VectorMath.Multiply(vector1, scalar1);
        PrintResult("2D Vector * Scalar", result);

        // Test case 2: Multiply a 3D vector
        double[] vector2 = { -1, 0, 5 };
        double scalar2 = -2;
        result = VectorMath.Multiply(vector2, scalar2);
        PrintResult("3D Vector * Scalar", result);

        // Test case 3: Invalid vector (1D)
        double[] invalidVector = { 1 };
        double scalar3 = 5;
        result = VectorMath.Multiply(invalidVector, scalar3);
        PrintResult("Invalid Vector (1D)", result);
    }

    // Helper function to print the result
    static void PrintResult(string testName, double[] result)
    {
        Console.WriteLine($"{testName}: [{string.Join(", ", result)}]");
    }
}

