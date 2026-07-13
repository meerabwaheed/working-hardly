using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 10, 20, 30, 40, 50 };

        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}
1. What is C#?

C# (C-Sharp) is a programming language developed by Microsoft.

It is used for:

Desktop Applications
Web Applications (ASP.NET Core)
Mobile Apps (.NET MAUI)
Games (Unity)
APIs
Cloud Applications

Example:

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello World");
    }
}

Output

Hello World
2. Structure of a C# Program
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello");
    }
}

Explanation

Part	Meaning
using System;	Imports built-in classes
class Program	Creates a class
static void Main()	Starting point of the program
Console.WriteLine()	Prints text
3. Comments

Single Line

// This is a comment

Multiple Line

/*
This is
a comment
*/
4. Variables

A variable stores data.

Syntax

datatype variableName = value;

Example

string name = "Meerab";
int age = 20;
double cgpa = 3.04;
char grade = 'A';
bool isStudent = true;

Print variables

Console.WriteLine(name);
Console.WriteLine(age);
Console.WriteLine(cgpa);

Output

Meerab
20
3.04
5. Data Types
Data Type	Example
int	10
double	10.5
float	12.3f
decimal	12.50m
char	'A'
string	"Hello"
bool	true

Example

int marks = 90;
double price = 100.5;
char section = 'B';
string city = "Lahore";
bool passed = true;
6. Taking Input
Console.Write("Enter your name: ");

string name = Console.ReadLine();

Console.WriteLine("Welcome " + name);

Output

Enter your name: Meerab

Welcome Meerab
