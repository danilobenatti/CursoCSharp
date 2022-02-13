using System;
using System.IO;

namespace CursoCSharp.API {
    class LendoArquivos {
        public static void Executar() {
            var path = @"~/lendo_arquivos.txt".ParseHome();

            if (!File.Exists(path)) {
                using (StreamWriter streamWriter = File.AppendText(path)) {
                    streamWriter.WriteLine("Produto;Preco;Qtde");
                    streamWriter.WriteLine("Caneta Bic Preta;3.59;89");
                    streamWriter.WriteLine("Borracha Branca;2.99;27");
                    streamWriter.Close();
                }
            }
            try {
                using (StreamReader streamReader = new StreamReader(path)) {
                    string json = streamReader.ReadToEnd();
                    Console.WriteLine(json);
                }
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }
    }
}