using System;

namespace Calculator
{
  class Program
  {
    public static void Main(string[] args)
    {
      ExibirMenuOperacoes();
    }

    static (float firstValue, float secondValue) PedirNumeros()
    {
      Console.Clear(); // limpar tela
      Console.WriteLine("Primeiro valor: ");
      float firstValue = float.Parse(Console.ReadLine()); // pedir valores no terminar
      Console.WriteLine("Informe o segundo valor: ");
      float secondValue = float.Parse(Console.ReadLine()); // pedir valores no terminar
      Console.WriteLine("");

      return (firstValue, secondValue);
    }

    static void Soma()
    {
      (float firstValue, float secondValue) = PedirNumeros();
      // Console.WriteLine($"Resultado da soma é: " + (firstValue + secondValue));// concatenação
      Console.WriteLine($"Resultado da soma é: {firstValue + secondValue}");// interpolação
      Console.ReadKey();// manter console sem fechar
      ExibirMenuOperacoes();
    }

    static void Subtracao()
    {
      (float firstValue, float secondValue) = PedirNumeros();
      Console.WriteLine($"Resultado da subtração é: {firstValue - secondValue}");
      Console.ReadKey();// manter console sem fechar
      ExibirMenuOperacoes();
    }

    static void Divisao()
    {
      (float firstValue, float secondValue) = PedirNumeros();
      Console.WriteLine($"Resultado da divisão é: {firstValue / secondValue}");
      Console.ReadKey();// manter console sem fechar
      ExibirMenuOperacoes();
    }

    static void Multiplicacao()
    {
      (float firstValue, float secondValue) = PedirNumeros();
      Console.WriteLine($"Resultado da multiplicaçãoivisão é: {firstValue * secondValue}");
      Console.ReadKey();// manter console sem fechar
      ExibirMenuOperacoes();
    }

    static void ExibirMenuOperacoes()
    {
      Console.Clear(); // limpar tela
      Console.WriteLine("Informe qual operação você deseja realizar:");
      Console.WriteLine("1 - Soma");
      Console.WriteLine("2 - Subtração");
      Console.WriteLine("3 - Divisão");
      Console.WriteLine("4 - Multiplicação");
      Console.WriteLine("5 - Sair");
      Console.WriteLine();
      Console.WriteLine("Informe uma das opções válidas.");
      short opcao = short.Parse(Console.ReadLine());

      switch (opcao)
      {
        case 1: Soma(); break;
        case 2: Subtracao(); break;
        case 3: Divisao(); break;
        case 4: Multiplicacao(); break;
        case 5: System.Environment.Exit(0); break;
        default: ExibirMenuOperacoes(); break;
      }
    }
  }
}