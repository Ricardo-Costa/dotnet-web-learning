using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;

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
      var arrayA = new int[1] { 21 };
      var arrayB = arrayA;
      arrayA[0] = 22;
      Console.WriteLine(arrayB[0]);

      // copia correta
      arrayB[0] = arrayA[0];
      // OU....
      arrayA.CopyTo(arrayB, 0);


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

      Console.WriteLine("------------------------------------------------");

      System.Collections.Generic.IList<Departamento> departamentos = new System.Collections.Generic.List<Departamento>();
      System.Collections.Generic.IList<Funcionario2> funcionarios2 = new System.Collections.Generic.List<Funcionario2>();
      funcionarios2.Add(
        new Funcionario2()
        {
          Id = 5,
          Nome = "Ricardo 22"
        }
      );
      funcionarios2.Add(
        new Funcionario2()
        {
          Id = 5,
          Nome = "Ricardo 2"
        }
      );
      departamentos.Add(
        new Departamento()
        {
          funcionarios = funcionarios2
        }
      );

      for (int j = 0; j < departamentos.Count; j++)
      {
          departamentos[j].Id = j + 100;

          for (int i = 0; i < departamentos[j].funcionarios.Count; i++)
              departamentos[j].funcionarios[i].Nome = $"Ricardo novo nome {i}";
      }

      Console.WriteLine(JsonConvert.SerializeObject(departamentos));

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

  public class Funcionario2
  {
    public int Id { get; set; }
    public string Nome { get; set; }
  }

  public class Departamento
  {
    public int Id { get; set; }
    public IList<Funcionario2> funcionarios { get; set; }
  }
}