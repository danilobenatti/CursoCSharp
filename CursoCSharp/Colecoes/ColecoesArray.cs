using System;

namespace CursoCSharp.Colecoes {
    class ColecoesArray {
        public static void Executar() {
            var alunos = new string[5];
            alunos[0] = "ALuno 1";
            alunos[1] = "Aluno 2";
            alunos[2] = "Aluno 3";
            alunos[3] = "Aluno 4";
            alunos[4] = "Aluno 5";

            Console.WriteLine("Alunos cadastrados: ");
            foreach (var aluno in alunos) {
                Console.WriteLine(aluno);
            }

            double somatorio = 0;
            double[] notas = { 9.5, 6.0, 7.5, 8.5, 10.0 };
            foreach (var nota in notas) {
                somatorio += nota;
            }
            //for (int i = 0; i < notas.Length; i++) {
            //    somatorio += notas[i];
            //}
            Console.WriteLine($"A média final é: {Math.Round(somatorio / notas.Length, 1)}");

            char[] letras = { 'A', 'r', 'r', 'a', 'y' };
            var palavra = new string(letras);
            Console.WriteLine(palavra);

            string palavraAoContrario = null;
            for (int i = letras.Length - 1; i >= 0; i--) {
                palavraAoContrario += letras[i];
            }
            Console.WriteLine(palavraAoContrario);
        }
    }
}
