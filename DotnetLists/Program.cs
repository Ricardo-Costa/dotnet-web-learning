using System;

namespace DotnetLists
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();

      var meuArray = new int[5]; // array de 5 posições
      meuArray[0] = 12;

      Console.WriteLine("-------------------[Array]----------------------");
      Console.WriteLine(meuArray[0]);

      Console.WriteLine("-------------------[Array inicializado]----------------------");
      var meuArray2 = new int[5]{ 12, 13, 14, 15, -12 }; // array de 5 posições
      Console.WriteLine(meuArray2[3]);

      Console.WriteLine("-------------------[Array varios tipos + structures]----------------------");
      var meuArray3 = new Teste[1]{ new Teste() }; // array de 5 posições
      Console.WriteLine(meuArray3[0].Id);
    }
  }

  struct Teste
  {
    public int Id { get; set; }
  }
}