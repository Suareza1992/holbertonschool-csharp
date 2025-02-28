using System;

class Program
{
    static void Main()
    {
        // Test Case 1: 2D Matrices
        double[,] matrix1 = { { 1, 2 }, { 3, 4 } };
        double[,] matrix2 = { { 5, 6 }, { 7, 8 } };
        double[,] result = MatrixMath.Add(matrix1, matrix2);
        PrintMatrix("2D Matrix Addition", result);

        // Test Case 2: 3D Matrices
        double[,] matrix3D_1 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        double[,] matrix3D_2 = { { 9, 8, 7 }, { 6, 5, 4 }, { 3, 2, 1 } };
        result = MatrixMath.Add(matrix3D_1, matrix3D_2);
        PrintMatrix("3D Matrix Addition", result);

        // Test Case 3: Different Size Matrices (Invalid)
        double[,] invalidMatrix1 = { { 1, 2, 3 } };
        double[,] invalidMatrix2 = { { 4, 5, 6 } };
        result = MatrixMath.Add(invalidMatrix1, invalidMatrix2);
        PrintMatrix("Invalid Matrix Addition", result);
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

