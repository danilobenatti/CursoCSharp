using System;

namespace CursoCSharp.TopicosAvancados {
    class Dynamics {
        public static void Executar() {
            dynamic meuObjeto = "teste";
            meuObjeto = 1;
            meuObjeto++;
            Console.WriteLine(meuObjeto);

            dynamic aluno = new System.Dynamic.ExpandoObject();
            aluno.Id = 1;
            aluno.Nome = "Maria Julia";
            aluno.Idade = 25;
            aluno.Nota = 9.8;
            Console.WriteLine($"{aluno.Id} {aluno.Nome} {aluno.Idade} {aluno.Nota}");
        }
    }
}