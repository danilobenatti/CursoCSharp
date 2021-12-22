using System;

namespace CursoCSharp.ClassesEMetodos {
    class ParametroPadrao {
        public static int Somar(int a = 1, int b = 2) {
            return a + b;
        }
        public static void Executar() {
            Console.WriteLine(Somar(10, 23));
            Console.WriteLine(Somar(10));
            Console.WriteLine(Somar());
            Console.WriteLine(Somar(a: 20));
            Console.WriteLine(Somar(b: 30));
        }
    }
}