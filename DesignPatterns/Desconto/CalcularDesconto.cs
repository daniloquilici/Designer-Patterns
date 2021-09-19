using System;

namespace DesignPatterns.Desconto
{
    public class CalcularDesconto
    {
        public void CalcularDescontoOrcamento(Orcamento orcamento)
        {
            var d1 = new Desconto10PorcentoMais5Itens();
            var d2 = new DescontoPorVendaCasada();
            var d3 = new Desconto7PorcentoValorMaior500();
            var d4 = new SemDesconto();

            d1.Proximo = d2;
            d2.Proximo = d3;
            d3.Proximo = d4;

            var desconto = d1.Calcular(orcamento);
            Console.WriteLine(desconto);
        }
    }
}
