using System;

/// <summary>
/// Provides a suite of linear algebra helper methods.
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Applies a shear transformation to a 2x2 matrix in either the X or Y direction.
    /// </summary>
    /// <param name="matrix">The input 2x2 matrix.</param>
    /// <param name="direction">'x' for X shear, 'y' for Y shear.</param>
    /// <param name="factor">The shear factor.</param>
    /// <returns>The sheared matrix, or [-1] if invalid.</returns>
    public static double[,] Shear2D(double[,] matrix, char direction, double factor)
    {
        // Ensure the matrix is exactly 2x2
        if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
        {
            return new double[,] { { -1 } };
        }

        // Define shear transformation matrix
        double[,] shearMatrix;
        if (direction == 'x')
        {
            shearMatrix = new double[,] { { 1, factor }, { 0, 1 } };
        }
        else if (direction == 'y')
        {
            shearMatrix = new double[,] { { 1, 0 }, { factor, 1 } };
        }
        else
        {
            return new double[,] { { -1 } }; // Invalid direction
        }

        // Create the result matrix
        double[,] result = new double[2, 2];

        // Perform matrix multiplication (M * S)
        for (int i = 0; i < 2; i++)  // Rows
        {
            for (int j = 0; j < 2; j++)  // Columns
            {
                result[i, j] = matrix[i, 0] * shearMatrix[0, j] + matrix[i, 1] * shearMatrix[1, j];
            }
        }

        return result;
    }
}
