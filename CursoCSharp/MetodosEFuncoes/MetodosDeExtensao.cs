using System;

namespace CursoCSharp.MetodosEFuncoes {
    public static class ExtensoesInteiro {
        public static int Soma(this int num1, int num2) {
            return num1 + num2;
        }
        public static double Subtracao(this double num1, int num2) {
            return num1 - num2;
        }
    }
    class MetodosDeExtensao {
        public static void Executar() {
            int numero1 = 5;
            double numero2 = 5.5;

            Console.WriteLine(numero1.Soma(3));
            Console.WriteLine(numero2.Subtracao(10));

            Console.WriteLine(2.Soma(3));
            Console.WriteLine(2.5.Subtracao(3));
        }
    }
}