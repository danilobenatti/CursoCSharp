using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos {
    class FormatandoNumero {
        public static void Executar() {

            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1"));
            Console.WriteLine(valor.ToString("#.##"));
            Console.WriteLine(valor.ToString("C"));
            Console.WriteLine(valor.ToString("P"));

            CultureInfo culture = new CultureInfo("pt-BR");
            Console.WriteLine(valor.ToString("C2", culture));

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10"));
        }
    }
}
