using System;
using System.Collections.Generic;

class LList
{
    public static LinkedList<int> CreatePrint(int size)
    {
        if (size < 0)
        {
            LinkedList<int> listEmpty = new LinkedList<int>();
            return listEmpty;
        }

        List<int> nLList = new List<int>();
        for (int i = 0; i < size; i++)
        {
            nLList.Add(i);
            Console.WriteLine(i);
        }

        LinkedList<int> nLList1 = new LinkedList<int>(nLList);
        return nLList1;
    }
}