using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.TopicosAvancados {
    class Nullables {
        static int num3;
        public static void Executar() {
            Nullable<int> num1 = null;
            int? num2 = null;
            Console.WriteLine(num3);

            if (num1.HasValue) {
                Console.WriteLine("Valor de num1: {0}", num1);
            } else {
                Console.WriteLine("A variável num1 não possui valor.");
            }

            int valor = num1 ?? 1000;
            Console.WriteLine(valor);

            bool? bool1 = null;
            bool resultado = bool1.GetValueOrDefault();
            Console.WriteLine(resultado);

            try {
                //int x = num1.Value;
                //int y = num2.Value;
                int x = num1.GetValueOrDefault();
                int y = num2.GetValueOrDefault();
                Console.WriteLine(x + y);
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
