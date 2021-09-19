using DesignPatterns.Imposto;
using DesignPatterns.Investimento;
using DesignPatterns.Relatorios;
using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new RelatorioContasSaldoPositivo().Imprimir(TipoExibicao.Simples));
            Console.WriteLine(new RelatorioContasSaldoPositivo().Imprimir(TipoExibicao.Complexo));

            Console.WriteLine(new RelatorioContasSaldoNegativo().Imprimir(TipoExibicao.Simples));
            Console.WriteLine(new RelatorioContasSaldoNegativo().Imprimir(TipoExibicao.Complexo));

            Console.ReadKey();
        }

        public static void TemplateMethod01()
        {
            var orcamento = new Orcamento(5100);
            orcamento.AdicionarItem(new Item("Mouse", 100));
            orcamento.AdicionarItem(new Item("Notebook", 4900));
            orcamento.AdicionarItem(new Item("Mouse", 100));

            new CalculadorDeImposto().CalcularImposto(orcamento, new IHIT());
        }

        public static void Requisicao()
        {
            Console.WriteLine("*************************************************************");
            Console.WriteLine("Requisição");
            Console.WriteLine("*************************************************************");
            var conta = new DesignPatterns.Requisicao.Conta("Danilo", 1000);
            var requisicao = new DesignPatterns.Requisicao.Requisicao(DesignPatterns.Requisicao.Formato.PORCENTO);
            new DesignPatterns.Requisicao.ProcessarRequisicao().Processar(conta, requisicao);
        }

        public static void CalcularDesconto()
        {
            Console.WriteLine("*************************************************************");
            Console.WriteLine("Desconto");
            Console.WriteLine("*************************************************************");

            DesignPatterns.Desconto.Orcamento orcamento = new DesignPatterns.Desconto.Orcamento(1160);
            orcamento.AdicionarItem(new DesignPatterns.Desconto.Item("Monitor", 950));
            orcamento.AdicionarItem(new DesignPatterns.Desconto.Item("Mouse", 50));
            orcamento.AdicionarItem(new DesignPatterns.Desconto.Item("Teclado", 50));
            orcamento.AdicionarItem(new DesignPatterns.Desconto.Item("Hub", 50));
            orcamento.AdicionarItem(new DesignPatterns.Desconto.Item("MousePad", 10));
            orcamento.AdicionarItem(new DesignPatterns.Desconto.Item("Wifi USB", 50));

            new DesignPatterns.Desconto.CalcularDesconto().CalcularDescontoOrcamento(orcamento);
        }

        public static void CalcularInetimento()
        {
            Console.WriteLine("*************************************************************");
            Console.WriteLine("Ivestimento");
            Console.WriteLine("*************************************************************");
            var conta = new Conta(100);
            new RealizadorDeInvestimentos().Investir(conta, new Conservador());
            conta = new Conta(100);
            new RealizadorDeInvestimentos().Investir(conta, new Moderado());
            conta = new Conta(100);
            new RealizadorDeInvestimentos().Investir(conta, new Arrojado());
        }

        public static void CalcularImposto()
        {
            Console.WriteLine("*************************************************************");
            Console.WriteLine("Imposto");
            Console.WriteLine("*************************************************************");
            var orcamento = new Orcamento(5000);
            new CalculadorDeImposto().CalcularImposto(orcamento, new ICMS());
            new CalculadorDeImposto().CalcularImposto(orcamento, new ISS());
            new CalculadorDeImposto().CalcularImposto(orcamento, new ICCC());
        }
    }
}
