using System;
using System.Collections.Generic;

class List // Class name remains the same for compliance but should be unique to avoid conflicts.
{
    // Renamed the method to match the required prototype
    public static List<int> DifferentElements(List<int> list1, List<int> list2)
    {
        var newList = new List<int>(); // Ensures newList is properly initialized

        // Add elements from list1 that are not in list2
        foreach (int i in list1)
        {
            if (!list2.Contains(i) && !newList.Contains(i)) // Corrected `List2` to `list2`
            {
                newList.Add(i);
            }
        }

        // Add elements from list2 that are not in list1
        foreach (int j in list2)
        {
            if (!list1.Contains(j) && !newList.Contains(j)) // Corrected `List1` to `list1`
            {
                newList.Add(j);
            }
        }

        // Sort the resulting list
        newList.Sort();

        return newList;
    }
}