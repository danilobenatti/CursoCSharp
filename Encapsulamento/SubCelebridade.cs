using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento {
    public class SubCelebridade {
        // Acessado por todos.
        public string InfoPublica = "Tenho um LinkedIn!";

        // Transmitido por herança.
        protected string CorDosOlhos = "azul";

        // Mesmo projeto (assembly).
        internal ulong NumeroCelular = 551199998888;

        // Herança ou mesmo projeto.
        protected internal string JeitoDeFalar = "Uso muitas gírias";

        // Mesma class ou herança no mesmo projeto (C# >= 7.2)
        private protected string SegredoDeFamilia = "bla bla bla";

        // private é o padrão
        readonly bool UsoMuitoPhotoshop = true;

        // public
        public void MeusAcessos() {
            Console.WriteLine("SubCelebridade...");
            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDosOlhos);
            Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitoDeFalar);
            Console.WriteLine(SegredoDeFamilia);
            Console.WriteLine(UsoMuitoPhotoshop);
        }
    }
}
