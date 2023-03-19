using System.Globalization;
using System;

namespace MyAppDate
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("---------------------- [ Data Atual ] ----------------------");
      // var data = new DateTime(); --> se nao informa params, nao pega o de hoje -->> 1/1/0001 12:00:00 AM
      var data = DateTime.Now; // pegar a data atual
      Console.WriteLine(data);

      Console.WriteLine("------------------- [ Data por parametro ] -------------------------");
      data = new DateTime(2020, 10, 12, 8, 23, 14);
      Console.WriteLine(data);
      Console.WriteLine(data.Year);
      Console.WriteLine(data.Month);
      Console.WriteLine(data.DayOfWeek);
      // botao direito e go to definition ver se Enum / enumeration
      Console.WriteLine((int) data.DayOfWeek); // TODO se enumerador consigo fazer um "cast" um "parse" para inteiro

      Console.WriteLine("------------------- [ Data - Formatações ] -------------------------");
      data = DateTime.Now;

      var formatedDate = String.Format("{0:yyyy}", data);
      Console.WriteLine(formatedDate);
      formatedDate = String.Format("{0:yyy}", data);
      Console.WriteLine(formatedDate);
      formatedDate = String.Format("{0:yy}", data);
      Console.WriteLine(formatedDate);
      formatedDate = String.Format("{0:y}", data);
      Console.WriteLine(formatedDate);
      formatedDate = String.Format("{0:Y}", data);
      Console.WriteLine(formatedDate);
      formatedDate = String.Format("{0:M}", data);
      Console.WriteLine(formatedDate);
      formatedDate = String.Format("{0:yyyy-MM-dd hh:mm:ss ff z}", data);
      formatedDate = String.Format("{0:r}", data); // obj JS ?
      Console.WriteLine(formatedDate);
      formatedDate = String.Format("{0:s}", data); // JSON date
      Console.WriteLine(formatedDate);
      formatedDate = String.Format("{0:u}", data); // JSON date
      Console.WriteLine(formatedDate);

      Console.WriteLine("------------------- [ Data - Manipulações ] -------------------------");
      data = DateTime.Now;
      data.AddDays(10); // nao modifica a data, apenas retorna a nova instancia com o valor
      Console.WriteLine(data.AddDays(10));
      Console.WriteLine((data.AddDays(10)).AddDays(-10));

      Console.WriteLine("------------------- [ Data - Comparação ] -------------------------");
      DateTime? data2 = null; // TODO DateTime? -> uma data que pode ser nula
      data2 = DateTime.Now;

      if (data == DateTime.Now) {
        Console.WriteLine("É igual");
      }

      if (data.Date == DateTime.Now.Date) { // compara so dates
        Console.WriteLine("DATE É igual");
      }

      if (data <= DateTime.Now) { // compara so dates
        Console.WriteLine("DATE menor igual");
      }

      Console.WriteLine("------------------- [ Data - Localização e Globalização ] -------------------------");
      var pt = new CultureInfo("pt-BR");
      var atual = CultureInfo.CurrentCulture; // pegar a atual do sistema

      // var pt = new System.Globalization.CultureInfo("pt-BR");
      data2 = DateTime.Now;

      Console.WriteLine(DateTime.Now.ToString("d"));
      Console.WriteLine(string.Format("{0:D}", DateTime.Now));
      Console.WriteLine(DateTime.Now.ToString("D", pt));
      Console.WriteLine(DateTime.Now.ToString("D", atual));

    }
  }
}