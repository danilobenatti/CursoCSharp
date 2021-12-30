using System;
using Encapsulamento;

namespace CursoCSharp.POO {
    public class FilhoNaoReconhecido : SubCelebridade {
        public new void MeusAcessos() {
            Console.WriteLine("FilhoNaoReconhecido...");
            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDosOlhos);
            //Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitoDeFalar);
            //Console.WriteLine(SegredoDeFamilia);
            //Console.WriteLine(UsoMuitoPhotoshop);
        }
    }
    public class AmigoDistante {
        public readonly SubCelebridade amiga = new SubCelebridade();
        public void MeusAcessos() {
            Console.WriteLine("AmigoDistante...");
            Console.WriteLine(amiga.InfoPublica);
            //Console.WriteLine(amiga.CorDosOlhos);
            //Console.WriteLine(amiga.NumeroCelular);
            //Console.WriteLine(amiga.JeitoDeFalar);
            //Console.WriteLine(amiga.SegredoDeFamilia);
            //Console.WriteLine(amiga.UsoMuitoPhotoshop);
        }
    }
    class Encapsulamento {
        public static void Executar() {
            SubCelebridade subCelebridade = new SubCelebridade();
            subCelebridade.MeusAcessos();

            new FilhoReconhecido().MeusAcessos();
            new AmigoProximo().MeusAcessos();

            new FilhoNaoReconhecido().MeusAcessos();
            new AmigoDistante().MeusAcessos();
        }
    }
}
