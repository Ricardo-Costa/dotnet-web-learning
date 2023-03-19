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

      Console.WriteLine("------------------- [ Data - Timezone ] -------------------------");
      pt = new CultureInfo("pt-BR");
      var dataUTC = DateTime.UtcNow; // TODO UTC

      Console.WriteLine(DateTime.Now.ToString("r", pt));
      Console.WriteLine(dataUTC.ToString("r", pt));
      Console.WriteLine(dataUTC.ToLocalTime().ToString("r", pt));

      var timezoneFortaleza = TimeZoneInfo.FindSystemTimeZoneById("America/Fortaleza");
      Console.WriteLine(timezoneFortaleza);

      var horaFortaleza = TimeZoneInfo.ConvertTimeFromUtc(dataUTC, timezoneFortaleza);
      Console.WriteLine(horaFortaleza);

      // foreach (var timezone in TimeZoneInfo.GetSystemTimeZones())
      // {
      //   Console.WriteLine(timezone.Id);
      //   Console.WriteLine(timezone);
      //   Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(dataUTC, timezone));
      //   Console.WriteLine("-----------------------");
      // }

      Console.WriteLine("------------------- [ Data - TimeSpan ] -------------------------");

      // frações de tempo
      var timeSpan = new TimeSpan();
      Console.WriteLine(timeSpan);
      
      var timeSpanNanosegundos = new TimeSpan(1);
      Console.WriteLine(timeSpanNanosegundos);
      
      var timeSpanHoraMinSeg = new TimeSpan(5, 12, 1);
      Console.WriteLine(timeSpanHoraMinSeg);
      
      var timeSpanDiaHoraMinSeg = new TimeSpan(2, 5, 12, 1); // etc...
      Console.WriteLine(timeSpanDiaHoraMinSeg);

      /// usado normalmente para calculos precisos com unidades de tempo
      Console.WriteLine(timeSpanDiaHoraMinSeg - timeSpanHoraMinSeg);
      Console.WriteLine(timeSpanDiaHoraMinSeg.Days);
      Console.WriteLine(timeSpanDiaHoraMinSeg.Add(new TimeSpan(12, 0, 0, 3)));


      Console.WriteLine("------------------- [ Data - Funções uteis ] -------------------------");
      Console.WriteLine(DateTime.DaysInMonth(2020, 2));
      
      if (DateTime.Now.DayOfWeek == DayOfWeek.Saturday || DateTime.Now.DayOfWeek == DayOfWeek.Sunday) {
        Console.WriteLine("É final de semana");
      } else {
        Console.WriteLine("Não é final de semana");
      }

      Console.WriteLine(DateTime.Now.IsDaylightSavingTime()); // TODO se é horário de verão
    }
  }
}