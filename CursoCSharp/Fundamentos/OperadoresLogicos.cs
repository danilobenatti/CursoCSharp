using System;

namespace CursoCSharp.Fundamentos {
    class OperadoresLogicos {
        public static void Executar() {
            var executouTrabalho1 = true;
            var executouTrabalho2 = false;

            bool comprouTv50 = executouTrabalho1 && executouTrabalho2; //AND
            Console.WriteLine($"Comprou TV 50pol? {comprouTv50}");

            bool comprouSorvete = executouTrabalho1 || executouTrabalho2; //OR
            Console.WriteLine($"Comprou Sorvete? {comprouSorvete}");

            bool comprouTv32 = executouTrabalho1 ^ executouTrabalho2; //XOR
            Console.WriteLine($"Comprou TV 32pol? {comprouTv32}");

            Console.WriteLine($"Mais saudável? {!comprouSorvete}");
        }
    }
}