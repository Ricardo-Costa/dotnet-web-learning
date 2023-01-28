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

      // inferencia
      var testInferencia = "inferencia com string";

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

      Console.WriteLine("--------------------------------------------");
      Console.WriteLine("Struct and Class...");
      Console.WriteLine("--------------------------------------------");

      // TODO https://www.youtube.com/watch?v=DSkR4ucd_Vs&t=5m33s
      Quadrado quadrado = new Quadrado(); // Value Type -- Stack
      Pessoa pessoa = new Pessoa(nome: "Carlos") // Reference Type -- Heap -- RunTime -> em tempo de execução
      {
        Idade=32
      };

      Console.WriteLine(pessoa.Andar());

      Funcionario funcionario = new Funcionario(matricula: 1023, nome: "Maria")
      {
        Altura=2.10
      };
      Console.WriteLine(funcionario.Andar());
      
      Console.WriteLine("--------------------------------------------");
      Console.WriteLine("Tuplas...");
      Console.WriteLine("--------------------------------------------");

      // TODO https://stackoverflow.com/questions/43476056/what-do-the-underscores-mean-in-a-numeric-literal-in-c
      string testCompare = (50000 == 50_000).ToString();
      Console.WriteLine($"{testCompare}");

      (string, int) populacao = ("Test City", 500_000);
      Console.WriteLine($"{populacao.Item1}: {populacao.Item2}");

      var populacao2 = ("Test City", 500_000);
      Console.WriteLine($"{populacao2.Item1}: {populacao2.Item2}");

      // nomeando
      (string cidade, int numero_populacao) populacao3 = ("Test City", 500_000);
      Console.WriteLine($"{populacao3.cidade}: {populacao3.numero_populacao}");

      // exibição comppleta
      Console.WriteLine(populacao3);

    }
  }
}