// See https://aka.ms/new-console-template for more information

/*
TODO Starting with .NET 6, the project template for new C# console apps generates the following code in the Program.cs file:
*/

// TODO Console.WriteLine("Hello, World!");


// TODO The new output uses recent C# features that simplify the code you need to write for a program.
// For .NET 5 and earlier versions, the console app template generates the following code:

using System;

namespace MyConsoleApp // TODO Note: actual namespace depends on the project name.
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("--------------------------------------------");
      Console.WriteLine("Start console app...");
      Console.WriteLine("--------------------------------------------");

      // Value Type -- Stack
      Boolean trueOrFalse = true;
      Int16 number2 = 1;
      Int32 number3 = 1;
      Int64 number4 = 1;
      Double numberDouble = 1.6;

      Char myChar = 'a'; // TODO char only one char
      String name = "My name here";
      
      // TODO Apelidos [ Alias ] fornecidos pelo framework
      bool trueOrFalse2 = true;
      short numberInt16 = 16;
      int numberInt32 = 32; // TODO o mais utilizado
      long number64 = 64;
      double numberDouble2 = 1.6;

      char myChar2 = 'a';
      string name2 = "My name here";
      // TODO string with multilines
      string textArea = @"
        Esta é uma string com multiplas linhas
        outra linha aqui {name2}
      ";
      // TODO As a side-note, with C# 6.0 you can now combine interpolated strings with the verbatim string literal:
      string showVariablesWithAlias = $@"
        bool trueOrFalse2 = {trueOrFalse2};
        short numberInt16 = {numberInt16};
        int numberInt32 = {numberInt32};
        long number64 = {number64};
        double numberDouble2 = {numberDouble2};
      ";
      Console.Write(showVariablesWithAlias);

      // Using string interpolation
      string test = $"Name {name}";
      Console.WriteLine(test);

    }
  }
}