using System;
using System.IO;

class Program
{
    static void Main()
    {
        // ✅ Test Case 1: Shear in X-direction (factor = 2)
        double[,] matrix = { { 1, 2 }, { 3, 4 } };
        double factorX = 2;
        double[,] result = MatrixMath.Shear2D(matrix, 'x', factorX);
        PrintMatrix("Shear in X-Direction (Factor = 2)", result);

        // ✅ Test Case 2: Shear in Y-direction (factor = -1)
        double factorY = -1;
        result = MatrixMath.Shear2D(matrix, 'y', factorY);
        PrintMatrix("Shear in Y-Direction (Factor = -1)", result);

        // ❌ Test Case 3: Invalid matrix (3x3)
        double[,] invalidMatrix = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        result = MatrixMath.Shear2D(invalidMatrix, 'x', 1);
        PrintMatrix("Invalid Matrix (Should Return [-1])", result);

        // ❌ Test Case 4: Invalid direction ('z')
        result = MatrixMath.Shear2D(matrix, 'z', 1);
        PrintMatrix("Invalid Direction (Should Return [-1])", result);

        // ✅ Writing to a text file
        WriteMatrixToFile("sheared_matrix.txt", result);
        Console.WriteLine("Sheared matrix written to sheared_matrix.txt");
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

    // Helper function to write matrix to a file
    static void WriteMatrixToFile(string filePath, double[,] matrix)
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    writer.Write(matrix[i, j] + (j < matrix.GetLength(1) - 1 ? " " : ""));
                }
                writer.WriteLine();
            }
        }
    }
}

