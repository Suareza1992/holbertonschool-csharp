using System;
using System.Collections.Generic;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        int i = 0;
        string j = "";

        if (myList.Count == 0)
            return "None";
        foreach (KeyValuePair<string, int> x in myList)
        {
            if (x.Value >= i)
            {
                i = x.Value;
                j = x.Key;
            }
        }

        return j;
    }
}