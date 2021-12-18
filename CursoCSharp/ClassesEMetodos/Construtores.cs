using System;

namespace CursoCSharp.ClassesEMetodos {
    class Carro {
        public string Modelo;
        public string Fabricante;
        public int Ano;

        public Carro() { }

        public Carro(string modelo, string fabricante, int ano) {
            Modelo = modelo;
            Fabricante = fabricante;
            Ano = ano;
        }
    }
    class Construtores {
        public static void Executar() {
            var carro1 = new Carro() { Modelo = "Gol", Fabricante = "Volkswagen", Ano = 2005 };
            //carro1.Modelo = "Gol";
            //carro1.Fabricante = "Volkswagen";
            //carro1.Ano = 2005;
            Console.WriteLine($"{carro1.Modelo} / {carro1.Fabricante} / {carro1.Ano}");

            var carro2 = new Carro("KA", "Ford", 2011);
            Console.WriteLine($"{carro2.Modelo} / {carro2.Fabricante} / {carro2.Ano}");
        }
    }
}