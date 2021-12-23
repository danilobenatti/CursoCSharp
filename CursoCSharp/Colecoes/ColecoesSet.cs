using System;
using System.Globalization;
using System.Collections.Generic;

namespace CursoCSharp.Colecoes {
    class ColecoesSet {
        public static void Executar() {
            var livro = new Produto() { nome = "G.O.T.", preco = 59.9 };
            var carrinho = new HashSet<Produto>();
            carrinho.Add(livro);

            ExibeCarrinho(carrinho);

            var combo = new HashSet<Produto>() {
                new Produto() { nome = "Camiseta Promo G.O.T.", preco = 41.6 },
                new Produto() { nome = "Box G.O.T Temp 1,2,3,4,5,6", preco = 190.87},
                new Produto() {nome = "Garrafa Smoothie G.O.T.", preco = 32.15}
            };
            //carrinho.AddRange(combo);
            carrinho.UnionWith(combo);

            ExibeCarrinho(carrinho);
            Console.WriteLine(carrinho.Count);
            //carrinho.RemoveAt(3);
            carrinho.Remove(livro);

            ExibeCarrinho(carrinho);

            Console.WriteLine(carrinho.Count);
            carrinho.Add(livro);
            Console.WriteLine(carrinho.Count);
            //Console.WriteLine(carrinho.LastIndexOf(livro));

            ExibeCarrinho(carrinho);

            static void ExibeCarrinho(HashSet<Produto> carrinho) {
                double total = 0;
                foreach (var item in carrinho) {
                    //Console.Write($"({carrinho.IndexOf(item)}) ");
                    Console.WriteLine($"Produto: {item.nome} - preço: {item.preco}");
                    total += item.preco;
                }
                CultureInfo culture = new CultureInfo("pt-BR");
                Console.WriteLine($"Valor total da lista: {total.ToString("C2", culture)}");
                Console.WriteLine("------------------------------");
            }
        }
    }
}