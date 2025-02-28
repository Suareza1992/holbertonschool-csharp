using System;

/// <summary>
/// Provides a suite of linear algebra helper methods.
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Adds two 2D or 3D matrices.
    /// </summary>
    /// <param name="matrix1">First matrix.</param>
    /// <param name="matrix2">Second matrix.</param>
    /// <returns>
    /// The resulting matrix after addition, or [-1] if invalid.
    /// </returns>
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        int rows1 = matrix1.GetLength(0);
        int cols1 = matrix1.GetLength(1);
        int rows2 = matrix2.GetLength(0);
        int cols2 = matrix2.GetLength(1);

        // Validate that both matrices are either 2x2 or 3x3 and match in size
        if (!((rows1 == 2 && cols1 == 2) || (rows1 == 3 && cols1 == 3)) || 
            rows1 != rows2 || cols1 != cols2)
        {
            return new double[,] { { -1 } }; // Return error matrix
        }

        // Create a new result matrix
        double[,] result = new double[rows1, cols1];

        // Perform element-wise addition
        for (int y = 0; y < rows1; y++)
        {
            for (int x = 0; x < cols1; x++)
            {
                result[y, x] = matrix1[y, x] + matrix2[y, x];
            }
        }

        return result;
    }
}
