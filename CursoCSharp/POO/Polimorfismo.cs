using System;

namespace CursoCSharp.POO {
    public class Alimento {
        public double Peso;
        public Alimento(double peso) {
            Peso = peso;
        }
        public Alimento() { }
    }
    public class Feijao : Alimento {
    }
    public class Arroz : Alimento {
    }
    public class Carne : Alimento {
    }
    public class Pessoa {
        public double Peso;
        //public void Comer(Feijao feijao) => Peso += feijao.Peso;
        //public void Comer(Arroz arroz) => Peso += arroz.Peso;
        //public void Comer(Carne carne) => Peso += carne.Peso;
        public void Comer(Alimento alimento) => Peso += alimento.Peso;
    }
    class Polimorfismo {
        public static void Executar() {
            var feijao = new Feijao { Peso = 0.30 };
            var arroz = new Arroz { Peso = 0.25 };
            var carne = new Carne { Peso = 0.30 };

            var cliente = new Pessoa { Peso = 80.2 };
            cliente.Comer(feijao);
            cliente.Comer(arroz);
            cliente.Comer(carne);

            Console.WriteLine($"Agora o peso do cliente é {cliente.Peso}!");
        }
    }
}