using System;

namespace Stopwatch
{
  class Program
  {
    static void Main(string[] args)
    {
      Menu();
    }

    static void Menu()
    {
      Console.Clear();
      Console.WriteLine("S = Segundo => 10s = 10 segundos");
      Console.WriteLine("M = Minutos => 1m = 1 minuto");
      Console.WriteLine("0 = Sair");
      Console.WriteLine("");
      Console.WriteLine("Quanto tempo deseja contar?");

      string value = Console.ReadLine().ToLower();
      // if (value.EndsWith("s")) Console.WriteLine("Sim terminar com S");
      char valueType = char.Parse(value.Substring(value.Length - 1, 1));
      int time = int.Parse(value.Substring(0, value.Length - 1));
      int multiplier = 1; // 1s

      if (valueType == 'm')
        multiplier = 60; // 1m

      char[] options = { 's', 'm' };
      if (!options.Contains(valueType)) {
        Console.WriteLine("Opção inválida, por favor tente novamente.");
        Thread.Sleep(2000);
        Menu();
      }

      PreStart(time * multiplier);
    }

    static void PreStart(int time)
    {
      Console.Clear();
      Console.WriteLine("Ready...");
      Thread.Sleep(1000);
      Console.Clear();
      Console.WriteLine("Set...");
      Thread.Sleep(1000);
      Console.Clear();
      Console.WriteLine("Go!!");
      Thread.Sleep(2500);
      Console.Clear();

      Start(time);
    }

    static void Start(int time)
    {
      int currentTime = 0;

      while(currentTime != time)
      {
        Console.Clear();
        currentTime++;
        Console.WriteLine(currentTime);
        Thread.Sleep(1000); // 1second
      }

      Console.Clear();
      Console.WriteLine("Stopwatch finalizado.");
      Thread.Sleep(2500); // 2.5s
    }
  }
}