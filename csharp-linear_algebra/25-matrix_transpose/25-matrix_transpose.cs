using System;

/// <summary>
/// Provides a suite of linear algebra helper methods.
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Transposes a matrix (flipping rows and columns).
    /// </summary>
    /// <param name="matrix">The input matrix.</param>
    /// <returns>The transposed matrix.</returns>
    public static double[,] Transpose(double[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        // Return an empty matrix if input is empty
        if (rows == 0 || cols == 0)
        {
            return new double[0, 0];
        }

        // Create transposed matrix with swapped dimensions
        double[,] transposed = new double[cols, rows];

        // Swap rows and columns
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                transposed[j, i] = matrix[i, j];
            }
        }

        return transposed;
    }
}
