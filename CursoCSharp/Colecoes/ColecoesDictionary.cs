using System;
using System.Collections.Generic;

namespace CursoCSharp.Colecoes {
    class ColecoesDictionary {
        public static void Executar() {
            var filmes = new Dictionary<int, string>();
            filmes.Add(2000, "American Beauty");
            filmes.Add(2002, "Uma Mente Brilhante");
            filmes.Add(2004, "O Senhor dos Anéis - O retorno do Rei");
            filmes.Add(2006, "Crash - No Limite");

            if (filmes.ContainsKey(2004)) {
                Console.WriteLine("2004: {0}", filmes[2004]);
                Console.WriteLine("2004: {0}", filmes.GetValueOrDefault(2004));
            }
            Console.WriteLine(filmes.ContainsValue("Filme 4"));
            Console.WriteLine($"Removeu? {filmes.Remove(2004)}");

            Console.WriteLine(filmes.Values.Count);

            filmes.TryGetValue(2006, out string filme2006);
            Console.WriteLine($"Filme: {filme2006}!");

            foreach (var chave in filmes.Keys) {
                Console.WriteLine(chave);
            }
            foreach (var valor in filmes.Values) {
                Console.WriteLine(valor);
            }
            foreach (KeyValuePair<int, string> filme in filmes) {
                Console.WriteLine(filme);
                Console.WriteLine($"Oscar {filme.Key}, Filme: {filme.Value}");
            }
            foreach (var filme in filmes) {
                Console.WriteLine($"Oscar {filme.Key}, Filme: {filme.Value}");
            }
        }
    }
}