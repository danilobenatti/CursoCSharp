using System;

namespace CursoCSharp.EstruturasDeControle {
    class EstruturaFor {
        public static void Executar() {
            //int i = 1;
            //while (i <= 10) {
            //    System.Console.WriteLine($"O valor de i é {i}.");
            //    i++;
            //}
            //for (int j = 0; j < 10; j++) {
            //    System.Console.WriteLine($"Usando for i é {i}.");
            //}

            double somatorio = 0;
            string entrada;

            Console.Write("Informe o tamanho da turma: ");
            entrada = Console.ReadLine();
            int.TryParse(entrada, out int tamanhoDaTurma);
            for (int i = 1; i <= tamanhoDaTurma; i++) {
                Console.Write($"Informe a nota do aluno: {i}: ");
                entrada = Console.ReadLine();
                double.TryParse(entrada, out double notaAtual);

                somatorio += notaAtual;
            }

            double media = tamanhoDaTurma > 0 ? somatorio / tamanhoDaTurma : 0;
            Console.WriteLine($"Média da turma é: {media}");
        }
    }
}