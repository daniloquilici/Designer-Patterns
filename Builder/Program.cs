using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var notaFiscal = new NotaFiscalBuilder()
                .AddCnpj("123.456.789/0001-10")
                .AddObservacoes("Observações")
                .AddRazaoSocial("Razão Social")
                .AddItem(new ItemNotaBuilder().AddNome("Item 01").AddValor(100).Builder())
                .AddItem(new ItemNotaBuilder().AddNome("Item 02").AddValor(200).Builder())
                .AddItem(new ItemNotaBuilder().AddNome("Item 03").AddValor(300).Builder())
                .Builder();
            Console.WriteLine("Razão Social: " + notaFiscal.RazaoSocial);
            Console.WriteLine("Emissão: " + notaFiscal.DataEmissao);
            Console.WriteLine("Valor: " + notaFiscal.ValorBruto);
            Console.WriteLine("Impostos: " + notaFiscal.Impostos);

            Console.WriteLine();
            Console.WriteLine();

            var notaFiscal2 = new NotaFiscalBuilder()
                .AddCnpj("123.456.159/0001-89")
                .AddObservacoes("Observações 123")
                .AddRazaoSocial("Razão Social 2")
                .AddItem(new ItemNotaBuilder().AddNome("Mouse").AddValor(30).Builder())
                .AddItem(new ItemNotaBuilder().AddNome("Teclado").AddValor(120).Builder())
                .AddItem(new ItemNotaBuilder().AddNome("Fone").AddValor(450).Builder())
                .AddDataAtual()
                .Builder();
            Console.WriteLine("Razão Social: " + notaFiscal2.RazaoSocial);
            Console.WriteLine("Emissão: " + notaFiscal2.DataEmissao);
            Console.WriteLine("Valor: " + notaFiscal2.ValorBruto);
            Console.WriteLine("Impostos: " + notaFiscal2.Impostos);

            Console.ReadKey();
        }
    }
}
