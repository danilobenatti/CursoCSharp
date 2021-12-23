using System;
using System.Collections;

namespace CursoCSharp.Colecoes {
    class ColecoesStack {
        public static void Executar() {
            var pilha = new Stack();
            pilha.Push(3);
            pilha.Push("texto");
            pilha.Push(true);
            pilha.Push(3.14f);

            ExibirPilha(pilha);

            Console.WriteLine("\n" + pilha.Pop());

            ExibirPilha(pilha);

            Console.WriteLine("\n" + pilha.Peek());

            ExibirPilha(pilha);
        }

        private static void ExibirPilha(Stack pilha) {
            foreach (var item in pilha) {
                Console.Write($"{item} ");
            }
        }
    }
}