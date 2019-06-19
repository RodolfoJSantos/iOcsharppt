using ByteBankImportacaoExportacao.Modelos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankImportacaoExportacao 
{ 
    class Program 
    { 
        static void Main(string[] args) 
        {
            //var enderecoArquivo = "c:/projetoAlura/contas.txt";
            var enderecoArquivo = "contas.txt"; // só acha o txt pois está na pasta debug a mesma do .exe

            var fluxoDoArquivo = new FileStream(enderecoArquivo, FileMode.Open);
            var buffer = new byte[1024]; //1kb

            var numeroBytesLidos = -1;

            while (numeroBytesLidos != 0)
            {
                numeroBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);
                EscreverBuffer(buffer);
            }

            Console.ReadLine();
        }

        static void EscreverBuffer(byte[] buffer)
        {
            foreach (var meuByte in buffer)
            {
                Console.Write(meuByte);
                Console.Write(" ");
            }
        }
    }
} 
 