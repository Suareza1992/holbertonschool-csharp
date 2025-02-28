using System;
using System.IO;

class Program
{
    static void Main()
    {
        // ✅ Test Case 1: Transpose a 2x3 matrix
        double[,] matrix1 = { { 1, 2, 3 }, { 4, 5, 6 } };
        double[,] result = MatrixMath.Transpose(matrix1);
        PrintMatrix("Transpose of 2x3 Matrix", result);

        // ✅ Test Case 2: Transpose a 3x2 matrix
        double[,] matrix2 = { { 1, 4 }, { 2, 5 }, { 3, 6 } };
        result = MatrixMath.Transpose(matrix2);
        PrintMatrix("Transpose of 3x2 Matrix", result);

        // ✅ Test Case 3: Transpose a square 3x3 matrix
        double[,] matrix3 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        result = MatrixMath.Transpose(matrix3);
        PrintMatrix("Transpose of 3x3 Matrix", result);

        // ❌ Test Case 4: Empty matrix
        double[,] emptyMatrix = new double[0, 0];
        result = MatrixMath.Transpose(emptyMatrix);
        PrintMatrix("Transpose of an Empty Matrix", result);

        // ✅ Writing to a text file
        WriteMatrixToFile("transposed_matrix.txt", result);
        Console.WriteLine("Transposed matrix written to transposed_matrix.txt");
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

