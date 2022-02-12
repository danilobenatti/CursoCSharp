using System;
using System.IO;

namespace CursoCSharp.API {
    public static class ExtensionsString {
        public static string ParseHome(this string path) {
            string home = (Environment.OSVersion.Platform == PlatformID.Unix) || (Environment.OSVersion.Platform == PlatformID.MacOSX) ?
                Environment.GetEnvironmentVariable("HOME") : Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%");
            return path.Replace("~", home);
        }
    }
    class PrimeiroArquivo {
        public static void Executar() {
            //var formaLiteral = @"\teste\ntestes\a.txt";
            //Console.WriteLine(formaLiteral);

            var path = @"~/primeiro_arquivo.txt".ParseHome();
            if (!File.Exists(path)) {
                using (StreamWriter streamWriter = File.CreateText(path)) {
                    streamWriter.WriteLine("Esse é");
                    streamWriter.WriteLine("o nosso");
                    streamWriter.WriteLine("primeiro");
                    streamWriter.WriteLine("arquivo!");
                    streamWriter.Close();
                }
            }
            using (StreamWriter streamWriter2 = File.AppendText(path)) {
                streamWriter2.WriteLine("");
                streamWriter2.WriteLine("É possível");
                streamWriter2.WriteLine("adicionar");
                streamWriter2.WriteLine("mais texto!");
                streamWriter2.Close();
            }
        }
    }
}