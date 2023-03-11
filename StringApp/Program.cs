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
    }
  }
}