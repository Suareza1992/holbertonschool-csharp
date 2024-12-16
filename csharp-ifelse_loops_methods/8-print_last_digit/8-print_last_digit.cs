using System;

class Number
{
    public static int PrintLastDigit(int number)
    {
        // Calculate the last digit using the modulus operator
        int lastDigit = number % 10;

        // Convert to positive if the last digit is negative
        if (lastDigit < 0)
            lastDigit = -lastDigit;

        // Print the last digit
        Console.Write(lastDigit);

        // Return the last digit
        return lastDigit;
    }
}