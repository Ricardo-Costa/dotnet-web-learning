using System.Text.RegularExpressions;
using System;

namespace EditorHtml
{
  public class Viewer
  {
    public static void Show(string text)
    {
      Console.Clear();
      Console.BackgroundColor = ConsoleColor.White;
      Console.ForegroundColor = ConsoleColor.Black;
      Console.Clear();
      Console.WriteLine("[Modo Visualização]");
      Console.WriteLine("---------------");
    }

    public static void Replace(string text)
    {
      // var string = new Regex("<strong><strong>");
    }
  }
}