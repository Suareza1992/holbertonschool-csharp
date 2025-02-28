using System;

class Program
{
    static void Main()
    {
        // ✅ Test Case 1: Valid 2x3 * 3x2 Multiplication
        double[,] matrix1 = { { 1, 2, 3 }, { 4, 5, 6 } };
        double[,] matrix2 = { { 7, 8 }, { 9, 10 }, { 11, 12 } };
        double[,] result = MatrixMath.Multiply(matrix1, matrix2);
        PrintMatrix("Valid 2x3 * 3x2 Multiplication", result);

        // ✅ Test Case 2: Valid 3x3 * 3x1 Multiplication
        double[,] matrix3 = { { 2, 3, 4 }, { 1, 0, 1 }, { 3, 2, 1 } };
        double[,] matrix4 = { { 1 }, { 2 }, { 3 } };
        result = MatrixMath.Multiply(matrix3, matrix4);
        PrintMatrix("Valid 3x3 * 3x1 Multiplication", result);

        // ❌ Test Case 3: Invalid 2x2 * 3x2 Multiplication
        double[,] invalidMatrix1 = { { 1, 2 }, { 3, 4 } };
        double[,] invalidMatrix2 = { { 5, 6 }, { 7, 8 }, { 9, 10 } };
        result = MatrixMath.Multiply(invalidMatrix1, invalidMatrix2);
        PrintMatrix("Invalid Matrix Multiplication (Should Return [-1])", result);
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

