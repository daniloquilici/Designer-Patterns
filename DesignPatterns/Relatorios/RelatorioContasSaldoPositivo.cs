using DesignPatterns.Investimento;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.Relatorios
{
    public class RelatorioContasSaldoPositivo : TemplateRelatorio
    {
        List<Conta> contas = new List<Conta>();
        public RelatorioContasSaldoPositivo()
        {
            contas.Add(new Conta("Danilo", 1000, "1011", "0860-2"));
            contas.Add(new Conta("Japa", 5000, "4548", "12345-8"));
            contas.Add(new Conta("Felipe", 3500, "1234", "87844"));
            contas.Add(new Conta("Shirlei", 60000, "8875", "554477-9"));
            contas.Add(new Conta("Fernando", 350, "2365", "44556-0"));

            contas.Add(new Conta("Rafael", -2000, "8471", "9894-2"));
            contas.Add(new Conta("Leonardo", 0, "5577", "8865-8"));
            contas.Add(new Conta("Michele", -500, "8966", "98742"));
        }

        public override string ExibicaoSimples()
        {
            var relatorio = string.Empty;
            relatorio += "***************************************************\n";
            relatorio += "BCO Online SP - Fone: (11) 33381-2882\n";
            relatorio += "***************************************************\n";

            foreach (var conta in contas.Where(x => x.Saldo > 0))
            {
                relatorio += string.Format("Titular: {0} - Saldo: {1}\n", conta.Nome, conta.Saldo.ToString("C"));
            }

            relatorio += "***************************************************\n";
            relatorio += "BCO Online SP - Fone: (11) 33381-2882\n";
            relatorio += "***************************************************\n";

            return relatorio;
        }

        public override string ExibicaoComplexa()
        {
            var relatorio = string.Empty;
            relatorio += "***************************************************\n";
            relatorio += "BCO Online SP - Av Giovanni Gonche, 123 Vila Andrade/SP - (11) 33381-2882\n";
            relatorio += "***************************************************\n";

            foreach (var conta in contas.Where(x => x.Saldo > 0))
            {
                relatorio += string.Format("Titular: {0} - AG: {1} - CC: {2} - Saldo: {3}\n", conta.Nome, conta.Agencia, conta.NumeroConta, conta.Saldo.ToString("C"));
            }

            relatorio += "***************************************************\n";
            relatorio += string.Format("contato@bcoonlinesp.com.br - {0}\n", DateTime.Now);
            relatorio += "***************************************************\n";

            return relatorio;
        }
    }
}
