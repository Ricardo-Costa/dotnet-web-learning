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

      Console.WriteLine("-------------------[Array ference type]----------------------");
      // var meuArray4 = meuArray3.CopyTo(); /// deve copiar via method para mudar referencia

      Console.WriteLine(meuArray3[0].Id);

      Console.WriteLine("-------------------[Array iterando/percorrendo]----------------------");

      for (var index = 0; index < meuArray2.Length; index++) {
        Console.WriteLine(meuArray2[index]);
      }

      foreach (var item in meuArray2) {
        Console.WriteLine(item);
      }

      var funcionarios = new Funcionario[1];
      funcionarios[0] = new Funcionario() { Id = 123, Nome = "Tester" };

      foreach (var funcionario in funcionarios) {
        Console.WriteLine(funcionario.Id);
        Console.WriteLine(funcionario.Nome);
      }

    }
  }

  struct Teste
  {
    public int Id { get; set; }
  }

  public struct Funcionario
  {
    public int Id { get; set; }
    public string Nome { get; set; }
  }
}