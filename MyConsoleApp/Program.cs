using System.Collections.Immutable;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
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

      // Balta
      var aluno = new Student{ Name="Carol" };
      var tupla = new Tuple<string, int, Student>("Meu texto", 1, aluno);
      Console.WriteLine(tupla.Item3.Name);
      // create
      var tupla2 = Tuple.Create<string, int, Student>("Meu texto", 1, null);
      // inferencia
      (string, decimal) tupla4 = ("Meu texto", 1.7M);

      // TODO desconstruindo

      // forma 1 
      (string city0, int pop0) = populacao3;
      // forma 2
      var (city, pop) = populacao3;
      // forma 3
      string city3;
      int pop3;
      (city3, pop3) = populacao3;

      // TODO descarte de valores

      var (_, pop4) = populacao3;

      Console.WriteLine($"{city}: {pop}");

      // TODO List and Enumerable
      Console.WriteLine("--------------------------------------------");
      Console.WriteLine("List and Enumerable...");
      Console.WriteLine("--------------------------------------------");

      var caderno = new List<Folha>();
      for (int i = 1; i < 51; i++)
      {
        caderno.Add(new Folha() { Pagina = i });
      }

      var folhasComTexto = caderno.FindAll(x => x.temTexto());
      Console.WriteLine(caderno.Count);
      Console.WriteLine(caderno);
      Console.WriteLine(folhasComTexto[1]);

      // TODO VER Enumerable




      // TODO Array 0, 1, 2, 3, 4
      int[] arr = { 1, 2, 3, 4, 5 };
      var resp = arr[0];
      Console.WriteLine(resp);

    }
  }
}

