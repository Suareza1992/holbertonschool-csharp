using System;

/// <summary>
/// Provides a suite of linear algebra helper methods.
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Rotates a square 2D matrix by a given angle (in radians).
    /// </summary>
    /// <param name="matrix">The input 2x2 matrix.</param>
    /// <param name="angle">The rotation angle in radians.</param>
    /// <returns>The rotated matrix, or [-1] if invalid.</returns>
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        // Ensure the matrix is exactly 2x2
        if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
        {
            return new double[,] { { -1 } };
        }

        // Rotation matrix components
        double cosTheta = Math.Cos(angle);
        double sinTheta = Math.Sin(angle);

        // Extract values from input matrix
        double x1 = matrix[0, 0];
        double y1 = matrix[0, 1];
        double x2 = matrix[1, 0];
        double y2 = matrix[1, 1];

        // Apply rotation transformation
        double[,] result = new double[2, 2];
        result[0, 0] = Math.Round(x1 * cosTheta - y1 * sinTheta, 2);
        result[0, 1] = Math.Round(x1 * sinTheta + y1 * cosTheta, 2);
        result[1, 0] = Math.Round(x2 * cosTheta - y2 * sinTheta, 2);
        result[1, 1] = Math.Round(x2 * sinTheta + y2 * cosTheta, 2);

        return result;
    }
}
