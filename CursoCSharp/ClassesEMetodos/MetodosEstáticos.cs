using System;

namespace CursoCSharp.ClassesEMetodos {
    public class CalculadoraEstatica {

        //Método de Classe ou Método Estático.
        public static int Multiplicar(int a, int b) => a * b;
        
        //Método de instância.
        public int Somar(int a, int b) => a + b;
    }
    class MetodosEstáticos {
        public static void Executar() {
            var resultado = CalculadoraEstatica.Multiplicar(2, 3);
            Console.WriteLine($"Resultato da multiplicação: {resultado}");

            var calculadoraEstatica = new CalculadoraEstatica();
            Console.WriteLine($"Resultado da soma: {calculadoraEstatica.Somar(2, 3)}");
        }
    }
}