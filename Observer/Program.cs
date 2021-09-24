using System;
using System.Collections.Generic;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Observer");

            var notaFiscal2 = new NotaFiscalBuilder()
                .AddCnpj("123.456.159/0001-89")
                .AddObservacoes("Observações 123")
                .AddRazaoSocial("Razão Social 2")
                .AddItem(new ItemNotaBuilder().AddNome("Mouse").AddValor(30).Builder())
                .AddItem(new ItemNotaBuilder().AddNome("Teclado").AddValor(120).Builder())
                .AddItem(new ItemNotaBuilder().AddNome("Fone").AddValor(450).Builder())
                .AddDataAtual()
                .AddAcoes(new NotaFiscalDAO())
                .AddAcoes(new EnviarEmail())
                .AddAcoes(new Multiplicador(10))
                .AddAcoes(new Multiplicador(2))
                .Builder();
            Console.WriteLine("Razão Social: " + notaFiscal2.RazaoSocial);
            Console.WriteLine("Emissão: " + notaFiscal2.DataEmissao);
            Console.WriteLine("Valor: " + notaFiscal2.ValorBruto);
            Console.WriteLine("Impostos: " + notaFiscal2.Impostos);

            Console.WriteLine();
            Console.WriteLine();

            var acoes = new List<IAcoesNotafiscal>();
            acoes.Add(new NotaFiscalDAO());
            acoes.Add(new Multiplicador(5));
            var nf = new NotaFiscalBuilder(acoes)
                .AddObservacoes("Testando buider com acões por parametro")
                .AddItem(new ItemNotaBuilder().AddNome("Mouse").AddValor(80).Builder())
                .Builder();


            Console.ReadKey();
        }
    }
}
