using System;

namespace CursoCSharp.ClassesEMetodos {
    public class Moto {
        private string Marca;
        private string Modelo;
        private uint Cilindrada;

        public Moto(string marca, string modelo, uint cilindrada) {
            //Marca = marca;
            //Modelo = modelo;
            //Cilindrada = cilindrada;
            SetMarca(marca);
            SetModelo(modelo);
            SetCilindrada(cilindrada);
        }
        public Moto() { }

        public string GetMarca() {
            return Marca;
        }
        public void SetMarca(string marca) {
            Marca = marca;
        }
        public string GetModelo() {
            return Modelo;
        }
        public void SetModelo(string modelo) {
            this.Modelo = modelo;
        }
        public uint GetCilindrada() {
            return Cilindrada;
        }
        public void SetCilindrada(uint cilindrada) {
            // 1ª opção
            //if (cilindrada > 0) {
            //    this.Cilindrada = cilindrada;
            //}
            // 2ª opção
            //this.Cilindrada = Math.Abs(cilindrada);
            this.Cilindrada = cilindrada;
        }
    }

    class GetSet {
        public static void Executar() {
            var moto1 = new Moto(marca: "Kawasaki", modelo: "Ninja ZX-6R", cilindrada: 636);
            Console.WriteLine($"Marca: {moto1.GetMarca()} / Modelo: {moto1.GetModelo()} / Cilindrada: {moto1.GetCilindrada()}");

            var moto2 = new Moto();
            moto2.SetMarca("Honda");
            moto2.SetModelo("CG Titan");
            moto2.SetCilindrada(150);
            Console.WriteLine($"Marca: {moto2.GetMarca()} / Modelo: {moto2.GetModelo()} / Cilindrada: {moto2.GetCilindrada()}");
        }
    }
}