using System.Collections.Generic;
using System;
/// <summary>
/// VectorMath class.
/// </summary>
class VectorMath
{
    /// <summary>
    /// Method that calculates and returns the length of a given vector.
    /// </summary>
    /// <param name="vector">2D or 3D vector.</param>
    /// <returns>returns the length rounded to the nearest hundredth.</returns>
    public static double Magnitude(double[] vector)
    {
        if (vector.Length < 2 || vector.Length > 3)
        {
            return -1;
        }

        double sum = 0;

        foreach (double component in vector)
        {
            sum += component * component;
        }

        return Math.Round(Math.Sqrt(sum), 2);
    }
}