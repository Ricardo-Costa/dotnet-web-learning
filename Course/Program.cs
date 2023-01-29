namespace Course
{
  class Program
  {
    public static void Main(string[] args)
    {
      // TODO built-in types ou tipos primitivos

      byte meuByte = 125;

      const int year = 2023;
      // TODO ERROR var month; // ERROR
      int day;

      // TODO numeros reais
      float calculo = 2.5f; // menor quantidade de alocação na capacidade
      double salario = 200_000.3;
      decimal compra = 300_000_000.456m; // maior
      compra = 300_000_000.456M; // m ou M => mesma coisa

      // TODO boolean
      bool verdade = true;

      // TODO char
      char letra = 'A';
      // TODO string
      string meuTexto = "Este é um texto";
      // TODO string with alias
      System.String meuTexto2 = "Este é um texto";
      
      // TODO object - quando nao sabemos qual tipo irá vir, perdemos um pouco de intelisence
      // TODO object - se comporta como um ANy do typescript
      object quantidade = 1;
      quantidade = 1.7;

      // TODO nullable type, um tipo que pode ser nulo tambem
      int? idade = null;
      idade = 25; 
      idade = null; 


      // TODO valores padrões - builtin types sempre possuem um valor padrao
      /*
      int => 0
      float => 0
      decimal => 0
      bool => false
      char => '\0'
      string => ""
      */

      // TODO conversao implícitas
      float valor = 25.4F;
      int outro = 25;
      valor = outro; // conversão implicita => Um TIPO ACEITA(É COMPATÍVEL) com o outro.
      // TODO conversao EXplicita
      // obrigatoriamente temos que informar o tipo que estamos convertendo.
      int inteiro = 100;
      uint interiroSemSinal = (uint)inteiro;
      inteiro = (int)valor;
      Console.WriteLine(inteiro);

      try
      {
        // TODO Parse, tenta realizar a conversao
        int meuInteiro = int.Parse("100"); 
        // meuInteiro = int.Parse(23.5f.ToString()); ERROR
        Console.WriteLine(meuInteiro); 
      }
      catch (System.Exception)
      {
        
        throw;
      }

      try
      {
        int meuInteiro2 = Convert.ToInt32("335");
        Console.WriteLine(meuInteiro2);
        meuInteiro2 = Convert.ToInt32(33.5);
        Console.WriteLine(meuInteiro2);
      }
      catch (System.Exception e)
      {
        Console.WriteLine(e.Message);
        // throw;
      }

      Console.WriteLine(TesteMethod("Ricardo"));

      var texto = "Test start app console...";
      Console.WriteLine(texto);
    }

    static string TesteMethod(string name, int idade = 29) // idade opcional, tem valor default
    {
      return $"Nome: {name} tem idade default {idade}";
    }

  }
}