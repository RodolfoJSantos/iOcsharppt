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
            using (var leitor = new StreamReader(fluxoDeArquivo))
            { 
                while (!leitor.EndOfStream)
                {
                    var linha = leitor.ReadLine();
                    var contaCorrente = ConverterStringEmContaCorrente(linha);
                    var msg = $"##Conta Corrente## \nTitular: {contaCorrente.Titular.Nome} " +
                        $"\nAg: {contaCorrente.Agencia}, Número: {contaCorrente.Numero} " +
                        $"\nSaldo: {contaCorrente.Saldo}\n=-----------------=";
                    Console.WriteLine(msg);
                }
            }                           

            Console.ReadLine();
        }

        static ContaCorrente ConverterStringEmContaCorrente(string linha)
        {
            string[] campos = linha.Split(',');

            var agencia = campos[0];
            var numero = campos[1];
            var saldo = campos[2].Replace('.',',');
            var nomeTitular = campos[3];

            var agenciaInt = int.Parse(agencia);
            var numeroInt = int.Parse(numero);
            var saldoDouble = double.Parse(saldo);
            var titular = new Cliente();
            titular.Nome = nomeTitular;

            var resultado = new ContaCorrente(agenciaInt, numeroInt);
            resultado.Titular = titular;
            resultado.Depositar(saldoDouble);

            return resultado;
        }
       
    }
}
