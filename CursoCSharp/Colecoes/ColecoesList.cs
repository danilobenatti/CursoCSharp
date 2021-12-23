using System;
using System.Globalization;
using System.Collections.Generic;

namespace CursoCSharp.Colecoes {
    public class Produto {
        public string Nome;
        public double Preco;
        public Produto() {
        }
        public Produto(string nome, double preco) {
            this.Nome = nome;
            this.Preco = preco;
        }
        public override bool Equals(object obj) {
            return obj is Produto produto &&
                   Nome == produto.Nome &&
                   Preco == produto.Preco;
        }
        public override int GetHashCode() {
            return HashCode.Combine(Nome, Preco);
        }
        //public override bool Equals(object obj) {
        //    var outroProduto = (Produto)obj;
        //    bool mesmoNome = Nome == outroProduto.Nome;
        //    bool mesmoPreco = Preco == outroProduto.Preco;
        //    return mesmoNome && mesmoPreco;
        //}
        //public override int GetHashCode() {
        //    return Nome.Length;
        //}
    }
    class ColecoesList {
        public static void Executar() {
            var livro = new Produto() { Nome = "G.O.T.", Preco = 59.9 };
            var carrinho = new List<Produto>();
            carrinho.Add(livro);

            var combo = new List<Produto>() {
                new Produto() { Nome = "Camiseta Promo G.O.T.", Preco = 41.6 },
                new Produto() { Nome = "Box G.O.T Temp 1,2,3,4,5,6", Preco = 190.87 },
                new Produto() { Nome = "Garrafa Smoothie G.O.T.", Preco = 32.15 },
                new Produto() { Nome = "Garrafa Smoothie G.O.T.", Preco = 32.15 }
            };
            carrinho.AddRange(combo);
            Console.WriteLine(carrinho.Count);
            carrinho.RemoveAt(3);

            ExibeCarrinho(carrinho);

            Console.WriteLine(carrinho.Count);
            carrinho.Add(livro);
            Console.WriteLine(carrinho.LastIndexOf(livro));

            ExibeCarrinho(carrinho);

            static void ExibeCarrinho(List<Produto> carrinho) {
                double total = 0;
                foreach (var item in carrinho) {
                    Console.Write($"({carrinho.IndexOf(item)}) ");
                    Console.WriteLine($"Produto: {item.Nome} - preço: {item.Preco}");
                    total += item.Preco;
                }
                CultureInfo culture = new CultureInfo("pt-BR");
                Console.WriteLine($"Valor total da lista: {total.ToString("C2", culture)}");
                Console.WriteLine("------------------------------");
            }
        }
    }
}