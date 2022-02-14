using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace CursoCSharp.TopicosAvancados {
    class ExemploLinq2 {
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

            var todos = alunos.Where(a => a.Nota > 0);
            foreach (var aluno in todos) {
                Console.WriteLine($"Nome: {aluno.Nome}, Idade: {aluno.Idade}, Nota: {aluno.Nota}");
            };

            var pedro = alunos.Single(aluno => aluno.Nome.Equals("Pedro"));
            Console.WriteLine($"Aluno {pedro.Nome} tem nota {pedro.Nota}");

            var fulano = alunos.SingleOrDefault(aluno => aluno.Nome.Equals("Fulano"));
            if (fulano == null) {
                Console.WriteLine("Aluno Inexistente!");
            }

            var anaPaula = alunos.First(aluno => aluno.Nome.Equals("Ana Paula"));
            Console.WriteLine(anaPaula.Nota);

            var sicrano = alunos.FirstOrDefault(aluno => aluno.Nome.Equals("Sicrano"));
            if (sicrano == null) {
                Console.WriteLine("Aluno Inexistente!");
            }

            var ana = alunos.LastOrDefault(aluno => aluno.Nome.Contains("Ana"));
            if (ana != null) {
                Console.WriteLine($"{ana.Nome} {ana.Nota}");
            } else {
                Console.WriteLine("Aluno Inexistente!");
            }

            var exemploSkip = alunos.Skip(1).Take(3);
            foreach (var item in exemploSkip) {
                Console.WriteLine(item.Nome);
            }

            var maiorNota = alunos.Max(a => a.Nota);
            if (!maiorNota.Equals(null) && maiorNota > 0 && !maiorNota.Equals("")) {
                Console.WriteLine($"A maior nota foi {maiorNota}");
            }

            var menorNota = alunos.Min(a => a.Nota);
            if (!menorNota.Equals(null) && menorNota > 0 && !menorNota.Equals("")) {
                Console.WriteLine($"A menor nota foi {menorNota}");
            }

            var somatorioNotas = alunos.Sum(a => a.Nota);
            var mediaNotas1 = somatorioNotas / alunos.Count();
            var mediaNotas2 = alunos.Average(aluno => aluno.Nota);
            Console.WriteLine(value: $"A média1 foi: {mediaNotas1:#.##}");
            Console.WriteLine(value: $"A média2 foi: {mediaNotas2:#.##}");

            var mediaNotasAprovados = alunos.Where(aluno => aluno.Nota >= 7).Average(aluno => aluno.Nota);
            Console.WriteLine($"A média dos aprovados foi: {mediaNotasAprovados:#.##}");
        }
    }
}