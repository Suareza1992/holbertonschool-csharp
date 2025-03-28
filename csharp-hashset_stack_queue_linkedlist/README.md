C# - Data Structures: HashSet, Stack, Queue, LinkedList

Learning Objectives
At the end of this project, you are expected to be able to explain to anyone, without the help of Google:

General
How to create and use arrays
What are Collections in C#?
How to create and use hashsets
How to create and use stacks
How to create and use queues
How to create and use linked lists
How to use foreach
Requirements
C# Tasks
Allowed editors: Visual Studio Code
All files will be compiled on Ubuntu 20.04 LTS using dotnet
A README.md file, at the root of the folder of the project, is mandatory
All default C# files named Program.cs should be renamed to the name given in each task
You do not need to know about namespaces yet. Namespaces should be omitted in this project
Each C# task requires its own folder and .csproj file. Push all task folders to your GitHub and ensure the task names on the folders are correct
You do not need to push your obj/ or bin/ folders
In the following examples, the main.cs files are shown as examples. You can use them to test your functions, but you don’t have to push them to your repo (if you do we won’t take them into account). We will use our own main.cs files at compilation. Our main.cs files might be different from the one shown in the examples
Tasks

0. Unique addition
mandatory
Write a method that adds all unique integers in a list.

Class Name: List
Prototype: public static int Sum(List<int> myList)
Returns the sum of unique integers in given list
carrie@ubuntu:~//0-unique_add$ cat 0-main.cs 
using System;
using System.Collections.Generic;

class Program
{
    // Main - entry point
    static void Main(string[] args)
    {
        List<int> myList1 = new List<int>() {1, 1, 2, 3, 4, 5, 6, 6, 7, 7, 8};
        List<int> myList2 = new List<int>() {98, 98, -14, 972, 0, -42, -972};

        Console.WriteLine(List.Sum(myList1));
        Console.WriteLine(List.Sum(myList2));
    }
}
carrie@ubuntu:~//0-unique_add$ 
carrie@ubuntu:~//0-unique_add$ ls
0-main.cs  0-unique_add.cs  0-unique_add.csproj  bin  obj
carrie@ubuntu:~//0-unique_add$ dotnet run
36
42
carrie@ubuntu:~//0-unique_add$ 
Repo:

GitHub repository: holbertonschool-csharp
Directory: csharp-hashset_stack_queue_linkedlist
File: 0-unique_add/, 0-unique_add/0-unique_add.csproj, 0-unique_add/0-unique_add.cs

1. Present in both
mandatory
Write a method that returns a sorted list of common elements in two lists.

Class Name: List
Prototype: public static List<int> CommonElements(List<int> list1, List<int> list2)
Returns a new sorted list of common elements in two given lists
You cannot use LINQ
You cannot use SortedList
carrie@ubuntu:~//1-common_elements$ cat 1-main.cs 
using System;
using System.Collections.Generic;

class Program
{
    // Main - entry point
    static void Main(string[] args)
    {
        List<int> myList1 = new List<int>() {1, 2, 3, 4, 5, 6};
        List<int> myList2 = new List<int>() {0, 2, 4, 6, 7, 8};
        List<int> newList = new List<int>();

        newList = List.CommonElements(myList1, myList2);

        foreach (int i in newList)
            Console.WriteLine(i);
    }
}
carrie@ubuntu:~//1-common_elements$ 
carrie@ubuntu:~//1-common_elements$ ls
1-common_elements.cs  1-common_elements.csproj  1-main.cs  bin  obj
carrie@ubuntu:~//1-common_elements$ dotnet run
2
4
6
carrie@ubuntu:~//1-common_elements$ 
Repo:

GitHub repository: holbertonschool-csharp
Directory: csharp-hashset_stack_queue_linkedlist
File: 1-common_elements/, 1-common_elements/1-common_elements.csproj, 1-common_elements/1-common_elements.cs
 
0/9 pts
2. Only differents
mandatory
Write a method that returns a sorted list of all elements present in one or the other list but not both.

Class Name: List
Prototype: public static List<int> DifferentElements(List<int> list1, List<int> list2)
Returns a new sorted list of all elements present in one or the other list but not both of the given lists
You cannot use LINQ
You cannot use SortedList
carrie@ubuntu:~//2-different_elements$ cat 2-main.cs 
using System;
using System.Collections.Generic;

class Program
{
    // Main - entry point
    static void Main(string[] args)
    {
        List<int> myList1 = new List<int>() {1, 2, 3, 4, 5, 6};
        List<int> myList2 = new List<int>() {0, 2, 4, 6, 7, 8};
        List<int> different;

        different = List.DifferentElements(myList1, myList2);

        foreach (int i in different)
            Console.WriteLine(i);
    }
}
carrie@ubuntu:~//2-different_elements$ 
carrie@ubuntu:~//2-different_elements$ ls
2-different_elements.cs  2-different_elements.csproj  2-main.cs  bin  obj
carrie@ubuntu:~//2-different_elements$ dotnet run
0
1
3
5
7
8
carrie@ubuntu:~//2-different_elements$ 
Repo:

GitHub repository: holbertonschool-csharp
Directory: csharp-hashset_stack_queue_linkedlist
File: 2-different_elements/, 2-different_elements/2-different_elements.csproj, 2-different_elements/2-different_elements.cs
 
0/9 pts
3. Full stack
mandatory
Given a Stack<string>, write a method that does the following:

Class: MyStack
Prototype: public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
Print the number of items in aStack
Format: Number of items: <number>
Print the item at the top of aStack without removing it
Format: Top item: <item>
If aStack is empty, print Stack is empty
Print if aStack contains a given item search
Format: Stack contains <search>: <True / False>
If aStack contains the given item search, remove all items up to and including search; otherwise, leave aStack as is
You can use .Pop() only once
Add a new given item newItem to aStack
Return aStack
carrie@ubuntu:~//3-stack_push_pop$ cat 3-main.cs
using System;
using System.Collections.Generic;

class Program
{
    // Main - entry point
    static void Main(string[] args)
    {
        Stack<string> aStack = new Stack<string>();

        aStack.Push("C");
        aStack.Push("HTML");
        aStack.Push("Javascript");
        aStack.Push("Python");
        aStack.Push("React");
        aStack.Push("Ruby");

        foreach (string item in aStack)
            Console.WriteLine(item);

        Console.WriteLine("------");

        MyStack.Info(aStack, "C#", "Javascript");

        Console.WriteLine("------");

        foreach (string item in aStack)
            Console.WriteLine(item);
    }
}
carrie@ubuntu:~//3-stack_push_pop$ 
carrie@ubuntu:~//3-stack_push_pop$ ls
3-main.cs  3-stack_push_pop.cs  3-stack_push_pop.csproj  bin  obj
carrie@ubuntu:~//3-stack_push_pop$ dotnet run
Ruby
React
Python
Javascript
HTML
C
------
Number of items: 6
Top item: Ruby
Stack contains "Javascript": True
------
C#
HTML
C
carrie@ubuntu:~//3-stack_push_pop$ 
Repo:

GitHub repository: holbertonschool-csharp
Directory: csharp-hashset_stack_queue_linkedlist
File: 3-stack_push_pop/, 3-stack_push_pop/3-stack_push_pop.csproj, 3-stack_push_pop/3-stack_push_pop.cs
 
0/6 pts
4. Queue it up
mandatory
Given a Queue<string>, write a method that does the following:

Class: MyQueue
Prototype: public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
Print the number of items in aQueue
Format: Number of items: <number>
Print the item at the top of aQueue without removing it
Format: First item: <item>
If aQueue is empty, print Queue is empty
Add a new given item newItem to aQueue
Print if aQueue contains a given item search
Format: Queue contains <search>: <True / False>
If aQueue contains the given item search, remove all items up to and including search; otherwise, leave aQueue as is
You can use .Dequeue() only once
Return aQueue
carrie@ubuntu:~//4-queue_enqueue_dequeue$ cat 4-main.cs
using System;
using System.Collections.Generic;

class Program
{
    // Main - entry point
    static void Main(string[] args)
    {
        Queue<string> aQueue = new Queue<string>();

        aQueue.Enqueue("C");
        aQueue.Enqueue("HTML");
        aQueue.Enqueue("Javascript");
        aQueue.Enqueue("Python");
        aQueue.Enqueue("React");
        aQueue.Enqueue("Ruby");

        foreach (string item in aQueue)
            Console.WriteLine(item);

        Console.WriteLine("------");

        MyQueue.Info(aQueue, "C#", "Javascript");

        Console.WriteLine("------");

        foreach (string item in aQueue)
            Console.WriteLine(item);
    }
}
carrie@ubuntu:~//4-queue_enqueue_dequeue$
carrie@ubuntu:~//4-queue_enqueue_dequeue$ ls
4-main.cs  4-queue_enqueue_dequeue.cs  4-queue_enqueue_dequeue.csproj  bin  obj
carrie@ubuntu:~//4-queue_enqueue_dequeue$ dotnet run
C
HTML
Javascript
Python
React
Ruby
------
Number of items: 6
First item: C
Queue contains "Javascript": True
------
Python
React
Ruby
C#
carrie@ubuntu:~//4-queue_enqueue_dequeue$ 
Repo:

GitHub repository: holbertonschool-csharp
Directory: csharp-hashset_stack_queue_linkedlist
File: 4-queue_enqueue_dequeue, 4-queue_enqueue_dequeue/4-queue_enqueue_dequeue.csproj, 4-queue_enqueue_dequeue/4-queue_enqueue_dequeue.cs
 
0/6 pts
5. Print a LinkedList
mandatory
Write a method that creates and prints a LinkedList of integers of a given size.

Class Name: LList
Prototype: public static LinkedList<int> CreatePrint(int size)
Returns the newly created list
If size is negative, return an empty list
carrie@ubuntu:~//5-print_linkedlist$ cat 5-main.cs 
using System;
using System.Collections.Generic;

class Program
{
    // Main - entry point
    static void Main(string[] args)
    {
        LinkedList<int> llist;
        int size;

        size = 8;

        llist = LList.CreatePrint(size);
        Console.WriteLine("-------------");
        Console.WriteLine("Linked List Length: " + llist.Count);
    }
}
carrie@ubuntu:~//5-print_linkedlist$ 
carrie@ubuntu:~//5-print_linkedlist$ ls
5-main.cs  5-print_linkedlist.cs  5-print_linkedlist.csproj  bin  obj
carrie@ubuntu:~//5-print_linkedlist$ dotnet run
0
1
2
3
4
5
6
7
-------------
Linked List Length: 8
carrie@ubuntu:~//5-print_linkedlist$ 
Repo:

GitHub repository: holbertonschool-csharp
Directory: csharp-hashset_stack_queue_linkedlist
File: 5-print_linkedlist/, 5-print_linkedlist/5-print_linkedlist.csproj, 5-print_linkedlist/5-print_linkedlist.cs
 
0/8 pts
6. LinkedList length
mandatory
Write a method that returns the number of elements in a LinkedList.

Class Name: LList
Prototype: public static int Length(LinkedList<int> myLList)
Returns the number of elements in a given LinkedList
You are not allowed to use .Count()
carrie@ubuntu:~//6-linkedlist_length$ cat 6-main.cs 
using System;
using System.Collections.Generic;
class Program
{
    // Main - entry point
    static void Main(string[] args)
    {
        LinkedList<int> myLList = new LinkedList<int>();

        myLList.AddLast(972);
        myLList.AddLast(0);
        myLList.AddLast(8);
        myLList.AddLast(98);
        myLList.AddLast(-4);
        myLList.AddLast(8);

        Console.WriteLine(LList.Length(myLList));
    }
}
carrie@ubuntu:~//6-linkedlist_length$
carrie@ubuntu:~//6-linkedlist_length$ ls
6-linkedlist_length.cs  6-linkedlist_length.csproj  6-main.cs  bin  obj
carrie@ubuntu:~//6-linkedlist_length$ dotnet run
6
carrie@ubuntu:~//6-linkedlist_length$ 
Repo:

GitHub repository: holbertonschool-csharp
Directory: csharp-hashset_stack_queue_linkedlist
File: 6-linkedlist_length/, 6-linkedlist_length/6-linkedlist_length.csproj, 6-linkedlist_length/6-linkedlist_length.cs
 
0/6 pts
7. Add node to the beginning
mandatory
Write a method that adds a node to the beginning of a LinkedList.

Class Name: LList
Prototype: public static LinkedListNode<int> Add(LinkedList<int> myLList, int n)
Returns the newly added node
carrie@ubuntu:~//7-linkedlist_add$ cat 7-main.cs 
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        LinkedList<int> myLList = new LinkedList<int>();

        myLList.AddLast(1);
        myLList.AddLast(2);
        myLList.AddLast(3);
        myLList.AddLast(4);
        myLList.AddLast(5);

        foreach (int i in myLList)
            Console.Write(i + " ");
        Console.WriteLine();

        LList.Add(myLList, 0);

        foreach (int i in myLList)
            Console.Write(i + " ");
        Console.WriteLine();
    }
}
carrie@ubuntu:~//7-linkedlist_add$ 
carrie@ubuntu:~//7-linkedlist_add$ ls
7-linkedlist_add.cs  7-linkedlist_add.csproj  7-main.cs  bin  obj
carrie@ubuntu:~//7-linkedlist_add$ dotnet run
1 2 3 4 5 
0 1 2 3 4 5 
carrie@ubuntu:~//7-linkedlist_add$ 
Repo:

GitHub repository: holbertonschool-csharp
Directory: csharp-hashset_stack_queue_linkedlist
File: 7-linkedlist_add/, 7-linkedlist_add/7-linkedlist_add.csproj, 7-linkedlist_add/7-linkedlist_add.cs
 
0/8 pts
8. Find value
mandatory
Write a method that finds a value in a LinkedList and returns its index position in the list.

Class Name: LList
Prototype: public static int FindNode(LinkedList<int> myLList, int value)
Returns the index position of the first occurrence of the value given or -1 if the value is not in the list
You are not allowed to use .Find() or FindLast()
carrie@ubuntu:~//8-linkedlist_find$ cat 8-main.cs 
using System;
using System.Collections.Generic;

class Program
{
    // Main - entry point
    static void Main(string[] args)
    {
        LinkedList<int> myLList = new LinkedList<int>();

        myLList.AddLast(1);
        myLList.AddLast(4);
        myLList.AddLast(9);
        myLList.AddLast(16);
        myLList.AddLast(25);
        myLList.AddLast(36);
        myLList.AddLast(49);

        Console.WriteLine("Node Position: " + LList.FindNode(myLList, 16));
        Console.WriteLine("Node Position: " + LList.FindNode(myLList, 1));
        Console.WriteLine("Node Position: " + LList.FindNode(myLList, -10));
    }
}
carrie@ubuntu:~//8-linkedlist_find$ 
carrie@ubuntu:~//8-linkedlist_find$ ls
8-linkedlist_find.cs  8-linkedlist_find.csproj  8-main.cs  bin  obj
carrie@ubuntu:~//8-linkedlist_find$ dotnet run
Node Position: 3
Node Position: 0
Node Position: -1
carrie@ubuntu:~//8-linkedlist_find$ 
Repo:

GitHub repository: holbertonschool-csharp
Directory: csharp-hashset_stack_queue_linkedlist
File: 8-linkedlist_find/, 8-linkedlist_find/8-linkedlist_find.csproj, 8-linkedlist_find/8-linkedlist_find.cs
 
0/9 pts
9. Pop
mandatory
Write a method that deletes the head node of a LinkedList and returns that node’s data.

Class Name: LList
Prototype: public static int Pop(LinkedList<int> myLList)
Returns the value of the head node
If the list is empty, return 0
carrie@ubuntu:~//9-linkedlist_pop$ cat 9-main.cs 
using System;
using System.Collections.Generic;

class Program
{
    // Main - entry point
    static void Main(string[] args)
    {
        LinkedList<int> myLList = new LinkedList<int>();

        myLList.AddLast(11);
        myLList.AddLast(3);
        myLList.AddLast(-9);
        myLList.AddLast(47);
        myLList.AddLast(0);
        myLList.AddLast(-9);

        Console.WriteLine(LList.Pop(myLList));
    }
}
carrie@ubuntu:~//9-linkedlist_pop$ 
carrie@ubuntu:~//9-linkedlist_pop$ ls
9-linkedlist_pop.cs  9-linkedlist_pop.csproj  9-main.cs  bin  obj
carrie@ubuntu:~//9-linkedlist_pop$ dotnet run
11
carrie@ubuntu:~//9-linkedlist_pop$ 
Repo:

GitHub repository: holbertonschool-csharp
Directory: csharp-hashset_stack_queue_linkedlist
File: 9-linkedlist_pop/, 9-linkedlist_pop/9-linkedlist_pop.csproj, 9-linkedlist_pop/9-linkedlist_pop.cs
 
0/9 pts
10. Get node at index
mandatory
Write a method that returns the value of the nth node of a LinkedList.

Class Name: LList
Prototype: public static int GetNode(LinkedList<int> myLList, int n)
Returns the value of the node at the given index
If the node doesn’t exist, return 0
Indexing starts at 0
carrie@ubuntu:~//10-linkedlist_get_node$ cat 10-main.cs 
using System;
using System.Collections.Generic;
class Program
{
    // Main - entry point
    static void Main(string[] args)
    {
        LinkedList<int> myLList = new LinkedList<int>();

        myLList.AddLast(91);
        myLList.AddLast(-22);
        myLList.AddLast(13);
        myLList.AddLast(14);
        myLList.AddLast(-54);
        myLList.AddLast(66);
        myLList.AddLast(37);
        myLList.AddLast(-8);

        Console.WriteLine(LList.GetNode(myLList, 5));
    }
}
carrie@ubuntu:~//10-linkedlist_get_node$ 
carrie@ubuntu:~//10-linkedlist_get_node$ ls
10-linkedlist_get_node.cs  10-linkedlist_get_node.csproj  10-main.cs  bin  obj
carrie@ubuntu:~//10-linkedlist_get_node$ dotnet run
66
carrie@ubuntu:~//10-linkedlist_get_node$ 
Repo:

GitHub repository: holbertonschool-csharp
Directory: csharp-hashset_stack_queue_linkedlist
File: 10-linkedlist_get_node/, 10-linkedlist_get_node/10-linkedlist_get_node.csproj, 10-linkedlist_get_node/10-linkedlist_get_node.cs
 
0/13 pts
11. LinkedList sum
mandatory
Write a method that returns the sum of all the data of a LinkedList.

Class Name: LList
Prototype: public static int Sum(LinkedList<int> myLList)
Returns the sum of the data in the LinkedList
carrie@ubuntu:~//11-linkedlist_sum$ cat 11-main.cs 
using System;
using System.Collections.Generic;

class Program
{
    // Main - entry point
    static void Main(string[] args)
    {
        LinkedList<int> myLList = new LinkedList<int>();

        myLList.AddLast(21);
        myLList.AddLast(9);
        myLList.AddLast(-8);
        myLList.AddLast(54);
        myLList.AddLast(23);
        myLList.AddLast(-6);
        myLList.AddLast(5);

        Console.WriteLine(LList.Sum(myLList));
    }
}
carrie@ubuntu:~//11-linkedlist_sum$ 
carrie@ubuntu:~//11-linkedlist_sum$ ls
11-linkedlist_sum.cs  11-linkedlist_sum.csproj  11-main.cs  bin  obj
carrie@ubuntu:~//11-linkedlist_sum$ dotnet run
98
carrie@ubuntu:~//11-linkedlist_sum$ 
Repo:

GitHub repository: holbertonschool-csharp
Directory: csharp-hashset_stack_queue_linkedlist
File: 11-linkedlist_sum/, 11-linkedlist_sum/11-linkedlist_sum.csproj, 11-linkedlist_sum/11-linkedlist_sum.cs
 
0/9 pts
12. Insert in order
mandatory
Write a method that inserts a new node in the correct position in an ordered LinkedList.

Class Name: LList
Prototype: public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
Returns the newly created node
carrie@ubuntu:~//12-linkedlist_insert$ cat 12-main.cs 
using System;
using System.Collections.Generic;

class Program
{
    // Main - entry point
    static void Main(string[] args)
    {
        LinkedList<int> myLList = new LinkedList<int>();
        LinkedListNode<int> current;

        myLList.AddLast(1);
        myLList.AddLast(4);
        myLList.AddLast(9);
        myLList.AddLast(16);
        myLList.AddLast(25);
        myLList.AddLast(36);
        myLList.AddLast(49);

        current = myLList.First;
        while (current != null)
        {
            Console.WriteLine(current.Value);
            current = current.Next;
        }

        Console.WriteLine("------------------");
        LList.Insert(myLList, 21);

        current = myLList.First;
        while (current != null)
        {
            Console.WriteLine(current.Value);
            current = current.Next;
        }
    }
}
carrie@ubuntu:~//12-linkedlist_insert$ 
carrie@ubuntu:~//12-linkedlist_insert$ ls
12-linkedlist_insert.cs  12-linkedlist_insert.csproj  12-main.cs  bin  obj
carrie@ubuntu:~//12-linkedlist_insert$ dotnet run
1
4
9
16
25
36
49
------------------
1
4
9
16
21
25
36
49
carrie@ubuntu:~//12-linkedlist_insert$ 
Repo:

GitHub repository: holbertonschool-csharp
Directory: csharp-hashset_stack_queue_linkedlist
File: 12-linkedlist_insert/, 12-linkedlist_insert/12-linkedlist_insert.csproj, 12-linkedlist_insert/12-linkedlist_insert.cs
 
0/12 pts
13. Delete at index
mandatory
Write a method that deletes the node at given position in a LinkedList.

Class Name: LList
Prototype: public static void Delete(LinkedList<int> myLList, int index)
carrie@ubuntu:~//13-linkedlist_delete$ cat 13-main.cs 
using System;
using System.Collections.Generic;

class Program
{
    // Main - entry point
    static void Main(string[] args)
    {
        LinkedList<int> myLList = new LinkedList<int>();
        LinkedListNode<int> current;

        myLList.AddLast(1);
        myLList.AddLast(4);
        myLList.AddLast(9);
        myLList.AddLast(16);
        myLList.AddLast(25);
        myLList.AddLast(36);
        myLList.AddLast(49);

        current = myLList.First;
        while (current != null)
        {
            Console.WriteLine(current.Value);
            current = current.Next;
        }

        Console.WriteLine("-------------------");
        LList.Delete(myLList, 5);

        current = myLList.First;
        while (current != null)
        {
            Console.WriteLine(current.Value);
            current = current.Next;
        }
    }
}
carrie@ubuntu:~//13-linkedlist_delete$ 
carrie@ubuntu:~//13-linkedlist_delete$ ls
13-linkedlist_delete.cs  13-linkedlist_delete.csproj  13-main.cs  bin  obj
carrie@ubuntu:~//13-linkedlist_delete$ dotnet run
1
4
9
16
25
36
49
-------------------
1
4
9
16
25
49
carrie@ubuntu:~//13-linkedlist_delete$ 
Repo:

GitHub repository: holbertonschool-csharp
Directory: csharp-hashset_stack_queue_linkedlist
File: 13-linkedlist_delete/, 13-linkedlist_delete/13-linkedlist_delete.csproj, 13-linkedlist_delete/13-linkedlist_delete.cs

Authors:

Ángel Suárez (suareza1992) (suarezangel.se@gmail.com)
