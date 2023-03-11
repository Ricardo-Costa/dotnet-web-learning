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


    }
  }
}