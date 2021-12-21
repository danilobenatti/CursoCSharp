using System;

namespace CursoCSharp.ClassesEMetodos {
    public class Cliente {
        public string Nome;
        public readonly DateTime Nascimento;
        public Cliente(string nome, DateTime nascimento) {
            Nome = nome;
            Nascimento = nascimento;

            Nascimento = new DateTime(2010, 10, 31);
        }
        public string GetDataDeNascimento() {
            return string.Format("{0}/{1}/{2}", Nascimento.Day, Nascimento.Month, Nascimento.Year);
        }
    }

    class Readonly {
        public static void Executar() {
            var novoCliente = new Cliente(nome: "Florinda", nascimento: new DateTime(1910, 08, 05));
            Console.WriteLine(novoCliente.Nome);
            Console.WriteLine(novoCliente.GetDataDeNascimento());
            //novoCliente.Nascimento = new DateTime(2010,10,31);
        }
    }
}