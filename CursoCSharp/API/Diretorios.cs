using System;
using System.IO;

namespace CursoCSharp.API {
    class Diretorios {
        public static void Executar() {
            var novoDiretorio = @"~/PastaCSharp".ParseHome();
            var arquivoTeste = novoDiretorio + @"/arquivoTeste.txt";
            var novoDiretorioDestino = @"~/PastaCSharpDestino".ParseHome();
            var diretorioDoProjeto = @"D:/source/repos/CursoCSharp/CursoCSharp";

            if (Directory.Exists(novoDiretorio)) {
                Directory.Delete(novoDiretorio, true);
            }

            if (Directory.Exists(novoDiretorioDestino)) {
                Directory.Delete(novoDiretorioDestino, true);
            }
            Console.WriteLine("Excluiu os diretórios" +
                "\nPressione uma tecla para continuar");
            Console.ReadKey();

            Directory.CreateDirectory(novoDiretorio);
            Console.WriteLine(Directory.GetDirectoryRoot(novoDiretorio));
            Console.WriteLine(Directory.GetCreationTime(novoDiretorio));
            if (!File.Exists(arquivoTeste)) {
                using (StreamWriter streamWriter = File.CreateText(arquivoTeste)) {
                    streamWriter.WriteLine("Arquivo teste dentro" +
                        " de Diretório Inicial");
                    streamWriter.Close();
                }
            }
            Console.WriteLine("Criou o diretório e arquivo iniciais" +
                "\nPressione uma tecla para continuar");
            Console.ReadKey();

            Console.WriteLine("\n===== Pastas =====");
            var pastas = Directory.GetDirectories(diretorioDoProjeto);
            foreach (var pasta in pastas) {
                Console.WriteLine(pasta);
            }
            Console.WriteLine("Listou pasta raiz do projeto" +
                "\nPressione uma tecla para continuar");
            Console.ReadKey();

            Console.WriteLine("\n===== Arquivos =====");
            var arquivos = Directory.GetFiles(diretorioDoProjeto);
            foreach (var arquivo in arquivos) {
                Console.WriteLine(arquivo);
            }
            Console.WriteLine("Listou arquivos da para raiz do projeto" +
                "\nPressione uma tecla para continuar");
            Console.ReadKey();

            Console.WriteLine("\n===== Diretório Raiz =====");
            var diretorio = Directory.GetDirectoryRoot(diretorioDoProjeto);
            Console.WriteLine(diretorio);
            Console.WriteLine("Diretório raiz do projeto" +
                "\nPressione uma tecla para continuar");
            Console.ReadKey();

            Console.WriteLine("\n===== Movendo um Diretório + Arquivo =====");
            //var dir = new DirectoryInfo(novoDiretorio);
            //dir.MoveTo(novoDiretorioDestino);
            Directory.Move(novoDiretorio, novoDiretorioDestino);
            Console.WriteLine("Moveu diretório??? e arquivo criados inicialmente" +
                "\nPressione uma tecla para encerrar");
            Console.ReadKey();
        }
    }
}