using System;

namespace CursoCSharp.ClassesEMetodos {

    public class Produto {
        public string Nome;
        public double Preco;
        public static double Desconto = 10; //valor: 10%

        //public Produto(string nome, double preco, double desconto) {
        //    Nome = nome;
        //    Preco = preco;
        //    Desconto = desconto;
        //}
        // ou
        public Produto(string Nome, double Preco, double Desconto) {
            this.Nome = Nome;
            this.Preco = Preco;
            //this.Desconto = Desconto;
        }
        public Produto() { }
        public double CalcularPrecoComDesconto() {
            return Preco - Preco * (Desconto/100);
        }
    }
    class AtributosEstaticos {

        public static void Executar() {
            Produto.Desconto = 50;

            var produto1 = new Produto() { Nome = "Caneta", Preco = 10.00 };
            var produto2 = new Produto();
            produto2.Nome = "Lápis";
            produto2.Preco = 1.50;
            //produto2.Desconto = 2;
            var produto3 = new Produto("Borracha", 5.00, 3);
            Console.WriteLine($"Desconto produto1 - {produto1.Nome}: {produto1.CalcularPrecoComDesconto()}");
            Console.WriteLine($"Desconto produto2 - {produto2.Nome}: {produto2.CalcularPrecoComDesconto()}");
            Console.WriteLine($"Desconto produto3 - {produto3.Nome}: {produto3.CalcularPrecoComDesconto()}");

        }
    }
}