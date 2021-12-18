using System;

namespace CursoCSharp.ClassesEMetodos {
    class CalculadoraComum {
        public int Somar(int a, int b) {
            return a + b;
        }
        public int Subtrair(int a, int b) {
            return a - b;
        }
        public int Multiplicar(int a, int b) {
            return a * b;
        }
        public int Dividir(int a, int b) {
            return a / b;
        }
    }
    class MetodosComRetorno {
        public static void Executar() {
            var calculadoraComum = new CalculadoraComum();
            var resultado = calculadoraComum.Somar(25, 5);
            Console.WriteLine(resultado);
            Console.WriteLine(calculadoraComum.Subtrair(25, 5));
            Console.WriteLine(calculadoraComum.Multiplicar(25, 5));
            Console.WriteLine(calculadoraComum.Dividir(25, 5));
        }
    }
}