﻿using System;

namespace CursoCSharp.ClassesEMetodos {
    public enum Genero { Acao, Aventura, Terror, Animacao, Comedia };
    public class Filme {
        public string Titulo;
        public Genero GeneroDoFilme;
    }

    class ExemploEnum {
        public static void Executar() {
            int id = (int)Genero.Animacao;
            Console.WriteLine(id);

            var filme = new Filme() {
                Titulo = "Um é pouco, dois é bom, três é demais",
                GeneroDoFilme = Genero.Comedia
            };
            Console.WriteLine($"{filme.Titulo} é {filme.GeneroDoFilme}");
        }
    }
}