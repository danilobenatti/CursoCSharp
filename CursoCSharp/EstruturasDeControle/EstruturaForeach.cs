using System;

namespace CursoCSharp.EstruturasDeControle {
    class EstruturaForEach {
        public static void Executar() {
            var palavra = "Opa!";

            foreach (var letra in palavra) {
                Console.WriteLine(letra);
            }

            var alunos = new string[] { "Ana", "Maria", "Carlos" };
            foreach (var nome in alunos) {
                Console.WriteLine(nome);
            }

        }
    }
}