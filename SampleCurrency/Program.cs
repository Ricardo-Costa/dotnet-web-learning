using System.Globalization;
using System;

namespace SampleCurrency
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();

      decimal valor = 10.25m; // para modedas em geral
      Console.WriteLine(valor);

      Console.WriteLine("-------------------[Formatação por Cultura]----------------------");
      Console.WriteLine(
        valor.ToString(
          CultureInfo.CreateSpecificCulture("en-US")
        )
      );
      Console.WriteLine(
        valor.ToString(
          CultureInfo.CreateSpecificCulture("pt-BR")
        )
      );
      Console.WriteLine(
        valor.ToString(
          "G", // number
          CultureInfo.CreateSpecificCulture("pt-BR")
        )
      );
      Console.WriteLine(
        valor.ToString(
          "C", // currency --> moeda
          CultureInfo.CreateSpecificCulture("pt-BR")
        )
      );
    }
  }
}