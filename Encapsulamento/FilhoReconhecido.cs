using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento {
    public class FilhoReconhecido : SubCelebridade {
        public new void MeusAcessos() {
            Console.WriteLine("FilhoReconhecido...");
            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDosOlhos);
            Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitoDeFalar);
            Console.WriteLine(SegredoDeFamilia);
            //Console.WriteLine(UsoMuitoPhotoshop); // esse atributo é privado.
        }
    }
}
