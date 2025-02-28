using System;

/// <summary>
/// Provides a suite of linear algebra helper methods.
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Multiplies a matrix by a scalar and returns the resulting matrix.
    /// </summary>
    /// <param name="matrix">The input 2D or 3D matrix.</param>
    /// <param name="scalar">The scalar multiplier.</param>
    /// <returns>The resulting matrix after multiplication, or [-1] if invalid.</returns>
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        // Validate that the matrix is either 2D (2x2) or 3D (3x3)
        if (!((rows == 2 && cols == 2) || (rows == 3 && cols == 3)))
        {
            return new double[,] { { -1 } }; // Return error matrix if invalid
        }

        // Create a new matrix to store the result
        double[,] result = new double[rows, cols];

        // Multiply each element by the scalar and store in the new matrix
        for (int y = 0; y < rows; y++)
        {
            for (int x = 0; x < cols; x++)
            {
                result[y, x] = matrix[y, x] * scalar;
            }
        }

        return result; // Return the new matrix instead of modifying the input
    }
}
