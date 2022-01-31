﻿using System;
using System.Collections.Generic;

namespace CursoCSharp.POO {
    interface Teste {
        bool Bla(string a);
    }
    interface OperacaoBinaria {
        int Operacao(int a, int b);
    }
    class Soma : OperacaoBinaria, Teste {
        public int Operacao(int a, int b) {
            return a + b;
        }
        public bool Bla(string teste) {
            return true;
        }
    }
    class Subtracao : OperacaoBinaria {
        public int Operacao(int a, int b) {
            return a - b;
        }
    }
    class Multiplica : OperacaoBinaria {
        public int Operacao(int a, int b) {
            return (a * b);
        }
    }
    class Calculadora {
        List<OperacaoBinaria> operacoes = new List<OperacaoBinaria> {
            new Soma(),
            new Subtracao(),
            new Multiplica(),
        };
        public string ExecutarOperacoes(int a, int b) {
            string result = "";
            foreach (var op in operacoes) {
                result += $"Usando {op.GetType().Name} = {op.Operacao(a, b)}\n";
            }
            return result;
        }
    }
    class Interface {
        public static void Executar() {
            var calc = new Calculadora();
            var result = calc.ExecutarOperacoes(20, 5);
            Console.WriteLine(result);
        }
    }
}