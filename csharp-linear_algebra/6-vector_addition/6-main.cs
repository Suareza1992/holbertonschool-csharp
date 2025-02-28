using System;

class Program
{
    static void Main()
    {
        // Test case 1: Valid 2D Vectors
        double[] vector1 = { 1, 2 };
        double[] vector2 = { 3, 4 };
        double[] result = VectorMath.Add(vector1, vector2);
        PrintResult("2D Addition", result);

        // Test case 2: Valid 3D Vectors
        double[] vector3D_1 = { 1, -2, 3 };
        double[] vector3D_2 = { -1, 2, -3 };
        result = VectorMath.Add(vector3D_1, vector3D_2);
        PrintResult("3D Addition", result);

        // Test case 3: Different Sizes (Invalid)
        double[] invalidVector1 = { 1, 2 };
        double[] invalidVector2 = { 3, 4, 5 };
        result = VectorMath.Add(invalidVector1, invalidVector2);
        PrintResult("Invalid Addition (Different Sizes)", result);

        // Test case 4: Invalid Dimension (1D)
        double[] invalidVector3 = { 5 };
        double[] invalidVector4 = { 10 };
        result = VectorMath.Add(invalidVector3, invalidVector4);
        PrintResult("Invalid Addition (1D)", result);
    }

    // Helper function to print the result
    static void PrintResult(string testName, double[] result)
    {
        Console.WriteLine($"{testName}: [{string.Join(", ", result)}]");
    }
}

