using System;

namespace CursoCSharp.Fundamentos {
    class VariaveisEConstantes {
        public static void Executar() {
            // Área de uma circunferência
            double raio = 4.5;
            // const double PI = 3.14;
            double area = Math.Pow(raio, 2) * Math.PI;
            Console.WriteLine(area);

            raio = 5.5;
            area = Math.Pow(raio, 2) * Math.PI;
            Console.WriteLine("Área do círculo é " + Math.Round(area, 2));

            bool estaChovendo = true;
            Console.WriteLine("Está chovendo " + estaChovendo);

            byte idade = 45;
            Console.WriteLine("Idade " + idade);

            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("Saldo de Gols " + saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("Salário " + salario);

            int menorValorInt = int.MinValue;
            Console.WriteLine("Menor valor de um INT é " + menorValorInt); // mais usado dos inteiros!

            uint populacaoBrasileira = 212_600_000;
            Console.WriteLine("População brasileira é de " + populacaoBrasileira + " pessoas");

            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor long " + menorValorLong);

            ulong populacaoMundial = 7_800_000_000;
            Console.WriteLine("População mundial é de " + populacaoMundial + " pessoas");

            float precoComputador = 1299.99f;
            Console.WriteLine("Preço do computador é de R$" + precoComputador);

            double valorDeMercadoDaApple = 2_400_000_000_000.00;
            Console.WriteLine("Valor de mercado da Apple US$" + valorDeMercadoDaApple); // mais usado dos reais!

            decimal distanciaEntreEstrelas = decimal.MaxValue;
            Console.WriteLine("Distância entre as estrelas " + distanciaEntreEstrelas);

            char letra = 'b';
            Console.WriteLine("Letra " + letra);

            string texto = "Seja bem vindo ao curso de C#!";
            Console.WriteLine(texto);
        }
    }
}
