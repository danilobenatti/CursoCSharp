using System;

namespace CursoCSharp.MetodosEFuncoes {
    class DelegatesComoParametros {
        public delegate int Operacao(int x, int y);
        public static int Soma(int x, int y) => x + y;
        public static string Calculadora(Operacao operacao, int x, int y) {
            var resultado = operacao(x, y);
            return $"Resultado: {resultado}";
        }
        public static void Executar() {
            Operacao subtract = (x, y) => x - y;
            Console.WriteLine(Calculadora(subtract, 3, 2));
            Console.WriteLine(Calculadora(Soma, 3, 2));
        }
    }
}