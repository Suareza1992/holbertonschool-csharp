using System;

class Program
{
    static void Main()
    {
        // Test Case 1: Multiply 2D Matrix by Scalar
        double[,] matrix2D = { { 1, 2 }, { 3, 4 } };
        double scalar1 = 2;
        double[,] result = MatrixMath.MultiplyScalar(matrix2D, scalar1);
        PrintMatrix("2D Matrix * Scalar", result);

        // Test Case 2: Multiply 3D Matrix by Scalar
        double[,] matrix3D = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        double scalar2 = -1;
        result = MatrixMath.MultiplyScalar(matrix3D, scalar2);
        PrintMatrix("3D Matrix * Scalar", result);

        // Test Case 3: Invalid Matrix (1x3)
        double[,] invalidMatrix = { { 1, 2, 3 } };
        double scalar3 = 3;
        result = MatrixMath.MultiplyScalar(invalidMatrix, scalar3);
        PrintMatrix("Invalid Matrix * Scalar", result);
    }

    // Helper function to print the matrix
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

