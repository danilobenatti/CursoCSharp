using System;
using System.Globalization;

namespace CursoCSharp {
    internal class OperadoresAritmeticos {
        public static void Executar() {
            var preco = 1000;
            var imposto = 355;
            var desconto = 0.1;

            double subtotal = preco + imposto;
            var total = subtotal - (subtotal * desconto);
            Console.WriteLine($"O preço final é {total}");
            Console.WriteLine("O preço em real {0}", total.ToString("C2", CultureInfo.CreateSpecificCulture("pt-BR")));

            // IMC
            double peso = 86.6;
            double altura = 1.84;
            double imc = peso / Math.Pow(altura, 2);
            Console.WriteLine($"Indice de Massa Corporea: {imc}");

            // par ou impar
            var num = 24;
            if (num%2 == 0) {
                Console.WriteLine("O número {0} é par.", num);
            } else {
                Console.WriteLine("O número {0} é impar.", num);
            }
        }
    }
}