using System;
using System.IO;

namespace CursoCSharp.API {
    class ExemploFileInfo {
        public static void ExcluirSeExistir(params string[] caminhos) {
            foreach (var caminho in caminhos) {
                FileInfo fileInfo = new FileInfo(caminho);
                if (fileInfo.Exists) {
                    fileInfo.Delete();
                }
            }
        }
        public static void Executar() {
            var caminhoOrigem = @"~/arq_origem.txt".ParseHome();
            var caminhoDestino = @"~/arq_destino.txt".ParseHome();
            var caminhoCopia = @"~/arq_copia.txt".ParseHome();
            ExcluirSeExistir(caminhoOrigem, caminhoDestino, caminhoCopia);

            using (StreamWriter streamWriter = File.CreateText(caminhoOrigem)) {
                streamWriter.WriteLine("Arquivo original!");
                streamWriter.Close();
            }
            FileInfo fileInfo = new FileInfo(caminhoOrigem);
            Console.WriteLine(fileInfo.Name);
            Console.WriteLine(fileInfo.IsReadOnly);
            Console.WriteLine(fileInfo.FullName);
            Console.WriteLine(fileInfo.Extension);
            Console.WriteLine(fileInfo.DirectoryName);
            
            fileInfo.CopyTo(caminhoCopia);
            fileInfo.MoveTo(caminhoDestino);
        }
    }
}