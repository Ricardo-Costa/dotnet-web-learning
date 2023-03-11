using System;

namespace StringApp
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("------------------- [ Guid ] ------------------------");
      var id = Guid.NewGuid();
      Console.WriteLine(id);

      id = new Guid("ba3f1dfa-8f7a-482f-8aa0-56cdb91f61b3");
      Console.WriteLine(id);
      Console.WriteLine(id.ToString().Substring(0, 8));

      id = new Guid();
      Console.WriteLine(id);

      Console.WriteLine("------------------- [ Interpolação de Strings ] ------------------------");

      var price = 10.2;
      var texto = "Opreço do produto é " + price + " apenas na promoção.";
      Console.WriteLine(texto);

      texto = string.Format("O preço do produto é {0} apenas na promoção.", price);
      Console.WriteLine(texto);

      texto = $"O preço do produto é {price} apenas na promoção.";
      Console.WriteLine(texto);

      texto = @"
      O preço do produto é {price} apenas na promoção.
      ";
      Console.WriteLine(texto);

      texto = $@"
      O preço do produto é {price} apenas na promoção.
      ";
      Console.WriteLine(texto);

      texto = @"Test \n Quebrou?";
      Console.WriteLine(texto);

      texto = "Test \n Quebrou?";
      Console.WriteLine(texto);

      Console.WriteLine("------------------- [ Comparação de Strings ] ------------------------");

      texto = "Testando";
      Console.WriteLine(texto.CompareTo("Testando"));
      Console.WriteLine(texto.CompareTo("testando"));

      texto = "Testando texto xyz";
      Console.WriteLine(texto.Contains("xyz"));
      Console.WriteLine(texto.Contains("Xyz")); // default casesensitive
      Console.WriteLine(texto.Contains("Xyz", StringComparison.OrdinalIgnoreCase));

      Console.WriteLine("------------------- [ Comparação de START e END de Strings ] ------------------------");

      texto = "Este é um texto simples.";
      Console.WriteLine(texto.StartsWith("Este"));
      Console.WriteLine(texto.StartsWith("este"));
      Console.WriteLine(texto.StartsWith("este", StringComparison.OrdinalIgnoreCase));
      Console.WriteLine(texto.EndsWith("Simples."));
      Console.WriteLine(texto.EndsWith("simples."));
      Console.WriteLine(texto.EndsWith("Simples.", StringComparison.OrdinalIgnoreCase));

      Console.WriteLine("------------------- [ Comparação de IGUAL de Strings ] ------------------------");

      texto = "Este é um texto simples.";
      Console.WriteLine(texto.Equals("Este é um texto simples."));
      Console.WriteLine(texto.Equals("este é um texto simples."));
      Console.WriteLine(texto.Equals("este é um texto simples.", StringComparison.OrdinalIgnoreCase));

      Console.WriteLine("------------------- [ Comparação de INDEX de Strings ] ------------------------");

      texto = "Este é um texto simples.";
      Console.WriteLine(texto.IndexOf("é"));
      Console.WriteLine(texto.LastIndexOf("m"));

    }
  }
}