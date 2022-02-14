using System;

namespace CursoCSharp.API {
    class ExemploTimeSpan {
        public static void Executar() {
            var intervalo = new TimeSpan(days: 10, hours: 20, minutes: 30, seconds: 40, milliseconds: 800);
            Console.WriteLine(intervalo);
            Console.WriteLine($"Dias: {intervalo.Days}");
            Console.WriteLine($"Horas: {intervalo.Hours}");
            Console.WriteLine($"Minutos: {intervalo.Minutes}");
            Console.WriteLine($"Segundos: {intervalo.Seconds}");
            Console.WriteLine($"Milisegundos: {intervalo.Milliseconds}");
            Console.WriteLine($"Total em minutos: {intervalo.TotalMinutes}");

            var largada = DateTime.Now;
            //var chegada = DateTime.Now.AddMinutes(15);
            var chegada = largada.AddMinutes(15);
            Console.WriteLine($"Hora da chegada: {chegada}");

            var tempo = chegada - largada;
            Console.WriteLine($"Duração: {tempo}");

            Console.WriteLine(intervalo.Add(TimeSpan.FromMinutes(8)));
            Console.WriteLine(intervalo.Add(TimeSpan.FromMinutes(-8)));
            Console.WriteLine(intervalo.Subtract(TimeSpan.FromMinutes(8)));

            Console.WriteLine("ToString1: {0}", intervalo.ToString("g"));
            Console.WriteLine("ToString2: {0}", intervalo.ToString("G"));
            Console.WriteLine("ToString3: {0}", intervalo.ToString("c"));

            Console.WriteLine("Parse: " + TimeSpan.Parse("15:30:45").TotalHours);
            Console.WriteLine("Parse: " + TimeSpan.Parse("15:30:45").TotalMinutes);
            Console.WriteLine("Parse: " + TimeSpan.Parse("15:30:45").TotalSeconds);
            Console.WriteLine("Parse: " + TimeSpan.Parse("15:30:45").TotalMilliseconds);
            Console.WriteLine("Parse: " + TimeSpan.Parse("15:30:45").TotalDays);
        }
    }
}