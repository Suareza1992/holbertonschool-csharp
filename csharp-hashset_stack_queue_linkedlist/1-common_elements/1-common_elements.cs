using System;
using System.Collections.Generic;

class List
{
    public static List<int> CommonElements(List<int> List1, List<int> List2)
    {
        var newList = new List<int>();
        foreach (int i in List1)
        {
            foreach (int j in List2)
            {
                if (i == j)
                    newList.Add(i);
            }

        }
        return newList;
    }
}