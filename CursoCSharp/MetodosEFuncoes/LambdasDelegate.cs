using System;

namespace CursoCSharp.MetodosEFuncoes {

    delegate double Operacao(double x, double y);

    class LambdasDelegate {
        public static void Executar() {
            Operacao sum = (x, y) => x + y;
            Operacao subt = (x, y) => x - y;
            Operacao div = (x, y) => x / y;
            Operacao mod = (x, y) => x % y;
            Operacao mult = (x, y) => x * y;
            Operacao pow = (x, y) => Math.Pow(x, y);

            Console.WriteLine(sum(2.5, 2.5));
            Console.WriteLine(subt(2.5, 2.5));
            Console.WriteLine(div(2.5, 2.5));
            Console.WriteLine(mod(2.5, 2.5));
            Console.WriteLine(mult(2.5, 2.5));
            Console.WriteLine(pow(2.5, 2.5));
        }
    }
}