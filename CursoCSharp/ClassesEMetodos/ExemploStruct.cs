using System;

namespace CursoCSharp.ClassesEMetodos {
    interface ponto {
        void MoverNaDiagonal(int delta);
    }
    struct Coordenada : ponto {
        public int X, Y;
        public Coordenada(int x, int y) {
            X = x;
            Y = y;
        }
        public void MoverNaDiagonal(int delta) {
            X += delta;
            Y += delta;
        }
    }
    class ExemploStruct {
        public static void Executar() {
            Coordenada coordenadaInicial;
            coordenadaInicial.X = 2;
            coordenadaInicial.Y = 2;
            Console.WriteLine("Coordenada inicial: ");
            Console.WriteLine($"X = {coordenadaInicial.X}");
            Console.WriteLine($"Y = {coordenadaInicial.Y}");

            var coordenadaFinal = new Coordenada() { X = 9, Y = 1 };
            coordenadaFinal.MoverNaDiagonal(10);

            Console.WriteLine("Coordenada final: ");
            Console.WriteLine($"X = {coordenadaFinal.X}");
            Console.WriteLine($"Y = {coordenadaFinal.Y}");
        }
    }
}