using System;

/// <summary>
/// Provides a suite of linear algebra helper methods.
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Multiplies two matrices and returns the resulting matrix.
    /// </summary>
    /// <param name="matrix1">First matrix (m x n).</param>
    /// <param name="matrix2">Second matrix (n x p).</param>
    /// <returns>The resulting matrix (m x p), or [-1] if multiplication is not possible.</returns>
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        int rows1 = matrix1.GetLength(0);
        int cols1 = matrix1.GetLength(1);
        int rows2 = matrix2.GetLength(0);
        int cols2 = matrix2.GetLength(1);

        // Check if matrices can be multiplied (columns of matrix1 must match rows of matrix2)
        if (cols1 != rows2)
        {
            return new double[,] { { -1 } }; // Return error matrix
        }

        // Create the result matrix with dimensions (rows1 x cols2)
        double[,] result = new double[rows1, cols2];

        // Perform matrix multiplication
        for (int i = 0; i < rows1; i++) // Iterate over rows of matrix1
        {
            for (int j = 0; j < cols2; j++) // Iterate over columns of matrix2
            {
                double sum = 0;
                for (int k = 0; k < cols1; k++) // Iterate over elements to sum the products
                {
                    sum += matrix1[i, k] * matrix2[k, j];
                }
                result[i, j] = sum;
            }
        }

        return result; // Return the new matrix
    }
}
