//Author: Sady Sell Neto
//Copyright (C) 2016

using System;

//This is a C# line comment.
/*This is a C# block comment.*/

//Entry point in C#: Main method.
//It can have any access modifier and belong to a class, a struct or a
//non-static class. It must be static.
//Valid signatures:
//static void Main()
//static void Main(string[] args)
//static int Main()
//static int Main(string[] args)

//If you use the args parameter, you will be able to access command line
//options. Also, by returning an int instead of void, you can return an exit
//code.

class Program {

    public static void Main() {

        Console.WriteLine("Hello, world!");

    }
}
