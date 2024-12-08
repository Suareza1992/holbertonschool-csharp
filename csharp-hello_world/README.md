C# - Hello, World

Learning Objectives
At the end of this project, you are expected to be able to explain to anyone, without the help of Google:

General
What is the meaning behind the name C#?
Who is the lead architect of the development team of C#?
What is .NET?
What is the difference between C# and .NET?
How to use VSCode and the integrated terminal to initialize, build, and run C# projects
How to print text and variables using Console.Write
Requirements
Shell Scripts
Allowed editors: vi, vim, emacs
All your scripts will be tested on Ubuntu 20.04 LTS
All your files should end with a new line
The first line of all your files should be exactly #!/usr/bin/env bash
All your files must be executable
C# Tasks
Allowed editors: Visual Studio Code
All files will be compiled on Ubuntu 20.04 LTS using dotnet
A README.md file, at the root of the folder of the project, is mandatory
All default C# files named Program.cs should be renamed to the name given in each task
You do not need to know about namespaces and classes yet. Namespaces should be omitted in this project. The default names generated in Program.cs for class are okay
Each C# task requires its own folder and .csproj file. Push all task folders to your GitHub and ensure the task names on the folders are correct
You do not need to push your obj/ or bin/ folders
Tasks
0. Initialize new project
mandatory
Write a Bash script that initializes a new C# project inside a folder titled 0-new_project.

Use the command dotnet
carrie@ubuntu:~/csharp-hello_world/$ ls
0-initialize_new_project.sh
carrie@ubuntu:~/csharp-hello_world/$ ./0-initialize_new_project.sh 
The template "Console Application" was created successfully.

Processing post-creation actions...
Running 'dotnet restore' on /home/carrie/csharp-hello_world/0-new_project/0-new_project.csproj...
  Restoring packages for /home/carrie/csharp-hello_world/0-new_project/0-new_project.csproj...
  Generating MSBuild file /home/carrie/csharp-hello_world/0-new_project/obj/0-new_project.csproj.nuget.g.props.
  Generating MSBuild file /home/carrie/csharp-hello_world/0-new_project/obj/0-new_project.csproj.nuget.g.targets.
  Restore completed in 151.49 ms for /home/carrie/csharp-hello_world/0-new_project/0-new_project.csproj.


Restore succeeded.

carrie@ubuntu:~/csharp-hello_world/$ ls
0-initialize_new_project.sh  0-new_project
carrie@ubuntu:~/csharp-hello_world/$ ls 0-new_project/
0-new_project.csproj  obj  Program.cs
carrie@ubuntu:~/csharp-hello_world/0-new_project$
Repo:

GitHub repository: holbertonschool-csharp
Directory: csharp-hello_world
File: 0-initialize_new_project.sh

1. Build new project
mandatory
Write a Bash script that initializes and builds a new C# project inside a folder titled 1-new_project.

Use the command dotnet
carrie@ubuntu:~/csharp-hello_world$ ls
1-build_new_project.sh
carrie@ubuntu:~/csharp-hello_world$ ./1-build_new_project.sh 
The template "Console Application" was created successfully.

Processing post-creation actions...
Running 'dotnet restore' on /home/carrie/csharp-hello_world/1-new_project/1-new_project.csproj...
  Restoring packages for /home/carrie/csharp-hello_world/1-new_project/1-new_project.csproj...
  Generating MSBuild file /home/carrie/csharp-hello_world/1-new_project/obj/1-new_project.csproj.nuget.g.props.
  Generating MSBuild file /home/carrie/csharp-hello_world/1-new_project/obj/1-new_project.csproj.nuget.g.targets.
  Restore completed in 149.24 ms for /home/carrie/csharp-hello_world/1-new_project/1-new_project.csproj.


Restore succeeded.

Microsoft (R) Build Engine version 15.4.8.50001 for .NET Core
Copyright (C) Microsoft Corporation. All rights reserved.

  1-new_project -> /home/carrie/csharp-hello_world/1-new_project/bin/Debug/netcoreapp2.1/1-new_project.dll

Build succeeded.
    0 Warning(s)
    0 Error(s)

Time Elapsed 00:00:02.21
carrie@ubuntu:~/csharp-hello_world$ ls
1-build_new_project.sh  1-new_project
carrie@ubuntu:~/csharp-hello_world$ ls 1-new_project/
1-new_project.csproj  bin  obj  Program.cs
carrie@ubuntu:~/csharp-hello_world$ 
Repo:

GitHub repository: holbertonschool-csharp
Directory: csharp-hello_world
File: 1-build_new_project.sh

2. Run new project
mandatory
Write a Bash script that initializes, builds, and runs a new C# project from a folder titled 2-new_project.

Use the command dotnet
carrie@ubuntu:~/csharp-hello_world$ ls
2-run_new_project.sh
carrie@ubuntu:~/csharp-hello_world$ ./2-run_new_project.sh 
The template "Console Application" was created successfully.

Processing post-creation actions...
Running 'dotnet restore' on /home/carrie/csharp-hello_world/2-new_project/2-new_project.csproj...
  Restoring packages for /home/carrie/csharp-hello_world/2-new_project/2-new_project.csproj...
  Generating MSBuild file /home/carrie/csharp-hello_world/2-new_project/obj/2-new_project.csproj.nuget.g.props.
  Generating MSBuild file /home/carrie/csharp-hello_world/2-new_project/obj/2-new_project.csproj.nuget.g.targets.
  Restore completed in 154.48 ms for /home/carrie/csharp-hello_world/2-new_project/2-new_project.csproj.


Restore succeeded.

Microsoft (R) Build Engine version 15.4.8.50001 for .NET Core
Copyright (C) Microsoft Corporation. All rights reserved.

  2-new_project -> /home/carrie/csharp-hello_world/2-new_project/bin/Debug/netcoreapp2.1/2-new_project.dll

Build succeeded.
    0 Warning(s)
    0 Error(s)

Time Elapsed 00:00:02.21
Hello World!
carrie@ubuntu:~/csharp-hello_world$ ls
2-new_project  2-run_new_project.sh
carrie@ubuntu:~/csharp-hello_world$ ls 2-new_project/
2-new_project.csproj  bin  obj  Program.cs
carrie@ubuntu:~/csharp-hello_world$
Repo:

GitHub repository: holbertonschool-csharp
Directory: csharp-hello_world
File: 2-run_new_project.sh

3. Hello, WriteLine
mandatory
Write a C# script that prints exactly "Programming is like building a multilingual puzzle followed by a new line.

Use the method Console.WriteLine
carrie@ubuntu:~/csharp-hello_world/3-writeline$ ls
3-writeline.csproj  bin  obj  3-writeline.cs
carrie@ubuntu:~/csharp-hello_world/3-writeline$ dotnet run
"Programming is like building a multilingual puzzle
carrie@ubuntu:~/csharp-hello_world/3-writeline$ 
Repo:

GitHub repository: holbertonschool-csharp
Directory: csharp-hello_world
File: 3-writeline/, 3-writeline/3-writeline.csproj, 3-writeline/3-writeline.cs

4. Print integer
mandatory
Complete this source code in order to print the integer stored in the variable number, followed by Mission Street followed by a new line.

You can find the source code here
Your code should be exactly 10 lines long
The output of the script should be:
the number, followed by Mission Street
followed by a new line
carrie@ubuntu:~/csharp-hello_world/4-print_integer$  ls
4-print_integer.cs  4-print_integer.csproj  bin  obj
carrie@ubuntu:~/csharp-hello_world/4-print_integer$ dotnet run
972 Mission Street
carrie@ubuntu:~/csharp-hello_world/4-print_integer$ 
Repo:

GitHub repository: holbertonschool-csharp
Directory: csharp-hello_world
File: 4-print_integer/, 4-print_integer/4-print_integer.csproj, 4-print_integer/4-print_integer.cs

5. Print float
mandatory
Complete this source code in order to print the float stored in the variable number with a precision of 2 digits.

You can find the source code here
Your script should be exactly 10 lines long
The output of the script should be:
Float: followed by the number with only 2 digits
followed by a new line
carrie@ubuntu:~/csharp-hello_world/5-print_float$ ls
5-print_float.cs  5-print_float.csproj  bin  obj
carrie@ubuntu:~/csharp-hello_world/5-print_float$ dotnet run
Float: 3.14
carrie@ubuntu:~/csharp-hello_world/5-print_float$ 
Repo:

GitHub repository: holbertonschool-csharp
Directory: csharp-hello_world
File: 5-print_float/, 5-print_float/5-print_float.csproj, 5-print_float/5-print_float.cs

6. Print string
mandatory
Complete this source code in order to print a string stored in the variable str 3 times, followed by its first 9 characters.

You can find the source code here
The output of the script should be:
the value of str 3 times
followed by a new line
followed by the first 9 characters of str
followed by a new line
You are not allowed to use any loops or conditional statement
carrie@ubuntu:~/csharp-hello_world/6-print_string$ ls
6-print_string.cs  6-print_string.csproj  bin  obj
carrie@ubuntu:~/csharp-hello_world/6-print_string$ dotnet run
Holberton SchoolHolberton SchoolHolberton School
Holberton
carrie@ubuntu:~/csharp-hello_world/6-print_string$ 
Repo:

GitHub repository: holbertonschool-csharp
Directory: csharp-hello_world
File: 6-print_string/, 6-print_string/6-print_string.csproj, 6-print_string/6-print_string.cs

7. Play with strings
mandatory
Complete this source code to print Welcome to Holberton School!

You can find the source code here
Your code should be exactly 12 lines long
You are not allowed to use any loops or conditional statement
You have to use the variables str1 and str2 in your new line of code
carrie@ubuntu:~/csharp-hello_world/7-concat$ ls
7-concat.cs  7-concat.csproj  bin  obj
carrie@ubuntu:~/csharp-hello_world/7-concat$ dotnet run
Welcome to Holberton School!
carrie@ubuntu:~/csharp-hello_world/7-concat$ 
Repo:

GitHub repository: holbertonschool-csharp
Directory: csharp-hello_world
File: 7-concat/, 7-concat/7-concat.csproj, 7-concat/7-concat.cs

8. Print variables
mandatory
Complete this source code in order to print the given variables as 972 Mission Street.

You can find the source code here
Your code should be exactly 12 lines long
You are not allowed to create new variables
You are not allowed to edit existing variables
The output of the script should be:
972 Mission Street
followed by a new line
carrie@ubuntu:~/csharp-hello_world/8-print_variables$ ls
8-print_variables.cs  8-print_variables.csproj  bin  obj
carrie@ubuntu:~/csharp-hello_world/8-print_variables$ dotnet run
972 Mission Street
carrie@ubuntu:~/csharp-hello_world/8-print_variables$ 
Repo:

GitHub repository: holbertonschool-csharp
Directory: csharp-hello_world
File: 8-print_variables/, 8-print_variables/8-print_variables.csproj, 8-print_variables/8-print_variables.cs

9. Print specifiers
mandatory
Complete this source code in order to print the given variables as in the result shown.

You can find the source code here
Your code should be no more than 12 lines long
You are not allowed to create new variables
The target locale is en-US.utf-8
The output of the script should be:
Percent: 75.53% tip
followed by a new line
followed by Currency: $98,765.43
followed by a new line
carrie@ubuntu:~/csharp-hello_world/9-print_specifiers$ ls
9-print_specifiers.cs  9-print_specifiers.csproj  bin  obj
carrie@ubuntu:~/csharp-hello_world/9-print_specifiers$ dotnet run
Percent: 75.53%
Currency: $98,765.43
carrie@ubuntu:~/csharp-hello_world/9-print_specifiers$ 
Repo:

GitHub repository: holbertonschool-csharp
Directory: csharp-hello_world
File: 9-print_specifiers/, 9-print_specifiers/9-print_specifiers.csproj, 9-print_specifiers/9-print_specifiers.cs

10. Copy - Cut - Paste
mandatory
Complete this source code.

You can find the source code here
Your code should be exactly 15 lines long
You are not allowed to use any loops or conditional statements
word_first_3 should contain the first 3 letters of the variable word
word_last_2 should contain the last 2 letters of the variable word
middle_word should contain the value of the variable word without the first and last letters
carrie@ubuntu:~/csharp-hello_world/10-copy_cut_paste$ ls
10-copy_cut_paste.cs  10-copy_cut_paste.csproj  bin  obj
carrie@ubuntu:~/csharp-hello_world/10-copy_cut_paste$ dotnet run
First 3 letters: Hol
Last 2 letters: on
Middle word: olberto
carrie@ubuntu:~/csharp-hello_world/10-copy_cut_paste$ 
Repo:

GitHub repository: holbertonschool-csharp
Directory: csharp-hello_world
File: 10-copy_cut_paste/, 10-copy_cut_paste/10-copy_cut_paste.csproj, 10-copy_cut_paste/10-copy_cut_paste.cs

11. Create a new sentence
mandatory
Complete this source code to print object-oriented programming in C# followed by a new line.

You can find the source code here
Your code should be exactly 11 lines long
You are not allowed to use any loops or conditional statements
You are not allowed to create new variables
You are not allowed to use string literals
carrie@ubuntu:~/csharp-hello_world/11-concat_edges$ ls
11-concat_edges.cs  11-concat_edges.csproj  bin  obj
carrie@ubuntu:~/csharp-hello_world/11-concat_edges$ dotnet run
object-oriented programming in C#
carrie@ubuntu:~/csharp-hello_world/11-concat_edges$ 
Repo:

GitHub repository: holbertonschool-csharp
Directory: csharp-hello_world
File: 11-concat_edges/, 11-concat_edges/11-concat_edges.csproj, 11-concat_edges/11-concat_edges.cs

Author:

Ángel Suárez (github.com/suareza1992)(suarezangel.se@gmail.com)
