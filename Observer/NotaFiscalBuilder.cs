using System;
using System.Collections.Generic;

namespace Observer
{
    public class NotaFiscalBuilder
    {
        private string RazaoSocial { get; set; }
        private string Cnpj { get; set; }
        private string Observacoes { get; set; }
        private DateTime? DataAtual { get; set; }
        private IList<ItemNota> Itens { get; set; }

        private IList<IAcoesNotafiscal> acoes;

        private double ValorBruto;
        private double Impostos;

        public NotaFiscalBuilder()
        {
            this.Itens = new List<ItemNota>();
            acoes = new List<IAcoesNotafiscal>();
        }

        public NotaFiscalBuilder(IList<IAcoesNotafiscal> acoesNotafiscal)
        {
            this.Itens = new List<ItemNota>();
            acoes = acoesNotafiscal;
        }

        public NotaFiscalBuilder AddRazaoSocial(string razaoSocial)
        {
            this.RazaoSocial = razaoSocial;
            return this;
        }

        public NotaFiscalBuilder AddCnpj(string cnpj)
        {
            this.Cnpj = cnpj;
            return this;
        }

        public NotaFiscalBuilder AddObservacoes(string observacoes)
        {
            this.Observacoes = observacoes;
            return this;
        }

        public NotaFiscalBuilder AddItem(ItemNota itemNota)
        {
            this.Itens.Add(itemNota);
            ValorBruto += itemNota.Valor;
            Impostos += itemNota.Valor * 0.05;
            return this;
        }

        public NotaFiscalBuilder AddDataAtual() 
        {
            this.DataAtual = DateTime.Now;
            return this;
        }

        public NotaFiscalBuilder AddAcoes(IAcoesNotafiscal acoesNotafiscal) 
        {
            acoes.Add(acoesNotafiscal);
            return this;
        }

        public NotaFiscal Builder()
        {
            var nf = new NotaFiscal(this.RazaoSocial, this.Cnpj, ValorBruto, Impostos, this.Observacoes, this.Itens, this.DataAtual);

            foreach (var acao in acoes)
            {
                acao.Executar(nf);
            }

            return nf;
        }
    }
}
