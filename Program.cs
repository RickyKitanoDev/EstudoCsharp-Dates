using System;
using System.Globalization;

namespace Date
{
    class Program
    {
        static void Main(string[] args)
        {
            //DATAS - TRABALHANDO COM DATAS
            Console.Clear();

            //var data = new DateTime(); // CRIAR DATA PADRÃO
            //var data = DateTime.Now; // NOW = DATA ATUAL
            //var data = new DateTime(2021, 8, 24, 9, 35, 0); //ANO,MES,DIA,HORA,MINUTO,SEGUNDO

            // Console.WriteLine(data);
            // Console.WriteLine(data.Year); //ANO
            // Console.WriteLine(data.Month); // MÊS
            // Console.WriteLine(data.Day); // DATA
            // Console.WriteLine(data.Hour); // HORAS
            // Console.WriteLine(data.Minute); // MINUTOS
            // Console.WriteLine(data.Second); // SEGUNDOS

            // Console.WriteLine(data.DayOfWeek); // DIA DA SEMANA
            // Console.WriteLine((int)data.DayOfWeek); // DIA DA SEMANA COMO ENUM
            // Console.WriteLine(data.DayOfYear); // DIA DO ANO

            // var data = DateTime.Now;

            // Y = ano, M = mes, d = dia, H = hora, mm = minuto, s = segundo, z = time zone
            // t = tempo compactado
            // d = Menor data possível
            // D = Data por extenso
            // T = tempo longo
            // f = Combina data e hora
            // g = combina data e hora no short
            // r = Data padronizada
            // s = mongle , usa formato com t
            // u = Padrão Json
            // var formatada = String.Format("{0:u}", data);

            // Console.WriteLine(data);


            // Console.WriteLine(data.AddDays(12)); // Add.Days() - Adiciona dias


            // Console.WriteLine(data.AddMonths(1)); // Add.Months() - Adiciona meses


            // Console.WriteLine(data.AddYears(1)); // Add.Years() - Adiciona anos

            // Console.WriteLine(data.AddHours(2)); // Add.Hours() - Adiciona horas

            //if(data == DateTime.Now) // NUNCA VAI FUNCIONAR, POIS NÃO SERÁ IGUAL, DEVIDO FRAÇÃO DE SEGUNDOS ETC;
            // if(data.Date == DateTime.Now.Date) // restringindo a data.
            // {
            //     Console.WriteLine("É igual");
            // }

            // var pt = new CultureInfo("pt-PT");
            // var br = new CultureInfo("pt-BR");
            // var en = new CultureInfo("en-US");
            // var de = new CultureInfo("de-DE");
            // var atual = CultureInfo.CurrentCulture; // CULTURA ATUAL

            // Console.WriteLine(DateTime.Now.ToString("D", atual ));

            var utcDate = DateTime.UtcNow; //HORÁRIO GLOBAL


            // Console.WriteLine(DateTime.Now);

            // Console.WriteLine(utcDate);

            // Console.WriteLine(utcDate.ToLocalTime());



            // var timezoneAustralia = TimeZoneInfo.FindSystemTimeZoneById("New Zealand Standard Time");

            /*foreach (TimeZoneInfo timeZone in TimeZoneInfo.GetSystemTimeZones()){  
                Console.WriteLine(timeZone.Id); 
                System.Console.WriteLine("------------------");
                Console.WriteLine(timeZone.StandardName); 
            }  */

            // Console.WriteLine(timezoneAustralia);

            // var horaAustralia = TimeZoneInfo.ConvertTimeFromUtc(utcDate, timezoneAustralia);
            // Console.WriteLine(horaAustralia);

            // var timezones = TimeZoneInfo.GetSystemTimeZones();
            // foreach(var timezone in timezones)
            // {
            //     Console.WriteLine(timezone.Id);
            //     Console.WriteLine(timezone);
            //     Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(utcDate, timezone));
            //     Console.WriteLine("------------------");
            // }


            // DaysInMonth - FUNÇÃO PARA SABER A QUANTIDADE DE DIAS EM UM DETERMINADO MÊS
            //Console.WriteLine(DateTime.DaysInMonth(2021, 8)); // 31 dias no mês Agosto de 2021.

            // Console.WriteLine(IsWeekend(DateTime.Now.DayOfWeek)); // RETORNA SE É FINAL DE SEMANA
            // Console.WriteLine(DateTime.Now.IsDaylightSavingTime()); // SABER SE ESTÁ EM HORÁRIO DE VERÃO

            // var timeSpan = new TimeSpan();
            // Console.WriteLine(timeSpan);

            // var  timeSpanNanosegundos = new TimeSpan(1);
            // Console.WriteLine(timeSpanNanosegundos);

            // var timeSpanHoraMinutoSegundo = new TimeSpan(12, 24, 30);
            // Console.WriteLine(timeSpanHoraMinutoSegundo);
            

            

        }
        // static bool IsWeekend(DayOfWeek today)
        // {
        //     return today == DayOfWeek.Saturday || today == DayOfWeek.Sunday;
        // }


    }
}
