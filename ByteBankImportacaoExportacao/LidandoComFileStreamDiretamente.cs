using ByteBankImportacaoExportacao.Modelos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankImportacaoExportacao
{
    partial class Program
    {
        static void FileStreamDiretamente()
        {
            var enderecoArquivo = "contas.txt";
            using (var fluxoDoArquivo = new FileStream(enderecoArquivo, FileMode.Open))
            {
                var buffer = new byte[1024]; //1kb
                var numeroBytesLidos = -1;

                while (numeroBytesLidos != 0)
                {
                    numeroBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);
                    Console.WriteLine($" Bytes lidos: {numeroBytesLidos}");
                    EscreverBuffer(buffer, numeroBytesLidos);
                }
            }
        }
        static void EscreverBuffer(byte[] buffer, int bytesLidos)
        {
            //var utf8 = new UTF8Encoding();
            //var utf8 = Encoding.UTF8;
            var utf8 = Encoding.Default;

            var texto = utf8.GetString(buffer, 0, bytesLidos);

            Console.Write(texto);

            //foreach (var meuByte in buffer)
            //{
            //    Console.Write(meuByte);
            //    Console.Write(" ");
            //}
        }
    }
}
