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
        static void Main(string[] args)
        {
            var enderecoArquivo = "contas.txt";
            using (var fluxoDeArquivo = new FileStream(enderecoArquivo, FileMode.Open))
            {
                var leitor = new StreamReader(fluxoDeArquivo);
                var linha = leitor.ReadToEnd();
                Console.WriteLine(linha);
            }

            Console.ReadLine();
        }

       
    }
}
