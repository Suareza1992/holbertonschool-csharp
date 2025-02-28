using System;

/// <summary>
/// Provides a suite of linear algebra helper methods.
/// </summary>
class VectorMath
{
    /// <summary>
    /// Multiplies a vector by a given scalar.
    /// </summary>
    /// <param name="vector">Vector to be multiplied.</param>
    /// <param name="scalar">Real number to multiply against vector.</param>
    /// <returns>The resulting vector after multiplication, or [-1] if invalid.</returns>
    public static double[] Multiply(double[] vector, double scalar)
    {
        if (vector.Length != 2 && vector.Length != 3)
            return new double[] { -1 }; // Invalid vector length

        double[] result = new double[vector.Length]; // New array for output

        for (int i = 0; i < vector.Length; i++)
        {
            result[i] = vector[i] * scalar; // Store the multiplied value
        }

        return result; // Return the new array instead of modifying input
    }
}
