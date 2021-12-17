using System;

namespace CursoCSharp.Fundamentos {
    class OperadoresRelacionais {
        public static void Executar() {
            // double nota = 6.0;
            double notaDeCorte = 7.0;
            Console.Write("Digite uma nota: ");
            double.TryParse(Console.ReadLine(), out double nota);

            Console.WriteLine("Nota inválida? {0}", arg0: nota > 10.0);
            Console.WriteLine("Nota inválida? {0}", arg0: nota < 0.0);
            Console.WriteLine("Nota máxima? {0}", arg0: nota == 10.0);
            Console.WriteLine("Tem como melhorar? {0}", arg0: nota != 10.0);
            Console.WriteLine("Passou por média? {0}", arg0: nota >= notaDeCorte);
            Console.WriteLine("Recuperação? {0}", arg0: nota < notaDeCorte);
            Console.WriteLine("Reprovado? {0}", arg0: nota <= 3.0);
        }
    }
}