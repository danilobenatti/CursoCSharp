using System;

namespace CursoCSharp.ClassesEMetodos {
    class ParametrosPorReferencia {
        public static void AlterarRef(ref int numero) {
            numero += 1000;
        }
        public static void AlterarOut(out int numero1, out int numero2) {
            numero1 = 0;
            numero2 = 0;
            numero1 += 15;
            numero2 += 30;
        }
        public static void Executar() {
            int a = 3;
            AlterarRef(numero: ref a);
            Console.WriteLine(value: a);

            AlterarOut(numero1: out int b, numero2: out int c);
            Console.WriteLine($"{b} {c}");

            // Exemplo de utilização do 'out'
            string str = "100";
            if (int.TryParse(str, out int num)) {
                Console.WriteLine($"{num + 1}");
            } else {
                Console.WriteLine("A conversão falhou!");
            }

            // Outro exemplo de utilização do 'out'
            static double calcularMedia(double nota1, double nota2, double nota3, out string conceito) {
                double media = (nota1 + nota2 + nota3) / 3;
                conceito = media >= 7 ? "aprovado" : "reprovado";
                return Math.Round(media, 2);
            }
            double mediaDoAluno = calcularMedia(1.6, 9.4, 5.0, out string conceito);
            Console.WriteLine($"A media é {mediaDoAluno} e o aluno está {conceito}");
        }
    }
}