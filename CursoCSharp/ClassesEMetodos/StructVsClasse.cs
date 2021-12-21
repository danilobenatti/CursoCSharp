using System;

namespace CursoCSharp.ClassesEMetodos {
    public struct SPonto {
        public int X;
        public int Y;
    }
    public class CPonto {
        public int X;
        public int Y;
    }
    class StructVsClasse {
        public static void Executar() {
            var ponto1 = new SPonto() { X = 1, Y = 3 };
            var copiaPonto1 = ponto1; // Atribuição por VALOR!!!
            ponto1.X = 3;

            Console.WriteLine(value: "--- Struct ---");
            Console.WriteLine(value: $"Ponto 1 X: {ponto1.X}");
            Console.WriteLine(value: $"Copia Ponto 1 X: {copiaPonto1.X}");

            var ponto2 = new CPonto() { X = 2, Y = 4 };
            var copiaPonto2 = ponto2; // Atribuição por REFÊRENCIA!!!
            ponto2.X = 4;

            Console.WriteLine(value: "--- Class ---");
            Console.WriteLine(value: $"Ponto 2 X: {ponto2.X}");
            Console.WriteLine(value: $"Copia Ponto 2 X: {copiaPonto2.X}");
        }
    }
}