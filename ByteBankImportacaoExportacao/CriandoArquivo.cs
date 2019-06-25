using System;
using System.IO;
using System.Text;

namespace ByteBankImportacaoExportacao
{
    partial class Program
    {
        static void CriarArquivo()
        {

            var caminhoNovoArquivo = "contasExportadas.csv";

            using (var fluxoDoArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
            {
                var contaComoString = "456,23455,2330.20,Gustavo Santos";
                var encoding = Encoding.UTF8;
                var bytes = encoding.GetBytes(contaComoString);

                fluxoDoArquivo.Write(bytes, 0, bytes.Length);
            }

        }

        static void CriarArquivoComWriter()
        {
            var caminhoNovoArquivo = "contasExportadas.csv";
            using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
            using (var escritor = new StreamWriter(fluxoDeArquivo))
            {
                escritor.Write("123,1234,2000.21,Jose Santos");
            }
            
        }
    }
}