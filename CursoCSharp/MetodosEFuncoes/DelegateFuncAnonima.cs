using System;

namespace CursoCSharp.MetodosEFuncoes {
    class DelegateFuncAnonima {
        delegate string StringOperacao(string str);
        public static void Executar() {
            StringOperacao inverter = delegate (string str) {
                char[] chars = str.ToCharArray();
                Array.Reverse(chars);
                return new string(chars);
            };
            Console.WriteLine(inverter("C# é show!"));
        }
    }
}