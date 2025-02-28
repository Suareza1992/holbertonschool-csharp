using System;

class VectorMath
{
    public static double[] Add(double[] vector1, double[] vector2)
    {
        // Ensure both vectors have the same length and are either 2D or 3D
        if (vector1.Length != vector2.Length || (vector1.Length != 2 && vector1.Length != 3))
        {
            return new double[] { -1 };
        }

        double[] sum = new double[vector1.Length];

        for (int i = 0; i < vector1.Length; i++)
        {
            sum[i] = vector1[i] + vector2[i];
        }

        return sum;
    }
}