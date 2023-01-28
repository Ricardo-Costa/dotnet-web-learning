using System;
namespace MyConsoleApp
{
  public class Folha
  {
    private bool _temTexto, _maisUmBool;
    public int Pagina { get; internal set; }

    public Folha()
    {
      var random = new Random().Next(1,2);
      _temTexto = random == 1;
    }

    public bool temTexto()
    {
      Console.WriteLine($"Executando processamento página{this.Pagina}...");
      return _temTexto;
    }
  }
}