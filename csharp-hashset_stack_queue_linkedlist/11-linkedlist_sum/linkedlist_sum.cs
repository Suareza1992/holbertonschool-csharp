using System;
using System.Collections.Generic;

class LList
{
    public static int Sum(LinkedList<int> myLList)
    {
        int index = 0;
        foreach (int i in myLList)
            index += i;
        return index;
    }
}