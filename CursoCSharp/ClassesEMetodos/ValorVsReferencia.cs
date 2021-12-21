using System;

namespace CursoCSharp.ClassesEMetodos {
    public class Dependente { // public struct Dependente {
        public string Nome;
        public int Idade;
    }
    class ValorVsReferencia {
        public static void Executar() {
            int numero = 3;
            int copiaNumero = numero;
            Console.WriteLine($"{numero} - {copiaNumero}");
            numero++;
            Console.WriteLine($"{numero} - {copiaNumero}");

            Dependente dependente = new Dependente { Nome = "João", Idade = 20 };
            Dependente dependenteCopia = dependente;
            Console.WriteLine($"{dependente.Nome} {dependenteCopia.Nome}");
            Console.WriteLine($"{dependente.Idade} {dependenteCopia.Idade}");

            dependenteCopia.Nome = "Renato";
            dependente.Idade = 25;

            Console.WriteLine($"{dependente.Nome} {dependenteCopia.Nome}");
            Console.WriteLine($"{dependente.Idade} {dependenteCopia.Idade}");
        }
    }
}