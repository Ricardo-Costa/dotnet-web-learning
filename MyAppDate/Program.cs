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
      Console.WriteLine(formatedDate);

    }
  }
}