using System;

namespace CursoCSharp.ClassesEMetodos {
    class Membros {
        public static void Executar() {
            Pessoa pessoa1 = new Pessoa();
            pessoa1.Nome = "João";
            pessoa1.Idade = 38;
            pessoa1.Sexo = 'M';
            pessoa1.Ativo = true;

            var pessoa2 = new Pessoa() { Nome = "Maria", Idade = 35, Sexo = 'F', Ativo = false };

            Console.WriteLine($"Apresentação de { pessoa1.Nome}");
            pessoa1.ApresentarNoConsole();
            Console.WriteLine($"Apresentação de { pessoa2.Nome}");
            pessoa2.ApresentarNoConsole();
        }
    }
}
