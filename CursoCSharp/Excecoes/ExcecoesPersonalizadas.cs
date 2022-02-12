using System;

namespace CursoCSharp.Excecoes {
    public class NegaticoException : Exception {
        public NegaticoException() { }
        public NegaticoException(string message) : base(message) { }
        public NegaticoException(String message, Exception inner) : base(message, inner) { }
    }
    public class ImparException : Exception {
        public ImparException(string message) : base(message) { }
    }
    class ExcecoesPersonalizadas {
        public static int PositivoPar() {
            Random random = new Random();
            int valor = random.Next(-30, 30);
            if (valor < 0) {
                throw new NegaticoException($"Valor {valor} é negativo! :(");
            }
            if (valor % 2 == 1) {
                throw new ImparException($"Valor {valor} é ímpar! :(");
            }
            return valor;
        }
        public static void Executar() {
            try {
                Console.WriteLine(PositivoPar());
            } catch (NegaticoException ex) {
                Console.WriteLine(ex.Message);
            } catch (ImparException ex) {
                Console.WriteLine(ex.Message);
            } catch {
                Console.WriteLine("Erro inesperado");
            }
        }
    }
}