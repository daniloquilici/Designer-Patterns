using System;
using System.Collections.Generic;

namespace Observer
{
    public class NotaFiscal
    {
        public string RazaoSocial { get; private set; }
        public string Cnpj { get; private set; }
        public DateTime? DataEmissao { get; private set; }
        public double ValorBruto { get; private set; }
        public double Impostos { get; private set; }
        public string Observacoes { get; private set; }
        public IList<ItemNota> Itens { get; private set; }

        public NotaFiscal(string razaoSocial, string cnpj, double valorBruto, double impostos, string observacoes, IList<ItemNota> itens, DateTime? dataEmissao = null)
        {
            this.RazaoSocial = razaoSocial;
            this.Cnpj = cnpj;
            this.DataEmissao = dataEmissao;
            this.ValorBruto = valorBruto;
            this.Impostos = impostos;
            this.Observacoes = observacoes;
            this.Itens = itens;
        }
    }
}
