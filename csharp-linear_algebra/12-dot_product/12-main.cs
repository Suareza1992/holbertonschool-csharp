using System;

class Program
{
    static void Main()
    {
        // Test case 1: Valid 2D dot product
        double[] vector1 = { 1, 2 };
        double[] vector2 = { 3, 4 };
        double result = VectorMath.DotProduct(vector1, vector2);
        PrintResult("2D Dot Product", result);

        // Test case 2: Valid 3D dot product
        double[] vector3D_1 = { 1, -2, 3 };
        double[] vector3D_2 = { 4, 0, -1 };
        result = VectorMath.DotProduct(vector3D_1, vector3D_2);
        PrintResult("3D Dot Product", result);

        // Test case 3: Different sizes (Invalid)
        double[] invalidVector1 = { 1, 2 };
        double[] invalidVector2 = { 3, 4, 5 };
        result = VectorMath.DotProduct(invalidVector1, invalidVector2);
        PrintResult("Invalid Dot Product (Different Sizes)", result);

        // Test case 4: Invalid Dimension (1D)
        double[] invalidVector3 = { 5 };
        double[] invalidVector4 = { 10 };
        result = VectorMath.DotProduct(invalidVector3, invalidVector4);
        PrintResult("Invalid Dot Product (1D)", result);
    }

    // Helper function to print results
    static void PrintResult(string testName, double result)
    {
        Console.WriteLine($"{testName}: {result}");
    }
}
