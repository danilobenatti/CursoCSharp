using System;

namespace CursoCSharp.ClassesEMetodos {
    class ParametrosPorReferencia {
        public static void AlterarRef(ref int numero) {
            numero += 1000;
        }
        public static void AlterarOut(out int numero1, out int numero2) {
            numero1 = 0;
            numero2 = 0;
            numero1 += 15;
            numero2 += 30;
        }
        public static void Executar() {
            int a = 3;
            AlterarRef(numero: ref a);
            Console.WriteLine(value: a);

            AlterarOut(numero1: out int b, numero2: out int c);
            Console.WriteLine($"{b} {c}");
        }
    }
}