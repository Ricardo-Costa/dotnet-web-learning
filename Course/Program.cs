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




      var texto = "Test start app console...";
      Console.WriteLine(texto);
      Console.WriteLine("Depois debug...");
    }

  }
}