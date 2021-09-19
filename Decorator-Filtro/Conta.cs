using System;

namespace Decorator_Filtro
{
    public class Conta
    {
        public double Saldo { get; private set; }
        public DateTime DataAbertura { get; private set; }

        public Conta(double saldo, DateTime dataAbertura)
        {
            this.Saldo = saldo;
            this.DataAbertura = dataAbertura;
        }
    }
}
