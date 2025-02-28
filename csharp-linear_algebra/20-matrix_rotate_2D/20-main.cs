using System;

class Program
{
    static void Main()
    {
        // ✅ Test Case 1: Rotate a 2x2 matrix by 90 degrees (π/2 radians)
        double[,] matrix = { { 1, 2 }, { 3, 4 } };
        double angle1 = Math.PI / 2; // 90 degrees
        double[,] result = MatrixMath.Rotate2D(matrix, angle1);
        PrintMatrix("Rotate 2D Matrix by 90°", result);

        // ✅ Test Case 2: Rotate the same matrix by 45 degrees (π/4 radians)
        double angle2 = Math.PI / 4; // 45 degrees
        result = MatrixMath.Rotate2D(matrix, angle2);
        PrintMatrix("Rotate 2D Matrix by 45°", result);

        // ❌ Test Case 3: Invalid matrix (3x3)
        double[,] invalidMatrix = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        result = MatrixMath.Rotate2D(invalidMatrix, angle1);
        PrintMatrix("Invalid Matrix Rotation (Should Return [-1])", result);
    }

    // Helper function to print matrices
    static void PrintMatrix(string testName, double[,] matrix)
    {
        Console.WriteLine($"\n{testName}:");
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}

