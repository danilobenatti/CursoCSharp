using System;

namespace CursoCSharp {
    public class CarroOpcional {
        double desconto = 0.1;

        string nome;
        public string Nome {
            get {
                return "Opcional: " + nome;
            }
            set {
                nome = value;
            }
        }

        //Propriedades autoimplementadas
        public double Preco { get; set; }

        // Somente leitura
        public double PrecoComDesconte {
            //get {
            //    return preco - (desconto * preco);
            //}
            get => Preco - (desconto * Preco); // Lambda
        }
        public CarroOpcional() {

        }
        public CarroOpcional(string nome, double preco) {
            Nome = nome;
            Preco = preco;
        }
    }
    class Props {
        public static void Executar() {
            var op1 = new CarroOpcional("Ar Condicionado", 3499.99);
            Console.WriteLine(op1.PrecoComDesconte);

            var op2 = new CarroOpcional();
            op2.Nome = "Direção Hidráulica";
            op2.Preco = 2349.9;

            Console.WriteLine(op1.Nome);
            Console.WriteLine(op1.Preco);
            Console.WriteLine(op1.PrecoComDesconte);

            Console.WriteLine(op2.Nome);
            Console.WriteLine(op2.Preco);
            Console.WriteLine(op2.PrecoComDesconte);
        }
    }
}