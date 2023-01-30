using System;
using System.IO;

namespace Stopwatch
{
  class Program
  {
    static void Main(string[] args)
    {
      Menu();
    }

    static void Menu()
    {
      Console.Clear();
      Console.WriteLine("O que você deseja fazer?");
      Console.WriteLine("1 - Abrir Arquivo");
      Console.WriteLine("2 - Criar Novo Arquivo");
      Console.WriteLine("0 - Sair");
      Console.WriteLine("");

      short option = short.Parse(Console.ReadLine());

      switch(option)
      {
        case 0: Environment.Exit(0); break;
        case 1: Open(); break;
        case 2: Edit(); break;
        default: Menu(); break;
      }

    }

    static void Open()
    {
    }

    static void Save(string text)
    {
      Console.Clear();
      Console.WriteLine("Qual o caminho para salvar o arquivo?");
      Console.WriteLine("Exemplo: outputfile/text.txt");
      var path = Console.ReadLine();

      // TODO sempre lembrar de fechar arquivo após abrilo para escrita
      // TODO using trata objetos em abertura e fechamento
      // https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/keywords/using-statement
      using(var file = new StreamWriter(path))
      {
        file.Write(text);
      }

      Console.WriteLine($"Aquivo salvo com sucesso em: {path}");
      Menu();
    }

    static void Edit()
    {
      Console.Clear();
      Console.WriteLine("Digite seu texto abaixo (ESC para sair)");
      Console.WriteLine("------------------------------");
      string text = "";

      do
      {
        text += Console.ReadLine();
        text += Environment.NewLine;
      }
      while(Console.ReadKey().Key != ConsoleKey.Escape);

      Save(text);
    }

  }
}