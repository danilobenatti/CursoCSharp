using System;

namespace CursoCSharp.ClassesEMetodos {
    class DesafioAtributo {

        int a = 10;

        public static void Executar() {
            // Desafio: acessar a variável 'a' de dentro do método 'Executar()'.
            var desafio = new DesafioAtributo();
            Console.WriteLine(value: $"O valor de 'a' é: {desafio.a}");
        }
    }
}