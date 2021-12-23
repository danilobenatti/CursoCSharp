using System;
using System.Collections;
using System.Collections.Generic;

namespace CursoCSharp.Colecoes {
    class ColecoesQueue {
        public static void Executar() {
            var fila = new Queue<string>();
            fila.Enqueue("Fulano");
            fila.Enqueue("Sicrano");
            fila.Enqueue("Beltrano");
            fila.Enqueue("Beltrano");

            foreach (var pessoa in fila) {
                Console.WriteLine(pessoa);
            }

            Console.WriteLine(fila.Peek());
            Console.WriteLine(fila.Count);
            Console.WriteLine(fila.Dequeue());
            Console.WriteLine(fila.Count);
            Console.WriteLine(fila.Peek());

            foreach (var pessoa in fila) {
                Console.WriteLine(pessoa);
            }

            var exemplo = new Queue();
            exemplo.Enqueue("Texto");
            exemplo.Enqueue('A');
            exemplo.Enqueue(100);
            exemplo.Enqueue(50.5);
            exemplo.Enqueue(true);
            Console.WriteLine(exemplo.Contains("texto"));
            Console.WriteLine(exemplo.Contains("Texto"));
        }
    }
}