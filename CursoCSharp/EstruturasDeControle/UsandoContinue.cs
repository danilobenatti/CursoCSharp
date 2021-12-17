using System;

namespace CursoCSharp.EstruturasDeControle {
    class UsandoContinue {
        public static void Executar() {
            int intervalo = 50;

            Console.WriteLine($"Numeros pares no intervalo de 1 a {intervalo}");

            for (int i = 1; i <= intervalo; i++) {
                if (i % 2 != 0) {
                    continue;
                }
                Console.Write($"{i} ");
            }
        }
    }
}