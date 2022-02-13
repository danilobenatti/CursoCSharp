using System;

namespace CursoCSharp.API {
    class ExemploDateTime {
        public static void Executar() {
            var dateTime = new DateTime(year: 2030, month: 2, day: 6);

            Console.WriteLine(dateTime.Day);
            Console.WriteLine(dateTime.Month);
            Console.WriteLine(dateTime.Year);

            // sem horas
            var hoje = DateTime.Today;
            Console.WriteLine(hoje);

            // com horas
            var diaAtual = DateTime.Now;
            Console.WriteLine(diaAtual);
            Console.WriteLine("Hora: " + diaAtual.Hour);
            Console.WriteLine("Minutos: " + diaAtual.Minute);
            Console.WriteLine("Segundos: " + diaAtual.Second);

            var amanha = diaAtual.AddDays(1);
            Console.WriteLine(amanha);

            var ontem = diaAtual.AddDays(-1);
            Console.WriteLine(ontem);

            Console.WriteLine(diaAtual.ToString("D"));
            Console.WriteLine(diaAtual.ToString("d"));
            Console.WriteLine(diaAtual.ToString("dd"));
            Console.WriteLine(diaAtual.ToString("ddd"));
            Console.WriteLine(diaAtual.ToString("dddd"));
            Console.WriteLine(diaAtual.ToString("M"));
            Console.WriteLine(diaAtual.ToString("MM"));
            Console.WriteLine(diaAtual.ToString("MMM"));
            Console.WriteLine(diaAtual.ToString("MMMM"));
            Console.WriteLine(diaAtual.ToString("y"));
            Console.WriteLine(diaAtual.ToString("Y"));
            Console.WriteLine(diaAtual.ToString("yy"));
            Console.WriteLine(diaAtual.ToString("yyy"));
            Console.WriteLine(diaAtual.ToString("yyyy"));
            Console.WriteLine(diaAtual.ToString("yyyyy"));
            Console.WriteLine(diaAtual.ToString("G"));
            Console.WriteLine(diaAtual.ToString("g"));
            Console.WriteLine(diaAtual.ToString("dd-MM-yyyy HH:MM:ss"));
        }
    }
}