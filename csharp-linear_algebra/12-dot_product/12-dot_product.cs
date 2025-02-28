using System;

/// <summary>
/// Provides a suite of linear algebra helper methods.
/// </summary>
class VectorMath
{
    /// <summary>
    /// Calculates the dot product of two vectors.
    /// </summary>
    /// <param name="vector1">First vector.</param>
    /// <param name="vector2">Second vector.</param>
    /// <returns>The dot product of two vectors, or -1 if invalid.</returns>
    public static double DotProduct(double[] vector1, double[] vector2)
    {
        if ((vector1.Length != 2 && vector1.Length != 3) || vector1.Length != vector2.Length)
        {
            return -1;  // Invalid input case
        }

        double sum = 0; // Stores the dot product result

        for (int i = 0; i < vector1.Length; i++)
        {
            sum += vector1[i] * vector2[i]; // Multiply corresponding elements and accumulate
        }

        return sum; // Return the dot product
    }
}
