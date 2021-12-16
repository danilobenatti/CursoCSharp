﻿using System;

namespace CursoCSharp {
    class EstruturaSwitch {
        public static void Executar() {
            Console.Write("Avalie meu atendimento com uma nota de 0 a 5: ");
            int.TryParse(Console.ReadLine(), out int nota);

            switch (nota) {
                case 0:
                    Console.WriteLine("Péssimo");
                    break;
                case 1:
                case 2:
                    Console.WriteLine("Ruim");
                    break;
                case 3:
                    Console.WriteLine("Médio");
                    break;
                case 4:
                    Console.WriteLine("Bom");
                    break;
                case 5:
                    Console.WriteLine("Muito Bom");
                    Console.WriteLine("Excelente!!!");
                    break;
                default:
                    Console.WriteLine("Nota inválida!");
                    break;
            }
            Console.WriteLine("Obrigado por responder a pesquisa.");
        }
    }
}