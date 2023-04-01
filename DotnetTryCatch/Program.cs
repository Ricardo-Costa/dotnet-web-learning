using System;

namespace DotnetTryCatch
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("-----------------[ Tratamento de Exceptions ]-------------------");
      int[] arrayA = new int[2];

      try
      {
        Console.WriteLine(arrayA[3]);
      }
      catch
      {
        Console.WriteLine("Deu ruim...");
        // throw;
      }

      try
      {
        Console.WriteLine(arrayA[3]);
      }
      catch (Exception ex)
      {
        Console.WriteLine("Deu ruim...");
        Console.WriteLine(ex.Message);
        // throw;
      }

      Console.WriteLine("-----------------[ Tratamento de Exceptions Multiplas ]-------------------");

      try
      {
        Console.WriteLine(arrayA[3]);
      }
      catch (IndexOutOfRangeException ex)
      {
        Console.WriteLine("Deu ruim no indice...");
        Console.WriteLine(ex.Message);
        // throw;
      }
      catch (Exception ex)
      {
        Console.WriteLine("Deu ruim GERAL...");
        Console.WriteLine(ex.Message);
        // throw;
      }
    }
  }
}