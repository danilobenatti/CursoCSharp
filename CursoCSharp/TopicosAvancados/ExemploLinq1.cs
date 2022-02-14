using System;
using System.Collections.Generic;
using System.Linq;

namespace CursoCSharp.TopicosAvancados {
    public class Aluno {
        public string Nome;
        public int Idade;
        public double Nota;
    }
    class ExemploLinq1 {
        public static void Executar() {
            var alunos = new List<Aluno> {
                new Aluno() {Nome = "Pedro", Idade = 15, Nota = 7.5 },
                new Aluno() {Nome = "André", Idade = 18, Nota = 9.0 },
                new Aluno() {Nome = "Ana Paula", Idade = 13, Nota = 8.25 },
                new Aluno() {Nome = "Jorge", Idade = 11, Nota = 6.75 },
                new Aluno() {Nome = "Ana Maria", Idade = 17, Nota = 9.25 },
                new Aluno() {Nome = "Julia", Idade = 16, Nota = 10.0 },
                new Aluno() {Nome = "Marcio", Idade = 12, Nota = 5.5 }
            };

            Console.WriteLine("\n===== Filtrar por Idade =====");
            var aprovados1 = alunos.Where(a => a.Idade >= 16).OrderBy(a => a.Idade);
            foreach (var aluno in aprovados1) {
                Console.WriteLine($"Aluno: {aluno.Nome}, Idade: {aluno.Idade}");
            }

            Console.WriteLine("\n===== Aprovados =====");
            var aprovados2 = alunos.Where(a => a.Nota >= 8).OrderByDescending(a => a.Nota);
            foreach (var aluno in aprovados2) {
                Console.WriteLine($"Aluno: {aluno.Nome}, Nota: {aluno.Nota}");
            }

            Console.WriteLine("\n===== Aprovados (por idade) =====");
            var alunosAprovados = from a in alunos where a.Nota >= 7 orderby a.Idade select a.Nome;
            foreach (var aluno in alunosAprovados) {
                Console.WriteLine($"Nome do aluno: {aluno}");
            }

            Console.WriteLine("\n===== Ordem de Chamada =====");
            var chamada = alunos.OrderBy(a => a.Nome).Select(a => a.Nome);
            var num = 0;
            foreach (string nomeAluno in chamada) {
                num++;
                Console.WriteLine($"Aluno n°{num}: {nomeAluno}");
            }
        }
    }
}